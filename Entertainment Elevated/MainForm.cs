using System;
using System.Windows.Forms;

namespace Entertainment_Elevated
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // The following four methods are essentially the same
        // All of them use the panel control to switch between pages
        // Easier on the user as there is only one window, not multiple
        private void EmployeeButton_Click(object sender, EventArgs e)
        {
            // Because this method runs when the button is clicked
            // The button is the sender, so this Control will be the button
            Control obj = (Control)sender;

            // This is done so the form of the button can be found
            // This form will always be the blank, GeneralForm so an implicit conversion can be done
            GeneralForm general = (GeneralForm)obj.FindForm();

            // A form of our wanted screen is created
            EmployeeForm employeeForm = new EmployeeForm();

            // All the controls on the GeneralForm are cleared so that the new controls can be added
            general.Controls.Clear();

            // Add the wanted panel onto the GeneralForm to display it
            general.Controls.Add(employeeForm.EmployeeFormPanel);
        }

        private void ScheduleButton_Click(object sender, EventArgs e)
        {
            Control obj = (Control)sender;
            GeneralForm general = (GeneralForm)obj.FindForm();
            ScheduleForm scheduleForm = new ScheduleForm();
            general.Controls.Clear();
            general.Controls.Add(scheduleForm.ScheduleFormPanel);
        }

        private void CustomerButton_Click(object sender, EventArgs e)
        {
            Control obj = (Control)sender;
            GeneralForm general = (GeneralForm)obj.FindForm();
            CustomerForm customerForm = new CustomerForm();
            general.Controls.Clear();
            general.Controls.Add(customerForm.CustomerFormPanel);
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            Control obj = (Control)sender;
            GeneralForm general = (GeneralForm)obj.FindForm();
            HelpForm helpForm = new HelpForm();
            general.Controls.Clear();
            general.Controls.Add(helpForm.HelpFormPanel);
        }
    }
}
