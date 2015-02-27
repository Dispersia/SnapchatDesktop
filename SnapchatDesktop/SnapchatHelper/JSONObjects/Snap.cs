using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapchatDesktop.SnapchatHelper.JSONObjects
{
    internal class Snap
    {
        public string id { get; set; }

        public int m { get; set; }
        public int st { get; set; }
        public long sts { get; set; }
        public long ts { get; set; }
        public bool zipped { get; set; }
    }
}
