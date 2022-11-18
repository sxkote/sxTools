using System.Net;
using System.Windows.Forms;
using ToolsWinApp.Models;

namespace ToolsWinApp.Forms
{
    public partial class SMTPServerConfigForm : Form
    {
        //public string From
        //{
        //    get { return this.textBoxFrom.Text; }
        //    set { this.textBoxFrom.Text = value; }
        //}
        //public string Server
        //{
        //    get { return this.textBoxServer.Text; }
        //    set { this.textBoxServer.Text = value; }
        //}
        //public int Port
        //{
        //    get { return (int)this.numericUpDownPort.Value; }
        //    set { this.numericUpDownPort.Value = value; }
        //}
        //public bool SSL
        //{
        //    get { return this.checkBoxSSL.Checked; }
        //    set { this.checkBoxSSL.Checked = value; }
        //}
        //public string Login
        //{
        //    get { return this.textBoxLogin.Text; }
        //    set { this.textBoxLogin.Text = value; }
        //}
        //public string Password
        //{
        //    get { return this.textBoxPassword.Text; }
        //    set { this.textBoxPassword.Text = value; }
        //}

        public SMTPServerConfig SMTPConfig
        {
            get
            {
                return new SMTPServerConfig()
                {
                    From = this.textBoxFrom.Text,
                    Server = this.textBoxServer.Text,
                    Port = (int)this.numericUpDownPort.Value,
                    SSL = this.checkBoxSSL.Checked,
                    Login = this.textBoxLogin.Text,
                    Password = this.textBoxPassword.Text,
                    SecurityProtocol = this.SecurityProtocol
                };
            }
            set
            {
                if (value == null)
                    return;

                this.textBoxFrom.Text = value.From;
                this.textBoxServer.Text = value.Server;
                this.numericUpDownPort.Value = value.Port;
                this.checkBoxSSL.Checked = value.SSL;
                this.textBoxLogin.Text = value.Login;
                this.textBoxPassword.Text = value.Password;
                this.SecurityProtocol = value.SecurityProtocol;
            }
        }

        public SecurityProtocolType SecurityProtocol
        {
            get 
            {
                SecurityProtocolType result = 0;
                if (this.checkBoxUseTLS12.Checked)
                    result = result | SecurityProtocolType.Tls12;
                if (this.checkBoxUseTLS11.Checked)
                    result = result | SecurityProtocolType.Tls11;
                if (this.checkBoxUseTLS10.Checked)
                    result = result | SecurityProtocolType.Tls;
                if (this.checkBoxUseSSL3.Checked)
                    result = result | SecurityProtocolType.Ssl3;
                return result;
            }
            set {
                this.checkBoxUseTLS12.Checked = value.HasFlag(SecurityProtocolType.Tls12);
                this.checkBoxUseTLS11.Checked = value.HasFlag(SecurityProtocolType.Tls11);
                this.checkBoxUseTLS10.Checked = value.HasFlag(SecurityProtocolType.Tls);
                this.checkBoxUseSSL3.Checked = value.HasFlag(SecurityProtocolType.Ssl3);
            }
        }


        public SMTPServerConfigForm()
        {
            InitializeComponent();
        }
    }
}
