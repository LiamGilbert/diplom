using DedSad.View;
using DedSad.View.Pages;
using DedSad.View.Windowes;
using System.Windows;

namespace DedSad
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AppFrame.frameMain = FrmMain;
            FrmMain.Navigate(new AdminPage());
        }
    }
}
