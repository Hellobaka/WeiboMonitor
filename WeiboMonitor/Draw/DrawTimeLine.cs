using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Text;
using WeiboMonitor.Model;

namespace WeiboMonitor.Draw
{
    public class DrawTimeLine
    {
        public static string Draw(TimeLine_Object item)
        {
            Bitmap main = new(652, 10000);
            using Graphics graphicsMain = Graphics.FromImage(main);
            graphicsMain.FillRectangle(new SolidBrush(Color.FromArgb(244, 245, 247)), new Rectangle(0, 0, main.Width, main.Height));
            Bitmap background = new(632, 100);
            using Graphics g = Graphics.FromImage(background);
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.InterpolationMode = InterpolationMode.HighQualityBilinear;
            g.FillRectangle(Brushes.White, new Rectangle(0, 0, background.Width, background.Height));

            DrawAvatar(item, g);
            DrawUserName(item, g);

            background.Save("1.png");
            return "1.png";
        }

        private static void DrawAvatar(TimeLine_Object item, Graphics g)
        {
            Bitmap avatar = (Bitmap)Image.FromFile(Path.Combine(Path.Combine(UpdateChecker.BasePath, "tmp"),
                item.user.avatar_large.GetFileNameFromURL()));
            Image round = new Bitmap(avatar.Width, avatar.Height);
            using Graphics roundGraphics = Graphics.FromImage(round);
            roundGraphics.FillRectangle(Brushes.Transparent, 0, 0, round.Width, round.Height);
            using GraphicsPath path = new();
            path.AddEllipse(0, 0, round.Width, round.Height);
            roundGraphics.SetClip(path);
            roundGraphics.DrawImage(avatar, 0, 0);
            g.DrawImage(round, new Rectangle(14, 14, 60, 60));
        }

        private static void DrawUserName(TimeLine_Object item, Graphics g)
        {
            Font font = new("Microsoft YaHei", 12);
            var timeValue = item.created_at.Split(' ');
            // Sat, 18 Aug 2018 07:22:16
            int left = 78;
            float charGap = -6, maxWidth = 632 - left, maxCharWidth = 0;
            PointF point = new PointF(left, 27);
            DateTime time = DateTime.Parse($"{timeValue[0]}, {timeValue[2]} {timeValue[1]} {timeValue[5]} {timeValue[3]}");
            DrawString(g, item.user.screen_name, Color.Black, ref point, font, 20, charGap, ref maxCharWidth, maxWidth, out float charHeight);
            point = new PointF(left, 27 + 24);
            DrawString(g, $"{time:G} · {item.region_name}", Color.FromArgb(153, 162, 170), ref point, font, 20, charGap, ref maxCharWidth, maxWidth, out charHeight);
        }

        private static void DrawMainText(TimeLine_Object item, Graphics g)
        {

        }

        private static void DrawMainImages(TimeLine_Object item, Graphics g)
        {

        }

        private static void DrawMainCard(TimeLine_Object item, Graphics g)
        {

        }

        private static void DrawMainData(TimeLine_Object item, Graphics g)
        {

        }

        private static void DrawString(Graphics g, string text, Color color, ref PointF point, Font font, int padding, float charGap, ref float maxCharWidth, float maxWidth, out float charHeight)
        {
            charHeight = 0;
            foreach (var item in text)
            {
                DrawString(g, item, color, ref point, font, padding, charGap, ref maxCharWidth, maxWidth, out charHeight);
            }
        }

        private static void DrawString(Graphics g, char text, Color color, ref PointF point, Font font, int padding, float charGap, ref float maxCharWidth, float maxWidth, out float charHeight)
        {
            var charSize = g.MeasureString(text.ToString(), font);
            charHeight = charSize.Height;
            if (text == '\n')
            {
                point.X = padding;
                point.Y += charSize.Height + 2;
                return;
            }
            if (charSize.Width < -charGap)
                charSize.Width = maxCharWidth > 0 ? maxCharWidth / 2 : (-charGap) * 3;
            maxCharWidth = Math.Max(maxCharWidth, charSize.Width);
            g.DrawString(text.ToString(), font, new SolidBrush(color), point);
            WrapTest(maxWidth, padding, charGap, charSize, ref point);
        }

        private static void WrapTest(float maxWidth, int padding, float charGap, SizeF charSize, ref PointF point)
        {
            if (point.X + charSize.Width >= maxWidth)
            {
                point.X = padding;
                point.Y += charSize.Height + 2;
            }
            else
            {
                point.X += charSize.Width + charGap;
            }
        }
    }
}
