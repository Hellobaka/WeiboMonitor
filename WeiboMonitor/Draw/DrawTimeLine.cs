using SkiaSharp;
using System;
using System.IO;
using System.Linq;
using WeiboMonitor.Model;
using WeiboMonitor_netframework;
using WeiboMonitor_netframework.Draw;

namespace WeiboMonitor.API
{
    public partial class GetTimeLine
    {
        private int AvatarSize { get; set; } = 100;

        private int BodyFontSize { get; set; } = 26;

        private int LargeFontSize { get; set; } = 30;

        private int MiddleFontSize { get; set; } = 26;

        public string Draw(TimeLine_Object item)
        {
            Directory.CreateDirectory(Path.Combine(Config.PicSaveBasePath, "Weibo"));
            int padding = 10;
            SKPoint avatarPoint = new(padding, padding);
            Painting main = new Painting(CanvasWidth, 14000);

            SKPoint point = new(padding, padding);
            DrawAvatar(item, ref main, ref point);
            DrawUserName(item, ref main, ref point);
            point = new(padding, avatarPoint.Y + AvatarSize + LargeFontSize);

            DrawText(item, ref main, ref point, CanvasWidth, padding);
            point = new(padding, point.Y + 10);
            DrawMainImages(item, ref main, ref point, padding);
            point = new(padding, point.Y + 10);
            DrawMainCard(item, ref main, ref point, (int)(main.Width - padding * 2));
            point = new(padding, point.Y + 10);
            DrawRetweet(item, ref main, ref point);
            point = new(padding, point.Y + 10);
            DrawData(item, ref main, 82, ref point);

            main.Resize((int)main.Width, (int)point.Y + padding);
            main.Padding(padding, padding, padding, padding, new SKColor(244, 245, 247));
            string filename = $"{item.id}.png";
            string path = Path.Combine(Config.PicSaveBasePath, "Weibo");
            Directory.CreateDirectory(path);
            main.Save(Path.Combine(path, filename));
            main.Dispose();
            return Path.Combine("Weibo", filename);
        }

        private void DrawAvatar(TimeLine_Object item, ref Painting img, ref SKPoint point)
        {
            string avatarPath = Path.Combine(Path.Combine(Config.BaseDirectory, "tmp"), item.user.avatar_large.GetFileNameFromURL());
            using var avatar = img.LoadImage(avatarPath);
            img.DrawImage(img.CreateCircularImage(avatar, AvatarSize), new SKRect { Location = point, Size = new() { Width = AvatarSize, Height = AvatarSize } });
        }

        private void DrawData(TimeLine_Object item, ref Painting img, int startX, ref SKPoint point)
        {
            int retweetCount = item.reposts_count;
            int commentCount = item.comments_count;
            int likeCount = item.attitudes_count;

            int iconSize = 20;
            int fontSize = 20;
            SKPoint initalPoint = new(point.X, point.Y);
            point = new(point.X, point.Y + fontSize);
            using var forward = img.LoadImage(Path.Combine(Config.BaseDirectory, "Assets", "forward.png"));
            using var comment = img.LoadImage(Path.Combine(Config.BaseDirectory, "Assets", "comment.png"));
            using var like = img.LoadImage(Path.Combine(Config.BaseDirectory, "Assets", "like.png"));

            img.DrawImage(forward, new SKRect { Location = point, Size = new(iconSize, iconSize) });
            point = new(point.X + iconSize + 4, point.Y - 2);
            point = img.DrawText(CommonHelper.ParseLongNumber(retweetCount), Painting.Anywhere, point, SKColor.Parse("#6d757a"), fontSize);
            point = new(point.X + 20, point.Y - fontSize + 2);

            img.DrawImage(comment, new SKRect { Location = point, Size = new(iconSize, iconSize) });
            point = new(point.X + iconSize + 4, point.Y - 2);
            point = img.DrawText(CommonHelper.ParseLongNumber(commentCount), Painting.Anywhere, point, SKColor.Parse("#6d757a"), fontSize);
            point = new(point.X + 20, point.Y - fontSize + 2);

            img.DrawImage(like, new SKRect { Location = point, Size = new(iconSize, iconSize) });
            point = new(point.X + iconSize + 4, point.Y - 2);
            point = img.DrawText(CommonHelper.ParseLongNumber(likeCount), Painting.Anywhere, point, SKColor.Parse("#6d757a"), fontSize);
        }

