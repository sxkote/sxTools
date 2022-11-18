using System;
using System.Windows.Forms;
using ToolsWinApp.Forms;

namespace ToolsWinApp
{
    public partial class ToolsWinAppForm : Form
    {
        public ToolsWinAppForm()
        {
            InitializeComponent();
        }

        private void menuSQLExecutor_Click(object sender, EventArgs e)
        {
            (new RunSQLForm()).ShowDialog();
        }

        private void menuEmailSender_Click(object sender, EventArgs e)
        {
            (new SendEmailForm()).ShowDialog();
        }

        private void menuDigitalSigner_Click(object sender, EventArgs e)
        {
            (new SignerForm()).ShowDialog();
        }
    }
}
