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
        public object ts { get; set; }
        public string direction { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
        public int type { get; set; }
    }
}
