using DedSad.Models;
using DedSad.Repository;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Excel = Microsoft.Office.Interop.Excel;
namespace DedSad.View.Pages
{
    public partial class Admin : Page
    {
        private readonly List<Childrens> childrens;
        public Admin()
        {
            InitializeComponent();
            childrens = new List<Childrens>();
            Init();

        }
        private async Task Init()
        {
            childrens.Clear();
            var parentsRepo = new ParentsRepository();
            var repo = new ChildrensRepository();
            var groupRepo = new GroupRepository();
            var parents = await parentsRepo.GetAllAsync();
            var dictionary = new Dictionary<int, Parents>(parents.Count);
            foreach(var item in parents)
            {
                dictionary.Add(item.id_child, item);
            }
            var items = await repo.GetAllAsync();
            var groups = await groupRepo.GetAllAsync();
            groups.Insert(0, new Group() { group_name = "Все" });
            foreach (var child in items)
            {
                var parent = dictionary[child.id_children];
                if(parent == null)
                {
                    child.female = "Нет";
                    child.man = "Нет";
                }
                else
                {
                    child.man = parent.father;
                    child.female = parent.mother;
                }
            }
            childrens.AddRange(items);
            ListViewChildren.ItemsSource = items;
            GroupCB.ItemsSource = groups;
            GroupCB.SelectedIndex = 0;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain.Navigate(new AddEdit());
        }

        private async void DdeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (ListViewChildren.SelectedItem is Childrens child)
            {
                var messageResult = MessageBox.Show("Удалить запись?", "Вы уверены?", MessageBoxButton.YesNo);
                if (messageResult == MessageBoxResult.Yes)
                {
                    var repo = new ChildrensRepository();
                    await repo.Delete(child.id_children);
                    await Init();
                }
            }
        }

        private void RedButton_Click(object sender, RoutedEventArgs e)
        {
            if(ListViewChildren.SelectedItem is Childrens child)
            {
                AppFrame.frameMain.Navigate(new AddEdit(child));
            }
        }

        private void ExcelButton_Click(object sender, RoutedEventArgs e)
        {
            Excel.Application app = new Excel.Application()
            {
                SheetsInNewWorkbook = 1
            };
            var workBook = app.Workbooks.Add();

            app.DisplayAlerts = false;

            Excel.Worksheet sheet = (Excel.Worksheet)app.Worksheets.get_Item(1);
            sheet.Name = "Дети";
            var selectedGroup = GroupCB.SelectedItem as Group;

            if (selectedGroup == null)
                return;

            var currentDate = DateTime.Now;
            sheet.Cells[1, 1] = "Группа:";
            sheet.Cells[1, 2] = selectedGroup.group_name;
            sheet.Cells[1, 4] = "Дата:";
            sheet.Cells[1, 5] = currentDate.ToString("dd.MM.yyyy");
            sheet.Cells[2, 1] = "ФИО";
            sheet.Cells[2, 2] = "Пол";
            sheet.Cells[2, 5] = "Адрес проживания";

            var children = childrens.Where(x => x.id_group == selectedGroup.id_group).ToList();
            var rowIndex = 3;

            foreach (var child in children)
            {
                sheet.Cells[rowIndex, 1] = child.person.FullName;
                sheet.Cells[rowIndex, 2] = child.person.sex;
                sheet.Cells[rowIndex, 5] = child.person.address.FullName;

                rowIndex++;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx";

            if (saveFileDialog.ShowDialog() == false)
            {
                return;
            }
            app.Visible = true;
            workBook.SaveAs(saveFileDialog.FileName);
        }

        private void SearchTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            FilteringChildrens();
        }

        private void GroupCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FilteringChildrens();
        }

        private void FilteringChildrens()
        {
            var list = childrens.Where(x => x.person.FullName.ToLower().Contains(SearchTB.Text.ToLower())).ToList();

            if(GroupCB.SelectedItem is Group group && group.id_group != 0)
            {
                list = list.Where(x => x.id_group == group.id_group).ToList();
            }
            ListViewChildren.ItemsSource = list;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain.Navigate(new Attendance());
        }
    }
}
