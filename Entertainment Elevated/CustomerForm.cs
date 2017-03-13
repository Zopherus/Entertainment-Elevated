using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Entertainment_Elevated
{
    public partial class CustomerForm : Form
    {
        // Is a consideration to use a hash table here, especially if the customer list becomes larger and larger
        // But hashing the names of the customers does not allow searching for part of a customer's name
        // Best compromise is to use a sorted alphabetically list for logarithmic search time
        public static List<Customer> Customers = new List<Customer>();

        public CustomerForm()
        {
            InitializeComponent();
            foreach (Customer customer in Customers)
            {
                CustomerListBox.Items.Add(customer);
            }
        }

        

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            RefreshListBox();
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            AddCustomerForm addCustomerForm = new AddCustomerForm();
            addCustomerForm.ShowDialog();
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog.Document = PrintDocument;
            PrintPreviewDialog.ShowDialog();
        }

        private void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 14, FontStyle.Bold);
            float lineHeightFloat = font.GetHeight();
            float verticalPrintPosition = e.MarginBounds.Top;
            float horizontalPrintPosition = e.MarginBounds.Left;
            foreach (Customer customer in Customers)
            {
                e.Graphics.DrawString(customer.ToString() + ": " + customer.StoreVisits.Count.ToString(), font, Brushes.Black,
                        horizontalPrintPosition, verticalPrintPosition);
                verticalPrintPosition += 2 * lineHeightFloat;
            }
        }

        private void AddVisitButton_Click(object sender, EventArgs e)
        {
            try
            {
                ((Customer)CustomerListBox.SelectedItem).StoreVisits.Add(new StoreVisit(DateTime.Now));
            }
            catch
            {
                MessageBox.Show("Please select a customer");
            }
        }

        public void RefreshListBox()
        {
            CustomerListBox.Items.Clear();
            foreach (Customer customer in Customers)
            {
                if (customer.ToString().ToLower().Contains(SearchTextBox.Text.ToLower()))
                    CustomerListBox.Items.Add(customer);
            }
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            Control obj = (Control)sender;
            GeneralForm general = (GeneralForm)obj.FindForm();
            MainForm mainForm = new MainForm();
            general.Controls.Clear();
            general.Controls.Add(mainForm.MainFormPanel);
        }

        private void CustomerData_Click(object sender, EventArgs e)
        {
            Control obj = (Control)sender;
            GeneralForm general = (GeneralForm)obj.FindForm();
            CustomerDataForm customerDataForm = new CustomerDataForm();
            general.Controls.Clear();
            general.Controls.Add(customerDataForm.CustomerDataFormPanel);
        }
    }
}
