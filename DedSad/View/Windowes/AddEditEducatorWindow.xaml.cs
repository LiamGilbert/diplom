using DedSad.Models;
using DedSad.Repository;
using DedSad.Utils;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows;

namespace DedSad.View.Windowes
{
    public partial class AddEditEducatorWindow : Window
    {
        private readonly Person _person;
        public AddEditEducatorWindow() : this(new Person())
        {
            Address.Visibility = Visibility.Visible;
            AuthorizationBlock.Visibility = Visibility.Visible;
        }

        public AddEditEducatorWindow(Person person)
        {
            InitializeComponent();
            _person = person;
            DataContext = person;
        }

        private void Sex_Checked(object sender, RoutedEventArgs e)
        {
            Sex.Content = "М";
        }

        private void Sex_Unchecked(object sender, RoutedEventArgs e)
        {
            Sex.Content = "Ж";
        }

        private async void TrySaveChanges(object sender, RoutedEventArgs e)
        {
            try
            {
                await SaveChanges();
                Close();
            }
            catch (Exception)
            {
                MessageBoxHandler.ShowMessageBoxError("Проверьте валидацию данных");
            }
        }

        private async Task SaveChanges()
        {
            var personRepo = new PersonRepository();
            var addressRepo = new AddressRepository();
            var authRepo = new AutorizationRepository();

            if (_person.id_person == 0)
            {
                var addressPunkts = Addresses.Text.Split(',');
                _person.id_role = 2;


                if (addressPunkts.Length != 3)
                {
                    throw new ArgumentException("Ошибка не правильный ввод данных");
                }
                var address = new Address
                {
                    town = addressPunkts[0].Trim(),
                    street = addressPunkts[1].Trim(),
                    house_number = addressPunkts[2].Trim()
                };
                var newAddress = await addressRepo.Create(address);
                _person.id_address = newAddress.id_address;
                var person = await personRepo.Create(_person);
                var authorization = new Authorization()
                {
                    login = LoginField.Text,
                    password = PasswordField.Text,
                    id_person = person.id_person
                };
                await authRepo.Create(authorization);
            }
            else
            {
                await personRepo.Update(_person);
            }

        }

        private void Back(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
