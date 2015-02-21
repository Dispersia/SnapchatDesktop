using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapchatDesktop.Snapchat
{
    class Snap
    {
        [InternalName("sn")]
        public string Username { get; set; }

        [InternalName("timer")]
        public double TimerLength { get; set; }

        [InternalName("ts")]
        public long TS { get; set; }

        [InternalName("sts")]
        public long STS { get; set; }

        [InternalName("id")]
        public string ID { get; set; }

        [InternalName("st")]
        public int ST { get; set; }

        [InternalName("m")]
        public int M { get; set; }
    }
}
