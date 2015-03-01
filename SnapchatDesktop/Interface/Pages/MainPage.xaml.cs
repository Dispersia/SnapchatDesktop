using System;
using SnapchatDesktop.Interface.Controls;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Diagnostics;
using System.Windows;

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
            if (Client.Snapchat.friendsResponse.Friends != null)
            {
                Client.Snapchat.friendsResponse.Friends = Client.Snapchat.friendsResponse.Friends.OrderBy(x =>
                    (!String.IsNullOrEmpty(x.Display)
                            ? x.Display
                            : x.Name)).ToList();

                for (int i = 0; i < Client.Snapchat.FriendsList.Count; i++)
                {
                    UserListItem item = new UserListItem();
                    item.DisplayName.Text = (!String.IsNullOrEmpty(Client.Snapchat.FriendsList[i].Display)
                        ? Client.Snapchat.FriendsList[i].Display
                        : Client.Snapchat.FriendsList[i].Name);
                    item.StoryImage.Source = new BitmapImage(new Uri("pack://application:,,,/Resources/SnapchatStory.jpg"));
                    friendsListBox.Items.Add(item);
                }
            }
            else
            {
                Client.Snapchat.FriendsList = Client.Snapchat.FriendsList.OrderBy(x =>
                    (!String.IsNullOrEmpty(x.Display)
                            ? x.Display
                            : x.Name)).ToList();

                for (int i = 0; i < Client.Snapchat.FriendsList.Count; i++)
                {
                    UserListItem item = new UserListItem();
                    item.DisplayName.Text = (!String.IsNullOrEmpty(Client.Snapchat.FriendsList[i].Display)
                        ? Client.Snapchat.FriendsList[i].Display
                        : Client.Snapchat.FriendsList[i].Name);
                    item.StoryImage.Source = new BitmapImage(new Uri("pack://application:,,,/Resources/SnapchatStory.jpg"));
                    friendsListBox.Items.Add(item);
                }
            }
        }

        private void CaptureButton_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Debug.WriteLine("Captured!");
        }
    }
}
