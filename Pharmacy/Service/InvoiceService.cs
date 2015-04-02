using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pharmacy.DAO;
using Pharmacy.Domain;

namespace Pharmacy.Service
{
    class InvoiceService : BaseService<Invoices>
    {
        private InvoiceDao dao = new InvoiceDao();

        public override BaseDao<Invoices> getDao()
        {
            return dao;
        }
    }
}
