namespace Pharmacy
{
    partial class FrmInvoiceManager
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_refund = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_des = new System.Windows.Forms.TextBox();
            this.tb_docdes = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lb_docname = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lb_total = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lb_user = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_createdate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_cus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_ID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtv_init = new System.Windows.Forms.DataGridView();
            this.bt_refund = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_exit = new System.Windows.Forms.Button();
            this.bt_search = new System.Windows.Forms.Button();
            this.bt_next = new System.Windows.Forms.Button();
            this.bt_pre = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_init)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_refund);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_des);
            this.groupBox1.Controls.Add(this.tb_docdes);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.lb_docname);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lb_total);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lb_user);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lb_createdate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lb_cus);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lb_ID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(663, 226);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Invoices Information";
            // 
            // cb_refund
            // 
            this.cb_refund.AutoSize = true;
            this.cb_refund.Location = new System.Drawing.Point(54, 190);
            this.cb_refund.Name = "cb_refund";
            this.cb_refund.Size = new System.Drawing.Size(15, 14);
            this.cb_refund.TabIndex = 18;
            this.cb_refund.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Refund";
            // 
            // tb_des
            // 
            this.tb_des.Location = new System.Drawing.Point(385, 116);
            this.tb_des.Multiline = true;
            this.tb_des.Name = "tb_des";
            this.tb_des.ReadOnly = true;
            this.tb_des.Size = new System.Drawing.Size(255, 61);
            this.tb_des.TabIndex = 16;
            // 
            // tb_docdes
            // 
            this.tb_docdes.Location = new System.Drawing.Point(7, 117);
            this.tb_docdes.Multiline = true;
            this.tb_docdes.Name = "tb_docdes";
            this.tb_docdes.ReadOnly = true;
            this.tb_docdes.Size = new System.Drawing.Size(255, 61);
            this.tb_docdes.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(382, 100);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "Description";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 100);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Doctor Description";
            // 
            // lb_docname
            // 
            this.lb_docname.AutoSize = true;
            this.lb_docname.Location = new System.Drawing.Point(449, 51);
            this.lb_docname.Name = "lb_docname";
            this.lb_docname.Size = new System.Drawing.Size(10, 13);
            this.lb_docname.TabIndex = 11;
            this.lb_docname.Text = "-";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(382, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Doctor Name";
            // 
            // lb_total
            // 
            this.lb_total.AutoSize = true;
            this.lb_total.Location = new System.Drawing.Point(449, 28);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(10, 13);
            this.lb_total.TabIndex = 9;
            this.lb_total.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(382, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Total";
            // 
            // lb_user
            // 
            this.lb_user.AutoSize = true;
            this.lb_user.Location = new System.Drawing.Point(449, 76);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(10, 13);
            this.lb_user.TabIndex = 7;
            this.lb_user.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(382, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Create by";
            // 
            // lb_createdate
            // 
            this.lb_createdate.AutoSize = true;
            this.lb_createdate.Location = new System.Drawing.Point(73, 76);
            this.lb_createdate.Name = "lb_createdate";
            this.lb_createdate.Size = new System.Drawing.Size(10, 13);
            this.lb_createdate.TabIndex = 5;
            this.lb_createdate.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Create date";
            // 
            // lb_cus
            // 
            this.lb_cus.AutoSize = true;
            this.lb_cus.Location = new System.Drawing.Point(73, 51);
            this.lb_cus.Name = "lb_cus";
            this.lb_cus.Size = new System.Drawing.Size(10, 13);
            this.lb_cus.TabIndex = 3;
            this.lb_cus.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Customer";
            // 
            // lb_ID
            // 
            this.lb_ID.AutoSize = true;
            this.lb_ID.Location = new System.Drawing.Point(73, 28);
            this.lb_ID.Name = "lb_ID";
            this.lb_ID.Size = new System.Drawing.Size(10, 13);
            this.lb_ID.TabIndex = 1;
            this.lb_ID.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoices ID";
            // 
            // dtv_init
            // 
            this.dtv_init.AllowUserToAddRows = false;
            this.dtv_init.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_init.Location = new System.Drawing.Point(13, 309);
            this.dtv_init.Name = "dtv_init";
            this.dtv_init.ReadOnly = true;
            this.dtv_init.Size = new System.Drawing.Size(662, 138);
            this.dtv_init.TabIndex = 4;
            // 
            // bt_refund
            // 
            this.bt_refund.Location = new System.Drawing.Point(438, 12);
            this.bt_refund.Name = "bt_refund";
            this.bt_refund.Size = new System.Drawing.Size(75, 50);
            this.bt_refund.TabIndex = 5;
            this.bt_refund.Text = "Refund";
            this.bt_refund.UseVisualStyleBackColor = true;
            this.bt_refund.Click += new System.EventHandler(this.bt_refund_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(519, 12);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(75, 50);
            this.bt_delete.TabIndex = 6;
            this.bt_delete.Text = "Delete";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_exit
            // 
            this.bt_exit.Image = global::Pharmacy.Properties.Resources._010_x_16;
            this.bt_exit.Location = new System.Drawing.Point(600, 12);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(75, 50);
            this.bt_exit.TabIndex = 7;
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // bt_search
            // 
            this.bt_search.Image = global::Pharmacy.Properties.Resources.Extra_Sugar_16;
            this.bt_search.Location = new System.Drawing.Point(174, 12);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(75, 50);
            this.bt_search.TabIndex = 2;
            this.bt_search.UseVisualStyleBackColor = true;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // bt_next
            // 
            this.bt_next.Image = global::Pharmacy.Properties.Resources.arrow_right_16;
            this.bt_next.Location = new System.Drawing.Point(93, 12);
            this.bt_next.Name = "bt_next";
            this.bt_next.Size = new System.Drawing.Size(75, 50);
            this.bt_next.TabIndex = 1;
            this.bt_next.UseVisualStyleBackColor = true;
            this.bt_next.Click += new System.EventHandler(this.bt_next_Click);
            // 
            // bt_pre
            // 
            this.bt_pre.Image = global::Pharmacy.Properties.Resources.arrow_left_16;
            this.bt_pre.Location = new System.Drawing.Point(12, 12);
            this.bt_pre.Name = "bt_pre";
            this.bt_pre.Size = new System.Drawing.Size(75, 50);
            this.bt_pre.TabIndex = 0;
            this.bt_pre.UseVisualStyleBackColor = true;
            this.bt_pre.Click += new System.EventHandler(this.bt_pre_Click);
            // 
            // FrmInvoiceManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 469);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_refund);
            this.Controls.Add(this.dtv_init);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_search);
            this.Controls.Add(this.bt_next);
            this.Controls.Add(this.bt_pre);
            this.Name = "FrmInvoiceManager";
            this.Text = "FrmInvoiceManager";
            this.Load += new System.EventHandler(this.FrmInvoiceManager_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_init)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_pre;
        private System.Windows.Forms.Button bt_next;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_des;
        private System.Windows.Forms.TextBox tb_docdes;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lb_docname;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lb_user;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_createdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_cus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtv_init;
        private System.Windows.Forms.Button bt_refund;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.CheckBox cb_refund;
        private System.Windows.Forms.Label label2;
    }
}