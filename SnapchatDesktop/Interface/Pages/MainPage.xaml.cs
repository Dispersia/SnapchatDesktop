using System;
using SnapchatDesktop.Interface.Controls;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;

namespace SnapchatDesktop.Pages
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        private VideoCaptureDevice webcam;
        private FilterInfoCollection webcamCollection;

        public MainPage()
        {
            InitializeComponent();
            webcamCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            webcam = new VideoCaptureDevice(webcamCollection[0].MonikerString);
            webcam.NewFrame += Webcam_NewFrame;

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

        private void Webcam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            System.Drawing.Image image = (Bitmap) eventArgs.Frame.Clone();
            MemoryStream mStream = new MemoryStream();
            image.Save(mStream, ImageFormat.Bmp);
            mStream.Seek(0, SeekOrigin.Begin);
            BitmapImage bImage = new BitmapImage();
            bImage.BeginInit();
            bImage.StreamSource = mStream;
            bImage.EndInit();

            bImage.Freeze();
            Dispatcher.BeginInvoke(new ThreadStart(delegate
            {
                webcamCapture.Source = bImage;
            }));
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
