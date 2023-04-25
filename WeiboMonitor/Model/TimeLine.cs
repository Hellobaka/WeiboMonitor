using System;
using System.Collections.Generic;
using System.Text;

namespace WeiboMonitor.Model
{

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
        public Visible visible { get; set; }
        public string created_at { get; set; }
        public long id { get; set; }
        public string idstr { get; set; }
        public string mid { get; set; }
        public string mblogid { get; set; }
        public User user { get; set; }
        public bool can_edit { get; set; }
        public int edit_count { get; set; }
        public string text_raw { get; set; }
        public string text { get; set; }
        public int textLength { get; set; }
        public object[] annotations { get; set; }
        public string source { get; set; }
        public bool favorited { get; set; }
        public string rid { get; set; }
        public string cardid { get; set; }
        public string[] pic_ids { get; set; }
        public Pic_Focus_Point1[] pic_focus_point { get; set; }
        public string geo { get; set; }
        public int pic_num { get; set; }
        public MainPicInfo[] pic_infos { get; set; }
        public bool is_paid { get; set; }
        public string pic_bg_new { get; set; }
        public int mblog_vip_type { get; set; }
        public Number_Display_Strategy number_display_strategy { get; set; }
        public int reposts_count { get; set; }
        public int comments_count { get; set; }
        public int attitudes_count { get; set; }
        public int attitudes_status { get; set; }
        public Continue_Tag continue_tag { get; set; }
        public bool isLongText { get; set; }
        public int mlevel { get; set; }
        public int content_auth { get; set; }
        public int is_show_bulletin { get; set; }
        public Comment_Manage_Info comment_manage_info { get; set; }
        public int share_repost_type { get; set; }
        public Topic_Struct[] topic_struct { get; set; }
        public int isTop { get; set; }
        public Title title { get; set; }
        public int mblogtype { get; set; }
        public bool showFeedRepost { get; set; }
        public bool showFeedComment { get; set; }
        public bool pictureViewerSign { get; set; }
        public bool showPictureViewer { get; set; }
        public object[] rcList { get; set; }
        public string region_name { get; set; }
        public object[] customIcons { get; set; }
        public int repost_type { get; set; }
        public Retweeted_Status retweeted_status { get; set; }
        public Url_Struct[] url_struct { get; set; }
        public Page_Info page_info { get; set; }
    }

    public class Visible
    {
        public int type { get; set; }
        public int list_id { get; set; }
    }

    public class User
    {
        public int id { get; set; }
        public string idstr { get; set; }
        public int pc_new { get; set; }
        public string screen_name { get; set; }
        public string profile_image_url { get; set; }
        public string profile_url { get; set; }
        public bool verified { get; set; }
        public int verified_type { get; set; }
        public string domain { get; set; }
        public string weihao { get; set; }
        public int verified_type_ext { get; set; }
        public string avatar_large { get; set; }
        public string avatar_hd { get; set; }
        public bool follow_me { get; set; }
        public bool following { get; set; }
        public int mbrank { get; set; }
        public int mbtype { get; set; }
        public int v_plus { get; set; }
        public bool planet_video { get; set; }
        public Icon_List[] icon_list { get; set; }
    }

    public class Icon_List
    {
        public string type { get; set; }
        public Data1 data { get; set; }
    }

    public class Data1
    {
        public int mbrank { get; set; }
        public int mbtype { get; set; }
        public int svip { get; set; }
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

    public class Number_Display_Strategy
    {
        public int apply_scenario_flag { get; set; }
        public int display_text_min_number { get; set; }
        public string display_text { get; set; }
    }

    public class Continue_Tag
    {
        public string title { get; set; }
        public string pic { get; set; }
        public string scheme { get; set; }
        public bool cleaned { get; set; }
    }

    public class Comment_Manage_Info
    {
        public int comment_permission_type { get; set; }
        public int approval_comment_type { get; set; }
        public int comment_sort_type { get; set; }
    }

    public class Title
    {
        public string text { get; set; }
        public int base_color { get; set; }
        public string icon_url { get; set; }
    }

    public class Retweeted_Status
    {
        public Visible1 visible { get; set; }
        public string created_at { get; set; }
        public long id { get; set; }
        public string idstr { get; set; }
        public string mid { get; set; }
        public string mblogid { get; set; }
        public User1 user { get; set; }
        public bool can_edit { get; set; }
        public string text_raw { get; set; }
        public string text { get; set; }
        public int textLength { get; set; }
        public object[] annotations { get; set; }
        public string source { get; set; }
        public bool favorited { get; set; }
        public string rid { get; set; }
        public string cardid { get; set; }
        public string[] pic_ids { get; set; }
        public Pic_Focus_Point[] pic_focus_point { get; set; }
        public string geo { get; set; }
        public int pic_num { get; set; }
        public Pic_Info pic_infos { get; set; }
        public bool is_paid { get; set; }
        public int mblog_vip_type { get; set; }
        public Number_Display_Strategy number_display_strategy { get; set; }
        public int reposts_count { get; set; }
        public int comments_count { get; set; }
        public int attitudes_count { get; set; }
        public int attitudes_status { get; set; }
        public bool isLongText { get; set; }
        public int mlevel { get; set; }
        public int content_auth { get; set; }
        public int is_show_bulletin { get; set; }
        public Comment_Manage_Info comment_manage_info { get; set; }
        public int mblogtype { get; set; }
        public bool showFeedRepost { get; set; }
        public bool showFeedComment { get; set; }
        public bool pictureViewerSign { get; set; }
        public bool showPictureViewer { get; set; }
        public object[] rcList { get; set; }
        public string region_name { get; set; }
        public object[] customIcons { get; set; }
        public string deleted { get; set; }
    }

    public class Visible1
    {
        public int type { get; set; }
        public int list_id { get; set; }
    }

    public class User1
    {
        public int id { get; set; }
        public string idstr { get; set; }
        public int pc_new { get; set; }
        public string screen_name { get; set; }
        public string profile_image_url { get; set; }
        public string profile_url { get; set; }
        public bool verified { get; set; }
        public int verified_type { get; set; }
        public string domain { get; set; }
        public string weihao { get; set; }
        public int verified_type_ext { get; set; }
        public string avatar_large { get; set; }
        public string avatar_hd { get; set; }
        public bool follow_me { get; set; }
        public bool following { get; set; }
        public int mbrank { get; set; }
        public int mbtype { get; set; }
        public int v_plus { get; set; }
        public bool planet_video { get; set; }
        public Icon_List1[] icon_list { get; set; }
    }

    public class Icon_List1
    {
        public string type { get; set; }
        public Data2 data { get; set; }
    }

    public class Data2
    {
        public int mbrank { get; set; }
        public int mbtype { get; set; }
        public int svip { get; set; }
    }

    public class Pic_Focus_Point
    {
        public Focus_Point focus_point { get; set; }
        public string pic_id { get; set; }
    }

    public class Page_Info
    {
        public string type { get; set; }
        public string page_id { get; set; }
        public string object_type { get; set; }
        public string object_id { get; set; }
        public string content1 { get; set; }
        public string content2 { get; set; }
        public int act_status { get; set; }
        public Media_Info media_info { get; set; }
        public string page_pic { get; set; }
        public string page_title { get; set; }
        public string page_url { get; set; }
        public Pic_Info pic_info { get; set; }
        public string oid { get; set; }
        public string type_icon { get; set; }
        public string author_id { get; set; }
        public string authorid { get; set; }
        public string warn { get; set; }
        public Actionlog1 actionlog { get; set; }
        public string short_url { get; set; }
    }

    public class Media_Info
    {
        public string video_orientation { get; set; }
        public string name { get; set; }
        public string stream_url { get; set; }
        public string stream_url_hd { get; set; }
        public string format { get; set; }
        public string h5_url { get; set; }
        public string mp4_sd_url { get; set; }
        public string mp4_hd_url { get; set; }
        public string h265_mp4_hd { get; set; }
        public string h265_mp4_ld { get; set; }
        public string inch_4_mp4_hd { get; set; }
        public string inch_5_mp4_hd { get; set; }
        public string inch_5_5_mp4_hd { get; set; }
        public string mp4_720p_mp4 { get; set; }
        public string hevc_mp4_720p { get; set; }
        public int prefetch_type { get; set; }
        public int prefetch_size { get; set; }
        public int act_status { get; set; }
        public string protocol { get; set; }
        public string media_id { get; set; }
        public int origin_total_bitrate { get; set; }
        public int duration { get; set; }
        public int forward_strategy { get; set; }
        public string search_scheme { get; set; }
        public int is_short_video { get; set; }
        public int vote_is_show { get; set; }
        public int belong_collection { get; set; }
        public string titles_display_time { get; set; }
        public int show_progress_bar { get; set; }
        public Ext_Info ext_info { get; set; }
        public string next_title { get; set; }
        public string kol_title { get; set; }
        public Play_Completion_Actions[] play_completion_actions { get; set; }
        public int video_publish_time { get; set; }
        public int play_loop_type { get; set; }
        public string author_mid { get; set; }
        public string author_name { get; set; }
        public Extra_Info extra_info { get; set; }
        public int has_recommend_video { get; set; }
        public Video_Download_Strategy video_download_strategy { get; set; }
        public int jump_to { get; set; }
        public string online_users { get; set; }
        public int online_users_number { get; set; }
        public int ttl { get; set; }
        public string storage_type { get; set; }
        public int is_keep_current_mblog { get; set; }
        public Author_Info author_info { get; set; }
        public Playback_List[] playback_list { get; set; }
    }

    public class Ext_Info
    {
        public string video_orientation { get; set; }
    }

    public class Extra_Info
    {
        public string sceneid { get; set; }
    }

    public class Video_Download_Strategy
    {
        public int abandon_download { get; set; }
    }

    public class Author_Info
    {
        public int id { get; set; }
        public string idstr { get; set; }
        public int pc_new { get; set; }
        public string screen_name { get; set; }
        public string profile_image_url { get; set; }
        public string profile_url { get; set; }
        public bool verified { get; set; }
        public int verified_type { get; set; }
        public string domain { get; set; }
        public string weihao { get; set; }
        public int verified_type_ext { get; set; }
        public string avatar_large { get; set; }
        public string avatar_hd { get; set; }
        public bool follow_me { get; set; }
        public bool following { get; set; }
        public int mbrank { get; set; }
        public int mbtype { get; set; }
        public int v_plus { get; set; }
        public bool planet_video { get; set; }
        public string verified_reason { get; set; }
        public string description { get; set; }
        public string location { get; set; }
        public string gender { get; set; }
        public int followers_count { get; set; }
        public string followers_count_str { get; set; }
        public int friends_count { get; set; }
        public int statuses_count { get; set; }
        public string url { get; set; }
        public int svip { get; set; }
        public string cover_image_phone { get; set; }
    }

    public class Play_Completion_Actions
    {
        public string type { get; set; }
        public string icon { get; set; }
        public string text { get; set; }
        public string link { get; set; }
        public int btn_code { get; set; }
        public int show_position { get; set; }
        public Actionlog actionlog { get; set; }
    }

    public class Actionlog
    {
        public string oid { get; set; }
        public int act_code { get; set; }
        public int act_type { get; set; }
        public string source { get; set; }
    }

    public class Playback_List
    {
        public Meta meta { get; set; }
        public Play_Info play_info { get; set; }
    }

    public class Meta
    {
        public string label { get; set; }
        public int quality_index { get; set; }
        public string quality_desc { get; set; }
        public string quality_label { get; set; }
        public string quality_class { get; set; }
        public int type { get; set; }
        public int quality_group { get; set; }
        public bool is_hidden { get; set; }
    }

    public class Play_Info
    {
        public int type { get; set; }
        public string mime { get; set; }
        public string protocol { get; set; }
        public string label { get; set; }
        public string url { get; set; }
        public int bitrate { get; set; }
        public string prefetch_range { get; set; }
        public string video_codecs { get; set; }
        public int fps { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int size { get; set; }
        public float duration { get; set; }
        public string sar { get; set; }
        public string audio_codecs { get; set; }
        public int audio_sample_rate { get; set; }
        public string quality_label { get; set; }
        public string quality_class { get; set; }
        public string quality_desc { get; set; }
        public int audio_channels { get; set; }
        public string audio_sample_fmt { get; set; }
        public int audio_bits_per_sample { get; set; }
        public string watermark { get; set; }
        public Extension extension { get; set; }
        public string video_decoder { get; set; }
        public bool prefetch_enabled { get; set; }
        public int tcp_receive_buffer { get; set; }
        public bool dolby_atmos { get; set; }
        public int col { get; set; }
        public int row { get; set; }
        public int interval { get; set; }
        public float offset { get; set; }
        public string[] urls { get; set; }
    }

    public class Extension
    {
        public Transcode_Info transcode_info { get; set; }
    }

    public class Transcode_Info
    {
        public int pcdn_rule_id { get; set; }
        public int pcdn_jank { get; set; }
        public string origin_video_dr { get; set; }
        public string ab_strategies { get; set; }
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

    public class Actionlog1
    {
        public int act_type { get; set; }
        public int act_code { get; set; }
        public string lcardid { get; set; }
        public string fid { get; set; }
        public string mid { get; set; }
        public string oid { get; set; }
        public long uuid { get; set; }
        public string source { get; set; }
        public string ext { get; set; }
    }

    public class Pic_Focus_Point1
    {
        public Focus_Point27 focus_point { get; set; }
        public string pic_id { get; set; }
    }

    public class Focus_Point27
    {
        public float left { get; set; }
        public float top { get; set; }
        public float width { get; set; }
        public float height { get; set; }
    }

    public class Topic_Struct
    {
        public string title { get; set; }
        public string topic_url { get; set; }
        public string topic_title { get; set; }
        public int is_invalid { get; set; }
        public Actionlog2 actionlog { get; set; }
    }

    public class Actionlog2
    {
        public int act_type { get; set; }
        public int act_code { get; set; }
        public string oid { get; set; }
        public long uuid { get; set; }
        public string cardid { get; set; }
        public string lcardid { get; set; }
        public string uicode { get; set; }
        public string luicode { get; set; }
        public string fid { get; set; }
        public string lfid { get; set; }
        public string ext { get; set; }
    }

    public class Url_Struct
    {
        public string url_title { get; set; }
        public string url_type_pic { get; set; }
        public string ori_url { get; set; }
        public string page_id { get; set; }
        public string short_url { get; set; }
        public string long_url { get; set; }
        public int url_type { get; set; }
        public bool result { get; set; }
        public Actionlog3 actionlog { get; set; }
        public string storage_type { get; set; }
        public int hide { get; set; }
        public string object_type { get; set; }
        public int ttl { get; set; }
        public string h5_target_url { get; set; }
        public int need_save_obj { get; set; }
        public int position { get; set; }
        public Pic_Infos2 pic_infos { get; set; }
        public string[] pic_ids { get; set; }
        public string gif_name { get; set; }
        public Vip_Gif vip_gif { get; set; }
    }

    public class Actionlog3
    {
        public int act_type { get; set; }
        public int act_code { get; set; }
        public string oid { get; set; }
        public long uuid { get; set; }
        public string cardid { get; set; }
        public string lcardid { get; set; }
        public string uicode { get; set; }
        public string luicode { get; set; }
        public string fid { get; set; }
        public string lfid { get; set; }
        public string ext { get; set; }
    }

    public class Pic_Infos2
    {
        public _6Dd57921ly1hdb41e40tgj20q70ff43p _6dd57921ly1hdb41e40tgj20q70ff43p { get; set; }
        public _611Ac992gy1hd4hqz5l3vj219s0qq14n _611ac992gy1hd4hqz5l3vj219s0qq14n { get; set; }
    }

    public class _6Dd57921ly1hdb41e40tgj20q70ff43p
    {
        public Thumbnail28 thumbnail { get; set; }
        public Bmiddle28 bmiddle { get; set; }
        public Large28 large { get; set; }
        public Woriginal woriginal { get; set; }
    }

    public class Thumbnail28
    {
        public string type { get; set; }
        public string url { get; set; }
        public int cut_type { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public bool croped { get; set; }
    }

    public class Bmiddle28
    {
        public string type { get; set; }
        public string url { get; set; }
        public int cut_type { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public bool croped { get; set; }
    }

    public class Large28
    {
        public string type { get; set; }
        public string url { get; set; }
        public int cut_type { get; set; }
        public string width { get; set; }
        public string height { get; set; }
        public bool croped { get; set; }
    }

    public class Woriginal
    {
        public string type { get; set; }
        public string url { get; set; }
        public int cut_type { get; set; }
        public string width { get; set; }
        public string height { get; set; }
        public bool croped { get; set; }
    }

    public class _611Ac992gy1hd4hqz5l3vj219s0qq14n
    {
        public Thumbnail29 thumbnail { get; set; }
        public Bmiddle29 bmiddle { get; set; }
        public Large29 large { get; set; }
        public Woriginal1 woriginal { get; set; }
    }

    public class Thumbnail29
    {
        public string type { get; set; }
        public string url { get; set; }
        public int cut_type { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public bool croped { get; set; }
    }

    public class Bmiddle29
    {
        public string type { get; set; }
        public string url { get; set; }
        public int cut_type { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public bool croped { get; set; }
    }

    public class Large29
    {
        public string type { get; set; }
        public string url { get; set; }
        public int cut_type { get; set; }
        public string width { get; set; }
        public string height { get; set; }
        public bool croped { get; set; }
    }

    public class Woriginal1
    {
        public string type { get; set; }
        public string url { get; set; }
        public int cut_type { get; set; }
        public string width { get; set; }
        public string height { get; set; }
        public bool croped { get; set; }
    }

    public class Vip_Gif
    {
        public string id { get; set; }
        public string url { get; set; }
        public string display_name { get; set; }
        public string object_type { get; set; }
        public string comment_id { get; set; }
        public string[] pic_ids { get; set; }
        public Biz biz { get; set; }
        public string target_url { get; set; }
        public string object_id { get; set; }
        public string request_oid { get; set; }
        public string containerid { get; set; }
        public string object_domain_id { get; set; }
        public int safe_status { get; set; }
        public string safe_extparam { get; set; }
        public string show_status { get; set; }
        public string act_status { get; set; }
        public string last_modified { get; set; }
        public long timestamp { get; set; }
        public long uuid { get; set; }
        public string uuidstr { get; set; }
        public string activate_status { get; set; }
        public bool is_longtext { get; set; }
    }

    public class Biz
    {
        public string biz_id { get; set; }
        public string containerid { get; set; }
    }
}
