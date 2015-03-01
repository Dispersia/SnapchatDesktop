using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapchatHelper.JSONObjects.loq
{
    public class FriendStory
    {
        public static string username { get; set; }
        public static List<Story> stories { get; set; }
        public static bool mature_content { get; set; }
    }
}
