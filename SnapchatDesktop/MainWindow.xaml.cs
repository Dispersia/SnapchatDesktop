using AForge.Video.DirectShow;
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
            Client.SetPage(new MainPage());
        }

        private void MetroWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(Content is MainPage)
            {
                (Content as MainPage).StopCamera();
            }
        }
    }
}
