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
using Pharmacy.Domain;

namespace Pharmacy.InvoiceSearch
{
    public partial class SearchInvoice : Form
    {
        InvoiceService invService = new InvoiceService();
        Invoices invoice = new Invoices();
        FrmInvoiceManager inip = null;
        public SearchInvoice(FrmInvoiceManager input)
        {
            InitializeComponent();
            this.inip = input;
        }

        private void tb_invoice_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = invService.search(tb_invoice.Text);
            dtv_display.DataSource = ds.Tables[0];
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            if (dtv_display.RowCount > 0)
            {
                this.inip.searchinvoicevalue(dtv_display.SelectedRows[0].Cells[Constants.INV_ID].Value.ToString().Trim());
                this.Close();
            }
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
