using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pharmacy.Domain;
using Pharmacy.Service;
using Pharmacy.Utils;
using Pharmacy.Properties;



namespace Pharmacy
{
    public partial class FrmDrugs : Form
    {
        DrugService drugService = new DrugService();
        Drugs drug = new Drugs();

        public FrmDrugs()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataSet ds = drugService.search(txbSearch.Text);
            dataGridView_DrugInfo.DataSource = ds.Tables[0];
        }

        private void FrmDrugs_Load(object sender, EventArgs e)
        {
            if (Settings.accLogin.Type.Trim() == Constants.type[1])
            {
                btnInsert.Enabled = true;         
                btnDelete.Enabled = false;
                btnSave.Enabled = false;
            }
            else {
                btnInsert.Enabled = false;
                btnDelete.Enabled = false;
                btnSave.Enabled = false;
            }

            DataSet ds = drugService.dsGetAll(Constants.ID, true);
            dataGridView_DrugInfo.DataSource = ds.Tables[0];
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txbSearch.Text = "";
            foreach (Control control in groupBox1.Controls)
            {
                if (control.Name.Substring(0, 3) == "txb")
                    control.Text = "";
            }

            cbTypeOfAmount.SelectedIndex = 0;
            cbGender.SelectedIndex = 0;
            DataSet ds = drugService.dsGetAll(Constants.ID, true);
            dataGridView_DrugInfo.DataSource = ds.Tables[0];
            if (Settings.accLogin.Type.Trim() == Constants.type[1])
            {
                btnInsert.Enabled = true;
                btnDelete.Enabled = false;
                btnSave.Enabled = false;
            }
        }


        private bool validate()
        {
            if (Utils.CommonMethod.checkEmptyString(txbName.Text, "Name is required", "Error"))
            {
                return false;
            }
            if (Utils.CommonMethod.checkEmptyString(txbSKU.Text, "SKU is required", "Error"))
            {
                return false;
            }
            if (Utils.CommonMethod.checkEmptyString(txbFeature.Text, "Feature is required", "Error"))
            {
                return false;
            }
            if (Utils.CommonMethod.checkNotInt(txbAmount.Text, "Amount must be a number", "Error"))
            {
                return false;
            }
            if (Utils.CommonMethod.checkNotFloat(txbPrice.Text, "Price must be a number", "Error"))
            {
                return false;
            }
            if (Utils.CommonMethod.checkNotFloat(txbDiscount.Text, "Discount must be a number", "Error"))
            {
                return false;
            }
            return true;
        }

        private void setDrug(Drugs drug, bool insert)
        {
            drug.Name = txbName.Text;
            drug.SKU = txbSKU.Text;
            drug.Format = txbFeature.Text;
            if (txbAmount.Text != "")
            {
                drug.Amount = Int32.Parse(txbAmount.Text);
                drug.Inventory = Int32.Parse(txbAmount.Text);
            }
            drug.TypeOfAmount = cbTypeOfAmount.Text;
            drug.MadeIn = txbMadeIn.Text;
            if (txbPrice.Text != "")
                drug.Prices = float.Parse(txbPrice.Text);
            if (txbDiscount.Text != "")
                drug.Discount = float.Parse(txbDiscount.Text);            
            drug.Gender = cbGender.Text;
            drug.Ingredients = txbIngredients.Text;
            drug.Cautions = txbCaution.Text;
            drug.Recommended = txbRecommended.Text;
            drug.Description = txbDescription.Text;
            drug.Feature = txbFeature.Text;
            
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                Drugs drugNew = new Drugs();
                setDrug(drugNew, true);
                if (drugService.insertObject(drugNew))
                {
                    DataSet ds = drugService.dsGetAll(Constants.ID, true);
                    dataGridView_DrugInfo.DataSource = ds.Tables[0];
                    btnClear_Click(sender, e);
                }
            }   
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (drugService.deleteById(drug.Id))
            {
                DataSet ds = drugService.dsGetAll(Constants.ID, true);
                dataGridView_DrugInfo.DataSource = ds.Tables[0];
                btnClear_Click(sender, e);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                setDrug(drug, false);
                if (drugService.updatedObject(drug))
                {
                    DataSet ds = drugService.dsGetAll(Constants.ID, true);
                    dataGridView_DrugInfo.DataSource = ds.Tables[0];
                }
            }  
        }

        private void dataGridView_DrugInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                drug = drugService.getById(dataGridView_DrugInfo.Rows[e.RowIndex].Cells[0].Value);
                txbID.Text = drug.Id.ToString();
                txbName.Text = drug.Name;
                txbSKU.Text = drug.SKU;
                txbFormat.Text = drug.Format;               
                txbAmount.Text = drug.Amount.ToString();
                cbTypeOfAmount.Text = drug.TypeOfAmount;
                txbMadeIn.Text = drug.MadeIn;
                txbPrice.Text = drug.Prices.ToString();
                txbDiscount.Text = drug.Discount.ToString();                
                cbGender.Text = drug.Gender;
                txbIngredients.Text = drug.Ingredients;
                txbCaution.Text = drug.Cautions;
                txbRecommended.Text = drug.Recommended;
                txbDescription.Text = drug.Description;
                txbFeature.Text = drug.Feature;
                if (Settings.accLogin.Type.Trim() == Constants.type[1])
                {
                    btnInsert.Enabled = false;
                    btnDelete.Enabled = true;
                    btnSave.Enabled = true;
                }                
            }
        }
    }
}
