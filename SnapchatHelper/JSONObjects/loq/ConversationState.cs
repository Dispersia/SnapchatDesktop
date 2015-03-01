using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapchatHelper.JSONObjects.loq
{
    public class ConversationState
    {
        public static UserSequences user_sequences { get; set; }
        public static UserChatReleases user_chat_releases { get; set; }
        public static UserSnapReleases user_snap_releases { get; set; }
    }
}
