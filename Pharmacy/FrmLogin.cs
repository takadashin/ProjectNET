using Pharmacy.Domain;
using Pharmacy.Properties;
using Pharmacy.Service;
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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        public delegate void LoginHandler(object sender);
        public LoginHandler OnClickSubmit;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            AccountService srv = new AccountService();

            Accounts account = srv.getByUserName(txtUserName.Text);
            if (account != null)
            {
                if (account.Password.Trim() == txtPassword.Text.Trim())
                {
                    Settings.accLogin = account;
                    if (OnClickSubmit != null)
                    {
                        OnClickSubmit(this);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Password is wrong. Please enter again", "ERROR", MessageBoxButtons.OK);
                }

            }
            else
            {
                MessageBox.Show("User name is wrong. Please enter again", "ERROR", MessageBoxButtons.OK);
            }

        }

    }
}
