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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DedSad.View.Pages
{
    public partial class AddEdit : Page
    {/*
        private readonly Childrens childrens;
        
        public AddEdit(): this(new Childrens())
        {
            childrens.person = new Person()
            {
                sex = new Sex()
            };
            childrens.group = new Group();
            childrens.parent = new Parents();
        }

        public AddEdit(Childrens childrens)
        {
            InitializeComponent();
            this.childrens = childrens;
            Init();
        }

        private async void Init()
        {
            var personRepo = new PersonRepository();
            var groupRepo = new GroupRepository();
            var parents = (await personRepo.GetAllAsync()).Where(x => x.role.role_name == "родитель").ToList();
            Mothers.ItemsSource = parents.Where(x => x.sex.sex_name == "женский").ToList();
            Fathers.ItemsSource = parents.Where(x => x.sex.sex_name == "мужской").ToList();

            var sexs = await sexRepo.GetAllAsync();
            Sex.ItemsSource = sexs;

            var groups = await groupRepo.GetAllAsync();
            Group.ItemsSource = groups;

            Mothers.SelectedValue = childrens.parents.id_mother;
            Fathers.SelectedValue = childrens.parents.id_father;
            Sex.SelectedValue = childrens.person.id_sex;
            Group.SelectedValue = childrens.id_group;
            Name.Text = childrens.person.name;
            LastName.Text = childrens.person.lastname;
            Patronymic.Text = childrens.person.patronymic;
            BirthDay.SelectedDate = childrens.person.birth_date;

        }
        */
        private /*async*/ void Save_Button_Click(object sender, RoutedEventArgs e)
        {
            /*try
            {
                await SaveChanges();
            }
            catch(Exception)
            {
                MessageBox.Show("Ошибка, что-то не так!");
            }*/
        }
        /*
        private async Task SaveChanges()
        {
            var parentsRepo = new ParentsRepository();
            var personRepo = new PersonRepository();
            var childrenRepo = new ChildrensRepository();

            var mother = Mothers.SelectedItem as Person;
            var father = Fathers.SelectedItem as Person;
            var sex = Sex.SelectedItem as Sex;
            var group = Group.SelectedItem as Group;

            childrens.parents.id_father = father.id_person;
            childrens.parents.id_mother = mother.id_person;

            childrens.person.id_address = mother.id_address;
            childrens.person.name = Name.Text;
            childrens.person.lastname = LastName.Text;
            childrens.person.patronymic = Patronymic.Text;
            childrens.person.birth_date = BirthDay.SelectedDate.Value;
            childrens.person.id_sex = sex.id_sex;
            childrens.person.id_role = 3;
            childrens.id_medcomission = 1;
            childrens.id_group = group.id_group;
            if (childrens.id_children == 0)
            {

                var parentsResult = await parentsRepo.Create(childrens.parents);
                childrens.id_parent = parentsResult.id_parent;
                var person = await personRepo.Create(childrens.person);
                childrens.id_person = person.id_person;

                var result = await childrenRepo.Create(childrens);
            }
            else
            {
                var parentsResult = await parentsRepo.Update(childrens.parents);
                childrens.id_parent = parentsResult.id_parent;

                var person = await personRepo.Update(childrens.person);
                childrens.id_person = person.id_person;

                var result = await childrenRepo.Update(childrens);
            }


            AppFrame.frameMain.Navigate(new Admin());
        }
        */
        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            //AppFrame.frameMain.Navigate(new Admin());
        }
    }
}
