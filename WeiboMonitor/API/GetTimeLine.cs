using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using WeiboMonitor.Model;

namespace WeiboMonitor.API
{
    public class GetTimeLine
    {
        public long UID { get; set; }

        public long LastID { get; set; } = 0;

        public bool ReFetchFlag { get; set; } = true;

        public string UserName { get; set; }

        public GetTimeLine(long uID)
        {
            UID = uID;
        }

        public ApiResult<TimeLine_Object[]> GetTimeLineList(int page = 1)
        {
            LogHelper.Info("刷新微博列表", $"UID={UID}, Name={UserName}, Page={page}");
            string url = $"https://weibo.com/ajax/statuses/mymblog?uid={UID}&page={page}";
            string text = CommonHelper.Get(url, TokenManager.GenerateCookie()).Result;
            //string text = File.ReadAllText("demo.json");
            if (text.StartsWith("{") is false)
            {
                TokenManager.UpdateToken();
                text = CommonHelper.Get(url, TokenManager.GenerateCookie()).Result;
            }
            ApiResult<TimeLine_Object[]> apiResult = new();
            if (text.StartsWith("{") is false)
            {
                apiResult.Success = false;
                apiResult.Message = "Cookie失效";
                return apiResult;
            }
            try
            {
                //File.WriteAllText("demo3.json", text);
                TimeLine json = JsonConvert.DeserializeObject<TimeLine>(text);
                apiResult.Object = json.data.list;
                if (json == null || json.data == null || json.data.list == null)
                {
                    apiResult.Success = false;
                    apiResult.Message = "解析失败";
                    return apiResult;
                }
                LogHelper.Info("刷新微博列表", $"拉取成功");
                foreach (var item in json.data.list)
                {
                    UpdatePicInfos(item);
                }
                if (json.data.list.Length > 0)
                {
                    UserName = json.data.list.First().user.screen_name;
                }
                return apiResult;
            }
            catch (Exception e)
            {
                apiResult.Success = false;
                apiResult.Message = $"解析失败：{e.Message}";
                LogHelper.Info("解析失败", e.Message);
                return apiResult;
            }
        }

        private void UpdatePicInfos(TimeLine_Object json)
        {
            if (json == null || json.pic_infos == null)
            {
                return;
            }
            List<MainPicInfo> picInfos = new();
            foreach (var item in (json.pic_infos as JToken).Children())
            {
                if (item is JProperty jP)
                {
                    picInfos.Add(JsonConvert.DeserializeObject<MainPicInfo>(jP.Value.ToString()));
                }
            }
            json.pic_info = picInfos.ToArray();
        }

