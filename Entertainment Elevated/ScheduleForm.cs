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
    public partial class ScheduleForm : Form
    {
        public ScheduleForm()
        {
            InitializeComponent();
            ScheduleDataGridView.Columns.Add("Name", "Name");
            for (int i = 1; i <= 7; i++)
            {

            }
            for (int i = 0; i < EmployeeForm.Employees.Count; i++)
            {
                ScheduleDataGridView.Rows.Add();
                ScheduleDataGridView.Rows[i].Cells[0].Value = EmployeeForm.Employees[i].GetName();
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
    }
}
