using DedSad.Models;
using DedSad.Repository;
using DedSad.Utils;
using DedSad.View.Windowes;
using System.Windows.Controls;

namespace DedSad.View.Pages
{
    public partial class GroupsPage : Page
    {
        public GroupsPage()
        {
            InitializeComponent();
            Initialize();
        }

        private async void Initialize()
        {
            var repo = new GroupRepository();
            var items = await repo.GetAllAsync();

            ListViewGroup.ItemsSource = items;
        }

        private void NavigateToAdminPage(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminPage());
        }

        private void NavigateToEditPage(object sender, System.Windows.RoutedEventArgs e)
        {
            if (ListViewGroup.SelectedItem is Group group)
            {
                GroupEditWindow window = new GroupEditWindow(group);
                window.ShowDialog();
                Initialize();
            }
            else
            {
                MessageBoxHandler.ShowMessageBoxError("Выберите группу");
            }
        }
    }
}
