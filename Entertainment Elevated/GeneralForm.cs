using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Entertainment_Elevated
{
    public partial class GeneralForm : Form
    {
        public GeneralForm()
        {
            MainForm mainForm = new MainForm();
            Controls.Clear();
            Controls.Add(mainForm.MainFormPanel);
            InitializeComponent();
        }

        // Load the employee XML file
        private void GeneralForm_Load(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Employee>));

            try
            {
                using (FileStream fileStream = File.OpenRead("Employees.xml"))
                {
                    if (fileStream.Length == 0)
                        return;
                    List<Employee> deserializedList = (List<Employee>)serializer.Deserialize(fileStream);
                    EmployeeForm.Employees = deserializedList;
                } 
            }
            catch
            {
                Console.WriteLine("XML Error");
            }
            

        }

        // Save the employee data in an XML file
        private void GeneralForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Employee>));
            using (FileStream fileStream = File.OpenWrite("Employees.xml"))
            {
                serializer.Serialize(fileStream, EmployeeForm.Employees);
            }
        }
    }
}
