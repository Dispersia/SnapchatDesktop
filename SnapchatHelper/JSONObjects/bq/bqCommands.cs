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

            var client = new HttpClient(new HttpClientHandler
            {
                Proxy = null
            }, true);

            client.DefaultRequestHeaders.Add("Accept", "*/*");
            client.DefaultRequestHeaders.Add("Accept-Language", "en-US;q=1, en;q=0.9");
            client.DefaultRequestHeaders.Add("Accept-Locale", "en");
            client.DefaultRequestHeaders.Add("User-Agent", HttpHelper.User_Agent);

            var response = await client.PostAsync(HttpHelper.BaseUrl + Location + "login", new FormUrlEncodedContent(postData));
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");

            var ResponseString = await response.Content.ReadAsStringAsync();

            if (!string.IsNullOrEmpty(ResponseString))
                return ResponseString;

            return string.Empty;
        }
    }
}
