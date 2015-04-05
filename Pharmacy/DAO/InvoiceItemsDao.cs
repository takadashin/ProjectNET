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
    class InvoiceItemsDao : BaseDao<InvoiceItems>
    {
        public InvoiceItemsDao()
        {
           tableName = Constants.INIT_TB;
        }

        public override List<InvoiceItems> convertToDomain(DataSet ds)
        {
            List<InvoiceItems> data = new List<InvoiceItems>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                data.Add(convertToDomain(dr));
            }
            return data;
        }

        public override InvoiceItems convertToDomain(DataRow dr)
        {
            InvoiceItems init = new InvoiceItems();
            if (dr[Constants.INIT_INID].ToString() != "")
                init.In_ID = new InvoiceDao().getById(dr[Constants.INIT_INID].ToString());
            if (dr[Constants.INIT_DRUG].ToString() != "")
                init.Drug_ID = new DrugDao().getById(Int32.Parse(dr[Constants.INIT_DRUG].ToString()));
            init.ItemNum = Int32.Parse( dr[Constants.INIT_ITEM].ToString());
            init.Quantity = Int32.Parse(dr[Constants.INIT_QTY].ToString());
            init.PaidEach = Double.Parse(dr[Constants.INIT_PAID].ToString());
            return init;
        }

        public override List<Criterion> convertToData(InvoiceItems init, out object id)
        {
            List<Criterion> data = new List<Criterion>();
            id = init.In_ID;
            data.Add(new Criterion(Constants.INIT_INID, init.In_ID.In_ID));
            data.Add(new Criterion(Constants.INIT_DRUG, init.Drug_ID.Id));
            data.Add(new Criterion(Constants.INIT_ITEM, init.ItemNum));
            data.Add(new Criterion(Constants.INIT_PAID, init.PaidEach));
            data.Add(new Criterion(Constants.INIT_QTY, init.Quantity));
  
            return data;
        }
    }
}
