using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pharmacy.DAO;
using Pharmacy.Domain;

namespace Pharmacy.Service
{
    class CustomerService : BaseService<Customers>
    {
        private CustomerDao dao = new CustomerDao();

        public override BaseDao<Customers> getDao()
        {
            return dao;
        }

    }
}
