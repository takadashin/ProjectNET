namespace Pharmacy
{
    partial class FrmDrugs
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
            this.txbName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txbFormat = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txbDescription = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txbCaution = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txbRecommended = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txbIngredients = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txbDiscount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.cbTypeOfAmount = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbMadeIn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbFeature = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbSKU = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.dataGridView_DrugInfo = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DrugInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(10, 71);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(330, 20);
            this.txbName.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txbFormat);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txbID);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txbDescription);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txbCaution);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txbRecommended);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txbIngredients);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Controls.Add(this.cbGender);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txbDiscount);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txbPrice);
            this.groupBox1.Controls.Add(this.cbTypeOfAmount);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txbAmount);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txbMadeIn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbFeature);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbSKU);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbName);
            this.groupBox1.Location = new System.Drawing.Point(12, 364);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1221, 292);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 133);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 13);
            this.label17.TabIndex = 35;
            this.label17.Text = "Format:";
            // 
            // txbFormat
            // 
            this.txbFormat.Location = new System.Drawing.Point(10, 149);
            this.txbFormat.Name = "txbFormat";
            this.txbFormat.Size = new System.Drawing.Size(133, 20);
            this.txbFormat.TabIndex = 4;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(21, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "ID:";
            // 
            // txbID
            // 
            this.txbID.Enabled = false;
            this.txbID.Location = new System.Drawing.Point(10, 32);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(330, 20);
            this.txbID.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(815, 133);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Description:";
            // 
            // txbDescription
            // 
            this.txbDescription.Location = new System.Drawing.Point(818, 149);
            this.txbDescription.Multiline = true;
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txbDescription.Size = new System.Drawing.Size(382, 90);
            this.txbDescription.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(815, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Cautions and Restrictions:";
            // 
            // txbCaution
            // 
            this.txbCaution.Location = new System.Drawing.Point(818, 32);
            this.txbCaution.Multiline = true;
            this.txbCaution.Name = "txbCaution";
            this.txbCaution.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txbCaution.Size = new System.Drawing.Size(382, 90);
            this.txbCaution.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(354, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Recommended Dose:";
            // 
            // txbRecommended
            // 
            this.txbRecommended.Location = new System.Drawing.Point(357, 149);
            this.txbRecommended.Multiline = true;
            this.txbRecommended.Name = "txbRecommended";
            this.txbRecommended.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txbRecommended.Size = new System.Drawing.Size(447, 90);
            this.txbRecommended.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(354, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Ingredients:";
            // 
            // txbIngredients
            // 
            this.txbIngredients.Location = new System.Drawing.Point(357, 32);
            this.txbIngredients.Multiline = true;
            this.txbIngredients.Name = "txbIngredients";
            this.txbIngredients.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txbIngredients.Size = new System.Drawing.Size(447, 90);
            this.txbIngredients.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(211, 263);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(59, 23);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(132, 263);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(59, 23);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(48, 263);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(59, 23);
            this.btnInsert.TabIndex = 15;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Men",
            "Women",
            "Unisex"});
            this.cbGender.Location = new System.Drawing.Point(174, 188);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(96, 21);
            this.cbGender.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(171, 172);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Gender:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(255, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(170, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Discount:";
            // 
            // txbDiscount
            // 
            this.txbDiscount.Location = new System.Drawing.Point(173, 228);
            this.txbDiscount.Name = "txbDiscount";
            this.txbDiscount.Size = new System.Drawing.Size(76, 20);
            this.txbDiscount.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(111, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Prices:";
            // 
            // txbPrice
            // 
            this.txbPrice.Location = new System.Drawing.Point(10, 227);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(95, 20);
            this.txbPrice.TabIndex = 9;
            // 
            // cbTypeOfAmount
            // 
            this.cbTypeOfAmount.FormattingEnabled = true;
            this.cbTypeOfAmount.Items.AddRange(new object[] {
            "Pill(s)",
            "Box(es)",
            "Bag(s)",
            "Bottle(s)"});
            this.cbTypeOfAmount.Location = new System.Drawing.Point(284, 148);
            this.cbTypeOfAmount.Name = "cbTypeOfAmount";
            this.cbTypeOfAmount.Size = new System.Drawing.Size(56, 21);
            this.cbTypeOfAmount.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Amount:";
            // 
            // txbAmount
            // 
            this.txbAmount.Location = new System.Drawing.Point(173, 149);
            this.txbAmount.Name = "txbAmount";
            this.txbAmount.Size = new System.Drawing.Size(97, 20);
            this.txbAmount.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Made in:";
            // 
            // txbMadeIn
            // 
            this.txbMadeIn.Location = new System.Drawing.Point(10, 188);
            this.txbMadeIn.Name = "txbMadeIn";
            this.txbMadeIn.Size = new System.Drawing.Size(133, 20);
            this.txbMadeIn.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Feature:";
            // 
            // txbFeature
            // 
            this.txbFeature.Location = new System.Drawing.Point(173, 110);
            this.txbFeature.Name = "txbFeature";
            this.txbFeature.Size = new System.Drawing.Size(167, 20);
            this.txbFeature.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "SKU:";
            // 
            // txbSKU
            // 
            this.txbSKU.Location = new System.Drawing.Point(10, 110);
            this.txbSKU.Name = "txbSKU";
            this.txbSKU.Size = new System.Drawing.Size(133, 20);
            this.txbSKU.TabIndex = 2;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(998, 662);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(99, 37);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1121, 662);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 37);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1145, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 35);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txbSearch
            // 
            this.txbSearch.Location = new System.Drawing.Point(69, 20);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(1055, 20);
            this.txbSearch.TabIndex = 0;
            // 
            // dataGridView_DrugInfo
            // 
            this.dataGridView_DrugInfo.AllowUserToAddRows = false;
            this.dataGridView_DrugInfo.AllowUserToDeleteRows = false;
            this.dataGridView_DrugInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView_DrugInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DrugInfo.Location = new System.Drawing.Point(12, 70);
            this.dataGridView_DrugInfo.Name = "dataGridView_DrugInfo";
            this.dataGridView_DrugInfo.ReadOnly = true;
            this.dataGridView_DrugInfo.Size = new System.Drawing.Size(1221, 288);
            this.dataGridView_DrugInfo.TabIndex = 0;
            this.dataGridView_DrugInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_DrugInfo_CellClick);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 51);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(124, 16);
            this.label15.TabIndex = 18;
            this.label15.Text = "Drugs Infomation";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(19, 23);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 13);
            this.label18.TabIndex = 32;
            this.label18.Text = "Search:";
            // 
            // FrmDrugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1240, 709);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dataGridView_DrugInfo);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txbSearch);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmDrugs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drug Details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmDrugs_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DrugInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txbDescription;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txbCaution;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txbRecommended;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbIngredients;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbDiscount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbPrice;
        private System.Windows.Forms.ComboBox cbTypeOfAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbMadeIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbFeature;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbSKU;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.DataGridView dataGridView_DrugInfo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txbFormat;
        private System.Windows.Forms.Label label18;
    }
}