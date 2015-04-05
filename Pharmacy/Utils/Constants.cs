using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Utils
{
    class Constants
    {   public static string[] gender= {"Male","Female"};
        public static string[] type = { "User", "Admin" };
        public const string ID = "Id";
        //Customer
        public const string CUST_TB = "CUSTOMERS";
        public const string CUST_NAME = "Name";
        public const string CUST_GENDER = "Gender";
        public const string CUST_ADD = "Address";
        public const string CUST_BIRTH = "YearOfBirth";
        public const string CUST_INS = "Insurance";
        public const string CUST_ALLERGY = "Allergy";
        public const string CUST_CREATEDBY = "CreatedBy";
        public const string CUST_MODIFIEDBY = "ModifiedBy";
        //Account
        public const string ACC_TB = "ACCOUNTS";
        public const string ACC_USERNAME = "UserName";
        public const string ACC_PASSWORD = "Password";
        public const string ACC_NAME = "Name";
        public const string ACC_GENDER = "Gender";
        public const string ACC_BIRTH = "DateOfBirth";
        public const string ACC_ADD = "Address";
        public const string ACC_PHONE = "PhoneNum";
        public const string ACC_INS = "Insurance";
        public const string ACC_TYPE = "Type";     
        //Drug
        public const string DRUG_TB = "DRUGS";
        public const string DRUG_NAME = "Name";
        public const string DRUG_SKU = "SKU";
        public const string DRUG_FORMAT = "Format";
        public const string DRUG_AMOUNT = "Amount";
        public const string DRUG_TYPEOFAMOUNT = "Type_of_Amount";
        public const string DRUG_MADEIN = "Made_In";
        public const string DRUG_PRICES = "Prices";
        public const string DRUG_DIS = "Discount";
        public const string DRUG_GENDER = "Gender";
        public const string DRUG_INGRE = "Ingredients";
        public const string DRUG_CAUTIONS = "Cautions";
        public const string DRUG_REC = "Recommended";
        public const string DRUG_DESC = "Description";
        public const string DRUG_FEATURE = "Feature";
        public const string DRUG_INVENTORY = "Inventory";
        //Invoices
        public const string INV_TB = "Invoices";
        public const string INV_ID = "In_ID";
        public const string INV_CUS = "CustomerID";
        public const string INV_DATE = "IN_CreateDate";
        public const string INV_DES = "IN_Description";
        public const string INV_TOTAL = "IN_Total";
        public const string INV_DOC = "IN_DoctorName";
        public const string INV_DOCDES = "IN_DoctorDes";
        public const string INV_CREARTEBY = "CreateBy";

        //Invoices Items
        public const string INIT_TB = "InvoicesItems";
        public const string INIT_INID = "In_ID";
        public const string INIT_ITEM = "Item#";
        public const string INIT_DRUG = "Drug_ID";
        public const string INIT_QTY = "QUANTITY";
        public const string INIT_PAID = "PAIDEACH";

    }
}
