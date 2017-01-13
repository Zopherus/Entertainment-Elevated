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
                    ScheduleDataGridView.Rows[i].Cells[j].ToolTipText = "eg:  9:00 AM-5:00 PM";
                }
            }
            DisplayShifts();
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
            DisplayShifts();
        }

        private void ScheduleDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Get the text that the user has edited
                string text = ScheduleDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToLower();
                if (text == "")
                    return;

                // Remove all whitespace in the text by using a regular expression
                text = Regex.Replace(text, @"\s+", "");

                // Get the column header of the column which has the day of the shift
                DateTime day = DateTime.Parse(ScheduleDataGridView.Columns[e.ColumnIndex].HeaderText);

                // Split the text at the hyphen
                string[] times = text.Split('-');

                //Find the number of hours from the start of the day that the shift starts and ends
                int startHours = DateTime.Parse(times[0]).Hour;

                int endHours = DateTime.Parse(times[1]).Hour;


                // Create new DateTimes for the starting and ending of the shift and create the shift
                DateTime start = new DateTime(day.Year, day.Month, day.Day, startHours, 0, 0);
                DateTime end = new DateTime(day.Year, day.Month, day.Day, endHours, 0, 0);
                Shift shift = new Shift(start, end);

                // Find which employee to add the shift to by searching through the Employee list
                string employeeName = ScheduleDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                foreach (Employee employee in EmployeeForm.Employees)
                {
                    if (employee.GetName() == employeeName)
                    {
                        employee.Shifts.Add(shift);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please check the entered text.");
            }
        }

        private void DisplayShifts()
        {
            // Clear the DataGridView
            for (int i = 1; i < ScheduleDataGridView.ColumnCount; i++)
            {
                for (int j = 0; j < ScheduleDataGridView.RowCount; j++)
                {
                    ScheduleDataGridView.Rows[j].Cells[i].Value = "";
                }
            }
            foreach (Employee employee in EmployeeForm.Employees)
            {
                for (int i = 0; i < 7; i++)
                {
                    DateTime day = ScheduleCalendar.SelectionStart.AddDays(i);
                    foreach (Shift shift in employee.Shifts)
                    {
                        if (shift.StartTime.DayOfYear == day.DayOfYear && shift.StartTime.Year == day.Year)
                        {
                            foreach (DataGridViewRow row in ScheduleDataGridView.Rows)
                            {
                                if (row.Cells[0].Value.ToString() == employee.GetName())
                                {
                                    string text = "";
                                    text = shift.StartTime.ToShortTimeString();
                                    text += "-";
                                    text += shift.EndTime.ToShortTimeString();
                                    row.Cells[i + 1].Value = text;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printSchools;
            printPreviewDialog1.ShowDialog();
        }

        private void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Print a list of all current courses.
            Font printFont = new Font("Arial", 10);
            Font headingFont = new Font("Arial", 14, FontStyle.Bold);

            float verticalPrintPositionFloat = e.MarginBounds.Top;
            float horizontalPrintPositionFloat = e.MarginBounds.Left;

            float col2 = horizontalPrintPositionFloat + 200;
            float col3 = col2 + 100;

            float lineHeightFloat = printFont.GetHeight();

            // Print heading.
            e.Graphics.DrawString("Current School List As of " + DateTime.Now.ToShortDateString(),
                                  headingFont,
                                  Brushes.Black,
                                  horizontalPrintPositionFloat,
                                  verticalPrintPositionFloat);

            //double spacing between lines of text
            verticalPrintPositionFloat += 2 * lineHeightFloat;

            // Loop through the list to print all courses.
            for (int indexInteger = 0; indexInteger < comboBoxSchools.Items.Count; indexInteger++)
            {
                e.Graphics.DrawString(comboBoxSchools.Items[indexInteger].ToString(),
                                      printFont,
                                      Brushes.Black,
                                      horizontalPrintPositionFloat,
                                      verticalPrintPositionFloat);
                verticalPrintPositionFloat += 2 * lineHeightFloat;
            }

            // Print heading.
            e.Graphics.DrawString(textBoxName.Text,
                                  printFont,
                                  Brushes.Aquamarine,
                                  horizontalPrintPositionFloat,
                                  verticalPrintPositionFloat);

            e.Graphics.DrawString(textBoxName.Text,
                                  printFont,
                                  Brushes.Green,
                                  col2,
                                  verticalPrintPositionFloat);

            e.Graphics.DrawString(textBoxName.Text,
                                  printFont,
                                  Brushes.Red,
                                  col3,
                                  verticalPrintPositionFloat);
        }
    }
}
