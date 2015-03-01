using Newtonsoft.Json;

namespace SnapchatHelper.JSONObjects.bq
{
    public class AddedFriend
    {
        [JsonProperty("ts")]
        public object Timestamp { get; set; }

        [JsonProperty("direction")]
        public string Direction { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }
    }
}
