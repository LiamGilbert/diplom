using DedSad.Models;
using DedSad.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DedSad.View.Pages;

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
            var repository = new AutorizationRepository();
            await repository.Login(new Autorization()
            {
                login = login,
                password = password
            });
            AppFrame.frameMain.Navigate(new AdminPage());
        }
    }
}
