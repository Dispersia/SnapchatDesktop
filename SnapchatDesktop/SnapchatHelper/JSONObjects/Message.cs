using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapchatDesktop.SnapchatHelper.JSONObjects
{
    internal class Message
    {
        public ChatMessage chat_message { get; set; }
        public string iter_token { get; set; }
    }
}
