using Pharmacy.DAO;
using Pharmacy.Domain;
using Pharmacy.Utils;
using System;
using System.Collections.Generic;
using System.Data;
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

        public DataSet search(string searchText)
        {
            List<Criterion> criterions = new List<Criterion>();
            if (!Utils.CommonMethod.checkNotInt(searchText, null, null))
            {
                criterions.Add(new Criterion(Constants.ID, searchText, "or"));
            }
            if (!Utils.CommonMethod.checkNotDateTime(searchText, null, null))
            {
                criterions.Add(new Criterion(Constants.ACC_BIRTH, searchText, "or"));
            }
            criterions.Add(new Criterion(Constants.ACC_NAME, searchText, "or"));
            criterions.Add(new Criterion(Constants.ACC_USERNAME, searchText, "or"));
            criterions.Add(new Criterion(Constants.ACC_PASSWORD, searchText, "or"));
            criterions.Add(new Criterion(Constants.ACC_GENDER, searchText, "or"));
            criterions.Add(new Criterion(Constants.ACC_ADD, searchText, "or"));
            criterions.Add(new Criterion(Constants.ACC_PHONE, searchText, "or"));
            criterions.Add(new Criterion(Constants.ACC_INS, searchText, "or"));
            criterions.Add(new Criterion(Constants.ACC_TYPE, searchText));
            return dsGetByCriterion(criterions, Constants.ID, true);
        }

    }
}
