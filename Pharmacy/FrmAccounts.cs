using Pharmacy.Domain;
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
    public partial class FrmAccounts : Form
    {
        AccountService accService = new AccountService();
        Accounts account = new Accounts();

        private void setAccount(Accounts account, bool insert)
        {
            account.Name = txtName.Text;
            account.UserName = txtUserName.Text;
            account.Password = txtPassword.Text;
            account.DateOfBirth = dtpDateOfBirth.Value;
            account.Gender = cmbGender.Text;
            account.Address = txtAdd.Text;
            account.PhoneNum = txtPhoneNumber.Text;
            account.Insurance = txtInsurance.Text;
            account.Type = cmbType.Text;            
        }

        
        private bool validate(bool add)
        {
            if (Utils.CommonMethod.checkEmptyString(txtName.Text, "Please Enter Name", "Error"))
            {
                return false;
            }

            if (Utils.CommonMethod.checkEmptyString(txtUserName.Text, "Please Enter User Name", "Error"))
            {
                return false;
            }
            
            if (add && accService.getByUserName(txtUserName.Text) != null)
            {
                    MessageBox.Show("UserName was exist already, please enter again", "Error");
                    return false;
            }

            if (Utils.CommonMethod.checkEmptyString(txtPassword.Text, "Please Enter Password", "Error"))
            {
                return false;
            }

            if (add || (!add && txtPassword.Text.Trim() != account.Password.Trim()))
            {

                if (Utils.CommonMethod.checkEmptyString(txtReTypePass.Text, "Please Enter ReType Password", "Error"))
                {
                    return false;
                }

                if (txtPassword.Text != txtReTypePass.Text)
                {
                    MessageBox.Show("Password is different from ReType Password, please enter again", "Error");
                    return false;
                }
            }
           
            return true;
        }

        public FrmAccounts()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAccounts_Load(object sender, EventArgs e)
        {
            DataSet ds = accService.dsGetAll(Constants.ID, true);
            dgvAccounts.DataSource = ds.Tables[0];
            cmbGender.DataSource = Constants.gender;
            cmbGender.SelectedIndex = 0;
            cmbType.DataSource = Constants.type;
            cmbType.SelectedIndex = 0;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control.Name.Substring(0, 3) == "txt")
                    control.Text = "";
            }
            cmbGender.SelectedIndex = 0;
            cmbType.SelectedIndex = 0;
            DataSet ds = accService.dsGetAll(Constants.ID, true);
            dgvAccounts.DataSource = ds.Tables[0];
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (validate(true))
            {
                Accounts accountNew = new Accounts();
                setAccount(accountNew, true);
                if (accService.insertObject(accountNew))
                {
                    DataSet ds = accService.dsGetAll(Constants.ID, true);
                    dgvAccounts.DataSource = ds.Tables[0];
                    btnClear_Click(sender, e);
                }
            }     
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validate(false))
            {
                setAccount(account, false);
                if (accService.updatedObject(account))
                {
                    DataSet ds = accService.dsGetAll(Constants.ID, true);
                    dgvAccounts.DataSource = ds.Tables[0];
                }
            }    
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (accService.deleteById(account.Id))
            {
                DataSet ds = accService.dsGetAll(Constants.ID, true);
                dgvAccounts.DataSource = ds.Tables[0];
                btnClear_Click(sender, e);
            }
        }

        private void dgvAccounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                account = accService.getById(dgvAccounts.Rows[e.RowIndex].Cells[0].Value);
                txtId.Text = account.Id.ToString();
                txtName.Text = account.Name;
                txtUserName.Text = account.UserName;
                dtpDateOfBirth.Value = account.DateOfBirth;
                txtPassword.Text = account.Password;
                cmbGender.SelectedIndex = Utils.CommonMethod.getComboboxIndex(Constants.gender, account.Gender); 
                txtAdd.Text = account.Address;
                txtPhoneNumber.Text = account.PhoneNum;
                txtInsurance.Text = account.Insurance;
                cmbType.SelectedIndex = Utils.CommonMethod.getComboboxIndex(Constants.type, account.Type);
                btnAdd.Enabled = false;
                btnDelete.Enabled = true;
                btnSave.Enabled = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataSet ds = accService.search(txtSearch.Text);
            dgvAccounts.DataSource = ds.Tables[0];
        }
    }
}
