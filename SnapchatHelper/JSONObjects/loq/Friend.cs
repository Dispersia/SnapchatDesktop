using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapchatHelper.JSONObjects.loq
{
    public class Friend
    {
        public static bool can_see_custom_stories { get; set; }
        public static string direction { get; set; }
        public static string name { get; set; }
        public static string display { get; set; }
        public static int type { get; set; }
        public static long? expiration { get; set; }
        public static bool? dont_decay_thumbnail { get; set; }
        public static string shared_story_id { get; set; }
        public static bool? is_shared_story { get; set; }
        public static bool? has_custom_description { get; set; }
        public static string venue { get; set; }
    }
}
