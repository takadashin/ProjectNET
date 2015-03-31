using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pharmacy.DAO;
using System.Data;
using Pharmacy.Utils;

namespace Pharmacy.Service
{
    public abstract class BaseService<T>
    {
        public abstract BaseDao<T> getDao();

        public DataSet dsGetAll(string orderByCol, bool ASC)
        {
            return getDao().dsGetAll(orderByCol,ASC);
        }
        public List<T> getAll(string orderByCol, bool ASC)
        {
            return  getDao().getAll(orderByCol,ASC);
        }
        public DataSet dsGetById(object id)
        {
            return getDao().dsGetById(id);
        }
        public T getById(object id)
        {
            return getDao().getById(id);
        }

        public DataSet dsGetBy(string colName, string value, bool eq)
        {
            return getDao().dsGetBy(colName, value, eq);
        }

        public List<T> getBy(string colName, string value, bool eq)
        {
            return getDao().getBy(colName, value, eq);
        }

        public DataSet dsGetByConditionStr(string criterion,string orderByCol, bool ASC)
        {
            return getDao().dsGetByConditionStr(criterion,orderByCol,ASC);
        }

        public DataSet dsGetByCriterion(List<Criterion> criterions, string orderByCol, bool ASC)
        {
            return getDao().dsGetByCriterion(criterions, orderByCol, ASC);
        }
        public List<T> getByConditionStr(string criterion, string orderByCol, bool ASC)
        {
            return getDao().getByConditionStr(criterion,orderByCol,ASC);
        }

        public bool deleteBy(string colName, object value, bool eq)
        {
             return getDao().deleteBy(colName,value,eq);
        }

        public bool deleteById(object id)
        {
             return getDao().deleteById(id);
        }

        public bool deleteByCriterion(List<Criterion> criterions)
        {
             return getDao().deleteByCriterion(criterions);
        }

        public bool insert(List<Criterion> criterions)
        {
             return getDao().insert(criterions);
        }

        public bool insertObject(T data)
        {
            return getDao().insertObject(data);
        }

        public bool updatedBy(string colName, object value,List<Criterion> data)
        {
             return getDao().updatedBy(colName,value,data);
        }

        public bool updatedByID(List<Criterion> data, object id){
             return getDao().updatedByID(data,id);
        }

        public bool updatedObject(T obj)
        {
            return getDao().updatedObject(obj);
        }

        public DataSet getBySQL(string sql, string orderByCol, bool ASC)
        {
             return getDao().getBySQL(sql,orderByCol,ASC);
        }

        public bool inUpDeBySQL(string sql,List<Criterion> criterions)
        {
             return getDao().inUpDeBySQL(sql,criterions);
        }

        public List<T> convertToDomain(DataSet ds)
        {
            return getDao().convertToDomain(ds);
        }

        public T convertToDomain(DataRow dr)
        {
            return getDao().convertToDomain(dr);
        }

        public List<Criterion> convertToData(T data, out object id)
        {
            return getDao().convertToData(data,out id);
        }
    }
}
