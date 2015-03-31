using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pharmacy.DAO;
using Pharmacy.Domain;

namespace Pharmacy.Service
{
    class DrugService : BaseService<Drugs>
    {
        private DrugDao dao = new DrugDao();

        public override BaseDao<Drugs> getDao()
        {
            return dao;
        }
    }
}
