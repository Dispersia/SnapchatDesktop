using SnapchatDesktop.Snapchat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapchatDesktop.SnapchatHelper.JSONObjects
{
    internal class FriendsResponse
    {
        public List<object> bests { get; set; }
        public List<Friend> friends { get; set; }
        public List<AddedFriend> added_friends { get; set; }
    }
}
