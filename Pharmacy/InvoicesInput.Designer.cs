namespace Pharmacy
{
    partial class InvoicesInput
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_createdate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_cus = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_des = new System.Windows.Forms.TextBox();
            this.tb_doc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_docdes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_drugid = new System.Windows.Forms.Label();
            this.bt_searchdrug = new System.Windows.Forms.Button();
            this.tb_paideach = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_qty = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_drug = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtv_drug = new System.Windows.Forms.DataGridView();
            this.EditDrugInforMenu = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_subtotal = new System.Windows.Forms.Label();
            this.lb_total = new System.Windows.Forms.Label();
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_clear = new System.Windows.Forms.Button();
            this.bt_searchcus = new System.Windows.Forms.Button();
            this.lb_cusid = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_drug)).BeginInit();
            this.EditDrugInforMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoices ID";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(80, 19);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(103, 20);
            this.tb_id.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Create Date";
            // 
            // dtp_createdate
            // 
            this.dtp_createdate.CustomFormat = "MM-DD-YYYY";
            this.dtp_createdate.Enabled = false;
            this.dtp_createdate.Location = new System.Drawing.Point(259, 19);
            this.dtp_createdate.Name = "dtp_createdate";
            this.dtp_createdate.Size = new System.Drawing.Size(140, 20);
            this.dtp_createdate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Customer";
            // 
            // tb_cus
            // 
            this.tb_cus.Location = new System.Drawing.Point(80, 57);
            this.tb_cus.Name = "tb_cus";
            this.tb_cus.Size = new System.Drawing.Size(293, 20);
            this.tb_cus.TabIndex = 5;
            this.tb_cus.Leave += new System.EventHandler(this.tb_cus_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Description";
            // 
            // tb_des
            // 
            this.tb_des.Location = new System.Drawing.Point(79, 109);
            this.tb_des.Multiline = true;
            this.tb_des.Name = "tb_des";
            this.tb_des.Size = new System.Drawing.Size(320, 57);
            this.tb_des.TabIndex = 8;
            // 
            // tb_doc
            // 
            this.tb_doc.Location = new System.Drawing.Point(514, 57);
            this.tb_doc.Name = "tb_doc";
            this.tb_doc.Size = new System.Drawing.Size(299, 20);
            this.tb_doc.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(412, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Doctor Name";
            // 
            // tb_docdes
            // 
            this.tb_docdes.Location = new System.Drawing.Point(514, 108);
            this.tb_docdes.Multiline = true;
            this.tb_docdes.Name = "tb_docdes";
            this.tb_docdes.Size = new System.Drawing.Size(302, 57);
            this.tb_docdes.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(412, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Doctor Description";
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(514, 22);
            this.tb_user.Name = "tb_user";
            this.tb_user.ReadOnly = true;
            this.tb_user.Size = new System.Drawing.Size(299, 20);
            this.tb_user.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(412, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Create User";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_drugid);
            this.groupBox1.Controls.Add(this.bt_searchdrug);
            this.groupBox1.Controls.Add(this.tb_paideach);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.tb_qty);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.tb_drug);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dtv_drug);
            this.groupBox1.Controls.Add(this.EditDrugInforMenu);
            this.groupBox1.Location = new System.Drawing.Point(16, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(803, 233);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Invoice Item List";
            // 
            // lb_drugid
            // 
            this.lb_drugid.AutoSize = true;
            this.lb_drugid.Location = new System.Drawing.Point(75, 69);
            this.lb_drugid.Name = "lb_drugid";
            this.lb_drugid.Size = new System.Drawing.Size(0, 13);
            this.lb_drugid.TabIndex = 13;
            // 
            // bt_searchdrug
            // 
            this.bt_searchdrug.Image = global::Pharmacy.Properties.Resources.searchicon2;
            this.bt_searchdrug.Location = new System.Drawing.Point(377, 44);
            this.bt_searchdrug.Name = "bt_searchdrug";
            this.bt_searchdrug.Size = new System.Drawing.Size(20, 20);
            this.bt_searchdrug.TabIndex = 12;
            this.bt_searchdrug.UseVisualStyleBackColor = true;
            this.bt_searchdrug.Click += new System.EventHandler(this.bt_searchdrug_Click);
            // 
            // tb_paideach
            // 
            this.tb_paideach.Location = new System.Drawing.Point(678, 44);
            this.tb_paideach.Name = "tb_paideach";
            this.tb_paideach.ReadOnly = true;
            this.tb_paideach.Size = new System.Drawing.Size(111, 20);
            this.tb_paideach.TabIndex = 11;
            this.tb_paideach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_qty_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(617, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Paid each";
            // 
            // tb_qty
            // 
            this.tb_qty.Location = new System.Drawing.Point(498, 44);
            this.tb_qty.Name = "tb_qty";
            this.tb_qty.Size = new System.Drawing.Size(111, 20);
            this.tb_qty.TabIndex = 9;
            this.tb_qty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_qty_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(430, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Quantity";
            // 
            // tb_drug
            // 
            this.tb_drug.Location = new System.Drawing.Point(78, 43);
            this.tb_drug.Name = "tb_drug";
            this.tb_drug.Size = new System.Drawing.Size(293, 20);
            this.tb_drug.TabIndex = 7;
            this.tb_drug.Enter += new System.EventHandler(this.tb_drug_Enter);
            this.tb_drug.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_drug_KeyDown);
            this.tb_drug.Leave += new System.EventHandler(this.tb_drug_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Drug";
            // 
            // dtv_drug
            // 
            this.dtv_drug.AllowUserToAddRows = false;
            this.dtv_drug.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_drug.Location = new System.Drawing.Point(7, 85);
            this.dtv_drug.Name = "dtv_drug";
            this.dtv_drug.ReadOnly = true;
            this.dtv_drug.Size = new System.Drawing.Size(790, 146);
            this.dtv_drug.TabIndex = 0;
            this.dtv_drug.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtv_drug_CellContentClick);
            this.dtv_drug.SelectionChanged += new System.EventHandler(this.dtv_drug_SelectionChanged);
            // 
            // EditDrugInforMenu
            // 
            this.EditDrugInforMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.editToolStripMenuItem});
            this.EditDrugInforMenu.Location = new System.Drawing.Point(3, 16);
            this.EditDrugInforMenu.Name = "EditDrugInforMenu";
            this.EditDrugInforMenu.Size = new System.Drawing.Size(797, 24);
            this.EditDrugInforMenu.TabIndex = 1;
            this.EditDrugInforMenu.Text = "menu";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // lb_subtotal
            // 
            this.lb_subtotal.AutoSize = true;
            this.lb_subtotal.Location = new System.Drawing.Point(16, 408);
            this.lb_subtotal.Name = "lb_subtotal";
            this.lb_subtotal.Size = new System.Drawing.Size(59, 13);
            this.lb_subtotal.TabIndex = 16;
            this.lb_subtotal.Text = "Sub Total :";
            // 
            // lb_total
            // 
            this.lb_total.AutoSize = true;
            this.lb_total.Location = new System.Drawing.Point(16, 431);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(31, 13);
            this.lb_total.TabIndex = 17;
            this.lb_total.Text = "Total";
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(652, 462);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(75, 23);
            this.bt_save.TabIndex = 18;
            this.bt_save.Text = "Save";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(743, 462);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_cancel.TabIndex = 19;
            this.bt_cancel.Text = "Cancel";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // bt_clear
            // 
            this.bt_clear.Location = new System.Drawing.Point(555, 462);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(75, 23);
            this.bt_clear.TabIndex = 20;
            this.bt_clear.Text = "Clear";
            this.bt_clear.UseVisualStyleBackColor = true;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // bt_searchcus
            // 
            this.bt_searchcus.Image = global::Pharmacy.Properties.Resources.searchicon2;
            this.bt_searchcus.Location = new System.Drawing.Point(379, 56);
            this.bt_searchcus.Name = "bt_searchcus";
            this.bt_searchcus.Size = new System.Drawing.Size(20, 20);
            this.bt_searchcus.TabIndex = 6;
            this.bt_searchcus.UseVisualStyleBackColor = true;
            this.bt_searchcus.Click += new System.EventHandler(this.bt_searchcus_Click);
            // 
            // lb_cusid
            // 
            this.lb_cusid.AutoSize = true;
            this.lb_cusid.Location = new System.Drawing.Point(77, 80);
            this.lb_cusid.Name = "lb_cusid";
            this.lb_cusid.Size = new System.Drawing.Size(0, 13);
            this.lb_cusid.TabIndex = 21;
            // 
            // InvoicesInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 490);
            this.Controls.Add(this.lb_cusid);
            this.Controls.Add(this.bt_clear);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.lb_total);
            this.Controls.Add(this.lb_subtotal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_user);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bt_searchcus);
            this.Controls.Add(this.tb_docdes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_doc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_des);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_cus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_createdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.EditDrugInforMenu;
            this.Name = "InvoicesInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InvoicesInput";
            this.Load += new System.EventHandler(this.InvoicesInput_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_drug)).EndInit();
            this.EditDrugInforMenu.ResumeLayout(false);
            this.EditDrugInforMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_createdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_cus;
        private System.Windows.Forms.Button bt_searchcus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_des;
        private System.Windows.Forms.TextBox tb_doc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_docdes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtv_drug;
        private System.Windows.Forms.MenuStrip EditDrugInforMenu;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Label lb_subtotal;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.Button bt_searchdrug;
        private System.Windows.Forms.TextBox tb_paideach;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_qty;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_drug;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lb_drugid;
        private System.Windows.Forms.Label lb_cusid;
    }
}