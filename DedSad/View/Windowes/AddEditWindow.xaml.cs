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
    public partial class AddEditWindow : Window
    {
        private readonly Childrens children;

        public AddEditWindow() : this(new Childrens())
        {
            NonUpdatableFields.Visibility = Visibility.Visible;
            children.person = new Person()
            {
            };
            children.group = new Group();
        }

        public AddEditWindow(Childrens childrens)
        {
            InitializeComponent();
            this.children = childrens;
            Init();
        }

        private async void Init()
        {
            var groupRepo = new GroupRepository();
            var groups = await groupRepo.GetAllAsync();

            Group.ItemsSource = groups;

            Group.SelectedValue = children.id_group;
            Sex.IsChecked = children.person.sex;
            Name.Text = children.person.firstname;
            LastName.Text = children.person.lastname;
            Patronymic.Text = children.person.patronymic;
        }

        private async void Save_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                await SaveChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка, что-то не так!");
            }
        }

        private async Task SaveChanges()
        {
            var parentsRepo = new ParentsRepository();
            var personRepo = new PersonRepository();
            var childrenRepo = new ChildrensRepository();
            var addressRepo = new AddressRepository();

            var group = Group.SelectedItem as Group;


            children.person.firstname = Name.Text;
            children.person.lastname = LastName.Text;
            children.person.patronymic = Patronymic.Text;
            children.person.sex = Sex.IsChecked.Value;
            children.person.id_role = 3;
            children.id_group = group.id_group;

            if (children.id_children == 0)
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
                children.person.id_address = createdAddress.id_address;
                var person = await personRepo.Create(children.person);
                children.id_person = person.id_person;

                var result = await childrenRepo.Create(children);
                var parents = new Parents
                {
                    father = Fathers.Text,
                    mother = Mothers.Text,
                    id_child = result.id_children
                };
                var createdParents = await parentsRepo.Create(parents);
            }
            else
            {
                var person = await personRepo.Update(children.person);
                children.id_person = person.id_person;

                var result = await childrenRepo.Update(children);
            }


            AppFrame.frameMain.Navigate(new AdminPage());
        }

        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain.Navigate(new AdminPage());
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
