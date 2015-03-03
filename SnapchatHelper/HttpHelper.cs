using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SnapchatHelper
{
    class HttpHelper
    {
        public const string
            SnapVersion = "9.2.0.0",
            BaseUrl = "https://feelinsonice-hrd.appspot.com",
            Static_Token = "m198sOkJEn37DjqZ32lpRu76xmw288xSQ9",
            User_Agent = "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36",
            Secret_Token = "iEk21fuwZApXlz93750dmW22pw389dPwOk",
            Pattern = "0001110111101110001111010101111011010001001110011000110001000110";

        private static HttpClient client;

        static HttpHelper()
        {
            client = new HttpClient(new HttpClientHandler() { Proxy = null });
            client.DefaultRequestHeaders.Add("Accept", "*/*");
            client.DefaultRequestHeaders.Add("Accept-Language", "en-US;q=1, en;q=0.9");
            client.DefaultRequestHeaders.Add("Accept-Locale", "en");
            client.DefaultRequestHeaders.Add("User-Agent", User_Agent);
        }

        public static async Task<string> post(string path, HttpContent postData)
        {
            var response = await client.PostAsync(string.Format("{0}{1}", BaseUrl, path), postData);

            return await response.Content.ReadAsStringAsync();
        }

        public static string generateTimestamp()
        {
            return (DateTime.Now.Millisecond / 1000).ToString();
        }

        public static string generateToken(string timestamp)
        {
            return generateToken(timestamp, Static_Token);
        }

        public static string generateToken(string timestamp, string one)
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
