using Newtonsoft.Json;
using SnapchatHelper.JSONObjects;
using SnapchatHelper.JSONObjects.bq;
using SnapchatHelper.JSONObjects.loq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SnapchatHelper
{
    public class Snapchat
    {
        #region bqproperties
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("enable_video_transcoding_android")]
        public bool enableVideoTranscodingAndroid { get; set; }

        [JsonProperty("bests")]
        public List<object> Bests { get; set; }

        [JsonProperty("score")]
        public int Score { get; set; }

        [JsonProperty("enable_save_story_to_gallery")]
        public bool enableSaveStoryToGallery { get; set; }

        [JsonProperty("number_of_best_friends")]
        public int numberOfBestFriends { get; set; }

        [JsonProperty("received")]
        public int Received { get; set; }

        [JsonProperty("logged")]
        public bool Logged { get; set; }

        [JsonProperty("added_friends")]
        public List<JSONObjects.bq.AddedFriend> FriendsList { get; set; }

        [JsonProperty("requests")]
        public List<object> Requests { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("story_privacy")]
        public string storyPrivacy { get; set; }

        [JsonProperty("sent")]
        public int Sent { get; set; }

        [JsonProperty("snaps")]
        public List<JSONObjects.bq.Snap> bqSnaps { get; set; }

        [JsonProperty("friends")]
        public List<JSONObjects.bq.Friend> bqFriends { get; set; }

        [JsonProperty("device_token")]
        public string deviceToken { get; set; }

        [JsonProperty("cash_customer_id")]
        public string cashCustomerId { get; set; }

        [JsonProperty("feature_settings")]
        public JSONObjects.bq.FeatureSettings bqFeatureSettings { get; set; }

        [JsonProperty("user_id")]
        public string userID { get; set; }

        [JsonProperty("snap_p")]
        public int snapP { get; set; }

        [JsonProperty("mobile_verification_key")]
        public string mobileVerificationKey { get; set; }

        [JsonProperty("video_filters_enabled")]
        public bool videoFiltersEnabled { get; set; }

        [JsonProperty("recents")]
        public List<object> Recents { get; set; }

        [JsonProperty("notification_sound_setting")]
        public string notificationSoundSetting { get; set; }

        [JsonProperty("added_friends_timestamp")]
        public long addedFriendsTimestamp { get; set; }

        [JsonProperty("allowed_to_use_cash")]
        public string allowedToUseCash { get; set; }

        [JsonProperty("is_cash_active")]
        public bool isCashActive { get; set; }

        [JsonProperty("searchable_by_phone_number")]
        public bool searchableByPhoneNumber { get; set; }

        [JsonProperty("snapchat_phone_number")]
        public string snapchatPhoneNumber { get; set; }

        [JsonProperty("auth_token")]
        public string authToken { get; set; }

        [JsonProperty("image_caption")]
        public bool imageCaption { get; set; }

        [JsonProperty("country_code")]
        public string countryCode { get; set; }

        [JsonProperty("blocked_from_using_our_story")]
        public bool blockedFromUsingOurStory { get; set; }

        [JsonProperty("qr_path")]
        public string qrPath { get; set; }

        [JsonProperty("cash_provider")]
        public string cashProvider { get; set; }

        [JsonProperty("current_timestamp")]
        public long currentTimestamp { get; set; }

        [JsonProperty("can_view_mature_content")]
        public bool canViewMatureContent { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("contacts_resync_request")]
        public int contactsResyncRequest { get; set; }

        [JsonProperty("should_send_text_to_verify_number")]
        public bool shouldSendTextToVerifyNumber { get; set; }

        [JsonProperty("temp")]
        public string Temp { get; set; }

        [JsonProperty("should_call_to_verify_number")]
        public bool shouldCallToVerifyNumber { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }
        #endregion

        #region loqproperties
        [JsonProperty("updates_response")]
        public UpdatesResponse UpdateResponse { get; set; } = new UpdatesResponse();

        [JsonProperty("friends_response")]
        public FriendsResponse friendsResponse { get; set; } = new FriendsResponse();

        [JsonProperty("stories_response")]
        public StoriesResponse storiesResponse { get; set; } = new StoriesResponse();

        [JsonProperty("conversations_response")]
        public List<ConversationsResponse> conversationsResponse { get; set; } = new List<ConversationsResponse>();

        [JsonProperty("discover")]
        public Discover discover { get; set; } = new Discover();

        [JsonProperty("get_channels_url")]
        public string getChannelsUrl { get; set; }

        [JsonProperty("messaging_gateway_info")]
        public MessagingGatewayInfo messagingGatewayInfo { get; set; } = new MessagingGatewayInfo();

        [JsonProperty("background_fetch_secret_key")]
        public string backgroundFetchSecretKey { get; set; }
        #endregion

        public static async Task<Snapchat> bqLogin(string username, string password)
        {
            var json = await bqCommands.Login(username, password);

            if (!string.IsNullOrEmpty(json))
            {
                return JsonConvert.DeserializeObject<Snapchat>(json);
            }
            else
            {
                Snapchat snapchat = new Snapchat()
                {
                    Message = "Failed.",
                    Logged = false
                };
                return snapchat;
            }
        }
    }
}
