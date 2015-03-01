using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapchatHelper.JSONObjects.loq
{
    public class Story2
    {
        public static string id { get; set; }
        public static string username { get; set; }
        public static bool mature_content { get; set; }
        public static string client_id { get; set; }
        public static object timestamp { get; set; }
        public static string media_id { get; set; }
        public static string media_key { get; set; }
        public static string media_iv { get; set; }
        public static string thumbnail_iv { get; set; }
        public static int media_type { get; set; }
        public static double time { get; set; }
        public static bool zipped { get; set; }
        public static bool is_shared { get; set; }
        public static int time_left { get; set; }
        public static string media_url { get; set; }
        public static string thumbnail_url { get; set; }
        public static string caption_text_display { get; set; }
    }
}
