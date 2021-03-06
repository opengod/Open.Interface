﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Reflection;
using SqlSugar;

namespace Open.Utils.Helper
{
    /// <summary>    
    /// 实体转换辅助类    
    /// </summary>    
    public class ModelConvertHelper<T> where T : new()
    {
        //public static IList<T> ConvertToModel(SqlSugar.DataTable dt)
        //{
        //    // 定义集合    
        //    IList<T> ts = new List<T>();
        //    // 获得此模型的类型   
        //    Type type = typeof(T);
        //    string tempName = string.Empty;
        //    foreach (SqlSugar.DataRow dr in dt.Rows)
        //    {
        //        T t = new T();
        //        // 获得此模型的公共属性      
        //        PropertyInfo[] propertys = t.GetType().GetProperties();
        //        // 遍历该对象的所有属性
        //        foreach (PropertyInfo pi in propertys)
        //        {
        //            tempName = pi.Name;  // 检查DataTable是否包含此列    
        //            if (dt.Columns.ContainsKey(tempName))
        //            {
        //                // 判断此属性是否有Setter      
        //                if (!pi.CanWrite) continue;
        //                // 取值
        //                object value = dr[tempName];
        //                // 如果非空，则赋给对象的属性  
        //                if (value != DBNull.Value)
        //                    pi.SetValue(t, value, null);
        //            }
        //        }
        //        ts.Add(t);
        //    }
        //    return ts;
        //}
    }
}
