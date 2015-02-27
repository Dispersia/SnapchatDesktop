using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapchatDesktop.SnapchatHelper.JSONObjects
{
    internal class ConversationMessages
    {
        public MessagingAuth messaging_auth { get; set; }
        public List<Message> messages { get; set; }
    }
}
