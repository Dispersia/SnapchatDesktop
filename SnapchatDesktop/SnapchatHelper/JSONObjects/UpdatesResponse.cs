using Newtonsoft.Json;
using SnapchatDesktop.Snapchat;
using SnapchatDesktop.SnapchatHelper;
using SnapchatDesktop.SnapchatHelper.JSONObjects;
using System.Collections.Generic;

namespace SnapchatDesktop
{
    internal class UpdatesResponse
    {
        public bool enable_video_transcoding_android { get; set; }

        public int score { get; set; }

        public bool enable_save_story_to_gallery { get; set; }

        public int number_of_best_friends { get; set; }

        public int received { get; set; }

        [JsonProperty("logged")]
        public bool Logged { get; set; }

        public List<string> seen_tooltips { get; set; }

        public List<object> requests { get; set; }

        public string username { get; set; }

        public string story_privacy { get; set; }

        public int sent { get; set; }

        public string device_token { get; set; }

        public string cash_customer_id { get; set; }

        public FeatureSettings feature_settings { get; set; }

        public string user_id { get; set; }

        public int snap_p { get; set; }

        public string mobile_verification_key { get; set; }

        public bool video_filters_enabled { get; set; }

        public List<object> recents { get; set; }

        public string notification_sound_setting { get; set; }

        public long added_friends_timestamp { get; set; }

        public string allowed_to_use_cash { get; set; }

        public bool is_cash_active { get; set; }

        public bool searchable_by_phone_number { get; set; }

        public ClientProperties client_properties { get; set; }

        public string snapchat_phone_number { get; set; }

        public string auth_token { get; set; }

        public bool image_caption { get; set; }

        public string country_code { get; set; }

        public long last_address_book_updated_date { get; set; }

        public bool blocked_from_using_our_story { get; set; }

        public string qr_path { get; set; }

        public string cash_provider { get; set; }

        public long current_timestamp { get; set; }

        public bool can_view_mature_content { get; set; }

        public string email { get; set; }

        public int contacts_resync_request { get; set; }

        public bool should_send_text_to_verify_number { get; set; }

        public string temp { get; set; }

        public bool should_call_to_verify_number { get; set; }

        public string mobile { get; set; }
    }
}