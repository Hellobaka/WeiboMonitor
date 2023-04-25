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
        public Pic_Infos pic_infos { get; set; }
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

    public class Pic_Infos
    {
        public _6Dd57921ly1hcmq8vpmsvj20nv0zsb0u _6dd57921ly1hcmq8vpmsvj20nv0zsb0u { get; set; }
        public _6Dd57921ly1hcmq96x05vj20ei0wrdms _6dd57921ly1hcmq96x05vj20ei0wrdms { get; set; }
        public _6Dd57921ly1hcmsiwvyxsj20d10h9aep _6dd57921ly1hcmsiwvyxsj20d10h9aep { get; set; }
        public _6Dd57921ly1hcmqbmo6fxj20ku0ezmzr _6dd57921ly1hcmqbmo6fxj20ku0ezmzr { get; set; }
        public _6Dd57921ly1hc3vlvznkbj211q0l8tph _6dd57921ly1hc3vlvznkbj211q0l8tph { get; set; }
        public _6Dd57921ly1hdbvf4j5ouj20oo0c30vk _6dd57921ly1hdbvf4j5ouj20oo0c30vk { get; set; }
        public _6Dd57921ly1hdbuhx1cmjj20k00ie75i _6dd57921ly1hdbuhx1cmjj20k00ie75i { get; set; }
        public _6Dd57921ly1hdbu6lt5uhj20n70xcwtk _6dd57921ly1hdbu6lt5uhj20n70xcwtk { get; set; }
        public _6Dd57921ly1hdbu6q7nz3j20n70xcwtj _6dd57921ly1hdbu6q7nz3j20n70xcwtj { get; set; }
        public _6Dd57921ly1hdbu7ibig3j20jq0sgdva _6dd57921ly1hdbu7ibig3j20jq0sgdva { get; set; }
        public _6Dd57921ly1hdbu7cf7l6j20g10mxwki _6dd57921ly1hdbu7cf7l6j20g10mxwki { get; set; }
        public _6Dd57921ly1hdbtrv77rlj20yi1is44i _6dd57921ly1hdbtrv77rlj20yi1is44i { get; set; }
        public _6Dd57921ly1hdbsij6ddhj20qo11oqfj _6dd57921ly1hdbsij6ddhj20qo11oqfj { get; set; }
        public _6Dd57921ly1hdbsimvu60j20qo11o4bb _6dd57921ly1hdbsimvu60j20qo11o4bb { get; set; }
        public _6Dd57921ly1hdbr5h9z3qj20cc0e43z8 _6dd57921ly1hdbr5h9z3qj20cc0e43z8 { get; set; }
        public _6Dd57921ly1hdbquorf3jj20k00xv0wh _6dd57921ly1hdbquorf3jj20k00xv0wh { get; set; }
        public _6Dd57921ly1hdbqur4et4j20qo1bfguj _6dd57921ly1hdbqur4et4j20qo1bfguj { get; set; }
        public _6Dd57921ly1hdbqgtgb3uj21ah1cdhdt _6dd57921ly1hdbqgtgb3uj21ah1cdhdt { get; set; }
        public _6Dd57921ly1hdbqaqp7guj20u00c574u _6dd57921ly1hdbqaqp7guj20u00c574u { get; set; }
        public _6Dd57921ly1hdbosg4wlhj20go0o0t9k _6dd57921ly1hdbosg4wlhj20go0o0t9k { get; set; }
        public _6Dd57921ly1hdbo8c8rvfj20n016qtd8 _6dd57921ly1hdbo8c8rvfj20n016qtd8 { get; set; }
        public _6Dd57921ly1hdbofaj37ej20n0159wmn _6dd57921ly1hdbofaj37ej20n0159wmn { get; set; }
        public _6Dd57921ly1hdb984ccnzj20o20sh1ce _6dd57921ly1hdb984ccnzj20o20sh1ce { get; set; }
        public _6Dd57921ly1hdb77v0oj5j228s35s7wi _6dd57921ly1hdb77v0oj5j228s35s7wi { get; set; }
        public _6Dd57921ly1hdb5288o9cg207u09n0ur _6dd57921ly1hdb5288o9cg207u09n0ur { get; set; }
    }

    public class _6Dd57921ly1hcmq8vpmsvj20nv0zsb0u
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

    public class _6Dd57921ly1hcmq96x05vj20ei0wrdms
    {
        public Thumbnail1 thumbnail { get; set; }
        public Bmiddle1 bmiddle { get; set; }
        public Large1 large { get; set; }
        public Original1 original { get; set; }
        public Largest1 largest { get; set; }
        public Mw20001 mw2000 { get; set; }
        public Focus_Point1 focus_point { get; set; }
        public string object_id { get; set; }
        public string pic_id { get; set; }
        public int photo_tag { get; set; }
        public string type { get; set; }
        public int pic_status { get; set; }
    }

    public class Thumbnail1
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Bmiddle1
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Large1
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Original1
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Largest1
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Mw20001
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Focus_Point1
    {
        public float left { get; set; }
        public float top { get; set; }
        public float width { get; set; }
        public float height { get; set; }
    }

    public class _6Dd57921ly1hcmsiwvyxsj20d10h9aep
    {
        public Thumbnail2 thumbnail { get; set; }
        public Bmiddle2 bmiddle { get; set; }
        public Large2 large { get; set; }
        public Original2 original { get; set; }
        public Largest2 largest { get; set; }
        public Mw20002 mw2000 { get; set; }
        public Focus_Point2 focus_point { get; set; }
        public string object_id { get; set; }
        public string pic_id { get; set; }
        public int photo_tag { get; set; }
        public string type { get; set; }
        public int pic_status { get; set; }
    }

    public class Thumbnail2
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Bmiddle2
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Large2
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Original2
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Largest2
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Mw20002
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Focus_Point2
    {
        public int left { get; set; }
        public float top { get; set; }
        public int width { get; set; }
        public float height { get; set; }
    }

    public class _6Dd57921ly1hcmqbmo6fxj20ku0ezmzr
    {
        public Thumbnail3 thumbnail { get; set; }
        public Bmiddle3 bmiddle { get; set; }
        public Large3 large { get; set; }
        public Original3 original { get; set; }
        public Largest3 largest { get; set; }
        public Mw20003 mw2000 { get; set; }
        public Focus_Point3 focus_point { get; set; }
        public string object_id { get; set; }
        public string pic_id { get; set; }
        public int photo_tag { get; set; }
        public string type { get; set; }
        public int pic_status { get; set; }
    }

    public class Thumbnail3
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Bmiddle3
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Large3
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Original3
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Largest3
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Mw20003
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Focus_Point3
    {
        public float left { get; set; }
        public float top { get; set; }
        public float width { get; set; }
        public float height { get; set; }
    }

    public class _6Dd57921ly1hc3vlvznkbj211q0l8tph
    {
        public Thumbnail4 thumbnail { get; set; }
        public Bmiddle4 bmiddle { get; set; }
        public Large4 large { get; set; }
        public Original4 original { get; set; }
        public Largest4 largest { get; set; }
        public Mw20004 mw2000 { get; set; }
        public Focus_Point4 focus_point { get; set; }
        public string object_id { get; set; }
        public string pic_id { get; set; }
        public int photo_tag { get; set; }
        public string type { get; set; }
        public int pic_status { get; set; }
    }

    public class Thumbnail4
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Bmiddle4
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Large4
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Original4
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Largest4
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Mw20004
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Focus_Point4
    {
        public float left { get; set; }
        public float top { get; set; }
        public float width { get; set; }
        public float height { get; set; }
    }

    public class _6Dd57921ly1hdbvf4j5ouj20oo0c30vk
    {
        public Thumbnail5 thumbnail { get; set; }
        public Bmiddle5 bmiddle { get; set; }
        public Large5 large { get; set; }
        public Original5 original { get; set; }
        public Largest5 largest { get; set; }
        public Mw20005 mw2000 { get; set; }
        public Focus_Point5 focus_point { get; set; }
        public string object_id { get; set; }
        public string pic_id { get; set; }
        public int photo_tag { get; set; }
        public string type { get; set; }
        public int pic_status { get; set; }
    }

    public class Thumbnail5
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Bmiddle5
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Large5
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Original5
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Largest5
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Mw20005
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Focus_Point5
    {
        public float left { get; set; }
        public float top { get; set; }
        public float width { get; set; }
        public float height { get; set; }
    }

    public class _6Dd57921ly1hdbuhx1cmjj20k00ie75i
    {
        public Thumbnail6 thumbnail { get; set; }
        public Bmiddle6 bmiddle { get; set; }
        public Large6 large { get; set; }
        public Original6 original { get; set; }
        public Largest6 largest { get; set; }
        public Mw20006 mw2000 { get; set; }
        public Focus_Point6 focus_point { get; set; }
        public string object_id { get; set; }
        public string pic_id { get; set; }
        public int photo_tag { get; set; }
        public string type { get; set; }
        public int pic_status { get; set; }
    }

    public class Thumbnail6
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Bmiddle6
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Large6
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Original6
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Largest6
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Mw20006
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Focus_Point6
    {
        public float left { get; set; }
        public float top { get; set; }
        public float width { get; set; }
        public float height { get; set; }
    }

    public class _6Dd57921ly1hdbu6lt5uhj20n70xcwtk
    {
        public Thumbnail7 thumbnail { get; set; }
        public Bmiddle7 bmiddle { get; set; }
        public Large7 large { get; set; }
        public Original7 original { get; set; }
        public Largest7 largest { get; set; }
        public Mw20007 mw2000 { get; set; }
        public Focus_Point7 focus_point { get; set; }
        public string object_id { get; set; }
        public string pic_id { get; set; }
        public int photo_tag { get; set; }
        public string type { get; set; }
        public int pic_status { get; set; }
    }

    public class Thumbnail7
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Bmiddle7
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Large7
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Original7
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Largest7
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Mw20007
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Focus_Point7
    {
        public float left { get; set; }
        public float top { get; set; }
        public float width { get; set; }
        public float height { get; set; }
    }

    public class _6Dd57921ly1hdbu6q7nz3j20n70xcwtj
    {
        public Thumbnail8 thumbnail { get; set; }
        public Bmiddle8 bmiddle { get; set; }
        public Large8 large { get; set; }
        public Original8 original { get; set; }
        public Largest8 largest { get; set; }
        public Mw20008 mw2000 { get; set; }
        public Focus_Point8 focus_point { get; set; }
        public string object_id { get; set; }
        public string pic_id { get; set; }
        public int photo_tag { get; set; }
        public string type { get; set; }
        public int pic_status { get; set; }
    }

    public class Thumbnail8
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Bmiddle8
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Large8
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Original8
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Largest8
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Mw20008
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Focus_Point8
    {
        public float left { get; set; }
        public float top { get; set; }
        public float width { get; set; }
        public float height { get; set; }
    }

    public class _6Dd57921ly1hdbu7ibig3j20jq0sgdva
    {
        public Thumbnail9 thumbnail { get; set; }
        public Bmiddle9 bmiddle { get; set; }
        public Large9 large { get; set; }
        public Original9 original { get; set; }
        public Largest9 largest { get; set; }
        public Mw20009 mw2000 { get; set; }
        public Focus_Point9 focus_point { get; set; }
        public string object_id { get; set; }
        public string pic_id { get; set; }
        public int photo_tag { get; set; }
        public string type { get; set; }
        public int pic_status { get; set; }
    }

    public class Thumbnail9
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Bmiddle9
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Large9
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Original9
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Largest9
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Mw20009
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Focus_Point9
    {
        public float left { get; set; }
        public float top { get; set; }
        public float width { get; set; }
        public float height { get; set; }
    }

    public class _6Dd57921ly1hdbu7cf7l6j20g10mxwki
    {
        public Thumbnail10 thumbnail { get; set; }
        public Bmiddle10 bmiddle { get; set; }
        public Large10 large { get; set; }
        public Original10 original { get; set; }
        public Largest10 largest { get; set; }
        public Mw200010 mw2000 { get; set; }
        public Focus_Point10 focus_point { get; set; }
        public string object_id { get; set; }
        public string pic_id { get; set; }
        public int photo_tag { get; set; }
        public string type { get; set; }
        public int pic_status { get; set; }
    }

    public class Thumbnail10
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Bmiddle10
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Large10
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Original10
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Largest10
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Mw200010
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Focus_Point10
    {
        public int left { get; set; }
        public float top { get; set; }
        public int width { get; set; }
        public float height { get; set; }
    }

    public class _6Dd57921ly1hdbtrv77rlj20yi1is44i
    {
        public Thumbnail11 thumbnail { get; set; }
        public Bmiddle11 bmiddle { get; set; }
        public Large11 large { get; set; }
        public Original11 original { get; set; }
        public Largest11 largest { get; set; }
        public Mw200011 mw2000 { get; set; }
        public Focus_Point11 focus_point { get; set; }
        public string object_id { get; set; }
        public string pic_id { get; set; }
        public int photo_tag { get; set; }
        public string type { get; set; }
        public int pic_status { get; set; }
    }

    public class Thumbnail11
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Bmiddle11
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Large11
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Original11
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Largest11
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Mw200011
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Focus_Point11
    {
        public float left { get; set; }
        public float top { get; set; }
        public float width { get; set; }
        public float height { get; set; }
    }

    public class _6Dd57921ly1hdbsij6ddhj20qo11oqfj
    {
        public Thumbnail12 thumbnail { get; set; }
        public Bmiddle12 bmiddle { get; set; }
        public Large12 large { get; set; }
        public Original12 original { get; set; }
        public Largest12 largest { get; set; }
        public Mw200012 mw2000 { get; set; }
        public Focus_Point12 focus_point { get; set; }
        public string object_id { get; set; }
        public string pic_id { get; set; }
        public int photo_tag { get; set; }
        public string type { get; set; }
        public int pic_status { get; set; }
    }

    public class Thumbnail12
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Bmiddle12
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Large12
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Original12
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Largest12
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Mw200012
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Focus_Point12
    {
        public float left { get; set; }
        public float top { get; set; }
        public float width { get; set; }
        public float height { get; set; }
    }

    public class _6Dd57921ly1hdbsimvu60j20qo11o4bb
    {
        public Thumbnail13 thumbnail { get; set; }
        public Bmiddle13 bmiddle { get; set; }
        public Large13 large { get; set; }
        public Original13 original { get; set; }
        public Largest13 largest { get; set; }
        public Mw200013 mw2000 { get; set; }
        public Focus_Point13 focus_point { get; set; }
        public string object_id { get; set; }
        public string pic_id { get; set; }
        public int photo_tag { get; set; }
        public string type { get; set; }
        public int pic_status { get; set; }
    }

    public class Thumbnail13
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Bmiddle13
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Large13
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Original13
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Largest13
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Mw200013
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Focus_Point13
    {
        public float left { get; set; }
        public float top { get; set; }
        public float width { get; set; }
        public float height { get; set; }
    }

    public class _6Dd57921ly1hdbr5h9z3qj20cc0e43z8
    {
        public Thumbnail14 thumbnail { get; set; }
        public Bmiddle14 bmiddle { get; set; }
        public Large14 large { get; set; }
        public Original14 original { get; set; }
        public Largest14 largest { get; set; }
        public Mw200014 mw2000 { get; set; }
        public Focus_Point14 focus_point { get; set; }
        public string object_id { get; set; }
        public string pic_id { get; set; }
        public int photo_tag { get; set; }
        public string type { get; set; }
        public int pic_status { get; set; }
    }

    public class Thumbnail14
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Bmiddle14
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Large14
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Original14
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Largest14
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Mw200014
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Focus_Point14
    {
        public float left { get; set; }
        public float top { get; set; }
        public float width { get; set; }
        public float height { get; set; }
    }

    public class _6Dd57921ly1hdbquorf3jj20k00xv0wh
    {
        public Thumbnail15 thumbnail { get; set; }
        public Bmiddle15 bmiddle { get; set; }
        public Large15 large { get; set; }
        public Original15 original { get; set; }
        public Largest15 largest { get; set; }
        public Mw200015 mw2000 { get; set; }
        public Focus_Point15 focus_point { get; set; }
        public string object_id { get; set; }
        public string pic_id { get; set; }
        public int photo_tag { get; set; }
        public string type { get; set; }
        public int pic_status { get; set; }
    }

    public class Thumbnail15
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Bmiddle15
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Large15
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Original15
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Largest15
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Mw200015
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Focus_Point15
    {
        public float left { get; set; }
        public float top { get; set; }
        public float width { get; set; }
        public float height { get; set; }
    }

    public class _6Dd57921ly1hdbqur4et4j20qo1bfguj
    {
        public Thumbnail16 thumbnail { get; set; }
        public Bmiddle16 bmiddle { get; set; }
        public Large16 large { get; set; }
        public Original16 original { get; set; }
        public Largest16 largest { get; set; }
        public Mw200016 mw2000 { get; set; }
        public Focus_Point16 focus_point { get; set; }
        public string object_id { get; set; }
        public string pic_id { get; set; }
        public int photo_tag { get; set; }
        public string type { get; set; }
        public int pic_status { get; set; }
    }

    public class Thumbnail16
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Bmiddle16
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Large16
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Original16
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Largest16
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Mw200016
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Focus_Point16
    {
        public int left { get; set; }
        public float top { get; set; }
        public int width { get; set; }
        public float height { get; set; }
    }

    public class _6Dd57921ly1hdbqgtgb3uj21ah1cdhdt
    {
        public Thumbnail17 thumbnail { get; set; }
        public Bmiddle17 bmiddle { get; set; }
        public Large17 large { get; set; }
        public Original17 original { get; set; }
        public Largest17 largest { get; set; }
        public Mw200017 mw2000 { get; set; }
        public Focus_Point17 focus_point { get; set; }
        public string object_id { get; set; }
        public string pic_id { get; set; }
        public int photo_tag { get; set; }
        public string type { get; set; }
        public int pic_status { get; set; }
    }

    public class Thumbnail17
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Bmiddle17
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Large17
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Original17
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Largest17
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Mw200017
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Focus_Point17
    {
        public int left { get; set; }
        public int top { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class _6Dd57921ly1hdbqaqp7guj20u00c574u
    {
        public Thumbnail18 thumbnail { get; set; }
        public Bmiddle18 bmiddle { get; set; }
        public Large18 large { get; set; }
        public Original18 original { get; set; }
        public Largest18 largest { get; set; }
        public Mw200018 mw2000 { get; set; }
        public Focus_Point18 focus_point { get; set; }
        public string object_id { get; set; }
        public string pic_id { get; set; }
        public int photo_tag { get; set; }
        public string type { get; set; }
        public int pic_status { get; set; }
    }

    public class Thumbnail18
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Bmiddle18
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Large18
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Original18
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Largest18
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Mw200018
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Focus_Point18
    {
        public float left { get; set; }
        public float top { get; set; }
        public float width { get; set; }
        public float height { get; set; }
    }

    public class _6Dd57921ly1hdbosg4wlhj20go0o0t9k
    {
        public Thumbnail19 thumbnail { get; set; }
        public Bmiddle19 bmiddle { get; set; }
        public Large19 large { get; set; }
        public Original19 original { get; set; }
        public Largest19 largest { get; set; }
        public Mw200019 mw2000 { get; set; }
        public Focus_Point19 focus_point { get; set; }
        public string object_id { get; set; }
        public string pic_id { get; set; }
        public int photo_tag { get; set; }
        public string type { get; set; }
        public int pic_status { get; set; }
    }

    public class Thumbnail19
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Bmiddle19
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Large19
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Original19
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Largest19
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Mw200019
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Focus_Point19
    {
        public float left { get; set; }
        public float top { get; set; }
        public float width { get; set; }
        public float height { get; set; }
    }

    public class _6Dd57921ly1hdbo8c8rvfj20n016qtd8
    {
        public Thumbnail20 thumbnail { get; set; }
        public Bmiddle20 bmiddle { get; set; }
        public Large20 large { get; set; }
        public Original20 original { get; set; }
        public Largest20 largest { get; set; }
        public Mw200020 mw2000 { get; set; }
        public Focus_Point20 focus_point { get; set; }
        public string object_id { get; set; }
        public string pic_id { get; set; }
        public int photo_tag { get; set; }
        public string type { get; set; }
        public int pic_status { get; set; }
    }

    public class Thumbnail20
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Bmiddle20
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Large20
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Original20
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Largest20
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Mw200020
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Focus_Point20
    {
        public float left { get; set; }
        public float top { get; set; }
        public float width { get; set; }
        public float height { get; set; }
    }

    public class _6Dd57921ly1hdbofaj37ej20n0159wmn
    {
        public Thumbnail21 thumbnail { get; set; }
        public Bmiddle21 bmiddle { get; set; }
        public Large21 large { get; set; }
        public Original21 original { get; set; }
        public Largest21 largest { get; set; }
        public Mw200021 mw2000 { get; set; }
        public string object_id { get; set; }
        public string pic_id { get; set; }
        public int photo_tag { get; set; }
        public string type { get; set; }
        public int pic_status { get; set; }
    }

    public class Thumbnail21
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Bmiddle21
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Large21
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Original21
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Largest21
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Mw200021
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class _6Dd57921ly1hdb984ccnzj20o20sh1ce
    {
        public Thumbnail22 thumbnail { get; set; }
        public Bmiddle22 bmiddle { get; set; }
        public Large22 large { get; set; }
        public Original22 original { get; set; }
        public Largest22 largest { get; set; }
        public Mw200022 mw2000 { get; set; }
        public Focus_Point21 focus_point { get; set; }
        public string object_id { get; set; }
        public string pic_id { get; set; }
        public int photo_tag { get; set; }
        public string type { get; set; }
        public int pic_status { get; set; }
    }

    public class Thumbnail22
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Bmiddle22
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Large22
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Original22
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Largest22
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Mw200022
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Focus_Point21
    {
        public float left { get; set; }
        public float top { get; set; }
        public float width { get; set; }
        public float height { get; set; }
    }

    public class _6Dd57921ly1hdb77v0oj5j228s35s7wi
    {
        public Thumbnail23 thumbnail { get; set; }
        public Bmiddle23 bmiddle { get; set; }
        public Large23 large { get; set; }
        public Original23 original { get; set; }
        public Largest23 largest { get; set; }
        public Mw200023 mw2000 { get; set; }
        public Focus_Point22 focus_point { get; set; }
        public string object_id { get; set; }
        public string pic_id { get; set; }
        public int photo_tag { get; set; }
        public string type { get; set; }
        public int pic_status { get; set; }
    }

    public class Thumbnail23
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Bmiddle23
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Large23
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Original23
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Largest23
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Mw200023
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Focus_Point22
    {
        public float left { get; set; }
        public float top { get; set; }
        public float width { get; set; }
        public float height { get; set; }
    }

    public class _6Dd57921ly1hdb5288o9cg207u09n0ur
    {
        public Thumbnail24 thumbnail { get; set; }
        public Bmiddle24 bmiddle { get; set; }
        public Large24 large { get; set; }
        public Original24 original { get; set; }
        public Largest24 largest { get; set; }
        public Mw200024 mw2000 { get; set; }
        public string object_id { get; set; }
        public string pic_id { get; set; }
        public int photo_tag { get; set; }
        public string type { get; set; }
        public string video_object_id { get; set; }
        public string video { get; set; }
        public int pic_status { get; set; }
    }

    public class Thumbnail24
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Bmiddle24
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Large24
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Original24
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Largest24
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Mw200024
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
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
        public Pic_Infos1 pic_infos { get; set; }
        public bool is_paid { get; set; }
        public int mblog_vip_type { get; set; }
        public Number_Display_Strategy1 number_display_strategy { get; set; }
        public int reposts_count { get; set; }
        public int comments_count { get; set; }
        public int attitudes_count { get; set; }
        public int attitudes_status { get; set; }
        public bool isLongText { get; set; }
        public int mlevel { get; set; }
        public int content_auth { get; set; }
        public int is_show_bulletin { get; set; }
        public Comment_Manage_Info1 comment_manage_info { get; set; }
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

    public class Pic_Infos1
    {
        public _6Dd57921ly1hdanw53tw9j20j60rtah2 _6dd57921ly1hdanw53tw9j20j60rtah2 { get; set; }
        public _6Dd57921ly1hdanvz17jbj20o01hcgqx _6dd57921ly1hdanvz17jbj20o01hcgqx { get; set; }
        public _6Dd57921ly1hd4bwsv8nmj20v418gkjl _6dd57921ly1hd4bwsv8nmj20v418gkjl { get; set; }
    }

    public class _6Dd57921ly1hdanw53tw9j20j60rtah2
    {
        public Thumbnail25 thumbnail { get; set; }
        public Bmiddle25 bmiddle { get; set; }
        public Large25 large { get; set; }
        public Original25 original { get; set; }
        public Largest25 largest { get; set; }
        public Mw200025 mw2000 { get; set; }
        public Focus_Point23 focus_point { get; set; }
        public string object_id { get; set; }
        public string pic_id { get; set; }
        public int photo_tag { get; set; }
        public string type { get; set; }
        public int pic_status { get; set; }
    }

    public class Thumbnail25
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Bmiddle25
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Large25
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Original25
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Largest25
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Mw200025
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Focus_Point23
    {
        public float left { get; set; }
        public float top { get; set; }
        public float width { get; set; }
        public float height { get; set; }
    }

    public class _6Dd57921ly1hdanvz17jbj20o01hcgqx
    {
        public Thumbnail26 thumbnail { get; set; }
        public Bmiddle26 bmiddle { get; set; }
        public Large26 large { get; set; }
        public Original26 original { get; set; }
        public Largest26 largest { get; set; }
        public Mw200026 mw2000 { get; set; }
        public Focus_Point24 focus_point { get; set; }
        public string object_id { get; set; }
        public string pic_id { get; set; }
        public int photo_tag { get; set; }
        public string type { get; set; }
        public int pic_status { get; set; }
    }

    public class Thumbnail26
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Bmiddle26
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Large26
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Original26
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Largest26
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Mw200026
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Focus_Point24
    {
        public float left { get; set; }
        public float top { get; set; }
        public float width { get; set; }
        public float height { get; set; }
    }

    public class _6Dd57921ly1hd4bwsv8nmj20v418gkjl
    {
        public Thumbnail27 thumbnail { get; set; }
        public Bmiddle27 bmiddle { get; set; }
        public Large27 large { get; set; }
        public Original27 original { get; set; }
        public Largest27 largest { get; set; }
        public Mw200027 mw2000 { get; set; }
        public Focus_Point25 focus_point { get; set; }
        public string object_id { get; set; }
        public string pic_id { get; set; }
        public int photo_tag { get; set; }
        public string type { get; set; }
        public int pic_status { get; set; }
    }

    public class Thumbnail27
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Bmiddle27
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Large27
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Original27
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Largest27
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Mw200027
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int cut_type { get; set; }
        public string type { get; set; }
    }

    public class Focus_Point25
    {
        public float left { get; set; }
        public float top { get; set; }
        public float width { get; set; }
        public float height { get; set; }
    }

    public class Number_Display_Strategy1
    {
        public int apply_scenario_flag { get; set; }
        public int display_text_min_number { get; set; }
        public string display_text { get; set; }
    }

    public class Comment_Manage_Info1
    {
        public int comment_permission_type { get; set; }
        public int approval_comment_type { get; set; }
        public int comment_sort_type { get; set; }
        public int ai_play_picture_type { get; set; }
    }

    public class Pic_Focus_Point
    {
        public Focus_Point26 focus_point { get; set; }
        public string pic_id { get; set; }
    }

    public class Focus_Point26
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
