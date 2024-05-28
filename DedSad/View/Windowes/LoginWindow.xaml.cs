using DedSad.Models;
using DedSad.Repository;
using DedSad.Utils;
using System;
using System.Windows;

namespace DedSad.View.Windowes
{
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private async void Pass_ok_Click(object sender, RoutedEventArgs e)
        {
            var login = logbox.Text.Trim().ToLower();
            var password = passbox.Password;
            try
            {
                var repository = new AutorizationRepository();
                await repository.Login(new Authorization()
                {
                    login = login,
                    password = password
                });
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                Close();
            }
            catch (Exception)
            {
                MessageBoxHandler.ShowMessageBoxError("Неправильный логин или пароль!");
            }
            
        }
    }
}
