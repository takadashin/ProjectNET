using Pharmacy.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void MnItemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MnItemCustomers_Click(object sender, EventArgs e)
        {
            FrmCustomers frm = new FrmCustomers();
            frm.Show();
        }

        private void MnItemLog_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.ShowDialog();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            MnManagement.Visible = false;
        }
    }
}
