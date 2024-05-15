using DedSad.Models;
using DedSad.Repository;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Excel = Microsoft.Office.Interop.Excel;

namespace DedSad.View.Pages
{
    public partial class Attendance : Page
    {
        public Attendance()
        {
            InitializeComponent();
            Init();
        }

        private async Task Init()
        {
            var repo = new AttendanceRepository();
            var items = await repo.GetAllAsync();
            ListViewChildren.ItemsSource = items;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain.Navigate(new Admin());
        }

        private void ExcelButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
