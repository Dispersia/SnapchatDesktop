using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapchatDesktop.Snapchat
{
    class Snapchat
    {[]
        public bool enableVideoTranscodingAndroid { get; set; }
        public int Score { get; set; }
        public bool enableSaveStoryToGallery { get; set; }
        public int numOfBestFriends { get; set; }
        public int Received { get; set; }
        public bool Logged { get; set; }
        public List<Friend> friendsList { get; set; } = new List<Friend>();

        public object[] requests;
        public string Username { get; set; }
        public string StoryPrivacy { get; set; }
        public int Sent { get; set; }
        public Snap[] Snaps { get; set; }
        public string DeviceToken { get; set; }
        public string CashCustomerId { get; set; }
        public string UserId { get; set; }
        public int SnapP { get; set; }
        public string MobileVerificationKey { get; set; }
        public bool VideoFiltersEnabled { get; set; }
        public object[] recents { get; set; }
        public string NotificationSoundSetting { get; set; }
        public long AddedFriendsTimestamp { get; set; } //The fuck could this even mean?
        public string AllowedToUseCash { get; set; } 
        public bool IsCashActive { get; set; } //How could this be true if AllowedToUseCash is off... and why are there two things for this...
        public bool SearchableByPhoneNumber { get; set; }
        public string SnapchatPhoneNumber { get; set; }
        public string AuthToken { get; set; }
        public bool ImageCaption { get; set; }
        public string CountryCode { get; set; }
        public bool BlockedFromUsingOurStory { get; set; }
        public string QrPath { get; set; }
        public string CashProvider { get; set; }
        public long CurrentTimestamp { get; set; }
        public bool CanViewMatureContent { get; set; }
        public string Email { get; set; }
        public int ContactsResyncRequest { get; set; }
        public bool ShouldSendTextToVerifyNumber { get; set; } //Why is this sent every request...
        public string Temp { get; set; } //THIS IS LITERALLY JUST PASSES TEMP EVERYWEHRETE LOLOLOLOL
        public bool ShouldCallToVerifyNumber { get; set; }
        public string MobileNumber { get; set; }
    }
}
