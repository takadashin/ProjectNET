using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Domain
{
    class Invoices
    {
        /* [In_ID]        
           [CustomerID]     
            [IN_CreateDate]  
            [IN_Description] 
            [IN_Total]       
            [IN_DoctorName]  
            [IN_DoctorDes*/
        private Accounts createby;

        public Accounts CreateBy
        {
            get { return createby; }
            set { createby = value; }
        }
        

        private Customers customerid;

        public Customers CustomerID
        {
            get { return customerid; }
            set { customerid = value; }
        }
        

        private string in_id;

        public string In_ID
        {
            get { return in_id; }
            set { in_id = value; }
        }
        private DateTime createdate;

        public DateTime CreateDate
        {
            get { return createdate; }
            set { createdate = value; }
        }
        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        private double total;

        public double Total
        {
            get { return total; }
            set { total = value; }
        }
        private string docname;

        public string DocName
        {
            get { return docname; }
            set { docname = value; }
        }
        private string docdes;

        public string DocDes
        {
            get { return docdes; }
            set { docdes = value; }
        }

        

        
        
        
        
        
        


    }
}
