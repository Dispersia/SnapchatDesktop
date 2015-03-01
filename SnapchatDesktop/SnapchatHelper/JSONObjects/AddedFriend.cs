using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapchatDesktop.SnapchatHelper.JSONObjects
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
