using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapchatHelper.JSONObjects.loq
{
    public class ConversationMessages
    {
        public static MessagingAuth messaging_auth { get; set; }
        public static List<Message> messages { get; set; }
    }
}
