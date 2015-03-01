using MahApps.Metro.Controls;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace SnapchatDesktop
{
    class Client
    {
        public static List<Page> openPages { get; set; } = new List<Page>(); //Love you C#6
        public static MetroWindow MainWindow { get; set; }
        public static SnapchatHelper.Snapchat Snapchat { get; set; }

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
    }
}
