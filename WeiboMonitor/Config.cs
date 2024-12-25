using System.Collections.Generic;

namespace WeiboMonitor_netframework
{
    public class Config : ConfigBase
    {
        public Config(string configPath) : base(configPath)
        {
            Instance = this;
        }

        public static ConfigBase Instance { get; set; }

        public static int RefreshInterval { get; set; } = 120000;

        public static bool DebugMode { get; set; } = false;

        public static int RetryCount { get; set; } = 3;

        public static string BaseDirectory { get; set; } = "";

        public static string PicSaveBasePath { get; set; } = "";

        public static string CustomFont { get; set; } = "";

        public static string CustomFontPath { get; set; } = "";

        public static List<string> DynamicFilters { get; set; } = [];

        public override void LoadConfig()
        {
            CustomFont = GetConfig("CustomFont", "Microsoft YaHei");
            CustomFontPath = GetConfig("CustomFontPath", "");
            RefreshInterval = GetConfig("RefreshInterval", 120 * 1000);
            RetryCount = GetConfig("RetryCount", 3);
            DebugMode = GetConfig("DebugMode", false);
            DynamicFilters = GetConfig("DynamicFilters", new List<string>() { });
        }
    }
}