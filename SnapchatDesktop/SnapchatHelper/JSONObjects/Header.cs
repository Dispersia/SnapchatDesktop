using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapchatDesktop.SnapchatHelper.JSONObjects
{
    internal class Header
    {
        public string from { get; set; }
        public List<string> to { get; set; }
        public string conv_id { get; set; }
    }
}
