using System.Drawing;
using System.Text.RegularExpressions;
using WeiboMonitor;
using WeiboMonitor.API;
using WeiboMonitor.Model;
using WeiboMonitor_netframework;

namespace Tester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Config config = new Config("config.json");
            config.LoadConfig();
            GetTimeLine timeLine = new GetTimeLine(1842706721);
            //timeLine.GetTimeLineList();
            var item = timeLine.CheckUpdate();
            if (item != null)
            {
                foreach(var t in timeLine.TimeLines.Take(10))
                {
                    timeLine.UpdateTextChain(t);
                    timeLine.DownloadPic(t);
                    Console.WriteLine(timeLine.Draw(t));
                }
            }
        }
    }
}