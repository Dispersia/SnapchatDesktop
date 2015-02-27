using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapchatDesktop.SnapchatHelper.JSONObjects
{
    internal class ConversationState
    {
        public UserSequences user_sequences { get; set; }
        public UserChatReleases user_chat_releases { get; set; }
        public UserSnapReleases user_snap_releases { get; set; }
    }
}
