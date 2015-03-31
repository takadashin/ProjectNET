using Pharmacy.Properties;
using Pharmacy.Utils;
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
            frm.ShowDialog();
        }

        void login(object sender)
        {
            MnManagement.Visible = true;
            MnItemLog.Text = "Log out";
            if(Settings.accLogin.Type.Trim() == Constants.type[1])
                MnItemAccounts.Visible = true;
            else
                MnItemAccounts.Visible = false;
        }

        private void MnItemLog_Click(object sender, EventArgs e)
        {
            if (Settings.accLogin == null)
            {
                FrmLogin frm = new FrmLogin();
                frm.OnClickSubmit += new FrmLogin.LoginHandler(login);
                frm.ShowDialog();
            }
            else
            {
                FrmMain_Load(sender, e);
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Settings.accLogin = null;
            MnItemLog.Text = "Log in";
            MnManagement.Visible = false;
        }

        private void MnItemAccounts_Click(object sender, EventArgs e)
        {
            FrmAccounts frm = new FrmAccounts();
            frm.ShowDialog();
        }
    }
}
