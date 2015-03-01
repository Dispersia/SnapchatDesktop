using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapchatHelper.JSONObjects.loq
{
    public class Friend
    {
        [JsonProperty("can_see_custom_stories")]
        public bool canSeeCustomStories { get; set; }

        [JsonProperty("direction")]
        public string Direction { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("expiration")]
        public long? Expiration { get; set; }

        [JsonProperty("dont_decay_thumbnail")]
        public bool? dontDecayThumbnail { get; set; }

        [JsonProperty("shared_story_id")]
        public string sharedStoryId { get; set; }

        [JsonProperty("is_shared_story")]
        public bool? isSharedStory { get; set; }

        [JsonProperty("has_custom_description")]
        public bool? hasCustomDescription { get; set; }

        [JsonProperty("venue")]
        public string Venue { get; set; }
    }
}
