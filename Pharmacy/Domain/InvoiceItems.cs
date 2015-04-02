using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Domain
{
    class InvoiceItems
    {
        /* [IN_ID]    
    [Item#]   
    [Drug_ID]  
    [QUANTITY] 
    [PAIDEACH]
         */
        private Invoices in_id;

        public Invoices In_ID
        {
            get { return in_id; }
            set { in_id = value; }
        }
        private Drugs drug_id;

        public Drugs Drug_ID
        {
            get { return drug_id; }
            set { drug_id = value; }
        }
        
        
        private int itemnum;

        public int ItemNum
        {
            get { return itemnum; }
            set { itemnum = value; }
        }

        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        private double paideach;

        public double PaidEach
        {
            get { return paideach; }
            set { paideach = value; }
        }
        
        

    }
}
