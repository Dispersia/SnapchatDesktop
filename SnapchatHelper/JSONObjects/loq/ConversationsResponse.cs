using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapchatHelper.JSONObjects.loq
{
    public class ConversationsResponse
    {
        public static List<string> participants { get; set; }
        public static long last_interaction_ts { get; set; }
        public static List<string> pending_chats_for { get; set; }
        public static List<object> pending_received_snaps { get; set; }
        public static string iter_token { get; set; }
        public static string id { get; set; }
        public static ConversationMessages conversation_messages { get; set; }
        public static ConversationState conversation_state { get; set; }
        public static LastSnap last_snap { get; set; }
        public static LastChatActions last_chat_actions { get; set; }
    }
}
