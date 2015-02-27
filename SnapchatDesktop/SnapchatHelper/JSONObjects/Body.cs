using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapchatDesktop.SnapchatHelper.JSONObjects
{
    internal class Body
    {
        public string type { get; set; }
        public string text { get; set; }
        public List<Attribute> attributes { get; set; }
    }
}
