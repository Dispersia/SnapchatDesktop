using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapchatHelper.JSONObjects.loq
{
    public class StoriesResponse
    {
        public static MatureContentText mature_content_text { get; set; }
        public static List<object> my_stories { get; set; }
        public static bool friend_stories_delta { get; set; }
        public static List<FriendStory> friend_stories { get; set; }
        public static List<object> my_group_stories { get; set; }
    }
}
