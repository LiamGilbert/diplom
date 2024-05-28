using DedSad.Models;
using DedSad.Repository;
using DedSad.Utils;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace DedSad.View.Windowes
{
    public partial class GroupEditWindow : Window
    {
        private readonly Group _group;
        public GroupEditWindow(Group group)
        {
            InitializeComponent();
            _group = group;
            Initialize();
        }

        private async void Initialize()
        {
            var personRepo = new PersonRepository();
            var typeRepo = new GroupTypesRepository();
            GroupType.ItemsSource = await typeRepo.GetAllAsync();
            Educator.ItemsSource = (await personRepo.GetAllAsync()).Where(x => x.role.role.ToLower().Equals("воспитатель")).ToList();
            DataContext = _group;
        }


        private async void TrySaveChanges(object sender, RoutedEventArgs e)
        {
            try
            {
                await SaveChanges();
            }
            catch (Exception)
            {
                MessageBoxHandler.ShowMessageBoxError("Проверьте введеные данные!");
            }
        }

        private async Task SaveChanges()
        {
            var groupRepo = new GroupRepository();

            await groupRepo.Update(_group);
            MessageBoxHandler.ShowMessageBoxInfo("Группа была изменена");
            Close();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
