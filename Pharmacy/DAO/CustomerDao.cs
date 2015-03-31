using Pharmacy.Domain;
using Pharmacy.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.DAO
{
    class CustomerDao : BaseDao<Customers>
    {
        public CustomerDao()
        {
           tableName = Constants.CUST_TB;
        }

        public override List<Customers> convertToDomain(DataSet ds)
        {   List<Customers> data = new List<Customers>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                data.Add(convertToDomain(dr));
            }
            return data;
        }

        public override Customers convertToDomain(DataRow dr)
        {
            Customers customer = new Customers();
            customer.Id = Int32.Parse(dr[Constants.ID].ToString());
            customer.Name = dr[Constants.CUST_NAME].ToString();
            customer.Gender = dr[Constants.CUST_GENDER].ToString();
            customer.Address = dr[Constants.CUST_ADD].ToString();
            if (dr[Constants.CUST_BIRTH].ToString() != "")
                customer.YearOfBirth = Int32.Parse(dr[Constants.CUST_BIRTH].ToString());
            customer.Insurance = dr[Constants.CUST_INS].ToString();
            customer.Allergy = dr[Constants.CUST_ALLERGY].ToString();
            if (dr[Constants.CUST_CREATEDBY].ToString() != "")
                customer.CreatedBy = new AccountDao().getById(Int32.Parse(dr[Constants.CUST_CREATEDBY].ToString()));
            if (dr[Constants.CUST_MODIFIEDBY].ToString() != "")
                customer.ModifiedBy = new AccountDao().getById(Int32.Parse(dr[Constants.CUST_MODIFIEDBY].ToString()));
            return customer;
        }

        public override List<Criterion> convertToData(Customers customer, out object id)
        {
            List<Criterion> data = new List<Criterion>();
            id = customer.Id;
            data.Add(new Criterion(Constants.CUST_NAME, customer.Name));
            data.Add(new Criterion(Constants.CUST_GENDER, customer.Gender));
            data.Add(new Criterion(Constants.CUST_ADD, customer.Address));
            data.Add(new Criterion(Constants.CUST_BIRTH, customer.YearOfBirth));
            data.Add(new Criterion(Constants.CUST_INS, customer.Insurance));
            data.Add(new Criterion(Constants.CUST_ALLERGY, customer.Allergy));
            data.Add(new Criterion(Constants.CUST_CREATEDBY, customer.CreatedBy.Id));
            data.Add(new Criterion(Constants.CUST_MODIFIEDBY, customer.ModifiedBy.Id));

            return data;
        }
    }
}
