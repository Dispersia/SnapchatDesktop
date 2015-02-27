namespace SnapchatDesktop.Snapchat
{
    class Friend
    {
        public bool can_see_custom_stories { get; set; }
        public string direction { get; set; }
        public string name { get; set; }
        public string display { get; set; }
        public int type { get; set; }
        public long? expiration { get; set; }
        public bool? dont_decay_thumbnail { get; set; }
        public string shared_story_id { get; set; }
        public bool? is_shared_story { get; set; }
        public bool? has_custom_description { get; set; }
        public string venue { get; set; }
    }
}
