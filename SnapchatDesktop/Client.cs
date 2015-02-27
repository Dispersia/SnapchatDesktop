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
            SnapVersion = "9.1.2.0",
            BaseUrl = "https://feelinsonice-hrd.appspot.com/loq/",
            Static_Token = "m198sOkJEn37DjqZ32lpRu76xmw288xSQ9",
            User_Agent = "Snapchat/" + SnapVersion + " (Nexus 4; Android 18; gzip)",
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
            string timestamp = (span.TotalSeconds * 1000).ToString(CultureInfo.InvariantCulture).Substring(0, 13);
            

            var postData = new Dictionary<string, string>()
            {
                { "username", username },
                { "password", password },
                { "timestamp", timestamp },
                { "req_token", getToken(timestamp, Static_Token) },
                { "features_map", "{\"all_updates_friends_response\":true}" },
                { "access_token", "eyJhbGciOiJSUzI1NiIsImtpZCI6Ijc0ZWIyNDY1MGE0NzViNDkzZGQzZjFiMjU2MmM5MTZmOTA1MzIyOTAifQ.eyJpc3MiOiJhY2NvdW50cy5nb29nbGUuY29tIiwic3ViIjoiMTA0NzkzMDIyMzY2MTc0NTE1NTAxIiwiYXpwIjoiNjk0ODkzOTc5MzI5LXFnMGkwdTg4dDBobThrNmsxbWJyYm5zdWoxMDFoNzN2LmFwcHMuZ29vZ2xldXNlcmNvbnRlbnQuY29tIiwiZW1haWwiOiJkaXNwZXJzaWFzQGdtYWlsLmNvbSIsImVtYWlsX3ZlcmlmaWVkIjp0cnVlLCJhdWQiOiI2OTQ4OTM5NzkzMjktbDU5ZjNwaGw0MmV0OWNscG9vMjk2ZDhyYXFvbGpsNnAuYXBwcy5nb29nbGV1c2VyY29udGVudC5jb20iLCJpYXQiOjE0MjUwMjE3OTAsImV4cCI6MTQyNTAyNTY5MH0.K22ML2yd3OK-2hdQzzcykmrzlG1mdfWGd9USxPnTBWSj01EDYRp2IrtiKLurSUuHwOrhUUzflyQCaWwH7lH6935U_jh6OA-LHUielGWZYcgKMqUY0I56AhHmYoigUmydVj05F6BAvnJ_seEL5gm4nk7HEZSA-__QPagntdf6Knk" } //Need to decompile again to figure this one out.
            };

            var requestClient = new HttpClient(new HttpClientHandler
            {
                Proxy = null
            }, true);

            requestClient.DefaultRequestHeaders.Add("Accept", "*/*");
            requestClient.DefaultRequestHeaders.Add("Accept-Language", "en-US");
            requestClient.DefaultRequestHeaders.Add("User-Agent", User_Agent);

            var response = await requestClient.PostAsync(BaseUrl + "login", new FormUrlEncodedContent(postData));
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");

            ResponseString = await response.Content.ReadAsStringAsync();

            if (!ResponseString.Contains("401 UNAUTHORIZED"))
                MySnapchat = JsonConvert.DeserializeObject<Snapchat.Snapchat>(ResponseString);
            else
            {
                MySnapchat = new Snapchat.Snapchat();
                MySnapchat.UpdateResponse.Logged = false;
                MySnapchat.Message = "401 Unauthorized error. Please submit as an issue on github, thanks!";
            }

            if (!MySnapchat.UpdateResponse.Logged)
                return false;

            return true;
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
