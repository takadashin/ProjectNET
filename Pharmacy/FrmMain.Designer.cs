namespace Pharmacy
{
    partial class FrmMain
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
            this.MnFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MnItemLog = new System.Windows.Forms.ToolStripMenuItem();
            this.MnItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MnManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.MnItemAccounts = new System.Windows.Forms.ToolStripMenuItem();
            this.MnItemDrugs = new System.Windows.Forms.ToolStripMenuItem();
            this.MnItemCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.MnItemInvoive = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnFile,
            this.MnManagement});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(719, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MnFile
            // 
            this.MnFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnItemLog,
            this.MnItemExit});
            this.MnFile.Name = "MnFile";
            this.MnFile.Size = new System.Drawing.Size(37, 20);
            this.MnFile.Text = "File";
            // 
            // MnItemLog
            // 
            this.MnItemLog.Name = "MnItemLog";
            this.MnItemLog.Size = new System.Drawing.Size(107, 22);
            this.MnItemLog.Text = "Log In";
            this.MnItemLog.Click += new System.EventHandler(this.MnItemLog_Click);
            // 
            // MnItemExit
            // 
            this.MnItemExit.Name = "MnItemExit";
            this.MnItemExit.Size = new System.Drawing.Size(107, 22);
            this.MnItemExit.Text = "Exit";
            this.MnItemExit.Click += new System.EventHandler(this.MnItemExit_Click);
            // 
            // MnManagement
            // 
            this.MnManagement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnItemAccounts,
            this.MnItemDrugs,
            this.MnItemCustomers,
            this.MnItemInvoive});
            this.MnManagement.Name = "MnManagement";
            this.MnManagement.Size = new System.Drawing.Size(90, 20);
            this.MnManagement.Text = "Management";
            // 
            // MnItemAccounts
            // 
            this.MnItemAccounts.Name = "MnItemAccounts";
            this.MnItemAccounts.Size = new System.Drawing.Size(152, 22);
            this.MnItemAccounts.Text = "Accounts";
            this.MnItemAccounts.Click += new System.EventHandler(this.MnItemAccounts_Click);
            // 
            // MnItemDrugs
            // 
            this.MnItemDrugs.Name = "MnItemDrugs";
            this.MnItemDrugs.Size = new System.Drawing.Size(152, 22);
            this.MnItemDrugs.Text = "Drugs";
            // 
            // MnItemCustomers
            // 
            this.MnItemCustomers.Name = "MnItemCustomers";
            this.MnItemCustomers.Size = new System.Drawing.Size(152, 22);
            this.MnItemCustomers.Text = "Customers";
            this.MnItemCustomers.Click += new System.EventHandler(this.MnItemCustomers_Click);
            // 
            // MnItemInvoive
            // 
            this.MnItemInvoive.Name = "MnItemInvoive";
            this.MnItemInvoive.Size = new System.Drawing.Size(152, 22);
            this.MnItemInvoive.Text = "Invoive";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 468);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnFile;
        private System.Windows.Forms.ToolStripMenuItem MnItemLog;
        private System.Windows.Forms.ToolStripMenuItem MnItemExit;
        private System.Windows.Forms.ToolStripMenuItem MnManagement;
        private System.Windows.Forms.ToolStripMenuItem MnItemAccounts;
        private System.Windows.Forms.ToolStripMenuItem MnItemDrugs;
        private System.Windows.Forms.ToolStripMenuItem MnItemCustomers;
        private System.Windows.Forms.ToolStripMenuItem MnItemInvoive;

    }
}