using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapchatHelper.JSONObjects.loq
{
    public class Body
    {
        public static string type { get; set; }
        public static string text { get; set; }
        public static List<Attribute> attributes { get; set; }
    }
}
