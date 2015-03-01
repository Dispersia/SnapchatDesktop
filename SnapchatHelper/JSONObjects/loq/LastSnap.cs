using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapchatHelper.JSONObjects.loq
{
    public class LastSnap
    {
        public static string sn { get; set; }
        public static int broadcast { get; set; }
        public static string broadcast_media_url { get; set; }
        public static bool broadcast_hide_timer { get; set; }
        public static string id { get; set; }
        public static int st { get; set; }
        public static int m { get; set; }
        public static long ts { get; set; }
        public static long sts { get; set; }
    }
}
