using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapchatHelper.JSONObjects.loq
{
    public class FriendsResponse
    {
        public static List<object> bests { get; set; }
        public static List<Friend> friends { get; set; }
        public static List<AddedFriend> added_friends { get; set; }
    }
}
