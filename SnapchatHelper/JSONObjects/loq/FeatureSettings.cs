using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapchatHelper.JSONObjects.loq
{
    public class FeatureSettings
    {
        public static bool front_facing_flash { get; set; }
        public static bool replay_snaps { get; set; }
        public static bool special_text { get; set; }
        public static bool visual_filters { get; set; }
        public static bool smart_filters { get; set; }
        public static bool power_save_mode { get; set; }
        public static bool swipe_cash_mode { get; set; }
    }
}