        private void DrawMainCard(TimeLine_Object item, ref Painting img, ref SKPoint point, int elementWidth = 100)
        {
            SKPoint initialPoint = new(point.X, point.Y);

            if (item.page_info == null || (item.page_info.object_type != "video" && item.page_info.object_type != "article"))
            {
                return;
            }
            if (item.page_info.object_type == "video")
            {
                if (item.page_info.media_info == null || item.page_info.media_info.playback_list == null)
                {
                    return;
                }
                using var videoPic = img.LoadImage(Path.Combine(Config.BaseDirectory, "tmp", item.page_info.pic_info.pic_big.url.GetFileNameFromURL()));
                float imgWidth = elementWidth;
                float imgHeight = videoPic.Height / (videoPic.Width / imgWidth);
                img.DrawImage(videoPic, new() { Location = point, Size = new(imgWidth, imgHeight) });
                img.DrawRectangle(new SKRect(point.X, point.Y + imgHeight - 40, imgWidth, 40), SKColors.Black, SKColors.Black, 0);

                img.DrawText(item.page_info.media_info.online_users, Painting.Anywhere, new SKPoint(point.X + 10, point.Y + imgHeight - 30), SKColors.White, BodyFontSize);
                string timeString = ParseTimeDuration2TimeString(item.page_info.media_info.playback_list.First()?.play_info?.duration);
                var size = img.MeasureString(timeString, BodyFontSize);
                img.DrawText(timeString, Painting.Anywhere, new SKPoint(initialPoint.X + imgWidth - size.Width - 10, initialPoint.Y + imgHeight - 30), SKColors.White);

                point = new SKPoint(initialPoint.X, point.Y + imgHeight + 10);
            }
            else
            {
                using var articlePic = img.LoadImage(Path.Combine(Config.BaseDirectory, "tmp", item.page_info.pic_info.pic_big.url.GetFileNameFromURL()));
                float imgWidth = elementWidth;
                float imgHeight = articlePic.Height / (articlePic.Width / imgWidth);
                img.DrawImage(articlePic, new() { Location = point, Size = new(imgWidth, imgHeight) });
                img.DrawRectangle(new SKRect(point.X, point.Y + imgHeight - 40, imgWidth, 40), SKColors.Black, SKColors.Black, 0);

                img.DrawText(item.page_info.content1, Painting.Anywhere, new SKPoint(initialPoint.X + 10, initialPoint.Y + imgHeight - 30), SKColors.White);

                point = new SKPoint(initialPoint.X, point.Y + imgHeight + 10);
            }
        }

