using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapchatHelper.JSONObjects.loq
{
    public class UpdatesResponse
    {
        public static bool enable_video_transcoding_android { get; set; }

        public static int score { get; set; }

        public static bool enable_save_story_to_gallery { get; set; }

        public static int number_of_best_friends { get; set; }

        public static int received { get; set; }

        [JsonProperty("logged")]
        public static bool Logged { get; set; }

        public static List<string> seen_tooltips { get; set; }

        public static List<object> requests { get; set; }

        public static string username { get; set; }

        public static string story_privacy { get; set; }

        public static int sent { get; set; }

        public static string device_token { get; set; }

        public static string cash_customer_id { get; set; }

        public static FeatureSettings feature_settings { get; set; }

        public static string user_id { get; set; }

        public static int snap_p { get; set; }

        public static string mobile_verification_key { get; set; }

        public static bool video_filters_enabled { get; set; }

        public static List<object> recents { get; set; }

        public static string notification_sound_setting { get; set; }

        public static long added_friends_timestamp { get; set; }

        public static string allowed_to_use_cash { get; set; }

        public static bool is_cash_active { get; set; }

        public static bool searchable_by_phone_number { get; set; }

        public static ClientProperties client_properties { get; set; }

        public static string snapchat_phone_number { get; set; }

        public static string auth_token { get; set; }

        public static bool image_caption { get; set; }

        public static string country_code { get; set; }

        public static long last_address_book_updated_date { get; set; }

        public static bool blocked_from_using_our_story { get; set; }

        public static string qr_path { get; set; }

        public static string cash_provider { get; set; }

        public static long current_timestamp { get; set; }

        public static bool can_view_mature_content { get; set; }

        public static string email { get; set; }

        public static int contacts_resync_request { get; set; }

        public static bool should_send_text_to_verify_number { get; set; }

        public static string temp { get; set; }

        public static bool should_call_to_verify_number { get; set; }

        public static string mobile { get; set; }
    }
}
