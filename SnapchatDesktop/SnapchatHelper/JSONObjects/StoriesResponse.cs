using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapchatDesktop.SnapchatHelper.JSONObjects
{
    internal class StoriesResponse
    {
        public MatureContentText mature_content_text { get; set; }
        public List<object> my_stories { get; set; }
        public bool friend_stories_delta { get; set; }
        public List<FriendStory> friend_stories { get; set; }
        public List<object> my_group_stories { get; set; }
    }
}
