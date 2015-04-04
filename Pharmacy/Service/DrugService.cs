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
    class DrugService : BaseService<Drugs>
    {
        private DrugDao dao = new DrugDao();

        public override BaseDao<Drugs> getDao()
        {
            return dao;
        }

        public DataSet search(string searchText)
        {
            List<Criterion> criterions = new List<Criterion>();
            if (!Utils.CommonMethod.checkNotInt(searchText, null, null))
            {
                criterions.Add(new Criterion(Constants.ID, searchText, "or"));
            }
            criterions.Add(new Criterion(Constants.DRUG_NAME, searchText, "or"));
            criterions.Add(new Criterion(Constants.DRUG_SKU, searchText, "or"));
            criterions.Add(new Criterion(Constants.DRUG_FORMAT, searchText, "or"));
            criterions.Add(new Criterion(Constants.DRUG_TYPEOFAMOUNT, searchText, "or"));
            criterions.Add(new Criterion(Constants.DRUG_MADEIN, searchText, "or"));
            criterions.Add(new Criterion(Constants.DRUG_GENDER, searchText, "or"));
            criterions.Add(new Criterion(Constants.DRUG_FEATURE, searchText));
            
            return dsGetByCriterion(criterions, Constants.ID, true);
        }

    }
}
