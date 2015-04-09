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
    public partial class SearchDrug : Form
    {
        DrugService custService = new DrugService();
        Drugs Drug = new Drugs();
        InvoicesInput inip = null;
        public SearchDrug(InvoicesInput input)
        {
            InitializeComponent();
            this.inip = input;
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            if (dtv_display.RowCount > 0)
            {
                this.inip.searchdrugvalue(dtv_display.SelectedRows[0].Cells[Constants.DRUG_NAME].Value.ToString().Trim(), dtv_display.SelectedRows[0].Cells[Constants.ID].Value.ToString().Trim());
                this.Close();
            }
        }

        private void tb_drug_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = custService.search(tb_drug.Text);
            dtv_display.DataSource = ds.Tables[0];
            if (dtv_display.RowCount > 0)
            {
                dtv_display.Rows[0].Selected = true;
            }
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
