using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static Entertainment_Elevated.ChangeFormPanel;

namespace Entertainment_Elevated
{
    public partial class CustomerDataForm : Form, IPanelForm
    {
        public CustomerDataForm()
        {
            InitializeComponent();

            // Initialize the ComboBox
            DayOfWeekComboBox.SelectedIndex = 0;

            // Initialize the Chart
            // Set the X-axis to be in short formatted hours
            CustomerDataChart.ChartAreas[0].AxisX.LabelStyle.IntervalType = DateTimeIntervalType.Hours;
            CustomerDataChart.ChartAreas[0].AxisX.LabelStyle.Format = "t";

            // The day starts at midnight and ends at 11pm
            DateTime minTime = new DateTime(1, 1, 1, 0, 0, 0);
            DateTime maxTime = new DateTime(1, 1, 1, 23, 0, 0);
            CustomerDataChart.ChartAreas[0].AxisX.Minimum = minTime.ToOADate();
            CustomerDataChart.ChartAreas[0].AxisX.Maximum = maxTime.ToOADate();

            // The chart will have an interval of 6 hours
            CustomerDataChart.ChartAreas[0].AxisX.Interval = 3;
        }

        private void DayOfWeekComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the day of the week from the ComboBox
            DayOfWeek dayOfWeek = (DayOfWeek)DayOfWeekComboBox.SelectedIndex;

            // Clear all other series
            CustomerDataChart.Series.Clear();

            // Add a new series with the name of the selected day
            Series series = CustomerDataChart.Series.Add(DayOfWeekComboBox.Text);

            // The chart type is column and the x values are time
            series.ChartType = SeriesChartType.Column;
            series.XValueType = ChartValueType.Time;

            // Loop through the jagged array of CustomerAttendance to find the frequency of customers on this day
            for (int i = 0; i < CustomerForm.CustomerAttendance[0].Length; i++)
            {
                // Only add the point into the chart if it is not 0
                if (CustomerForm.CustomerAttendance[DayOfWeekComboBox.SelectedIndex][i] != 0)
                    series.Points.AddXY(new DateTime(1, 1, 1, i, 0, 0), CustomerForm.CustomerAttendance[DayOfWeekComboBox.SelectedIndex][i]);
            }
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            ChangeFormPanels<MenuForm>(sender);
        }

        private void CustomerButton_Click(object sender, EventArgs e)
        {
            ChangeFormPanels<CustomerForm>(sender);
        }

        public Panel Panel()
        {
            return CustomerDataFormPanel;
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            // Show the preview of the document to be printed
            PrintPreviewDialog.Document = PrintDocument;
            PrintPreviewDialog.ShowDialog();
        }

        private void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Get the height of the chart
            int height = CustomerDataChart.Size.Height;

            // Get the width of the chart
            int width = CustomerDataChart.Width;

            // Resize the form of the chart to the size specified above
            CustomerDataChart.FindForm().ClientSize = new Size(width, height);

            // Fill the whole form with the chart
            CustomerDataChart.Dock = DockStyle.Fill;

            // Create a new bitmap that encompasses the whole chart
            Bitmap bitmap = new Bitmap(CustomerDataChart.Width, CustomerDataChart.Height);

            // Draws the whole chart onto the bitmap
            CustomerDataChart.DrawToBitmap(bitmap, new Rectangle(0, 0, CustomerDataChart.Width, CustomerDataChart.Height));

            // Reset the position of the chart in the form
            CustomerDataChart.Dock = DockStyle.None;

            // Reset the size of the form
            CustomerDataChart.FindForm().Width = GeneralForm.FORMWIDTH;
            CustomerDataChart.FindForm().Height = GeneralForm.FORMHEIGHT;

            // Draw the bitmap image onto the page
            e.Graphics.DrawImage(bitmap, 0, 0);

            // Create a font to write with 
            Font font = new Font("Arial", 18, FontStyle.Bold);

            // Where to write
            // Shift vertical position down to bottom of bitmap
            float verticalPrintPosition = e.MarginBounds.Top + bitmap.Height;
            float horizontalPrintPosition = e.MarginBounds.Left;

            // Write the number of hours onto the page in the specified positions
            e.Graphics.DrawString(DayOfWeekComboBox.Text, font, Brushes.Black,
                horizontalPrintPosition, verticalPrintPosition);

        }
    }
}
