using Pharmacy.DAO;
using Pharmacy.Domain;
using Pharmacy.Utils;
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

        public Accounts getByUserName(string userName)
        {
            List<Accounts> accounts = getBy(Constants.ACC_USERNAME, userName, true);
            if (accounts != null && accounts.Count > 0)
            {
                return accounts[0];
            }
            return null;
        }
        

    }
}
