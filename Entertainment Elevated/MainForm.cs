using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entertainment_Elevated
{
    public enum Page { Main, Employee, Schedule, Customer};
    public partial class MainForm : Form
    {
        public Page page;
        public MainForm()
        {
            //this.WindowState = FormWindowState.Maximized;
            page = Page.Main;
            InitializeComponent();
        }

        private void EmployeeButton_Click(object sender, EventArgs e)
        {
            Control obj = (Control)sender;
            Form form = obj.FindForm();
            GeneralForm general = (GeneralForm)form;
            EmployeeForm employeeForm = new EmployeeForm();
            general.Controls.Clear();
            general.Controls.Add(employeeForm.EmployeeFormPanel);
        }

        private void ScheduleButton_Click(object sender, EventArgs e)
        {
            Control obj = (Control)sender;
            Form form = obj.FindForm();
            GeneralForm general = (GeneralForm)form;
            ScheduleForm scheduleForm = new ScheduleForm();
            general.Controls.Clear();
            general.Controls.Add(scheduleForm.ScheduleFormPanel);
        }

        private void CustomerButton_Click(object sender, EventArgs e)
        {
            Control obj = (Control)sender;
            Form form = obj.FindForm();
            GeneralForm general = (GeneralForm)form;
            CustomerForm customerForm = new CustomerForm();
            general.Controls.Clear();
            general.Controls.Add(customerForm.CustomerFormPanel);
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            QuitButton.FindForm().Close();
        }
    }
}
