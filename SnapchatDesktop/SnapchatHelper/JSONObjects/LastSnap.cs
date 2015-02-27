using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapchatDesktop.SnapchatHelper.JSONObjects
{
    internal class LastSnap
    {
        public string sn { get; set; }
        public int broadcast { get; set; }
        public string broadcast_media_url { get; set; }
        public bool broadcast_hide_timer { get; set; }
        public string id { get; set; }
        public int st { get; set; }
        public int m { get; set; }
        public long ts { get; set; }
        public long sts { get; set; }
    }
}
