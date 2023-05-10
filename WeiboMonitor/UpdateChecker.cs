using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using WeiboMonitor.API;
using WeiboMonitor.Draw;
using WeiboMonitor.Model;

namespace WeiboMonitor
{
    public class UpdateChecker
    {
        public static string BasePath { get; set; } = "";
        public static string PicPath { get; set; } = "";
        public int WeiboCheckCD { get; set; } = 5;
        public static UpdateChecker Instance { get; set; }
        public bool Enabled { get; set; } = false;

        public List<GetTimeLine> TimeLines { get; set; } = new();
        public int WeiboErrCount { get; set; }

        public delegate void TimeLineUpdateHandler(TimeLine_Object timeLine, long uid, string pic);
        public event TimeLineUpdateHandler OnTimeLineUpdate;

        public UpdateChecker(string basePath, string picPath)
        {
            BasePath = basePath;
            PicPath = picPath;
            Instance = this;
            bool flag = TokenManager.UpdateToken();
            LogHelper.Info("刷新Token", $"结果：{flag}", flag);
            new Thread(() =>
            {
                while (true)
                {
                    if (Enabled)
                    {
                        Thread.Sleep(WeiboCheckCD * 60 * 1000);
                        try
                        {
                            CheckWeiboUpdate();
                        }
                        catch (Exception e)
                        {
                            LogHelper.Info("更新检查失败", e.Message + e.StackTrace, false);
                        }
                    }
                }
            }).Start();
        }

        private void CheckWeiboUpdate()
        {
            foreach (var item in TimeLines)
            {
                string pic = null;
                TimeLine_Object update = null;
                try
                {
                    update = item.CheckUpdate();
                    if (update != null)
                    {
                        item.DownloadPic(update);
                        pic = DrawTimeLine.Draw(update);
                    }
                    item.ReFetchFlag = false;
                }
                catch (Exception e)
                {
                    pic = null;
                    update = null;
                    item.ReFetchFlag = true;
                    LogHelper.Info("微博更新", $"错误次数={WeiboErrCount},exc={e.Message + e.StackTrace}", false);
                    WeiboErrCount++;
                    if (WeiboErrCount >= 3)
                    {
                        LogHelper.Info("微博更新", "错误次数超过上限", false);
                        LogHelper.Info("异常捕获", e.Message + e.StackTrace, false);
                        item.ReFetchFlag = false;
                        WeiboErrCount = 1;
                    }
                }
                finally
                {
                    if (update != null)
                    {
                        OnTimeLineUpdate?.Invoke(update, update.user.id, pic);
                        LogHelper.Info("微博更新", $"{item.UserName}的微博有更新，id={item.LastID}，路径={pic}");
                    }
                }
            }
        }

        public GetTimeLine AddWeibo(long uid)
        {
            if (TimeLines.Any(x => x.UID == uid))
            {
                return TimeLines.First(x => x.UID == uid);
            }
            var timeLine = new GetTimeLine(uid);
            if(timeLine.CheckUpdate() != null)
            {
                TimeLines.Add(timeLine);
                return timeLine;
            }
            else
            {
                return null;
            }
        }

        public void Start()
        {
            Enabled = true;
        }

        public void RemoveWeibo(int uid)
        {
            if (TimeLines.Any(x => x.UID == uid) is false)
            {
                return;
            }

            TimeLines.Remove(TimeLines.First(x => x.UID == uid));
        }

        public List<(long, string)> GetBangumiList()
        {
            List<(long, string)> ls = new();
            foreach (var item in TimeLines)
            {
                ls.Add((item.UID, item.UserName));
            }
            return ls;
        }
    }
}