        private void UpdateTextChain(TimeLine_Object item)
        {
            string text = item.text;
            // 替换br
            text = text.Replace("<br />", "\n");
            // 长文
            if (item.isLongText)
            {
                // 暂不验证
                // 寻找特征点，短文本向前拉取10个字符当做特征
                // 之后在长文本中寻找此特征，若找到则进行拼接
                string url = $"https://weibo.com/ajax/statuses/longtext?id={item.mblogid}";
                string json = CommonHelper.Get(url, TokenManager.GenerateCookie()).Result;
                //string json = File.ReadAllText("demo4.json");
                if (json.StartsWith("{") is false)
                {
                    TokenManager.UpdateToken();
                    json = CommonHelper.Get(url, TokenManager.GenerateCookie()).Result;
                }
                if (json.StartsWith("{") is false)
                {
                    // Cookie失效
                    return;
                }
                var longTweet = JsonConvert.DeserializeObject<LongTweet>(json);
                if (longTweet != null && longTweet.http_code == 200)
                {
                    string longText = longTweet.data.longTextContent;
                    int shortEndIndex = text.IndexOf(" ​​​ ...");// U+200B
                    if (shortEndIndex > 0)
                    {
                        string sigText = text.Substring(shortEndIndex - 15, 10);
                        int longSigIndex = longText.IndexOf(sigText, 100);
                        if (longSigIndex > 0)
                        {
                            text = text.Substring(0, text.IndexOf(sigText)) + longText.Substring(longSigIndex);
                            if (longTweet.data.url_struct != null && longTweet.data.url_struct.Length != 0)
                            {
                                foreach (var url_Struct in longTweet.data.url_struct)
                                {
                                    text = text.Replace(url_Struct.short_url, $"%{url_Struct.url_title}%");
                                }
                            }
                        }
                    }
                }
            }
            // 超链接 => %%
            text = Regex.Replace(text, "<a .*?>(.*?)<\\/a>", "%$1%");
            // 微博表情
            text = Regex.Replace(text, "<img.*?alt=\"(.*?)\".*src=\"(.*?)\" \\/>", "{img$2,alt$1}");
            // 其余html标签
            text = Regex.Replace(text, "<.*?>", "");
            text = text.Replace(" ", "");// U+200B
            // 分割文本串
            List<TextChainItem> textChains = item.TextChain;
            bool linkFlag = false;
            string textItem = "";
            foreach (var c in text)
            {
                if (c == '%')
                {
                    if (linkFlag)
                    {
                        textChains.Add(new TextChainItem { Text = textItem, LinkFlag = true });
                        textItem = "";
                        linkFlag = false;
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(textItem))
                        {
                            textChains.Add(new TextChainItem { Text = textItem, LinkFlag = false });
                        }
                        textItem = "";
                        linkFlag = true;
                    }
                    continue;
                }
                textItem += c;
                // 过滤表情
                var match = Regex.Match(textItem, "{img(.*),alt(.*)}");
                if (match.Groups.Count == 3)
                {
                    textChains.Add(new TextChainItem { Text = textItem.Replace(match.Groups[0].Value, ""), LinkFlag = linkFlag });
                    textChains.Add(new TextChainItem { ImageURL = match.Groups[1].Value, ImageAlt = match.Groups[2].Value });
                    textItem = "";
                }
            }
            if (!string.IsNullOrEmpty(textItem))
            {
                textChains.Add(new TextChainItem { Text = textItem, LinkFlag = linkFlag });
            }
        }

        public TimeLine_Object CheckUpdate()
        {
            var ls = GetTimeLineList();
            if (!ls.Success)
            {
                LogHelper.Info("检查更新", $"失败: {ls.Message}", false);
                return null;
            }
            long maxID = GetMaxID(ls.Object);
            if (maxID != 0 && (ReFetchFlag || maxID != LastID))
            {
                LastID = maxID;
                var obj = ls.Object.First(x => x.id == LastID);
                UpdateTextChain(obj);
                return obj;
            }
            return null;
        }

        public void DownloadPic(TimeLine_Object obj)
        {
            if (obj == null)
            {
                return;
            }
            _ = CommonHelper.DownloadFile(obj.user.avatar_large, Path.Combine(UpdateChecker.BasePath, "tmp")).Result;
            if (obj.pic_info != null)
            {
                foreach (var item in obj.pic_info)
                {
                    _ = CommonHelper.DownloadFile(item.large.url, Path.Combine(UpdateChecker.BasePath, "tmp")).Result;
                }
            }
            foreach (var item in obj.TextChain.Where(x => x.ImageURL != null))
            {
                _ = CommonHelper.DownloadFile(item.ImageURL, Path.Combine(UpdateChecker.BasePath, "tmp")).Result;
            }
            if (obj.page_info != null && (obj.page_info.object_type == "video" || obj.page_info.object_type == "article"))
            {
                _ = CommonHelper.DownloadFile(obj.page_info.pic_info.pic_big?.url, Path.Combine(UpdateChecker.BasePath, "tmp")).Result;
            }
            if (obj.retweeted_status != null)
            {
                UpdatePicInfos(obj.retweeted_status);
                UpdateTextChain(obj.retweeted_status);
                DownloadPic(obj.retweeted_status);
            }
        }

        private static long GetMaxID(TimeLine_Object[] ls)
        {
            return (long)(ls.OrderByDescending(x => x.id).FirstOrDefault()?.id);
        }
    }
}
