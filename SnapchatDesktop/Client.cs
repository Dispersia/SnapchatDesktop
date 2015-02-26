using MahApps.Metro.Controls;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace SnapchatDesktop
{
    class Client
    {
        public static List<Page> openPages { get; set; } = new List<Page>(); //Love you C#6
        public static MetroWindow MainWindow { get; set; }
        public static string Username { get; set; }
        public static string AuthToken { get; set; }
        public static string RequestToken { get; set; }
        private const string
            BaseUrl = "https://feelinsonice-hrd.appspot.com/bq/",
            Static_Token = "m198sOkJEn37DjqZ32lpRu76xmw288xSQ9",
            User_Agent = "Snapchat/9.2.0 (Linux; Android 4.4.2; Nexus 4 Build/KOT49H) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/34.0.1847.114 Mobile Safari/537.36",
            Secret_Token = "iEk21fuwZApXlz93750dmW22pw389dPwOk",
            Pattern = "0001110111101110001111010101111011010001001110011000110001000110";

        public static Snapchat.Snapchat MySnapchat { get; set; }

        public static string ResponseString { get; set; }

        public static void SetPage(Page page)
        {
            foreach (Page p in openPages)
            {
                if (p.GetType() == page.GetType())
                {
                    Application.Current.MainWindow.Content = p;
                    return;
                }
            }
            openPages.Add(page);
            Application.Current.MainWindow.Content = page;
        }

        public static void ClearPage(Page page)
        {
            foreach (Page p in openPages)
            {
                if (p.GetType() == page.GetType())
                {
                    openPages.Remove(p);
                    return;
                }
            }
        }

        //Thanks to Nikey646 for the suggestion on updating this.
        public static async Task<bool> Login(string username, string password)
        {
            TimeSpan span = DateTime.Now - new DateTime(1970, 1, 1);
            string timestamp = span.TotalSeconds.ToString(CultureInfo.InvariantCulture);
            string first = getSha(Secret_Token + Static_Token);
            string second = getSha(timestamp + Secret_Token);

            StringBuilder tokenBuilder = new StringBuilder();
            for (int i = 0; i < Pattern.Length; i++)
            {
                char c = Pattern[i];
                if (c == '0')
                    tokenBuilder.Append(first[i]);
                else
                    tokenBuilder.Append(second[i]);
            }

            var postData = new Dictionary<string, string>()
            {
                { "username", username },
                { "password", password },
                { "timestamp", timestamp },
                { "req_token", tokenBuilder.ToString() }
            };

            var requestClient = new HttpClient(new HttpClientHandler
            {
                UseCookies = true,
                CookieContainer = new CookieContainer(),
                Credentials = new NetworkCredential(username, password),
                Proxy = null,
                PreAuthenticate = true
            }, true);

            requestClient.DefaultRequestHeaders.Add("Accept", "application/json");
            requestClient.DefaultRequestHeaders.Add("Accept-Language", "en-US");
            requestClient.DefaultRequestHeaders.Add("User-Agent", User_Agent);

            var response = await requestClient.PostAsync(BaseUrl + "login", new FormUrlEncodedContent(postData));
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");

            ResponseString = await response.Content.ReadAsStringAsync();

            if (!ResponseString.Contains("401 UNAUTHORIZED"))
                MySnapchat = JsonConvert.DeserializeObject<Snapchat.Snapchat>(ResponseString);
            else
                MySnapchat = new Snapchat.Snapchat() {
                    Logged = false,
                    Message = "401 Unauthorized error. Please submit as an issue on github, thanks!"
                };

            if (!MySnapchat.Logged)
                return false;

            return true;
        }

        private static string getSha(string input)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(input);
            byte[] hash = SHA256.Create().ComputeHash(bytes);
            return hash.Aggregate(string.Empty, (current, x) => current + string.Format("{0:x2}", x));
        }
    }
}
