using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapchatDesktop.SnapchatHelper.JSONObjects
{
    internal class AddedFriend
    {
        public object ts { get; set; }
        public string direction { get; set; }
        public string name { get; set; }
        public string display { get; set; }
        public int type { get; set; }
    }
}
