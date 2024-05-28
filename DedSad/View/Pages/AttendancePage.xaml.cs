using DedSad.Models;
using DedSad.Repository;
using Microsoft.Win32;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Excel = Microsoft.Office.Interop.Excel;

namespace DedSad.View.Pages
{
    public partial class AttendancePage : Page
    {
        private readonly List<Models.Attendance> _attendances;
        public AttendancePage()
        {
            InitializeComponent();
            _attendances = new List<Models.Attendance>();
            Init();
        }

        private async Task Init()
        {
            var groupRepo = new GroupRepository();
            var repo = new AttendanceRepository();
            var groups = await groupRepo.GetAllAsync();
            groups.Insert(0, new Models.Group { group_name = "Все" });
            var items = await repo.GetAllAsync();
            _attendances.AddRange(items);
            ListViewChildren.ItemsSource = items;

            GroupCB.ItemsSource = groups;
            GroupCB.SelectedIndex = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain.Navigate(new AdminPage());
        }

        private void ExcelButton_Click(object sender, RoutedEventArgs e)
        {
            Excel.Application app = new Excel.Application()
            {
                SheetsInNewWorkbook = 1
            };
            var workBook = app.Workbooks.Add();

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx";

            if (saveFileDialog.ShowDialog() == false)
            {
                return;
            }

            app.DisplayAlerts = false;

            Excel.Worksheet sheet = (Excel.Worksheet)app.Worksheets.get_Item(1);
            sheet.Name = "Посещение";
            if (!StartDate.SelectedDate.HasValue)
            {
                MessageBox.Show("Выберите дату начала");
                return;
            }

            if (!EndDate.SelectedDate.HasValue)
            {
                MessageBox.Show("Выберите дату конца");
                return;
            }
            var dateStart = StartDate.SelectedDate.Value;
            var dateEnd = EndDate.SelectedDate.Value;
            var items = _attendances.Where(x => x.date >= dateStart && x.date <= dateEnd).ToList();

            var group = GroupCB.SelectedItem as Models.Group;
            if (group == null)
            {
                MessageBox.Show("Выберите группу!");
                return;
            }

            if (group.id_group != 0)
            {
                items = items.Where(x => x.children.id_group == group.id_group).ToList();
                sheet.Cells[1, 1] = "Группа";
                sheet.Cells[1, 2] = group.group_name;
            }
            else
            {
                items = items.OrderBy(x => x.children.id_group).ToList();
                sheet.Cells[1, 1] = "Все группы";
            }

            sheet.Cells[2, 1] = "ФИО";
            sheet.Cells[2, 2] = "Дата";
            sheet.Cells[2, 3] = "Пометка";
            sheet.Cells[2, 4] = "Причина";
            if (group.id_group == 0)
            {
                sheet.Cells[2, 5] = "Группа";
            }
            for (int i = 0; i < items.Count; i++)
            {
                var item = items[i];
                var rowIndex = i + 3;
                var person = item.children.person;
                sheet.Cells[rowIndex, 1] = person.FullName;
                sheet.Cells[rowIndex, 2] = item.date.ToString("dd MMM yyyy г.");
                sheet.Cells[rowIndex, 3] = item.mark;
                sheet.Cells[rowIndex, 4] = item.reason == null ? "Нет" : item.reason.reason;
                if (group.id_group == 0)
                {
                    sheet.Cells[rowIndex, 5] = item.children.group.group_name;
                }
            }


            app.Visible = true;
            workBook.SaveAs(saveFileDialog.FileName);
        }

        private void GroupCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (GroupCB.SelectedItem is Group group) 
            {
                if (group.group_name == "Все")
                {
                    ListViewChildren.ItemsSource = _attendances.ToList();
                }
                else
                {
                    ListViewChildren.ItemsSource = _attendances.Where(x=>x.children.id_group == group.id_group).ToList();
                }
            }

        }
    }
}
