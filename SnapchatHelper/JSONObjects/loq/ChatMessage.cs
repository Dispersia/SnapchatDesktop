using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapchatHelper.JSONObjects.loq
{
    public class ChatMessage
    {
        public static Body body { get; set; }
        public static string chat_message_id { get; set; }
        public static SavedState saved_state { get; set; }
        public static int seq_num { get; set; }
        public static object timestamp { get; set; }
        public static Header header { get; set; }
        public static string type { get; set; }
        public static string id { get; set; }
    }
}
