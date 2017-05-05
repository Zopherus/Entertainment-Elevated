using System;
using System.Windows.Forms;

namespace Entertainment_Elevated
{
    public partial class CustomerDataForm : Form, IPanelForm
    {
        public CustomerDataForm()
        {
            InitializeComponent();
        }

        public Panel Panel()
        {
            return CustomerDataFormPanel;
        }
    }
}
