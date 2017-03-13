using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Entertainment_Elevated
{
    public partial class ScheduleForm : Form
    {
        private decimal hours = 0;
        private decimal pay = 0;

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
                ScheduleDataGridView.Rows[i].Cells[0].Value = EmployeeForm.Employees[i].ToString();

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
            GeneralForm general = (GeneralForm)obj.FindForm();
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

                // Find the number of hours from the start of the day that the shift starts and ends
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
                    // Unfortunately, using employee names to compare employees could cause problems
                    // If there are two employees with the exact same names
                    // However, this will be extremely rare and the workaround to this problem would be complex
                    if (employee.ToString() == employeeName)
                    {
                        // Add the shift to the employee
                        employee.Shifts.Add(shift);
                        return;
                    }
                }

                // Update the shifts
                DisplayShifts();
            }

            // Throw an error and display a popup box if user enters erroneous information
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

            // Reset the hours and pay to recalculate them 
            hours = 0;
            pay = 0;

            // This loop runs in at least cubic worse case time with respect to the number of employees
            // Although this could cause problems if the number of employees or shifts grows large
            // It is highly unlikely for these to be high enough for this loop to cause lag
            
            // Loop through all of the employees
            foreach (Employee employee in EmployeeForm.Employees)
            {
                // Loop through each day
                for (int i = 0; i < 7; i++)
                {
                    DateTime day = ScheduleCalendar.SelectionStart.AddDays(i);

                    // Loop through the shifts
                    foreach (Shift shift in employee.Shifts)
                    {
                        // See if they match up with the current day
                        if (shift.StartTime.DayOfYear == day.DayOfYear && shift.StartTime.Year == day.Year)
                        {
                            // Add to the hours and pay
                            hours += shift.NumberHours();
                            pay += shift.Pay(employee.Payrate);

                            // Loop through the rows of the grid to add the shift onto the GridView
                            foreach (DataGridViewRow row in ScheduleDataGridView.Rows)
                            {
                                // Checking for correct employee
                                if (row.Cells[0].Value.ToString() == employee.ToString())
                                {
                                    string text = "";
                                    text = shift.StartTime.ToShortTimeString();
                                    text += "-";
                                    text += shift.EndTime.ToShortTimeString();

                                    // Increment by one since first cell is employee name
                                    row.Cells[i + 1].Value = text;
                                }
                            }
                        }
                    }
                }
            }

            // Update the labels to show correct total of hours of pay
            HoursLabel.Text = "Hours: " + hours.ToString();
            PayLabel.Text = "Pay: " + pay.ToString("C");
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            // Show the preview of the document to be printed
            PrintPreviewDialog.Document = PrintDocument;
            PrintPreviewDialog.ShowDialog();
        }

        private void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            ScheduleDataGridView.ClearSelection();
            int height = ScheduleDataGridView.Rows.GetRowsHeight(DataGridViewElementStates.None);
            height += ScheduleDataGridView.ColumnHeadersHeight + 2;
            int width = ScheduleDataGridView.Columns.GetColumnsWidth(DataGridViewElementStates.None) + 3;
            ScheduleDataGridView.FindForm().ClientSize = new Size(width, height);
            ScheduleDataGridView.Dock = DockStyle.Fill;
            Bitmap bitmap = new Bitmap(ScheduleDataGridView.Width, ScheduleDataGridView.Height);
            ScheduleDataGridView.DrawToBitmap(bitmap, new Rectangle(0, 0, ScheduleDataGridView.Width, ScheduleDataGridView.Height));
            ScheduleDataGridView.Dock = DockStyle.Top;
            ScheduleDataGridView.FindForm().Width = 600;
            ScheduleDataGridView.FindForm().Height = 500;
            e.Graphics.DrawImage(bitmap, 0, 0);
            Font font = new Font("Arial", 14, FontStyle.Bold);
            float lineHeightFloat = font.GetHeight();
            float verticalPrintPosition = e.MarginBounds.Top + bitmap.Height;
            float horizontalPrintPosition = e.MarginBounds.Left;
            e.Graphics.DrawString("Number of hours: " + hours.ToString(), font, Brushes.Black, 
                horizontalPrintPosition, verticalPrintPosition);
            verticalPrintPosition += 2 * lineHeightFloat;
            e.Graphics.DrawString("Amount of pay: " + pay.ToString("C"), font, Brushes.Black,
                horizontalPrintPosition, verticalPrintPosition);
        }
    }
}
