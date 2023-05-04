using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using WeiboMonitor.Model;

namespace WeiboMonitor.API
{
    public class GetTimeLine
    {
        public long UID { get; set; }

        public long LastID { get; set; } = 0;

        public bool ReFetchFlag { get; set; }

        public string UserName { get; set; }

        public GetTimeLine(long uID)
        {
            UID = uID;
        }

        public ApiResult<TimeLine_Object[]> GetTimeLineList(int page = 1)
        {
            LogHelper.Info("刷新微博列表", $"UID={UID}, Name={UserName}, Page={page}");
            string url = $"https://weibo.com/ajax/statuses/mymblog?uid={UID}&page={page}";
            //string text = CommonHelper.Get(url, TokenManager.GenerateCookie()).Result;
            string text = File.ReadAllText("demo.json");
            if(text.StartsWith("{") is false)
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
                //File.WriteAllText("demo2.json", text);
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

        public TimeLine_Object CheckUpdate()
        {
            var ls = GetTimeLineList();
            long maxID = GetMaxID(ls.Object);
            if (maxID != 0 && maxID != LastID)
            {
                LastID = maxID;
                return ls.Object.First(x => x.id == LastID);
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
        }

        private static long GetMaxID(TimeLine_Object[] ls)
        {
            return (long)(ls.OrderByDescending(x => x.id).FirstOrDefault()?.id);
        }
    }
}
