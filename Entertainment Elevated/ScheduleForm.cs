using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entertainment_Elevated
{
    public partial class ScheduleForm : Form
    {
        public ScheduleForm()
        {
            InitializeComponent();
            ScheduleDataGridView.Columns.Add("Name", "Name");
            DateTime today = DateTime.Today;
            for (int i = 0; i < 7; i++)
            {
                ScheduleDataGridView.Columns.Add(today.AddDays(i).ToShortDateString(), today.AddDays(i).ToShortDateString());
            }
            for (int i = 0; i < EmployeeForm.Employees.Count; i++)
            {
                ScheduleDataGridView.Rows.Add();
                ScheduleDataGridView.Rows[i].Cells[0].Value = EmployeeForm.Employees[i].GetName();

                for (int j = 1; j <= 7; j++)
                {
                    ScheduleDataGridView.Rows[i].Cells[j].ToolTipText = "eg:  8am - 4pm";
                }
            }

        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            Control obj = (Control)sender;
            Form form = obj.FindForm();
            GeneralForm general = (GeneralForm)form;
            MainForm mainForm = new MainForm();
            general.Controls.Clear();
            general.Controls.Add(mainForm.MainFormPanel);
        }

        private void ScheduleCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            for (int i = 1; i < ScheduleDataGridView.ColumnCount; i++)
            {
                ScheduleDataGridView.Columns[i].Name = ScheduleCalendar.SelectionStart.AddDays(i - 1).ToShortDateString();
                ScheduleDataGridView.Columns[i].HeaderText = ScheduleCalendar.SelectionStart.AddDays(i - 1).ToShortDateString();
            }
        }

        private void ScheduleDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
                // Get the text that the user has edited
                string text = ScheduleDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToLower();

                // Remove all whitespace in the text by using a regular expression
                text = Regex.Replace(text, @"\s+", "");

                // Get the column header of the column which has the day of the shift
                DateTime day = DateTime.Parse(ScheduleDataGridView.Columns[e.ColumnIndex].HeaderText);

                // Split the text at the hyphen
                string[] times = text.Split('-');
            
                int startHours = int.Parse(string.Concat(times[0].TakeWhile(c => char.IsDigit(c)))) + 
                    (times[0].First(c => char.IsLetter(c)) == 'p' ? 12 : 0);

                int endHours = int.Parse(string.Concat(times[1].TakeWhile(c => char.IsDigit(c)))) +
                    (times[1].First(c => char.IsLetter(c)) == 'p' ? 12 : 0);

                DateTime start = new DateTime(day.Year, day.Month, day.Day, startHours, 0, 0);
                DateTime end = new DateTime(day.Year, day.Month, day.Day, endHours, 0, 0);
                Shift shift = new Shift(start, end);

                string employeeName = ScheduleDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                foreach (Employee employee in EmployeeForm.Employees)
                {
                    if (employee.GetName() == employeeName)
                    {
                        employee.shifts.Add(shift);
                    }
                }
            //}
            //catch
            //{
           //     MessageBox.Show("Please check the entered text.");
           // }
        }
    }
}
