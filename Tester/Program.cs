using Newtonsoft.Json;
using System.Drawing;
using System.Text.RegularExpressions;
using WeiboMonitor;
using WeiboMonitor.API;
using WeiboMonitor.Draw;
using WeiboMonitor.Model;

namespace Tester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TokenManager.UpdateToken();
            GetTimeLine timeLine = new GetTimeLine(5762457113);
            //timeLine.GetTimeLineList();
            var item = timeLine.CheckUpdate();
            if (item != null)
            {
                timeLine.DownloadPic(item);
                DrawTimeLine.Draw(item);
            }
        }
    }
}