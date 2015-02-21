using MahApps.Metro.Controls;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
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
            Timestamp = "1373207221",
            User_Agent = "Snapchat/9.1.2.0 (Nexus 4; Android 18; gzip)",
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

        public static bool Login(string username, string password)
        {
            TimeSpan span = DateTime.Now - new DateTime(1970, 1, 1);
            string timestamp = span.TotalSeconds.ToString(CultureInfo.InvariantCulture);
            StringBuilder postBuilder = new StringBuilder();
            postBuilder.Append("username=" + username);
            postBuilder.Append("&password=" + password);
            postBuilder.Append("&timestamp=" + timestamp);
            string reqToken = string.Empty;
            string first = getSha(string.Format("{0}{1}", Secret_Token, Static_Token));
            string second = getSha(string.Format("{0}{1}", timestamp, Secret_Token));

            StringBuilder tokenBuilder = new StringBuilder();
            for (int i = 0; i < Pattern.Length; i++)
            {
                char c = Pattern[i];
                if (c == '0')
                    tokenBuilder.Append(first[i]);
                else
                    tokenBuilder.Append(second[i]);
            }
            postBuilder.Append("&req_token=" + tokenBuilder.ToString());

            HttpWebRequest request = WebRequest.Create(string.Format(string.Format("{0}{1}", BaseUrl, "login"))) as HttpWebRequest;
            request.Accept = "*/*";
            request.Headers.Add(HttpRequestHeader.AcceptLanguage, "en-US");
            request.ContentType = "application/x-www-form-urlencoded";
            request.Method = "POST";
            request.UserAgent = User_Agent;

            using (StreamWriter writer = new StreamWriter(request.GetRequestStream()))
            {
                writer.Write(postBuilder.ToString());
            }

            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {

                using (Stream rs = response.GetResponseStream())
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        byte[] buff = new byte[8000];
                        int count = 0;
                        int current = 0;
                        do
                        {
                            count = rs.Read(buff, 0, buff.Length);
                            ms.Write(buff, 0, count);
                            current += count;
                        } while (count > 0);
                        response.Close();
                        ResponseString = Encoding.UTF8.GetString(ms.ToArray());
                        using (StreamWriter output = new StreamWriter("data.txt"))
                        {
                            output.Write(ResponseString);
                        }
                        MySnapchat = JsonConvert.DeserializeObject<Snapchat.Snapchat>(ResponseString);

                        if (!MySnapchat.Logged)
                            return false;

                        return true;
                    }
                }
            }
        }

        private static string getSha(string input)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(input);
            byte[] hash = SHA256.Create().ComputeHash(bytes);
            return hash.Aggregate(string.Empty, (current, x) => current + string.Format("{0:x2}", x));
        }
    }
}
