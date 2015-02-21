using MahApps.Metro.Controls;
using SnapchatDesktop.Pages;

namespace SnapchatDesktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {

        public MainWindow()
        {
            InitializeComponent();
            Client.MainWindow = this;
            Client.SetPage(new LoginPage());
        }
    }
}
