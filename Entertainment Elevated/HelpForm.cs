using System;
using System.Windows.Forms;
using static Entertainment_Elevated.ChangeFormPanel;

namespace Entertainment_Elevated
{
    public partial class HelpForm : Form, IPanelForm
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            ChangeFormPanels<MainForm>(sender);
        }

        // To satisfy the IPanelForm interface requirement
        public Panel Panel()
        {
            return HelpFormPanel;
        }
    }
}
