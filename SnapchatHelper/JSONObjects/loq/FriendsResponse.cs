using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapchatHelper.JSONObjects.loq
{
    public class FriendsResponse
    {
        [JsonProperty("bests")]
        public List<object> Bests { get; set; }

        [JsonProperty("friends")]
        public List<Friend> Friends { get; set; }

        [JsonProperty("added_friends")]
        public List<AddedFriend> AddedFriends { get; set; }
    }
}
