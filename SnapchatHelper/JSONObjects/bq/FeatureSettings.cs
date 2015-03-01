using Newtonsoft.Json;

namespace SnapchatHelper.JSONObjects.bq
{
    public class FeatureSettings
    {
        [JsonProperty("front_facing_flash")]
        public bool frontFacingFlash { get; set; }

        [JsonProperty("replay_snaps")]
        public bool replaySnaps { get; set; }

        [JsonProperty("special_text")]
        public bool specialText { get; set; }

        [JsonProperty("visual_filters")]
        public bool visualFilters { get; set; }

        [JsonProperty("smart_filters")]
        public bool smartFilters { get; set; }

        [JsonProperty("power_save_mode")]
        public bool powerSaveMode { get; set; }

        [JsonProperty("swipe_cash_mode")]
        public bool swipeCashMode { get; set; }
    }
}
