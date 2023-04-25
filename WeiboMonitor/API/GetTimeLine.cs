using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            string url = $"https://weibo.com/ajax/statuses/mymblog?uid={UID}&page={page}";
            string text = CommonHelper.Get(url).Result;
            ApiResult<TimeLine_Object[]> apiResult = new();
            if (text.StartsWith("{") is false)
            {
                apiResult.Success = false;
                apiResult.Message = "Cookie失效";
                return apiResult;
            }
            try
            {
                var setting = new JsonSerializerSettings
                {
                    Converters = new List<JsonConverter>
                    {
                        new TimeLineJsonConverter(),
                    }
                };
                TimeLine json = JsonConvert.DeserializeObject<TimeLine>(text, setting);
                apiResult.Object = json.data.list;
                if (json == null || json.data == null || json.data.list == null)
                {
                    apiResult.Success = false;
                    apiResult.Message = "解析失败";
                    return apiResult;
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
                return apiResult;
            }
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
            if (obj.pic_infos != null)
            {
                foreach (var item in obj.pic_infos)
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

    public class TimeLineJsonConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(MainPicInfo);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var token = JToken.Load(reader);
            if (token.Children().Any(x =>
            {
                return x is JObject && x["pic_id"] != null;
            }))
            {
                List<MainPicInfo> picInfos = new();
                foreach (var item in token.Children())
                {
                    if (item is JObject)
                    {
                        picInfos.Add(JsonConvert.DeserializeObject<MainPicInfo>(item.ToString()));
                    }
                }
                return picInfos;
            }
            return null;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {

        }
    }
}
