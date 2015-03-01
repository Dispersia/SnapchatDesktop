using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapchatHelper.JSONObjects.loq
{
    public class LastChatActions
    {
        public static string last_reader { get; set; }
        public static long last_read_timestamp { get; set; }
        public static string last_writer { get; set; }
        public static long last_write_timestamp { get; set; }
        public static string last_write_type { get; set; }
    }
}
