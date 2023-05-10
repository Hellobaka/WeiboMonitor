using System;
using System.Collections.Generic;
using System.Drawing;
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
        public string FontName { get; set; }
        public Font Font { get; set; }

        public delegate void TimeLineUpdateHandler(TimeLine_Object bangumi, string pic);
        public event TimeLineUpdateHandler OnTimeLineUpdate;

        public UpdateChecker(string basePath, string picPath)
        {
            BasePath = basePath;
            PicPath = picPath;
            Instance = this;
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
                        OnTimeLineUpdate?.Invoke(update, pic);
                        LogHelper.Info("微博更新", $"{item.UserName}的微博有更新，id={item.LastID}，路径={pic}");
                    }
                }
            }
        }
    }
}
