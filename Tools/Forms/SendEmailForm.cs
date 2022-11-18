using LV.Common.Services;
using LV.Common.Values;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ToolsWinApp.Models;
using ToolsWinApp.Services;

namespace ToolsWinApp.Forms
{
    public partial class SendEmailForm : Form
    {
        protected IEnumerable<string> Attachments { get; set; } = null;

        protected SMTPServerConfig _smtpConfig = null;

        protected SMTPServerConfig SMTPConfig
        {
            get { return _smtpConfig; }
            set
            {
                _smtpConfig = value;

                this.textBoxConnectionString.Text = _smtpConfig == null ? "" : CommonService.Serialize(_smtpConfig);
            }
        }

        public SendEmailForm()
        {
            InitializeComponent();

            CommonService.JsonConverters.Add(new StringEnumConverter() { AllowIntegerValues = true });
           
            var smtpConfigText = System.Configuration.ConfigurationManager.AppSettings["SMTPServerConfig"];

            if (String.IsNullOrWhiteSpace(smtpConfigText))
                this.SMTPConfig = new SMTPServerConfig();
            else
                this.SMTPConfig = CommonService.Deserialize<SMTPServerConfig>(smtpConfigText);

            var now = DateTime.Now;
            this.textBoxSubject.Text = $"Test Subject: {now}";
            this.textBoxBody.Text = $"Test Body: {now}";
        }

        private void buttonAttachmentsBrowse_Click(object sender, EventArgs e)
        {
            if (this.openFileDialogAttachments.ShowDialog() != DialogResult.OK)
                return;

            this.Attachments = this.openFileDialogAttachments.FileNames;
            this.textBoxAttachments.Text = String.Join(Environment.NewLine, this.Attachments);
        }

        private void buttonAttachmentsClear_Click(object sender, EventArgs e)
        {
            this.Attachments = null;
            this.textBoxAttachments.Text = "";
        }

        private void buttonConnectionStringModify_Click(object sender, EventArgs e)
        {
            var dialog = new SMTPServerConfigForm();
            dialog.SMTPConfig = this.SMTPConfig;
            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            this.SMTPConfig = dialog.SMTPConfig;
        }

        private IEnumerable<FileData> GetAttachments()
        {
            if (this.Attachments == null || this.Attachments.Count() <= 0)
                return null;

            var attachments = new List<FileData>();
            foreach (var att in this.Attachments)
                attachments.Add(new FileData(att, File.ReadAllBytes(att)));

            return attachments;
        }

        private void buttonSendEmail_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.textBoxRecipient.Text))
            {
                MessageBox.Show("Please, select Recipient!", "ERROR");
                return;
            }
            if (String.IsNullOrWhiteSpace(this.textBoxSubject.Text))
            {
                MessageBox.Show("Please, type in the Subject!", "ERROR");
                return;
            }
            if (String.IsNullOrWhiteSpace(this.textBoxBody.Text))
            {
                MessageBox.Show("Please, type in some Body text!", "ERROR");
                return;
            }

            try
            {
                var emailService = new EmailNotificationService(this.SMTPConfig);
                emailService.SendEmail(
                    this.textBoxSubject.Text,
                    this.textBoxBody.Text,
                    this.textBoxRecipient.Text,
                    attachments: this.GetAttachments());

                MessageBox.Show("Email was sent successfully!", "SUCCESS");
            }
            catch(Exception ex)
            {
                MessageBox.Show(CommonService.GetErrorMessage(ex), "ERROR");
            }
        }
    }
}
