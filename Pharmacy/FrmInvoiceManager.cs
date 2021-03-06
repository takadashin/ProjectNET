﻿using Pharmacy.Domain;
using Pharmacy.InvoiceSearch;
using Pharmacy.Properties;
using Pharmacy.Service;
using Pharmacy.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Pharmacy
{
    public partial class FrmInvoiceManager : Form
    {
        InvoiceService invser = new InvoiceService();
        InvoiceItemServices initser = new InvoiceItemServices();
        public FrmInvoiceManager()
        {
           
            InitializeComponent();
        }
        int index;
        DataTable dbmain = new DataTable();
        private void FrmInvoiceManager_Load(object sender, EventArgs e)
        {
            init();
        }
        private void init()
        {
            index = 1;
            dbmain = invser.getdisplaysearch().Tables[0];
            loaddetail(index);
        }
        private void loaddetail(int newindex)
        {
            if (dbmain.Rows.Count > 0)
            {
                lb_cus.Text = dbmain.Rows[newindex - 1][Constants.CUST_NAME].ToString();
                lb_ID.Text = dbmain.Rows[newindex - 1][Constants.INV_ID].ToString();
                lb_user.Text = dbmain.Rows[newindex - 1][Constants.ACC_USERNAME].ToString();
                lb_total.Text = "$" + dbmain.Rows[newindex - 1][Constants.INV_TOTAL].ToString();
                lb_docname.Text = dbmain.Rows[newindex - 1][Constants.INV_DOC].ToString();
                lb_createdate.Text = dbmain.Rows[newindex - 1][Constants.INV_DATE].ToString();
                tb_des.Text = dbmain.Rows[newindex - 1][Constants.INV_DES].ToString();
                tb_docdes.Text = dbmain.Rows[newindex - 1][Constants.INV_DOCDES].ToString();
                bool check = Boolean.Parse(dbmain.Rows[newindex - 1][Constants.INV_REFUND].ToString());
                if (check)
                    cb_refund.Checked = true;
                else
                    cb_refund.Checked = false;
                DataTable dbinit = new DataTable();
                dbinit = initser.dsGetBy(Constants.INIT_INID, dbmain.Rows[newindex - 1][Constants.INV_ID].ToString(), true).Tables[0];
                dtv_init.DataSource = dbinit;
                groupBox1.Text = "#" + index + "/" + "Total rows:" + dbmain.Rows.Count;
            }
        }

        private void bt_next_Click(object sender, EventArgs e)
        {
            if (index != dbmain.Rows.Count)
                index++;
            else
                index = 1;
            loaddetail(index);
        }

        private void bt_pre_Click(object sender, EventArgs e)
        {
            if (index != 1)
                index--;
            else
                index = dbmain.Rows.Count;
            loaddetail(index);
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            SearchInvoice iv = new SearchInvoice(this);
            iv.ShowDialog();
        }
        public void searchinvoicevalue(string value)
        {
            int count = 1;
            foreach (DataRow rw in dbmain.Rows)
            {
                if (rw[Constants.INIT_INID].ToString().Trim().Equals(value.Trim()))
                    break;
                count++;
            }
            index = count;
            loaddetail(index);
        }

        private void bt_refund_Click(object sender, EventArgs e)
        {
            if (cb_refund.Checked == false)
            {
                List<Criterion> data = new List<Criterion>();
                Criterion refundcol = new Criterion(Constants.INV_REFUND, true);
                Criterion userchange = new Criterion(Constants.INV_MODIFYBY, Settings.accLogin.Id);

                data.Add(refundcol);
                data.Add(userchange);
                bool i = invser.updatedBy(Constants.INV_ID, dbmain.Rows[index - 1][Constants.INV_ID].ToString().Trim(), data);
                if (i)
                {
                    DataTable dbinit = new DataTable();
                    dbinit = initser.dsGetBy(Constants.INIT_INID, dbmain.Rows[index - 1][Constants.INV_ID].ToString(), true).Tables[0];
                    foreach (DataRow rw in dbinit.Rows)
                    {
                        DrugService drugsv = new DrugService();
                        int itemmax = drugsv.getById(rw[Constants.INIT_DRUG].ToString().Trim()).Amount;
                        List<Criterion> dataacc = new List<Criterion>();
                        int valueitem = itemmax + int.Parse(rw[Constants.INIT_QTY].ToString().Trim());
                        Criterion ammount = new Criterion(Constants.DRUG_AMOUNT, valueitem);
                        dataacc.Add(ammount);
                        bool ii = drugsv.updatedBy(Constants.ID, int.Parse(rw[Constants.INIT_DRUG].ToString().Trim()), dataacc);
                        if (ii == false)
                        {
                            MessageBox.Show("Failed");
                            return;
                        }

                    }
                    MessageBox.Show("Update Successful");
                }
                else
                    MessageBox.Show("Failed");
                init();
            }
            else
                MessageBox.Show("This invoices was refunded");
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            if (Settings.accLogin.Type.Trim() == "Admin")
            {
                if (initser.deleteBy(Constants.INV_ID, dbmain.Rows[index - 1][Constants.INV_ID].ToString().Trim(), true))
                    if (invser.deleteBy(Constants.INV_ID, dbmain.Rows[index - 1][Constants.INV_ID].ToString().Trim(), true))
                    {
                        MessageBox.Show("Delete Successful");
                        init();
                    }
            }
            else
            { MessageBox.Show("You are not Admin"); }
                    
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
