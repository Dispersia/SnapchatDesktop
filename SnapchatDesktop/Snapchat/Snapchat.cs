using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace SnapchatDesktop.Snapchat
{
    class Snapchat
    {
        public Snapchat()
        {
            var resultObjects = AllChildren(JObject.Parse(Client.ResponseString))
            .First(c => c.Type == JTokenType.Array && c.Path.Contains("friends"))
            .Children<JObject>();

            foreach (JObject result in resultObjects)
            {
                FriendsList.Add(JsonConvert.DeserializeObject<Friend>(result.ToString()));
            }
        }

        [InternalName("enable_video_transcoding_android")]
        public bool enableVideoTranscodingAndroid { get; set; }

        [InternalName("score")]
        public int Score { get; set; }

        [InternalName("enable_save_story_to_gallery")]
        public bool enableSaveStoryToGallery { get; set; }

        [InternalName("number_of_best_friends")]
        public int numOfBestFriends { get; set; }

        [InternalName("received")]
        public int Received { get; set; }

        [InternalName("logged")]
        public bool Logged { get; set; }

        [InternalName("friends")]
        public List<Friend> FriendsList { get; set; } = new List<Friend>();

        [InternalName("requests")]
        public object[] requests;

        [InternalName("username")]
        public string Username { get; set; }

        [InternalName("story_privacy")]
        public string StoryPrivacy { get; set; }

        [InternalName("sent")]
        public int Sent { get; set; }

        [InternalName("snaps")]
        public Snap[] Snaps { get; set; }

        [InternalName("device_token")]
        public string DeviceToken { get; set; }

        [InternalName("cash_customer_id")]
        public string CashCustomerId { get; set; }

        [InternalName("user_id")]
        public string UserId { get; set; }

        [InternalName("snap_p")]
        public int SnapP { get; set; }

        [InternalName("mobile_verification_key")]
        public string MobileVerificationKey { get; set; }

        [InternalName("video_filters_enabled")]
        public bool VideoFiltersEnabled { get; set; }

        [InternalName("recents")]
        public object[] recents { get; set; }

        [InternalName("notification_sound_setting")]
        public string NotificationSoundSetting { get; set; }

        [InternalName("added_friends_timestamp")]
        public long AddedFriendsTimestamp { get; set; } //The fuck could this even mean?

        [InternalName("allowed_to_use_cash")]
        public string AllowedToUseCash { get; set; }

        [InternalName("is_cash_active")]
        public bool IsCashActive { get; set; } //How could this be true if AllowedToUseCash is off... and why are there two things for this...

        [InternalName("searchable_by_phone_number")]
        public bool SearchableByPhoneNumber { get; set; }

        [InternalName("snapchat_phone_number")]
        public string SnapchatPhoneNumber { get; set; }

        [InternalName("auth_token")]
        public string AuthToken { get; set; }

        [InternalName("image_caption")]
        public bool ImageCaption { get; set; }

        [InternalName("country_code")]
        public string CountryCode { get; set; }

        [InternalName("blocked_from_using_our_story")]
        public bool BlockedFromUsingOurStory { get; set; }

        [InternalName("qr_path")]
        public string QrPath { get; set; }

        [InternalName("cash_provider")]
        public string CashProvider { get; set; }

        [InternalName("current_timestamp")]
        public long CurrentTimestamp { get; set; }

        [InternalName("can_view_mature_content")]
        public bool CanViewMatureContent { get; set; }

        [InternalName("email")]
        public string Email { get; set; }

        [InternalName("contacts_resync_request")]
        public int ContactsResyncRequest { get; set; }

        [InternalName("should_send_text_to_verify_number")]
        public bool ShouldSendTextToVerifyNumber { get; set; } //Why is this sent every request...

        [InternalName("temp")]
        public string Temp { get; set; } //THIS LITERALLY JUST PASSES "TEMP" EVERYWEHRETE LOLOLOLOL

        [InternalName("should_call_to_verify_number")]
        public bool ShouldCallToVerifyNumber { get; set; }

        [InternalName("mobile")]
        public string MobileNumber { get; set; }


        private IEnumerable<JToken> AllChildren(JToken json)
        {
            foreach (var c in json.Children())
            {
                yield return c;
                foreach (var cc in AllChildren(c))
                {
                    yield return cc;
                }
            }
        }
    }

    public class InternalNameAttribute : Attribute
    {
        public string Name { get; set; }
        public InternalNameAttribute(string name)
        {
            Name = name;
        }
    }
}
