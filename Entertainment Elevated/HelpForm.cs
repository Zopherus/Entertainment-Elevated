using System;
using System.Windows.Forms;

namespace Entertainment_Elevated
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            Control obj = (Control)sender;
            GeneralForm general = (GeneralForm)obj.FindForm();
            MainForm mainForm = new MainForm();
            general.Controls.Clear();
            general.Controls.Add(mainForm.MainFormPanel);
        }
    }
}
