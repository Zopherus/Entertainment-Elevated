using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entertainment_Elevanted
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            //this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        private void EmployeeButton_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm();
            Controls.Clear();
            Controls.Add(employeeForm.EmployeeFormPanel);
            BackButton.BringToFront();
        }

        private void ScheduleButton_Click(object sender, EventArgs e)
        {
            ScheduleForm scheduleForm = new ScheduleForm();
            Controls.Clear();
            Controls.Add(scheduleForm.ScheduleFormPanel);
            BackButton.BringToFront();
        }

        private void CustomerButton_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            Controls.Clear();
            Controls.Add(customerForm.CustomerFormPanel);
            BackButton.BringToFront();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
