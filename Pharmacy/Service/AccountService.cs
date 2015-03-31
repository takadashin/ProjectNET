using Pharmacy.DAO;
using Pharmacy.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Service
{
    class AccountService : BaseService<Accounts>
    {
        private AccountDao dao = new AccountDao();

        public override BaseDao<Accounts> getDao()
        {
            return dao;
        }

    }
}
