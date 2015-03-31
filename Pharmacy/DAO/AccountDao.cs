using Pharmacy.Domain;
using Pharmacy.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.DAO
{
    class AccountDao : BaseDao<Accounts>
    {
        public AccountDao()
        {
           tableName = Constants.ACC_TB;
        }

        public override List<Accounts> convertToDomain(DataSet ds)
        {   List<Accounts> data = new List<Accounts>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                data.Add(convertToDomain(dr));
            }
            return data;
        }

        public override Accounts convertToDomain(DataRow dr)
        {
            Accounts account = new Accounts();
            account.Id = Int32.Parse(dr[Constants.ID].ToString());
            account.UserName = dr[Constants.ACC_USERNAME].ToString();
            account.Password = dr[Constants.ACC_PASSWORD].ToString();
            account.Name = dr[Constants.ACC_NAME].ToString();
            account.DateOfBirth = (DateTime)dr[Constants.ACC_BIRTH];
            account.Gender = dr[Constants.ACC_GENDER].ToString();
            account.Address = dr[Constants.ACC_ADD].ToString();
            account.PhoneNum = dr[Constants.ACC_PHONE].ToString();
            account.Insurance = dr[Constants.ACC_INS].ToString();
            account.Type = dr[Constants.ACC_TYPE].ToString();
            return account;
        }

        public override List<Criterion> convertToData(Accounts account, out object id)
        {
            List<Criterion> data = new List<Criterion>();
            id = account.Id;
            data.Add(new Criterion(Constants.ACC_USERNAME, account.UserName));
            data.Add(new Criterion(Constants.ACC_PASSWORD, account.Password));
            data.Add(new Criterion(Constants.ACC_NAME, account.Name));
            data.Add(new Criterion(Constants.ACC_BIRTH, account.DateOfBirth));
            data.Add(new Criterion(Constants.ACC_GENDER, account.Gender));
            data.Add(new Criterion(Constants.ACC_ADD, account.Address));
            data.Add(new Criterion(Constants.ACC_PHONE, account.PhoneNum));
            data.Add(new Criterion(Constants.ACC_INS, account.Insurance));
            data.Add(new Criterion(Constants.ACC_TYPE, account.Type));
            return data;
        }
    }
}
