using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapchatDesktop.Snapchat
{
    class Friend
    {
        public long Id { get; set; }
        public string Direction { get; set; }
        public string Name { get; set; }
        public string Display { get; set; }
        public int Type { get; set; } //Type 2 is blocked, Type 0 is added 

        public Friend(long ts, string direction, string name, string display, int type)
        {
            Id = ts;
            Direction = direction;
            Name = name;
            Display = display;
            Type = type;
        }
    }
}
