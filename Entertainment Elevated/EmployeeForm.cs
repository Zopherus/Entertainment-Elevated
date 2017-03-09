using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Entertainment_Elevated
{
    public partial class EmployeeForm : Form
    {
        public static List<Employee> Employees = new List<Employee>();
        public EmployeeForm()
        {
            InitializeComponent();
            if (Employees.Count > 0)
                EmployeeDataGridView.DataSource = Employees;
            
            try
            {
                EmployeeDataGridView.Columns["FirstName"].DisplayIndex = 0;
                EmployeeDataGridView.Columns["LastName"].DisplayIndex = 1;
                EmployeeDataGridView.Columns["Email"].DisplayIndex = 2;
                EmployeeDataGridView.Columns["PhoneNumber"].DisplayIndex = 3;
                EmployeeDataGridView.Columns["Payrate"].DisplayIndex = 4;
                EmployeeDataGridView.Columns["Position"].DisplayIndex = 5;
            }
            catch { }
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

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addEmployeeForm = new AddEmployeeForm(EmployeeDataGridView);
            addEmployeeForm.ShowDialog();
        }
    }
}
