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

namespace Pharmacy
{
    public partial class FrmCustomers : Form
    {
        CustomerService custService = new CustomerService();
        Customers customer = new Customers();

        public FrmCustomers()
        {
            AccountService accService = new AccountService();
            Settings.accLogin = accService.getById(2);
            InitializeComponent();
        }

        private void setCustomer(Customers customer,bool insert)
        {
            customer.Name = txtName.Text;
            customer.Gender = cmbGender.Text;
            customer.Address = txtAdd.Text;
            if (txtYearOfBirth.Text != "")
                customer.YearOfBirth = Int32.Parse(txtYearOfBirth.Text);
            customer.Insurance = txtInsurance.Text;
            customer.Allergy = txtAllergy.Text;
            if(insert)
                customer.CreatedBy = Settings.accLogin;
            customer.ModifiedBy = Settings.accLogin;
        }
        private bool validate()
        {
            if (Utils.CommonMethod.checkEmptyString(txtName.Text, "Please Enter Name", "Error"))
            {
                return false;
            }
            if (Utils.CommonMethod.checkNotInt(txtYearOfBirth.Text, "Year Of Birth is Number", "Error"))
            {
                return false;
            }
            return true;
        }

        private void FrmCustomers_Load(object sender, EventArgs e)
        {
            DataSet ds = custService.dsGetAll(Constants.ID, true);
            dgvCustomers.DataSource = ds.Tables[0];
            cmbGender.DataSource = Constants.gender;
            cmbGender.SelectedIndex = 0;
            btnDelete.Enabled=false;
            btnSave.Enabled=false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            if (validate())
            {
                Customers customerNew = new Customers();
                setCustomer(customerNew,true);
                if (custService.insertObject(customerNew))
                {
                    DataSet ds = custService.dsGetAll(Constants.ID, true);
                    dgvCustomers.DataSource = ds.Tables[0];
                    btnClear_Click(sender, e);
                }
            }           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control.Name.Substring(0, 3) == "txt")
                    control.Text = "";
            }
            cmbGender.SelectedIndex = 0;
            DataSet ds = custService.dsGetAll(Constants.ID, true);
            dgvCustomers.DataSource = ds.Tables[0];
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                setCustomer(customer,false);
                if (custService.updatedObject(customer))
                {
                    DataSet ds = custService.dsGetAll(Constants.ID, true);
                    dgvCustomers.DataSource = ds.Tables[0];
                }
            }     
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (custService.deleteById(customer.Id))
            {
                DataSet ds = custService.dsGetAll(Constants.ID, true);
                dgvCustomers.DataSource = ds.Tables[0];
                btnClear_Click(sender, e);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            DataSet ds = custService.search(txtSearch.Text);
            dgvCustomers.DataSource = ds.Tables[0];
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                customer = custService.getById(dgvCustomers.Rows[e.RowIndex].Cells[0].Value);
                txtId.Text = customer.Id.ToString();
                txtName.Text = customer.Name;
                cmbGender.SelectedIndex = Utils.CommonMethod.getComboboxIndex(Constants.gender,customer.Gender);
                txtAdd.Text = customer.Address;
                txtYearOfBirth.Text = customer.YearOfBirth.ToString();
                txtInsurance.Text = customer.Insurance;
                txtAllergy.Text = customer.Allergy;
                btnAdd.Enabled = false;
                btnDelete.Enabled = true;
                btnSave.Enabled = true;
            }
        }
    }
}
