using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapchatDesktop.SnapchatHelper.JSONObjects
{
    internal class FriendStory
    {
        public string username { get; set; }
        public List<Story> stories { get; set; }
        public bool mature_content { get; set; }
    }
}
