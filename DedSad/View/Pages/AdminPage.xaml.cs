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
using DedSad.View.Windowes;
using DedSad.Utils;

namespace DedSad.View.Pages
{
    public partial class AdminPage : Page
    {
        private readonly List<Children> _childrens;
        public AdminPage()
        {
            InitializeComponent();
            _childrens = new List<Children>();
            Init();

        }
        private async Task Init()
        {
            _childrens.Clear();
            var parentsRepo = new ParentsRepository();
            var repo = new ChildrensRepository();
            var groupRepo = new GroupRepository();

            var items = await repo.GetAllAsync();
            var groups = await groupRepo.GetAllAsync();
            groups.Insert(0, new Group() { group_name = "Все" });
            _childrens.AddRange(items);
            ListViewChildren.ItemsSource = items;
            GroupCB.ItemsSource = groups;
            GroupCB.SelectedIndex = 0;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain.Navigate(new AddEditWindow());
        }

        private async void DdeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (ListViewChildren.SelectedItem is Children child)
            {
                var messageResult = MessageBoxHandler.ShowMessageBoxQuestion($"Вы уверены что хотите удалить запись о ребенке {child.person.FullName}?");
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
            if (ListViewChildren.SelectedItem is Children child)
            {
                AppFrame.frameMain.Navigate(new AddEditWindow(child));
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
            sheet.Cells[3, 1] = "ФИО";
            sheet.Cells[3, 2] = "Пол";
            sheet.Cells[3, 3] = "Адрес проживания";
            var childrens = new List<Children>();
            if (selectedGroup.group_name != "Все")
            {
                childrens.AddRange(_childrens.Where(x => x.id_group == selectedGroup.id_group).ToList());
            }
            else
            {
                childrens.AddRange(_childrens);
            }
            var rowIndex = 4;

            foreach (var child in childrens)
            {
                sheet.Cells[rowIndex, 1] = child.person.FullName;
                sheet.Cells[rowIndex, 2] = child.person.sex_name;
                sheet.Cells[rowIndex, 3] = child.person.address.FullName;

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
            var list = _childrens.Where(x => x.person.FullName.ToLower().Contains(SearchTB.Text.ToLower())).ToList();

            if (GroupCB.SelectedItem is Group group && group.id_group != 0)
            {
                list = list.Where(x => x.id_group == group.id_group).ToList();
            }
            ListViewChildren.ItemsSource = list;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AttendancePage());
        }

        private void NavigateToGroupPage(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new GroupsPage());
        }

        private void NavigateToEducatorsPage(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EducatorsPage());
        }

        private void NavigateToMoreInformation(object sender, RoutedEventArgs e)
        {
            if(ListViewChildren.SelectedItem is Children childrens)
            {
                ParentsWindow window = new ParentsWindow(childrens);
                window.ShowInTaskbar = true;
                window.ShowDialog();
            }
            
        }
    }
}
