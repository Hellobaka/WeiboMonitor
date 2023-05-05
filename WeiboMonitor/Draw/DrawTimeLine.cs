using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Text.RegularExpressions;
using WeiboMonitor.Model;

namespace WeiboMonitor.Draw
{
    public class DrawTimeLine
    {
        private static PrivateFontCollection EmojiFontCollection { get; set; } = new();
        private static Font EmojiFont { get; set; } = null;
        public static string Draw(TimeLine_Object item)
        {
            Bitmap main = new(652, 10000);
            using Graphics graphicsMain = Graphics.FromImage(main);
            graphicsMain.FillRectangle(new SolidBrush(Color.FromArgb(244, 245, 247)), new Rectangle(0, 0, main.Width, main.Height));
            Bitmap background = new(632, 400);
            using Graphics g = Graphics.FromImage(background);
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.InterpolationMode = InterpolationMode.HighQualityBilinear;
            g.FillRectangle(Brushes.White, new Rectangle(0, 0, background.Width, background.Height));

            PointF point = new();
            DrawAvatar(item, g, ref point);
            DrawUserName(item, g, ref point);
            DrawText(item, g, ref point);
            DrawData(item, g, ref point);

            background.Save("1.png");
            return "1.png";
        }

        private static void DrawAvatar(TimeLine_Object item, Graphics g, ref PointF point)
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

        private static void DrawUserName(TimeLine_Object item, Graphics g, ref PointF point)
        {
            var timeValue = item.created_at.Split(' ');
            // Sat, 18 Aug 2018 07:22:16
            int left = 82;
            point = new PointF(left, 27);
            DateTime time = DateTime.Parse($"{timeValue[0]}, {timeValue[2]} {timeValue[1]} {timeValue[5]} {timeValue[3]}");
            g.DrawString(item.user.screen_name, new("Microsoft YaHei", 12), Brushes.Black, point);
            //DrawString(g, item.user.screen_name, Color.Black, ref point, font, 20, charGap, ref maxCharWidth, maxWidth, out float charHeight);
            point = new PointF(left, 27 + 24);
            g.DrawString($"{time:G} · {item.region_name}", new("Microsoft YaHei", 10), new SolidBrush(Color.FromArgb(153, 162, 170)), point);
            //DrawString(g, $"{time:G} · {item.region_name}", Color.FromArgb(153, 162, 170), ref point, font, 20, charGap, ref maxCharWidth, maxWidth, out charHeight);
        }

        private static void DrawText(TimeLine_Object item, Graphics g, ref PointF point)
        {
            // 绘制
            int left = 82;
            float charGap = -6, maxWidth = 632 - 30, maxCharWidth = 0, charHeight = 0;
            point = new(left, 75);
            Font font = new("Microsoft YaHei", 12);
            foreach (var c in item.TextChain)
            {
                if(c.Text != null)
                {
                    DrawString(g, c.Text, c.LinkFlag ? Color.FromArgb(235, 115, 80) : Color.Black, ref point, font, left, charGap, ref maxCharWidth, maxWidth, out charHeight);
                }
                else
                {
                    // 表情元素
                    point = new PointF(point.X + 2, point.Y);
                    Bitmap img = (Bitmap)Image.FromFile(Path.Combine(Path.Combine(UpdateChecker.BasePath, "tmp"), c.ImageURL.GetFileNameFromURL()));
                    g.DrawImage(img, point.X, point.Y, 20, 20);
                    point = new PointF(point.X + 20, point.Y);
                }
            }
            point = new(left, point.Y + charHeight);
        }

        private static void DrawMainImages(TimeLine_Object item, Graphics g, ref PointF point)
        {
            // gif => 不支持(第一帧 gif图标)
            // 长图
            // 九宫图
            // 多于9张图 => 全画
        }

        private static void DrawMainCard(TimeLine_Object item, Graphics g, ref PointF point)
        {
            // 文章
            // 视频
        }

        private static void DrawData(TimeLine_Object item, Graphics g, ref PointF point)
        {
            int retweet = item.reposts_count;
            int comment = item.comments_count;
            int like = item.attitudes_count;
            Font font = new("Microsoft YaHei", 12);
            // 转发
            Bitmap forwardImage = (Bitmap)Image.FromFile(Path.Combine(UpdateChecker.BasePath, "Assets", "forward.png"));
            point = new(point.X, point.Y + 10);
            g.DrawImage(forwardImage, point.X, point.Y, 16, 16);
            point = new(point.X + 16 + 4, point.Y - 2);
            g.DrawString(retweet.ToString(), font, new SolidBrush(Color.FromArgb(109, 117, 122)), point);
            // 评论
            Bitmap commentImage = (Bitmap)Image.FromFile(Path.Combine(UpdateChecker.BasePath, "Assets", "comment.png"));
            point = new(point.X + 40, point.Y + 2);
            g.DrawImage(commentImage, point.X, point.Y, 16, 16);
            point = new(point.X + 20, point.Y - 2);
            g.DrawString(comment.ToString(), font, new SolidBrush(Color.FromArgb(109, 117, 122)), point);
            // 点赞
            Bitmap likeImage = (Bitmap)Image.FromFile(Path.Combine(UpdateChecker.BasePath, "Assets", "like.png"));
            point = new(point.X + 40, point.Y + 2);
            g.DrawImage(likeImage, point.X, point.Y, 16, 16);
            point = new(point.X + 20, point.Y - 2);
            g.DrawString(like.ToString(), font, new SolidBrush(Color.FromArgb(109, 117, 122)), point);
        }

        private static void DrawString(Graphics g, string text, Color color, ref PointF point, Font font, int padding, float charGap, ref float maxCharWidth, float maxWidth, out float charHeight)
        {
            charHeight = 0;
            for (int i = 0; i < text.Length; i++)
            {
                // Emoji支持
                if (char.IsSurrogatePair(text, i))
                {
                    string emoji = text.Substring(i, 2);
                    if(EmojiFontCollection.Families.Length== 0)
                    {
                        EmojiFontCollection.AddFontFile(Path.Combine(UpdateChecker.BasePath, "Assets", "seguiemj.ttf"));
                        EmojiFont = new Font(EmojiFontCollection.Families[0], 12);
                    }
                    var charSize = g.MeasureString(emoji, EmojiFont);
                    g.DrawString(emoji.ToString(), EmojiFont, new SolidBrush(color), point);
                    point = new(point.X + charSize.Width - 6, point.Y);
                    i++;
                }
                else
                {
                    DrawString(g, text[i], color, ref point, font, padding, charGap, ref maxCharWidth, maxWidth, out charHeight);
                }
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
            {
                charSize.Width = maxCharWidth > 0 ? maxCharWidth / 2 : (-charGap) * 3;
            }

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
