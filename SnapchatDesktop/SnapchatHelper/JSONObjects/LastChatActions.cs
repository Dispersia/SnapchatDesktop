using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapchatDesktop.SnapchatHelper.JSONObjects
{
    internal class LastChatActions
    {
        public string last_reader { get; set; }
        public long last_read_timestamp { get; set; }
        public string last_writer { get; set; }
        public long last_write_timestamp { get; set; }
        public string last_write_type { get; set; }
    }
}
