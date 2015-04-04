using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pharmacy.DAO;
using Pharmacy.Domain;
using System.Data;

using Pharmacy.Utils;

namespace Pharmacy.Service
{
    class InvoiceService : BaseService<Invoices>
    {
        private InvoiceDao dao = new InvoiceDao();
        private CustomerDao cusdao = new CustomerDao();
        public override BaseDao<Invoices> getDao()
        {
            return dao;
        }
        public int getidlist()
        {
            return int.Parse( dao.getBySQL("select MAX( CAST( SUBSTRING(" + Constants.INV_ID + " ,2,LEN(" + Constants.INV_ID + ")) as int)) as NUM from " + Constants.INV_TB, "NUM", true).Tables[0].Rows[0][0].ToString());
        }
        public string[] getcussuggess(string name)
        {
            
            DataSet dslist = dao.getBySQL("select "+Constants.CUST_NAME+" from "+Constants.CUST_TB+" where " + Constants.CUST_NAME + " LIKE '%"+ name+"%'", Constants.CUST_NAME, true);
            string[] list = new string[dslist.Tables[0].Rows.Count];
            int count = 0;
            foreach (DataRow rw in dslist.Tables[0].Rows)
            {
                list[count]=( rw[Constants.CUST_NAME].ToString().Trim());
                count++;
            }
            return list;
        }
        public string[] getdrugsuggess(string name)
        {
           
            DataSet dslist = dao.getBySQL("select  "+Constants.DRUG_NAME+" from " + Constants.DRUG_TB + " where " + Constants.DRUG_NAME + " LIKE '%" + name + "%'", Constants.DRUG_NAME, true);
            string[] list = new string[dslist.Tables[0].Rows.Count];
            int count = 0;
            foreach (DataRow rw in dslist.Tables[0].Rows)
            {
                list[count] = (rw[Constants.DRUG_NAME].ToString().Trim());
                count++;
            }
            return list;
        }
        public string getcusidfromsearch(string name)
        {
            DataSet ds = dao.getBySQL("select * from " + Constants.CUST_TB + " where " + Constants.CUST_NAME + " LIKE '%" + name + "%'", Constants.CUST_NAME, true);
            if (ds.Tables[0].Rows.Count > 0)
                return ds.Tables[0].Rows[0][0].ToString();
            else
                return String.Empty;
        }
        public string getdrugidfromsearch(string name)
        {
            DataSet ds = dao.getBySQL("select * from " + Constants.DRUG_TB + " where " + Constants.DRUG_NAME + " LIKE '%" + name + "%'", Constants.CUST_NAME, true);
            if (ds.Tables[0].Rows.Count > 0)
                return ds.Tables[0].Rows[0][0].ToString();
            else
                return String.Empty;
        }
    }
}
