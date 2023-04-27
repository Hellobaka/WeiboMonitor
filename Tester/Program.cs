using WeiboMonitor.API;
using WeiboMonitor.Draw;

namespace Tester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetTimeLine timeLine = new GetTimeLine(1842706721);
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