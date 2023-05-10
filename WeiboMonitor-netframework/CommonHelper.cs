using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace WeiboMonitor
{
    public static class CommonHelper
    {
        public static string UA { get; set; } = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/111.0.0.0 Safari/537.36 Edg/111.0.1661.62";

        public static async Task<string> Get(string url, string cookie = "")
        {
            try
            {
                HttpClientHandler handler = new();
                handler.CookieContainer = new CookieContainer();
                if (!string.IsNullOrEmpty(cookie))
                {
                    foreach(var item in cookie.Split(';'))
                    {
                        if(string.IsNullOrEmpty(item) is false)
                        {
                            string[] c = item.Split('=');
                            handler.CookieContainer.Add(new Uri("https://weibo.com/"), new Cookie(c.First(), c.Last()));
                        }
                    }
                }

                using var http = new HttpClient(handler);
                http.DefaultRequestHeaders.Add("user-agent", UA);
                var r = await http.GetAsync(url);
                r.Content.Headers.ContentType.CharSet = "UTF-8";
                return await r.Content.ReadAsStringAsync();
            }
            catch (Exception e)
            {
                LogHelper.Info("Get", e.Message);
                return string.Empty;
            }
        }

        public static async Task<string> Post(string url, HttpContent body)
        {
            try
            {
                using var http = new HttpClient();
                http.DefaultRequestHeaders.Add("user-agent", UA);
                var r = await http.PostAsync(url, body);
                r.Content.Headers.ContentType.CharSet = "UTF-8";
                return await r.Content.ReadAsStringAsync();
            }
            catch (Exception e)
            {
                LogHelper.Info("Post", e.Message);
                return string.Empty;
            }
        }

        public static string ParseLongNumber(int num)
        {
            string numStr = num.ToString();
            int step = 1;
            for (int i = numStr.Length - 1; i > 0; i--)
            {
                if (step % 3 == 0)
                {
                    numStr = numStr.Insert(i, ",");
                }
                step++;
            }
            return numStr;
        }

        /// <summary>
        /// 下载文件
        /// </summary>
        /// <param name="url">网址</param>
        /// <param name="path">目标文件夹</param>
        /// <param name="overwrite">重复时是否覆写</param>
        /// <returns></returns>
        public static async Task<bool> DownloadFile(string url, string path, bool overwrite = false)
        {
            using var http = new HttpClient();
            try
            {
                if (string.IsNullOrWhiteSpace(url))
                {
                    return false;
                }

                string fileName = GetFileNameFromURL(url);
                if (!overwrite && File.Exists(Path.Combine(path, fileName)))
                {
                    return true;
                }

                var r = await http.GetAsync(url);
                byte[] buffer = await r.Content.ReadAsByteArrayAsync();
                Directory.CreateDirectory(path);
                File.WriteAllBytes(Path.Combine(path, fileName), buffer);
                return true;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                return false;
            }
        }

        public static string GetFileNameFromURL(this string url)
        {
            return url.Split('/').Last().Split('?').First();
        }

        public static string ParseNum2Chinese(this int num)
        {
            return num > 10000 ? $"{num / 10000.0:f1}万" : num.ToString();
        }

        public static bool CompareNumString(string a, string b)
        {
            if (a.Length != b.Length)
            {
                return a.Length > b.Length;
            }

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                {
                    return a[i] > b[i];
                }
            }
            return false;
        }
    }
}
