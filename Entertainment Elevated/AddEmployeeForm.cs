using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entertainment_Elevated
{
    public partial class AddEmployeeForm : Form
    {
        private List<string> Positions = new List<string>();
        DataGridView gridView;
        //Pass in the employee datagridview from the employeeForm to refresh it
        public AddEmployeeForm(DataGridView GridView)
        {
            InitializeComponent();
            gridView = GridView;
        } 

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader streamReader = new StreamReader("Positions.txt");
                string line = streamReader.ReadLine();
                while (line != null)
                {
                    Positions.Add(line);
                    line = streamReader.ReadLine();
                }
                streamReader.Close();
            }
            catch
            { }
            PositionListView.Items.Add(Positions[0]);
            PositionListView.Items.Add(Positions[1]);
            PositionListView.Items.Add(Positions[2]);
        }

        private void AddEmployeeForm_FormClosed(object sender, EventArgs e)
        {
            StreamWriter streamWriter = new StreamWriter("Positions.txt");
            foreach(string position in Positions)
            {
                streamWriter.WriteLine(position);
            }
            streamWriter.Close();
            gridView.DataSource = null;
            gridView.DataSource = EmployeeForm.Employees;
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee(FirstNameTextBox.Text, LastNameTextBox.Text, PhoneNumberTextBox.Text,PhoneNumberTextBox.Text, PositionListView.SelectedItems[0].ToString());
            EmployeeForm.Employees.Add(employee);
            this.Close();
        }
    }
}
