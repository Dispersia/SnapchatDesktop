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
        public static string Username { get; set; }
        public static string AuthToken { get; set; }
        public static string RequestToken { get; set; }
        public static string ResponseString { get; set; }
        private const string
            SnapVersion = "9.1.2.0",
            BaseUrl = "https://feelinsonice-hrd.appspot.com/bq/",
            Static_Token = "m198sOkJEn37DjqZ32lpRu76xmw288xSQ9",
            User_Agent = "Snapchat/" + SnapVersion + " (Nexus 4; Android 18; gzip)",
            Secret_Token = "iEk21fuwZApXlz93750dmW22pw389dPwOk",
            Pattern = "0001110111101110001111010101111011010001001110011000110001000110";

        //Thanks to Nikey646 for the suggestion on updating this.
        public static async Task<string> Login(string username, string password)
        {
            TimeSpan span = DateTime.Now - new DateTime(1970, 1, 1);
            string timestamp = (span.TotalSeconds * 1000).ToString(CultureInfo.InvariantCulture).Substring(0, 13);


            var postData = new Dictionary<string, string>()
            {
                { "username", username },
                { "password", password },
                { "timestamp", timestamp },
                { "req_token", getToken(timestamp, Static_Token) }
            };

            var requestClient = new HttpClient(new HttpClientHandler
            {
                Proxy = null
            }, true);

            requestClient.DefaultRequestHeaders.Add("Accept", "*/*");
            requestClient.DefaultRequestHeaders.Add("Accept-Language", "en-US;q=1, en;q=0.9");
            requestClient.DefaultRequestHeaders.Add("Accept-Locale", "en");
            requestClient.DefaultRequestHeaders.Add("User-Agent", User_Agent);

            var response = await requestClient.PostAsync(BaseUrl + "login", new FormUrlEncodedContent(postData));
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");

            ResponseString = await response.Content.ReadAsStringAsync();

            if (!String.IsNullOrEmpty(ResponseString) && !ResponseString.Contains("401 UNAUTHORIZED"))
                return ResponseString;

            return string.Empty;
        }

        private static string getToken(string timestamp, string one)
        {
            string first = getSha(Secret_Token + one);
            string second = getSha(timestamp + Secret_Token);

            StringBuilder tokenBuilder = new StringBuilder();
            for (int i = 0; i < Pattern.Length; i++)
            {
                char c = Pattern[i];
                tokenBuilder.Append(c == '0' ?
                    first[i] :
                    second[i]);
            }
            return tokenBuilder.ToString();
        }

        private static string getSha(string input)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(input);
            byte[] hash = SHA256.Create().ComputeHash(bytes);
            return hash.Aggregate(string.Empty, (current, x) => current + string.Format("{0:x2}", x));
        }
    }
}
