
namespace ToolsWinApp
{
    partial class ToolsWinAppForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSQLExecutor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEmailSender = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDigitalSigner = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSQLExecutor,
            this.menuEmailSender,
            this.menuDigitalSigner});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // menuSQLExecutor
            // 
            this.menuSQLExecutor.Name = "menuSQLExecutor";
            this.menuSQLExecutor.Size = new System.Drawing.Size(224, 26);
            this.menuSQLExecutor.Text = "SQL Executor";
            this.menuSQLExecutor.Click += new System.EventHandler(this.menuSQLExecutor_Click);
            // 
            // menuEmailSender
            // 
            this.menuEmailSender.Name = "menuEmailSender";
            this.menuEmailSender.Size = new System.Drawing.Size(224, 26);
            this.menuEmailSender.Text = "Email Sender";
            this.menuEmailSender.Click += new System.EventHandler(this.menuEmailSender_Click);
            // 
            // menuDigitalSigner
            // 
            this.menuDigitalSigner.Name = "menuDigitalSigner";
            this.menuDigitalSigner.Size = new System.Drawing.Size(224, 26);
            this.menuDigitalSigner.Text = "Digital Signer";
            this.menuDigitalSigner.Click += new System.EventHandler(this.menuDigitalSigner_Click);
            // 
            // ToolsWinAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ToolsWinAppForm";
            this.Text = "sxTools Application";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuSQLExecutor;
        private System.Windows.Forms.ToolStripMenuItem menuEmailSender;
        private System.Windows.Forms.ToolStripMenuItem menuDigitalSigner;
    }
}