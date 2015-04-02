using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pharmacy.DAO;
using Pharmacy.Domain;

namespace Pharmacy.Service
{
    class InvoiceItemServices :BaseService<InvoiceItems>
    {
        private InvoiceItemsDao dao = new InvoiceItemsDao();

        public override BaseDao<InvoiceItems> getDao()
        {
            return dao;
        }
    
    }
}
