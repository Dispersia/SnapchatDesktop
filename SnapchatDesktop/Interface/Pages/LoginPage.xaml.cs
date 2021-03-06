﻿using System.Windows;
using System.Windows.Controls;
using MahApps.Metro.Controls.Dialogs;
using System.Threading;
using System.Windows.Threading;
using SnapchatHelper;

namespace SnapchatDesktop.Pages
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(UsernameBox.Text))
            {
                await Client.MainWindow.ShowMessageAsync("Invalid Username", "Please enter a valid username!");
            }
            else if (string.IsNullOrEmpty(PasswordBox.Password))
            {
                await Client.MainWindow.ShowMessageAsync("Invalid Password", "Please enter a valid password!");
            }
            else
            {
                LoginGrid.Visibility = Visibility.Hidden;
                LoggingInProgressRing.Visibility = Visibility.Visible;
                LoggingInLabel.Visibility = Visibility.Visible;

                await Dispatcher.BeginInvoke(DispatcherPriority.Input, new ThreadStart(async() =>
                {
                    Client.Snapchat = await Snapchat.Login(UsernameBox.Text, PasswordBox.Password);
                    if (Client.Snapchat.Logged)
                    {
                        Client.SetPage(new MainPage());
                    }
                    else
                    {
                        await Client.MainWindow.ShowMessageAsync("Login Failed", string.IsNullOrEmpty(Client.Snapchat.Message) ? "Failed." : Client.Snapchat.Message);
                        LoginGrid.Visibility = Visibility.Visible;
                        LoggingInProgressRing.Visibility = Visibility.Hidden;
                        LoggingInLabel.Visibility = Visibility.Hidden;
                    }
                }));
            }
        }
    }
}
