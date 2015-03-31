using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Utils
{
    public class Criterion
    {   private string colName;
        private object data;
        private string relation;

        public string ColName
        {
            get { return colName; }
        }
        public object Data
        {
            get { return data; }
        }
        public string Relation
        {
            get { return relation; }
        }
        public Criterion(string colName, object data)
        {
            this.colName = colName;
            this.data = data;
            this.relation = "";
        }
        public Criterion(string colName, object data,string relation)
        {
            this.colName = colName;
            this.data = data;
            this.relation = relation;
        }
    }
}
