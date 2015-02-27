using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapchatDesktop.SnapchatHelper.JSONObjects
{
    internal class ConversationsResponse
    {
        public List<string> participants { get; set; }
        public long last_interaction_ts { get; set; }
        public List<string> pending_chats_for { get; set; }
        public List<object> pending_received_snaps { get; set; }
        public string iter_token { get; set; }
        public string id { get; set; }
        public ConversationMessages conversation_messages { get; set; }
        public ConversationState conversation_state { get; set; }
        public LastSnap last_snap { get; set; }
        public LastChatActions last_chat_actions { get; set; }
    }
}
