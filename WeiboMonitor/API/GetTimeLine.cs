using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            if(text.StartsWith("{") is false)
            {
                apiResult.Success = false;
                apiResult.Message = "Cookie失效";
                return apiResult;
            }
            try
            {
                TimeLine json = JsonConvert.DeserializeObject<TimeLine>(text);
                apiResult.Object = json.data.list;
                if (json == null || json.data == null || json.data.list == null)
                {
                    apiResult.Success = false;
                    apiResult.Message = "解析失败";
                    return apiResult;
                }
                if(json.data.list.Length > 0)
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
            if(maxID != 0 && maxID != LastID)
            {
                LastID = maxID;
                return ls.Object.First(x => x.id == LastID);
            }
            return null;
        }

        private static long GetMaxID(TimeLine_Object[] ls) => (long)(ls.OrderByDescending(x => x.id).FirstOrDefault()?.id);
    }
}
