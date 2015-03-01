using Newtonsoft.Json;

namespace SnapchatHelper.JSONObjects.bq
{
    public class Snap
    {
        [JsonProperty("sn")]
        public string SnapSender { get; set; }

        [JsonProperty("t")]
        public int TTimer { get; set; }

        [JsonProperty("timer")]
        public long Timer { get; set; }

        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("st")]
        public int StateOfMedia { get; set; } // -1 = NONE, 0 = SENT, 1 = DELIVERED, 2 = VIEWED, 3 = SCREENSHOT

        [JsonProperty("m")]
        public int MediaType { get; set; } // 0 = IMAGE, 1 = VIDEO, 2 = VIDEO_NOAUDIO, 3 = FRIEND_REQUEST, 4 = FRIEND_REQUEST_IMAGE, 5 = FRIEND_REQUEST_VIDEO, 6 = FRIEND_REQUEST_VIDEO_NOAUDIO

        [JsonProperty("ts")]
        public long Timestamp { get; set; }

        [JsonProperty("sts")]
        public long SentTimestamp { get; set; }
    }
}
