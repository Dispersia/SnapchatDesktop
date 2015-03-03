using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SnapchatHelper.JSONObjects.bq
{
    class bqCommands
    {
        private const string Location = "/bq/";

        //Thanks to Nikey646 for the suggestion on updating this.
        public static async Task<string> Login(string username, string password)
        {
            var timestamp = HttpHelper.generateTimestamp();

            var postData = new Dictionary<string, string>()
            {
                { "username", username },
                { "password", password },
                { "timestamp", timestamp },
                { "req_token", HttpHelper.generateToken(timestamp) }
            };

            var responseString = await HttpHelper.post(Location + "login", new FormUrlEncodedContent(postData));

            if (!string.IsNullOrEmpty(responseString))
                return responseString;

            return string.Empty;
        }
    }
}
