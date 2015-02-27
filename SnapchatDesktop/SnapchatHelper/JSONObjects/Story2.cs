using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapchatDesktop.SnapchatHelper.JSONObjects
{
    class Story2
    {
        public string id { get; set; }
        public string username { get; set; }
        public bool mature_content { get; set; }
        public string client_id { get; set; }
        public object timestamp { get; set; }
        public string media_id { get; set; }
        public string media_key { get; set; }
        public string media_iv { get; set; }
        public string thumbnail_iv { get; set; }
        public int media_type { get; set; }
        public double time { get; set; }
        public bool zipped { get; set; }
        public bool is_shared { get; set; }
        public int time_left { get; set; }
        public string media_url { get; set; }
        public string thumbnail_url { get; set; }
        public string caption_text_display { get; set; }
    }
}
