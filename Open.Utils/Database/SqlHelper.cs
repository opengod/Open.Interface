using System;
using System.Collections;
using System.Reflection;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using SqlSugar;

namespace Open.Utils
{
    public class SqlHelper
    {
        /// <summary>
        /// 获取实体类键值
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        public static Hashtable GetPropertyInfo<T>(T entity)
        {
            Type type = entity.GetType();
            Hashtable ht = new Hashtable();
            PropertyInfo[] props = type.GetProperties();
            foreach (PropertyInfo prop in props)
            {
                bool flag = true;
                foreach (Attribute attr in prop.GetCustomAttributes(true))
                {
                    NotMappedAttribute notMapped = attr as NotMappedAttribute;
                    if (notMapped != null)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    string name = prop.Name;
                    object value = prop.GetValue(entity, null);
                    ht[name] = value;
                }
            }
            return ht;
        }

        /// <summary>
        /// 将对象参数
        /// </summary>
        /// <param name="fieldValueParams">对象</param>
        /// <returns></returns>
        public static List<SugarParameter> FieldValueParamToParameter(List<FieldValueParam> fieldValueParams)
        {
            try
            {
                var args = new List<SugarParameter>();
                foreach (var item in fieldValueParams)
                {
                    args.Add(new SugarParameter(item.name, item.value));
                }
                return args;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// mysql分页语句
        /// </summary>
        /// <param name="strSql">sql语句</param>
        /// <param name="orderField">排序字段</param>
        /// <param name="isAsc">排序类型</param>
        /// <param name="pageSize">每页数据条数</param>
        /// <param name="pageIndex">页码</param>
        /// <returns></returns>
        public static StringBuilder MySqlPageSql(string strSql, string orderField, bool isAsc, int pageSize, int pageIndex)
        {
            var sb = new StringBuilder();
            if (pageIndex == 0)
            {
                pageIndex = 1;
            }
            int num = (pageIndex - 1) * pageSize;
            string OrderBy = "";

            if (!string.IsNullOrEmpty(orderField))
            {
                if (orderField.ToUpper().IndexOf("ASC") + orderField.ToUpper().IndexOf("DESC") > 0)
                {
                    OrderBy = " Order By " + orderField;
                }
                else
                {
                    OrderBy = " Order By " + orderField + " " + (isAsc ? "ASC" : "DESC");
                }
            }
            sb.Append(strSql + OrderBy);
            sb.Append(" limit " + num + "," + pageSize + "");
            return sb;
        }
    }
}
