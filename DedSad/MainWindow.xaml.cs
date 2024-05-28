using DedSad.View;
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
            LoginWindow window = new LoginWindow();
            window.Show();
            this.Close();
        }
    }
}