        private void DrawMainImages(TimeLine_Object item, ref Painting img, ref SKPoint point, int padding = 0)
        {
            if (item.pic_info == null || item.pic_info.Length == 0)
            {
                return;
            }
            SKPoint initalPoint = new(point.X, point.Y);

            int picCount = item.pic_info.Length;
            int imgMaxWidth = 0;
            if (picCount == 1)
            {
                var i = item.pic_info[0];
                using var image = img.LoadImage(Path.Combine(Path.Combine(Config.BaseDirectory, "tmp"), i.large.url.GetFileNameFromURL()));
                imgMaxWidth = (int)(img.Width - padding * 2);
                int width = image.Width;
                int height = image.Height;
                if (image.Width > imgMaxWidth)
                {
                    width = imgMaxWidth;
                    height = (int)(image.Height * (imgMaxWidth / (float)image.Width));
                }
                img.DrawImage(image, new SKRect { Location = point, Size = new(width, height) });
                if (i.large.url.EndsWith(".gif"))
                {
                    int paddingLeft = 4;
                    int paddingTop = 2;
                    var textSize = img.MeasureString("动图", 14);
                    var textPoint = new SKPoint(point.X + width - 10 - textSize.Width - paddingLeft, point.Y + height - 10 - textSize.Height);
                    img.DrawRectangle(new SKRect { Location = new(textPoint.X - paddingLeft, textPoint.Y - paddingTop), Size = new(textSize.Width + paddingLeft * 2, textSize.Height + paddingTop * 2) }, new SKColor(0, 0, 0, 0xBB), SKColors.Black, 0);
                    img.DrawText("动图", Painting.Anywhere, textPoint, SKColors.White, 14);
                }
                point = new(initalPoint.X, point.Y + height + 10);
            }
            else
            {
                imgMaxWidth = picCount == 4 ? 480 : 360;
                bool newLine = false;
                for (int index = 1; index <= picCount; index++)
                {
                    var image = img.LoadImage(Path.Combine(Path.Combine(Config.BaseDirectory, "tmp"), item.pic_info[index - 1].large.url.GetFileNameFromURL()));
                    if (image.Width >= imgMaxWidth && image.Height >= imgMaxWidth)
                    {
                        // 缩小后，剪裁顶部
                        if (image.Width > image.Height)
                        {
                            int width = (int)(image.Width / (image.Height / (imgMaxWidth * 1.0f)));
                            image = img.ResizeImage(image, width, imgMaxWidth);
                        }
                        else
                        {
                            int height = (int)(image.Height / (image.Width / (imgMaxWidth * 1.0f)));
                            image = img.ResizeImage(image, imgMaxWidth, height);
                        }
                        image = image.Subset(new SKRectI { Location = new(), Size = new(imgMaxWidth, imgMaxWidth) });
                    }
                    else if (image.Width >= imgMaxWidth && image.Height < imgMaxWidth)
                    {
                        // 剪裁左侧
                        image = image.Subset(new SKRectI { Location = new(), Size = new(image.Height, image.Height) });
                    }
                    else if (image.Width < imgMaxWidth && image.Height >= imgMaxWidth)
                    {
                        // 剪裁顶部
                        image = image.Subset(new SKRectI { Location = new(), Size = new(image.Width, image.Width) });
                    }
                    else
                    {
                        // 在中心绘制
                        using Painting frame = new(imgMaxWidth, imgMaxWidth);
                        frame.DrawRectangle(new SKRect { Size = new(imgMaxWidth, imgMaxWidth) }, SKColors.White, SKColors.Gray, 1);
                        frame.DrawImage(image, new SKRect { Location = new(imgMaxWidth / 2 - image.Width / 2, imgMaxWidth / 2 - image.Height / 2), Size = new(image.Width, image.Height) });
                        image.Dispose();
                        image = frame.SnapShot();
                    }
                    img.DrawImage(image, new SKRect { Location = point, Size = new(imgMaxWidth, imgMaxWidth) });
                    if (item.pic_info[index - 1].large.url.EndsWith(".gif"))
                    {
                        int paddingLeft = 4;
                        int paddingTop = 2;
                        var textSize = img.MeasureString("动图", 14);
                        var textPoint = new SKPoint(point.X + imgMaxWidth - 10 - textSize.Width - paddingLeft, point.Y + imgMaxWidth - 10 - textSize.Height);
                        img.DrawRectangle(new SKRect { Location = new(textPoint.X - paddingLeft, textPoint.Y - paddingTop), Size = new(textSize.Width + paddingLeft * 2, textSize.Height + paddingTop * 2) }, new SKColor(0, 0, 0, 0xBB), SKColors.Black, 0);
                        img.DrawText("动图", Painting.Anywhere, textPoint, SKColors.White, 14);
                    }
                    image.Dispose();
                    if (picCount == 4)
                    {
                        newLine = index % 2 == 0;
                        point = index % 2 == 0 ? new(initalPoint.X, point.Y + imgMaxWidth + 10) : new(point.X + imgMaxWidth + 10, point.Y);
                    }
                    else
                    {
                        newLine = index % 3 == 0;
                        point = index % 3 == 0 ? new(initalPoint.X, point.Y + imgMaxWidth + 10) : new(point.X + imgMaxWidth + 10, point.Y);
                    }
                }
                if (!newLine)
                {
                    point = new SKPoint(initalPoint.X, point.Y + imgMaxWidth + 10);
                }
            }
        }

