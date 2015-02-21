
using System.Windows;
using System.Windows.Controls;

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
            for(int i = 0; i < Client.MySnapchat.FriendsList.Count; i++)
            {
                MessageBox.Show(Client.MySnapchat.FriendsList[i].Name);
            }
        }
    }
}
