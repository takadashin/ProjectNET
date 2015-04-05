namespace Pharmacy.InvoiceSearch
{
    partial class SearchInvoice
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
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_ok = new System.Windows.Forms.Button();
            this.dtv_display = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_invoice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_display)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(462, 208);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_cancel.TabIndex = 16;
            this.bt_cancel.Text = "Cancel";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // bt_ok
            // 
            this.bt_ok.Location = new System.Drawing.Point(362, 208);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(75, 23);
            this.bt_ok.TabIndex = 15;
            this.bt_ok.Text = "Ok";
            this.bt_ok.UseVisualStyleBackColor = true;
            this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // dtv_display
            // 
            this.dtv_display.AllowUserToAddRows = false;
            this.dtv_display.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_display.Location = new System.Drawing.Point(12, 30);
            this.dtv_display.Name = "dtv_display";
            this.dtv_display.ReadOnly = true;
            this.dtv_display.Size = new System.Drawing.Size(531, 160);
            this.dtv_display.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Invoices";
            // 
            // tb_invoice
            // 
            this.tb_invoice.Location = new System.Drawing.Point(69, 4);
            this.tb_invoice.Name = "tb_invoice";
            this.tb_invoice.Size = new System.Drawing.Size(474, 20);
            this.tb_invoice.TabIndex = 12;
            this.tb_invoice.TextChanged += new System.EventHandler(this.tb_invoice_TextChanged);
            // 
            // SearchInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 239);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.dtv_display);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_invoice);
            this.Name = "SearchInvoice";
            this.Text = "SearchInvoice";
            ((System.ComponentModel.ISupportInitialize)(this.dtv_display)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.DataGridView dtv_display;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_invoice;
    }
}