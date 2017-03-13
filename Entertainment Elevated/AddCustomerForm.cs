using System;
using System.Windows.Forms;

namespace Entertainment_Elevated
{
    public partial class AddCustomerForm : Form
    {
        public AddCustomerForm()
        {
            InitializeComponent();
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (FirstNameTextBox.Text == "")
                    MessageBox.Show("Please enter a first name.");
                if (LastNameTextBox.Text == "")
                    MessageBox.Show("Please enter a last name.");
                // Create a new customer object and add it to the Customers list
                Customer customer = new Customer(FirstNameTextBox.Text, LastNameTextBox.Text, PhoneNumberTextBox.Text, EmailTextBox.Text);
                CustomerForm.Customers.Add(customer);
            }
            catch
            {
                // Throw an error and display a popup box if user enters erroneous information
                MessageBox.Show("Please check entered data.");
                return;
            }

            Close();
        }
    }
}
