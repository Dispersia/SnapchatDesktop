using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapchatDesktop.Snapchat
{
    class Friend
    {
        [InternalName("can_see_custom_stories")]
        public string CanSeeCustomStories { get; set; }

        [InternalName("direction")]
        public string Direction { get; set; }

        [InternalName("name")]
        public string Name { get; set; }

        [InternalName("display")]
        public string Display { get; set; }

        [InternalName("type")]
        public int Type { get; set; } //Type 2 is blocked, Type 0 is added, no idea what 1 is, yet to encounter it.
    }
}
