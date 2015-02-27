using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapchatDesktop.SnapchatHelper.JSONObjects
{
    internal class MessagingGatewayInfo
    {
        public GatewayAuthToken gateway_auth_token { get; set; }
        public string gateway_server { get; set; }
    }
}
