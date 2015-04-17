using Pharmacy.Domain;
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

namespace Pharmacy.InvoiceSearch
{
    public partial class SearchCustomer : Form
    {
        CustomerService custService = new CustomerService();
        Customers customer = new Customers();
        InvoicesInput inip = null;
        public SearchCustomer(InvoicesInput input)
        {
            InitializeComponent();
            this.inip = input;
        }

        private void tb_cus_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = custService.search(tb_cus.Text);
            dtv_display.DataSource = ds.Tables[0];
            if (dtv_display.RowCount > 0)
            {
                dtv_display.Rows[0].Selected = true;
            }
        }

        private void SearchCustomer_Load(object sender, EventArgs e)
        {
             
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            if (dtv_display.RowCount > 0)
            {
               
                this.inip.searchcusvalue(dtv_display.Rows[dtv_display.CurrentCell.RowIndex].Cells[Constants.CUST_NAME].Value.ToString().Trim(), dtv_display.Rows[dtv_display.CurrentCell.RowIndex].Cells[Constants.ID].Value.ToString().Trim());
               this.Close();
            }
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
