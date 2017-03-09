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
        public List<string> Positions { get; private set; } = new List<string>();
        private DataGridView gridView;
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
            PositionComboBox.Items.AddRange(Positions.ToArray());
        }

        private void AddEmployeeForm_FormClosed(object sender, EventArgs e)
        {
            StreamWriter streamWriter = new StreamWriter("Positions.txt");
            foreach(string position in Positions)
            {
                if (position != "")
                    streamWriter.WriteLine(position);
            }
            streamWriter.Close();
            gridView.DataSource = null;
            gridView.DataSource = EmployeeForm.Employees;

            gridView.Columns["FirstName"].DisplayIndex = 0;
            gridView.Columns["LastName"].DisplayIndex = 1;
            gridView.Columns["Email"].DisplayIndex = 2;
            gridView.Columns["PhoneNumber"].DisplayIndex = 3;
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            if (!PositionComboBox.Items.Contains(PositionComboBox.Text))
                Positions.Add(PositionComboBox.Text);
            Employee employee = new Employee(FirstNameTextBox.Text, LastNameTextBox.Text, PhoneNumberTextBox.Text, EmailTextBox.Text, PositionComboBox.Text, decimal.Parse(PayrateTextbox.Text));
            EmployeeForm.Employees.Add(employee);
            Close();
        }
    }
}
