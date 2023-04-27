using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using WeiboMonitor.Model;

namespace WeiboMonitor.Draw
{
    public class DrawTimeLine
    {
        public static string Draw(TimeLine_Object timeline)
        {
            Bitmap bitmap = new(632, 10000);
            Bitmap background = new(632, 500);
            using Graphics g = Graphics.FromImage(background);
            return null;
        }
    }
}
