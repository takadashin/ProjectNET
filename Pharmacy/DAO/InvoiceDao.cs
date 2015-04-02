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
    class InvoiceDao : BaseDao<Invoices>
    {
        public InvoiceDao()
        {
           tableName = Constants.INV_TB;
        }

        public override List<Invoices> convertToDomain(DataSet ds)
        {   List<Invoices> data = new List<Invoices>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                data.Add(convertToDomain(dr));
            }
            return data;
        }

        public override Invoices convertToDomain(DataRow dr)
        {
            Invoices invoices = new Invoices();
            invoices.In_ID = dr[Constants.INV_ID].ToString();
            if (dr[Constants.INV_CREARTEBY].ToString() != "")
                invoices.CreateBy = new AccountDao().getById(Int32.Parse(dr[Constants.INV_CREARTEBY].ToString()));
            if (dr[Constants.INV_CUS].ToString() != "")
                invoices.CustomerID = new CustomerDao().getById(Int32.Parse(dr[Constants.INV_CUS].ToString()));
            invoices.CreateDate = Convert.ToDateTime( dr[Constants.INV_DATE].ToString());
            invoices.Description = dr[Constants.INV_DES].ToString();
            invoices.Total = Double.Parse(dr[Constants.INV_TOTAL].ToString());
            invoices.DocName = dr[Constants.INV_DOC].ToString();
            invoices.DocDes = dr[Constants.INV_DES].ToString();
            return invoices;
        }

        public override List<Criterion> convertToData(Invoices invoices, out object id)
        {
            List<Criterion> data = new List<Criterion>();
            id = invoices.In_ID;
            data.Add(new Criterion(Constants.INV_CUS, invoices.CustomerID.Id));
            data.Add(new Criterion(Constants.INV_CREARTEBY, invoices.CreateBy.Id));
            data.Add(new Criterion(Constants.INV_DATE, invoices.CreateDate));
            data.Add(new Criterion(Constants.INV_DES, invoices.Description));
            data.Add(new Criterion(Constants.INV_TOTAL, invoices.Total));
            data.Add(new Criterion(Constants.INV_DOC, invoices.DocName));
            data.Add(new Criterion(Constants.INV_DOCDES, invoices.DocDes));
            return data;
        }
    }
}
