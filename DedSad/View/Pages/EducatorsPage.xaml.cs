using DedSad.Models;
using DedSad.Repository;
using DedSad.Utils;
using DedSad.View.Windowes;
using System;
using System.Linq;
using System.Windows.Controls;

namespace DedSad.View.Pages
{
    public partial class EducatorsPage : Page
    {
        public EducatorsPage()
        {
            InitializeComponent();
            Initialize();
        }

        private async void Initialize()
        {
            var repo = new PersonRepository();

            var items = (await repo.GetAllAsync()).Where(x => x.role.role.ToLower().Equals("воспитатель")).ToList();
            ListViewEducator.ItemsSource = items;
        }

        private void NavigateToAdminPage(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminPage());
        }

        private void AddButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            AddEditEducatorWindow window = new AddEditEducatorWindow();
            window.ShowDialog();
            Initialize();
        }

        private async void DdeleteButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (ListViewEducator.SelectedItem is Person person)
            {
                try
                {
                    var personRepo = new PersonRepository();
                    await personRepo.Delete(person.id_person);
                    Initialize();
                }
                catch (Exception)
                {
                    MessageBoxHandler.ShowMessageBoxError("Произошла ошибка при удалении");
                }
                
            }
            else
            {
                MessageBoxHandler.ShowMessageBoxError("Выберите человека!");
            }
        }

        private void RedButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (ListViewEducator.SelectedItem is Person person)
            {
                AddEditEducatorWindow window = new AddEditEducatorWindow(person);
                window.ShowDialog();
                Initialize();
            }
            else
            {
                MessageBoxHandler.ShowMessageBoxError("Выберите человека!");
            }
        }
    }
}
