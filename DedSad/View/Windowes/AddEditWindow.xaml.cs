using DedSad.Models;
using DedSad.Repository;
using System;
using System.Threading.Tasks;
using System.Windows;
using DedSad.View.Pages;
using DedSad.Utils;

namespace DedSad.View.Windowes
{
    public partial class AddEditWindow : Window
    {
        private readonly Children _children;

        public AddEditWindow() : this(new Children())
        {
            NonUpdatableFields.Visibility = Visibility.Visible;
            _children.person = new Person()
            {
            };
            _children.group = new Group();
        }

        public AddEditWindow(Children childrens)
        {
            InitializeComponent();
            this._children = childrens;
            Init();
        }

        private async void Init()
        {
            var groupRepo = new GroupRepository();
            var groups = await groupRepo.GetAllAsync();

            Group.ItemsSource = groups;

            Group.SelectedValue = _children.id_group;
            Sex.IsChecked = _children.person.sex;
            Name.Text = _children.person.firstname;
            LastName.Text = _children.person.lastname;
            Patronymic.Text = _children.person.patronymic;
            BirthDayDocument.Text = _children.birth_sertificate;
        }

        private async void Save_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                await SaveChanges();
            }
            catch (Exception)
            {
                MessageBoxHandler.ShowMessageBoxError("Проверьте корректность данных!");
            }
        }

        private async Task SaveChanges()
        {
            var parentsRepo = new ParentsRepository();
            var personRepo = new PersonRepository();
            var childrenRepo = new ChildrensRepository();
            var addressRepo = new AddressRepository();

            var group = Group.SelectedItem as Group;


            _children.person.firstname = Name.Text;
            _children.person.lastname = LastName.Text;
            _children.person.patronymic = Patronymic.Text;
            _children.person.sex = Sex.IsChecked.Value;
            _children.person.id_role = 3;
            _children.birth_sertificate = BirthDayDocument.Text;
            _children.id_group = group.id_group;

            if (_children.id_children == 0)
            {
                var partsAddresses = Addresses.Text.Split(',');

                if (partsAddresses.Length != 3)
                {
                    MessageBox.Show("Неправильный формат адреса");
                    return;
                }
                var address = new Address
                {
                    town = partsAddresses[0],
                    street = partsAddresses[1],
                    house_number = partsAddresses[2]
                };
                var createdAddress = await addressRepo.Create(address);
                _children.person.id_address = createdAddress.id_address;
                var person = await personRepo.Create(_children.person);
                _children.id_person = person.id_person;

                var result = await childrenRepo.Create(_children);
                var parents = new Parents
                {
                    father = Fathers.Text,
                    mother = Mothers.Text,
                    id_child = result.id_children,
                    home_telephone = Phone.Text
                };
                var createdParents = await parentsRepo.Create(parents);
            }
            else
            {
                var person = await personRepo.Update(_children.person);
                _children.id_person = person.id_person;

                var result = await childrenRepo.Update(_children);
            }


            Close();
        }

        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Sex_Checked(object sender, RoutedEventArgs e)
        {
            Sex.Content = "М";
        }

        private void Sex_Unchecked(object sender, RoutedEventArgs e)
        {
            Sex.Content = "Ж";
        }
    }
}
