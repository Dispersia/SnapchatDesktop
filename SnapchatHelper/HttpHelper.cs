using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SnapchatHelper
{
    class HttpHelper
    {
        public const string
            SnapVersion = "9.1.2.0",
            BaseUrl = "https://feelinsonice-hrd.appspot.com",
            Static_Token = "m198sOkJEn37DjqZ32lpRu76xmw288xSQ9",
            User_Agent = "Snapchat/" + SnapVersion + " (Nexus 4; Android 18; gzip)",
            Secret_Token = "iEk21fuwZApXlz93750dmW22pw389dPwOk",
            Pattern = "0001110111101110001111010101111011010001001110011000110001000110";
        private static DateTime nix = new DateTime(1970, 1, 1);

        public static string generateTimestamp()
        {
            TimeSpan span = DateTime.Now - nix;
            return (span.TotalSeconds * 1000).ToString(CultureInfo.InvariantCulture).Substring(0, 13);
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
