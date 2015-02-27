using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SnapchatDesktop.SnapchatHelper.JSONObjects;
using System;
using System.Collections.Generic;

namespace SnapchatDesktop.Snapchat
{
    class Snapchat
    {
        [JsonProperty("message")]
        public string Message { get; set; }

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


        /*public class Dispersia
        {
            public bool saved { get; set; }
            public int version { get; set; }
        }

        public class SavedState
        {
            public Dispersia dispersia { get; set; }
        }*/

        /*
        public class Dispersia2
        {
            public int teamsnapchat { get; set; }
        }*/
    }
}
