using System;
using SnapchatDesktop.Interface.Controls;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Diagnostics;
using System.Windows;
using SnapchatHelper.JSONObjects.bq;

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
                    (!string.IsNullOrEmpty(x.Display)
                            ? x.Display
                            : x.Name)).ToList();

                for (int i = 0; i < Client.Snapchat.FriendsList.Count; i++)
                {
                    UserListItem item = new UserListItem();
                    item.DisplayName.Text = !string.IsNullOrEmpty(Client.Snapchat.FriendsList[i].Display)
                        ? Client.Snapchat.FriendsList[i].Display
                        : Client.Snapchat.FriendsList[i].Name;
                    item.StoryImage.Source = new BitmapImage(new Uri("pack://application:,,,/Resources/SnapchatStory.jpg"));
                    friendsListBox.Items.Add(item);
                }
            }
            else
            {
                Client.Snapchat.FriendsList = Client.Snapchat.FriendsList.OrderBy(x =>
                    (!string.IsNullOrEmpty(x.Display)
                            ? x.Display
                            : x.Name)).ToList();

                for (int i = 0; i < Client.Snapchat.FriendsList.Count; i++)
                {
                    UserListItem item = new UserListItem();
                    item.DisplayName.Text = (!string.IsNullOrEmpty(Client.Snapchat.FriendsList[i].Display)
                        ? Client.Snapchat.FriendsList[i].Display
                        : Client.Snapchat.FriendsList[i].Name);
                    item.StoryImage.Source = new BitmapImage(new Uri("pack://application:,,,/Resources/SnapchatStory.jpg"));
                    friendsListBox.Items.Add(item);
                }
            }
        }

        private async void CaptureButton_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (await Client.Snapchat.Logout(Client.Snapchat))
                MessageBox.Show("Logged Out");
            else
                MessageBox.Show("Failed to logout.");
        }

        private void ViewSnap_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show((friendsListBox.SelectedItem as UserListItem).DisplayName.Text);
        }

        private void SendMessage_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
