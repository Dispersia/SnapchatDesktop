namespace SnapchatDesktop.Snapchat
{
    class Friend
    {
        [InternalName("can_see_custom_stories")]
        public string CanSeeCustomStories { get; set; }

        [InternalName("direction")]
        public string Direction { get; set; }

        [InternalName("name")]
        public string Name { get; set; }

        [InternalName("display")]
        public string Display { get; set; }

        [InternalName("type")]
        public int Type { get; set; } //Type 2 is blocked, Type 0 is added, Type 1 was on a story, so maybe someone who isn't a friend that shared a story that isn't blocked?

        [InternalName("expiration")]
        public long Expiration { get; set; }

        [InternalName("dont_decay_thumbnail")]
        public bool DontDecayThumbnail { get; set; }

        [InternalName("shared_story_id")]
        public string SharedStoryId { get; set; }

        [InternalName("is_shared_story")]
        public bool isSharedStory { get; set; }

        [InternalName("has_custom_description")]
        public bool HasCustomDescription { get; set; }

        [InternalName("venue")]
        public string Venue { get; set; }
    }
}
