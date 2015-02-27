using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapchatDesktop.SnapchatHelper.JSONObjects
{
    internal class ChatMessage
    {
        public Body body { get; set; }
        public string chat_message_id { get; set; }
        public SavedState saved_state { get; set; }
        public int seq_num { get; set; }
        public object timestamp { get; set; }
        public Header header { get; set; }
        public string type { get; set; }
        public string id { get; set; }
    }
}
