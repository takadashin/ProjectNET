using Pharmacy.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy.DAO
{
    public class BaseDao<T>
    {
        protected string connStr = Pharmacy.Properties.Settings.Default.PharmacyConnectionString;
        protected string tableName;

        public DataSet dsGetAll(string orderByCol, bool ASC)
        {
            return dsGetByConditionStr("",orderByCol,ASC);
        }

        public List<T> getAll(string orderByCol, bool ASC)
        {
            return convertToDomain(dsGetAll(orderByCol,ASC));
        }

        public DataSet dsGetById(object id)
        {
            return dsGetByConditionStr("where " + Constants.ID + "='" + id + "'", null , false);
        }

        public T getById(object id)
        {
           List<T> data = convertToDomain(dsGetById(id));
            if (data.Count == 1)
            {
                return (T)data[0];
            }
            return default(T);
        }

        public DataSet dsGetBy(string colName, string value, bool eq)
        {
            if(eq)
                return dsGetByConditionStr("where " + colName + "='" + value + "'",null,false);
            else
                return dsGetByConditionStr("where " + colName + "<>'" + value + "'", null, false);
        }

        public List<T> getBy(string colName, string value, bool eq)
        {
            return convertToDomain(dsGetBy(colName,value,eq));
        }

        public DataSet dsGetByConditionStr(string criterion, string orderByCol, bool ASC)
        {
            return getBySQL("select * from " + tableName + " " + criterion, orderByCol, ASC);
        }

        public DataSet dsGetByCriterion(List<Criterion> criterions, string orderByCol, bool ASC)
        {   string criterion = "where ";
            foreach (Criterion cr in criterions)
            {   criterion += cr.ColName + "='" + cr.Data + "' ";
                if (cr.Relation != null)
                    criterion += cr.Relation + " ";
            }
            return dsGetByConditionStr(criterion, orderByCol, ASC);
        }
        public List<T> getByConditionStr(string criterion, string orderByCol, bool ASC)
        {
            return convertToDomain(dsGetByConditionStr(criterion,orderByCol,ASC));
        }

        public bool deleteBy(string colName, object value, bool eq)
        {
            if(eq)
                return inUpDeBySQL("Delete From " + tableName + " where " + colName + "='" + value + "'", null);
            else
                return inUpDeBySQL("Delete From " + tableName + " where " + colName + "<>'" + value + "'", null);
        }

        public bool deleteById(object id)
        {
            return deleteBy(Constants.ID, id, true);
        }

        public bool deleteByCriterion(List<Criterion> criterions)
        {
            string sql = "Delete From " + tableName + " where ";
            foreach (Criterion criterion in criterions)
            {
                sql = sql + criterion.ColName + "= @" + criterion.ColName;
                if (criterion.Relation != "")
                    sql = sql + " " + criterion.Relation + " ";
            }
            return inUpDeBySQL(sql, criterions);
        }

        public bool insert(List<Criterion> criterions)
        {
            string sqlName = "(";
            string sqlValue = "(";

            for (int i = 0; i < criterions.Count; i++ )
            {
                if (i < criterions.Count - 1)
                {
                    sqlName = sqlName + criterions[i].ColName + ",";
                    sqlValue = sqlValue + "@" + criterions[i].ColName + ",";
                }
                else
                {
                    sqlName = sqlName + criterions[i].ColName + ")";
                    sqlValue = sqlValue + "@" + criterions[i].ColName + ")";
                }
            }
            string sql = "Insert Into " + tableName + sqlName + " Values" + sqlValue;
            return inUpDeBySQL(sql, criterions);
        }

        public bool insertObject(T data)
        {
            object id;
            return insert(convertToData(data,out id));
        }

        public bool updatedBy(string colName, object value,List<Criterion> data)
        {
            string sql = "Update " + tableName + " Set ";

            for (int i = 0; i < data.Count; i++)
            {
                if (i < data.Count - 1)
                    sql = sql + data[i].ColName + "= @" + data[i].ColName + ",";
                else
                    sql = sql + data[i].ColName + "= @" + data[i].ColName;
            }
            sql = sql + " where " + colName + "=@" + colName;
            data.Add(new Criterion(colName,value));
            return inUpDeBySQL(sql, data);
        }

        public bool updatedByID(List<Criterion> data, object id)
        {
            return updatedBy(Constants.ID,id,data);
        }

        public bool updatedObject(T obj)
        {
            Object id;
            List<Criterion> data = convertToData(obj,out id);
            return updatedByID(data, id);
        }

        public DataSet getBySQL(string sql, string orderByCol, bool ASC)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connStr);
                conn.Open();

                if (orderByCol != null)
                {
                    sql += " Order By " + orderByCol;
                    if (!ASC)
                        sql += " DESC";
                }

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                GC.Collect();
                conn.Close();
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error SQL: " + ex.Message, "Error");
            }
            return null;
        }

        public bool inUpDeBySQL(string sql,List<Criterion> criterions)
        {
            SqlConnection conn = new SqlConnection(connStr);
            try
            {   conn.Open();
                SqlTransaction tran = conn.BeginTransaction(IsolationLevel.Serializable);
                SqlCommand com = new SqlCommand(sql, conn);

                if (criterions != null)
                    foreach (Criterion criterion in criterions)
                        com.Parameters.AddWithValue(criterion.ColName, criterion.Data);
   
                com.Transaction = tran;
                int i = com.ExecuteNonQuery();
                if (i != 0)
                {
                    tran.Commit();
                    com.Dispose();
                    conn.Dispose();
                    conn.Close();
                    GC.Collect();
                    return true;
                }
                else
                {
                    tran.Rollback();
                    com.Dispose();
                    conn.Dispose();
                    conn.Close();
                    GC.Collect();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error SQL: " + ex.Message, "Error");
                conn.Close();
                GC.Collect();
                return false;
            }
        }  

        public virtual List<T> convertToDomain(DataSet ds)
        {
            return null;
        }
        
        public virtual T convertToDomain(DataRow dr)
        {
            return default(T);
        }
        public virtual List<Criterion> convertToData(T data, out object Id)
        {
            Id = 0;
            return null;
        }
     
    }
}
