using System;
using SnapchatDesktop.Interface.Controls;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace SnapchatDesktop.Pages
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            Client.MySnapchat.FriendsList = Client.MySnapchat.FriendsList.OrderBy(x =>
                (!String.IsNullOrEmpty(x.Display)
                        ? x.Display
                        : x.Name)).ToList();

            for(int i = 0; i < Client.MySnapchat.FriendsList.Count; i++)
            {
                UserListItem item = new UserListItem();
                item.DisplayName.Text = (!String.IsNullOrEmpty(Client.MySnapchat.FriendsList[i].Display)
                    ? Client.MySnapchat.FriendsList[i].Display
                    : Client.MySnapchat.FriendsList[i].Name);
                item.StoryImage.Source = new BitmapImage(new Uri("pack://application:,,,/Resources/SnapchatStory.jpg"));
                friendsListBox.Items.Add(item);
            }
        }
    }
}
