using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.InteropServices.ComTypes;
using System.Text.RegularExpressions;
using System.Web;
using System.Xml.Linq;

namespace WeiboMonitor.API
{
    public static class TokenManager
    {
        public static string SubToken { get; set; } = "";

        public static string SubpToken { get; set; } = "";

        public static string GenerateCookie()
        {
            if(string.IsNullOrEmpty(SubToken))
            {
                return "";
            }
            return $"SUB={SubToken};SUBP={SubpToken};";
        }

        public static bool UpdateToken()
        {
            try
            {
                LogHelper.Info("UpdateToken", "开始刷新Token...");
                string sub = "", subp = "";
                bool result = GetTID(out string tid, out string confidence);
                result = result && UpdateCookie(tid, confidence, out sub, out subp);
                if (result)
                {
                    SubToken = sub;
                    SubpToken = subp;
                }
                return result && CrossDomainBoardcast(sub, subp);
            }
            catch (Exception e)
            {
                LogHelper.Info("更新Token", e.Message + e.StackTrace, false);
                return false;
            }
        }

        private static bool GetTID(out string tid, out string confidence)
        {
            tid = null; 
            confidence = null ;
            string url = "https://passport.weibo.com/visitor/genvisitor";
            var formContent = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("cb", "gen_callback"),
                new KeyValuePair<string, string>("fp", "{\"os\":\"1\",\"browser\":\"Chrome111,0,0,0\",\"fonts\":\"undefined\",\"screenInfo\":\"1920*1080*24\",\"plugins\":\"Portable Document Format::internal-pdf-viewer::PDF Viewer|Portable Document Format::internal-pdf-viewer::Chrome PDF Viewer|Portable Document Format::internal-pdf-viewer::Chromium PDF Viewer|Portable Document Format::internal-pdf-viewer::Microsoft Edge PDF Viewer|Portable Document Format::internal-pdf-viewer::WebKit built-in PDF\"}")
            });
            string result = CommonHelper.Post(url, formContent).Result;
            if (string.IsNullOrEmpty(result) is false && result.StartsWith("window"))
            {
                var match = Regex.Match(result, "{.*}");
                if(match.Groups.Count == 0) 
                {
                    LogHelper.Info("GetTID", $"Update Fail: {result}", false);
                    return false;
                }
                JObject json = JObject.Parse(match.Groups[0].Value);
                if (json["retcode"] != null && json["retcode"].ToString() == "20000000")
                {
                    tid = json["data"]["tid"].ToString();
                    confidence = json["data"]["confidence"].ToString();
                    LogHelper.Info("UpdateToken", "TID获取成功");
                    return true;
                }
                else
                {
                    LogHelper.Info("GetTID", $"Update Fail: {result}", false);
                    return false;
                }
            }
            LogHelper.Info("GetTID", $"Update Fail: {result}", false);
            return false;
        }

        private static bool UpdateCookie(string tid, string confidence, out string sub, out string subp)
        {
            sub = null;
            subp = null;
            tid = tid.Replace("+", "%2B").Replace("/", "%2F").Replace("=", "%3D");
            string url = $"https://passport.weibo.com/visitor/visitor?a=incarnate&t={tid}&w=2&c={confidence}&gc=&cb=cross_domain&from=weibo&_rand={new Random().NextDouble()}";
            string result = CommonHelper.Get(url).Result;
            if (string.IsNullOrEmpty(result) is false && result.StartsWith("window"))
            {
                var match = Regex.Match(result, "{.*}");
                if (match.Groups.Count == 0)
                {
                    LogHelper.Info("UpdateCookie", $"Update Fail: {result}", false);
                    return false;
                }
                JObject json = JObject.Parse(match.Groups[0].Value);
                if (json["retcode"] != null && json["retcode"].ToString() == "20000000")
                {
                    sub = json["data"]["sub"].ToString();
                    subp = json["data"]["subp"].ToString();
                    LogHelper.Info("UpdateToken", "Cookie获取成功");
                    return true;
                }
                else
                {
                    LogHelper.Info("UpdateCookie", $"Update Fail: {result}", false);
                    return false;
                }
            }
            return true;
        }

        private static bool CrossDomainBoardcast(string sub, string subp)
        {
            string url = $"https://login.sina.com.cn/visitor/visitor?a=crossdomain&cb=return_back&s={sub}&sp={subp}&from=weibo&_rand={new Random().NextDouble()}&entry=miniblog";
            string result = CommonHelper.Get(url).Result;
            if (string.IsNullOrEmpty(result) is false && result.StartsWith("window"))
            {
                var match = Regex.Match(result, "{.*}");
                if (match.Groups.Count == 0)
                {
                    LogHelper.Info("CrossDomainBoardcast", $"Update Fail: {result}", false);
                    return false;
                }
                JObject json = JObject.Parse(match.Groups[0].Value);
                if (json["retcode"] != null)
                {
                    LogHelper.Info("UpdateToken", $"跨域广播retcode: {json["retcode"]}");
                    return json["retcode"].ToString() == "20000000";
                }
                else
                {
                    LogHelper.Info("CrossDomainBoardcast", $"Update Fail: {result}", false);
                    return false;
                }
            }
            return false;
        }
    }
}