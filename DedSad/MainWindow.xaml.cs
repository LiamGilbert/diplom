using DedSad.View;
using DedSad.View.Pages;
using System.Windows;

namespace DedSad
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AppFrame.frameMain = FrmMain;
            FrmMain.Navigate(new Login());
        }
    }
}
