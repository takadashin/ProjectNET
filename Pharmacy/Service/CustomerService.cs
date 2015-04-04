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
    class CustomerService : BaseService<Customers>
    {
        private CustomerDao dao = new CustomerDao();

        public override BaseDao<Customers> getDao()
        {
            return dao;
        }
        public DataSet search(string searchText)
        {
            List<Criterion> criterions = new List<Criterion>();
            if (!Utils.CommonMethod.checkNotInt(searchText, null, null))
            {
                criterions.Add(new Criterion(Constants.ID, searchText, "or"));
                criterions.Add(new Criterion(Constants.CUST_BIRTH, searchText, "or"));
                criterions.Add(new Criterion(Constants.CUST_CREATEDBY, searchText, "or"));
                criterions.Add(new Criterion(Constants.CUST_MODIFIEDBY, searchText, "or"));
            }
            criterions.Add(new Criterion(Constants.CUST_NAME, searchText, "or"));
            criterions.Add(new Criterion(Constants.CUST_GENDER, searchText, "or"));
            criterions.Add(new Criterion(Constants.CUST_ADD, searchText, "or"));
            criterions.Add(new Criterion(Constants.CUST_INS, searchText, "or"));
            criterions.Add(new Criterion(Constants.CUST_ALLERGY, searchText));
            return dsGetByCriterion(criterions, Constants.ID, true);
        }
        

    }
}
