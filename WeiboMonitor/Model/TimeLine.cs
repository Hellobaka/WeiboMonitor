using System.Collections.Generic;

namespace WeiboMonitor.Model
{
    public class LongTweet
    {
        public int ok { get; set; }

        public int http_code { get; set; }

        public LongTweetData data { get; set; }
    }

    public class LongTweetData
    {
        public string longTextContent { get; set; }

        public Url_Struct[] url_struct { get; set; }
    }

    public class TimeLine
    {
        public TimeLine_Data data { get; set; }

        public int ok { get; set; }
    }

    public class TimeLine_Data
    {
        public string since_id { get; set; }

        public TimeLine_Object[] list { get; set; }

        public int status_visible { get; set; }

        public bool bottom_tips_visible { get; set; }

        public string bottom_tips_text { get; set; }

        public object[] topicList { get; set; }

        public int total { get; set; }
    }

    public class TimeLine_Object
    {
        public string created_at { get; set; }

        public long id { get; set; }

        public string idstr { get; set; }

        public string mid { get; set; }

        public string mblogid { get; set; }

        public User user { get; set; }

        public string text_raw { get; set; }

        public string text { get; set; }

        public int pic_num { get; set; }

        public MainPicInfo[] pic_info { get; set; }

        public object pic_infos { get; set; }

        public int reposts_count { get; set; }

        public int comments_count { get; set; }

        public int attitudes_count { get; set; }

        public bool isLongText { get; set; }

        public string region_name { get; set; }

        public TimeLine_Object retweeted_status { get; set; }

        public Page_Info page_info { get; set; }

        public List<TextChainItem> TextChain { get; set; } = new();
    }

    public class TextChainItem
    {
        public string Text { get; set; }

        public bool LinkFlag { get; set; }

        public string ImageURL { get; set; }

        public string ImageAlt { get; set; }
    }

    public class User
    {
        public long id { get; set; }

        public string screen_name { get; set; }

        public string avatar_large { get; set; }
    }

    public class MainPicInfo
    {
        public Thumbnail thumbnail { get; set; }

        public Bmiddle bmiddle { get; set; }

        public Large large { get; set; }

        public Original original { get; set; }

        public Largest largest { get; set; }

        public Mw2000 mw2000 { get; set; }

        public Focus_Point focus_point { get; set; }

        public string object_id { get; set; }

        public string pic_id { get; set; }

        public int photo_tag { get; set; }

        public string type { get; set; }

        public int pic_status { get; set; }
    }

    public class Thumbnail
    {
        public string url { get; set; }

        public int width { get; set; }

        public int height { get; set; }

        public int cut_type { get; set; }

        public string type { get; set; }
    }

    public class Bmiddle
    {
        public string url { get; set; }

        public int width { get; set; }

        public int height { get; set; }

        public int cut_type { get; set; }

        public string type { get; set; }
    }

    public class Large
    {
        public string url { get; set; }

        public int width { get; set; }

        public int height { get; set; }

        public int cut_type { get; set; }

        public string type { get; set; }
    }

    public class Original
    {
        public string url { get; set; }

        public int width { get; set; }

        public int height { get; set; }

        public int cut_type { get; set; }

        public string type { get; set; }
    }

    public class Largest
    {
        public string url { get; set; }

        public int width { get; set; }

        public int height { get; set; }

        public int cut_type { get; set; }

        public string type { get; set; }
    }

    public class Mw2000
    {
        public string url { get; set; }

        public int width { get; set; }

        public int height { get; set; }

        public int cut_type { get; set; }

        public string type { get; set; }
    }

    public class Focus_Point
    {
        public float left { get; set; }

        public float top { get; set; }

        public float width { get; set; }

        public float height { get; set; }
    }

    public class Page_Info
    {
        public string type { get; set; }

        public string page_id { get; set; }

        public string object_type { get; set; }

        public string content1 { get; set; }

        public string content2 { get; set; }

        public int act_status { get; set; }

        public Media_Info media_info { get; set; }

        public Pic_Info pic_info { get; set; }
    }

    public class Media_Info
    {
        public string online_users { get; set; }

        public Playback_List[] playback_list { get; set; }
    }

    public class Playback_List
    {
        public Play_Info play_info { get; set; }
    }

    public class Play_Info
    {
        public float duration { get; set; }
    }

    public class Pic_Info
    {
        public Pic_Big pic_big { get; set; }

        public Pic_Small pic_small { get; set; }

        public Pic_Middle pic_middle { get; set; }
    }

    public class Pic_Big
    {
        public string height { get; set; }

        public string url { get; set; }

        public string width { get; set; }
    }

    public class Pic_Small
    {
        public string height { get; set; }

        public string url { get; set; }

        public string width { get; set; }
    }

    public class Pic_Middle
    {
        public string url { get; set; }

        public string height { get; set; }

        public string width { get; set; }
    }

    public class Url_Struct
    {
        public string url_title { get; set; }

        public string short_url { get; set; }
    }
}