        private void DrawRetweet(TimeLine_Object item, ref Painting img, ref SKPoint point)
        {
            SKPoint initalPoint = new(point.X, point.Y);
            if (item.retweeted_status == null)
            {
                return;
            }

            int padding = 10;
            int width = CanvasWidth - padding * 4;
            int fontSize = 26;
            int avatarSize = fontSize * 2;

            Painting main = new(width, 10000);
            main.Clear(new(244, 245, 247));
            SKPoint p = new(0, 0);
            // avatar
            using var avatar = main.LoadImage(Path.Combine(Path.Combine(Config.BaseDirectory, "tmp"), item.retweeted_status.user.avatar_large.GetFileNameFromURL()));
            main.DrawImage(main.CreateCircularImage(avatar, avatarSize), new SKRect { Location = p, Size = new(avatarSize, avatarSize) });

            p = new(p.X + avatarSize + fontSize / 2, p.Y + avatarSize / 2 - fontSize / 2);
            p = main.DrawText(item.retweeted_status.user.screen_name, Painting.Anywhere, p, new(0, 161, 214), fontSize);
            p = new(0, p.Y + fontSize + 5);

            // main
            DrawText(item.retweeted_status, ref main, ref p, width, 0);
            p = new(padding, p.Y + 10);
            DrawMainImages(item.retweeted_status, ref main, ref p, 0);
            p = new(padding, p.Y + 10);
            DrawMainCard(item.retweeted_status, ref main, ref p, width);

            img.DrawRectangle(new(initalPoint.X, initalPoint.Y, width + padding * 2 + initalPoint.X, p.Y + 20 + initalPoint.Y), new(244, 245, 247), SKColors.Black, 0);
            main.Resize((int)main.Width, (int)p.Y + 10);
            img.DrawImage(main.SnapShot(), new SKRect { Location = new(initalPoint.X + 10, initalPoint.Y + 10), Size = new(main.Width, main.Height) });
            point = new(initalPoint.X, initalPoint.Y + p.Y + 20 + 10);
            main.Dispose();
        }

        private void DrawText(TimeLine_Object item, ref Painting img, ref SKPoint point, int elementWidth, int padding = 14)
        {
            SKPoint initalPoint = new(point.X, point.Y);

            foreach (var c in item.TextChain)
            {
                if (c.Text != null)
                {
                    point = img.DrawText(c.Text, new SKRect { Left = initalPoint.X, Right = elementWidth - padding }, point, SKColors.Black, BodyFontSize);
                    point.Y -= BodyFontSize;
                }
                else
                {
                    // 表情元素
                    using (var emoji = img.LoadImage(Path.Combine(Path.Combine(Config.BaseDirectory, "tmp"), c.ImageURL.GetFileNameFromURL())))
                    {
                        img.DrawImage(emoji, new SKRect { Left = point.X, Top = point.Y, Size = new SKSize { Width = BodyFontSize + 2, Height = BodyFontSize + 2 } });
                    }
                    point = new(point.X + BodyFontSize + 2, point.Y);
                }
            }
            point = new(initalPoint.X, point.Y + BodyFontSize + 3);
        }

        private void DrawUserName(TimeLine_Object item, ref Painting img, ref SKPoint point)
        {
            var timeValue = item.created_at.Split(' ');
            // Sat, 18 Aug 2018 07:22:16
            DateTime time = DateTime.Parse($"{timeValue[0]}, {timeValue[2]} {timeValue[1]} {timeValue[5]} {timeValue[3]}");
            SKColor nameColor = SKColors.Black;
            img.DrawText(item.user.screen_name, Painting.Anywhere, new SKPoint() { X = point.X + AvatarSize + LargeFontSize / 2, Y = point.Y + 5 }, nameColor, LargeFontSize);
            img.DrawText($"{time:G} · {item.region_name}", Painting.Anywhere, new SKPoint() { X = point.X + AvatarSize + LargeFontSize / 2, Y = point.Y + LargeFontSize * 1.5f }, new SKColor(153, 162, 170), MiddleFontSize);
        }

        private string ParseTimeDuration2TimeString(float? duration)
        {
            if (!duration.HasValue)
            {
                return "00:00";
            }
            int hour = (int)(duration / 3600);
            int minute = (int)((duration - hour * 3600) / 60);
            int second = (int)(duration - hour * 3600 - minute * 60);
            return $"{(hour > 0 ? hour + ":" : "")}{minute:00}:{second:00}";
        }
    }
}