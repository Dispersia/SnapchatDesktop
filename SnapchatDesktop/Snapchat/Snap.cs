using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapchatDesktop.Snapchat
{
    class Snap
    {
        public string Username { get; set; }
        public double TimerLength { get; set; }
        public long TS { get; set; }
        public long STS { get; set; }

        public Snap(string sn, int t, double timer, string id, int st, int m, long ts, long sts)
        {
            Username = sn;
            TimerLength = timer;
            TS = ts;
            STS = sts;
        }
    }
}
