using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pharmacy.Domain;
using Pharmacy.Utils;
using System.Data;

namespace Pharmacy.DAO
{
    class DrugDao : BaseDao<Drugs>
    {
        public DrugDao()
        {
           tableName = Constants.DRUG_TB;
        }

        public override List<Drugs> convertToDomain(DataSet ds)
        {   List<Drugs> data = new List<Drugs>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                data.Add(convertToDomain(dr));
            }
            return data;
        }

        public override Drugs convertToDomain(DataRow dr)
        {
            Drugs drug = new Drugs();
            drug.Id = Int32.Parse(dr[Constants.ID].ToString());
            drug.Name = dr[Constants.DRUG_NAME].ToString();
            drug.SKU = dr[Constants.DRUG_SKU].ToString();
            drug.Format = dr[Constants.DRUG_FORMAT].ToString();
            drug.Amount = Int32.Parse(dr[Constants.DRUG_AMOUNT].ToString());
            drug.TypeOfAmount = dr[Constants.DRUG_TYPEOFAMOUNT].ToString();
            drug.MadeIn = dr[Constants.DRUG_MADEIN].ToString();
            drug.Prices = double.Parse(dr[Constants.DRUG_PRICES].ToString());
            drug.Discount = double.Parse(dr[Constants.DRUG_DIS].ToString());
            drug.Gender = dr[Constants.DRUG_GENDER].ToString();
            drug.Ingredients = dr[Constants.DRUG_INGRE].ToString();
            drug.Cautions = dr[Constants.DRUG_CAUTIONS].ToString();
            drug.Recommended = dr[Constants.DRUG_REC].ToString();
            drug.Description = dr[Constants.DRUG_DESC].ToString();
            return drug;
        }

        public override List<Criterion> convertToData(Drugs drug, out object id)
        {
            List<Criterion> data = new List<Criterion>();
            id = drug.Id;
            data.Add(new Criterion(Constants.CUST_NAME, drug.Name));
            data.Add(new Criterion(Constants.CUST_NAME, drug.SKU));
            data.Add(new Criterion(Constants.CUST_NAME, drug.Format));
            data.Add(new Criterion(Constants.CUST_NAME, drug.Amount));
            data.Add(new Criterion(Constants.CUST_NAME, drug.TypeOfAmount));
            data.Add(new Criterion(Constants.CUST_NAME, drug.MadeIn));
            data.Add(new Criterion(Constants.CUST_NAME, drug.Prices));
            data.Add(new Criterion(Constants.CUST_NAME, drug.Discount));
            data.Add(new Criterion(Constants.CUST_GENDER, drug.Gender));
            data.Add(new Criterion(Constants.CUST_ADD, drug.Ingredients));
            data.Add(new Criterion(Constants.CUST_BIRTH, drug.Cautions));
            data.Add(new Criterion(Constants.CUST_INS, drug.Recommended));
            data.Add(new Criterion(Constants.CUST_ALLERGY, drug.Description));

            return data;
        }
    }
}
