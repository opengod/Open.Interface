using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Open.Utils.Helper
{
    public static class PropertyHelper
    {

        /// <summary>
        /// 获取类型成员描述，使用DescriptionAttribute设置描述
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="FieldName">属性名称</param>
        /// <returns></returns>
        public static string GetDescription<T>(string FieldName)
        {
            try
            {
                PropertyDescriptor pd = TypeDescriptor.GetProperties(typeof(T))[FieldName];
                DescriptionAttribute description = pd == null ? null : pd.Attributes[typeof(DescriptionAttribute)] as DescriptionAttribute;
                string str = description == null ? "" : description.Description;
                return str;
            }
            catch
            {
                return "";
            }
        }

        public static string GetProperties<T>(T t)
        {
            string tStr = string.Empty;
            if (t == null)
            {
                return tStr;
            }
            System.Reflection.PropertyInfo[] properties = t.GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);

            if (properties.Length <= 0)
            {
                return tStr;
            }
            foreach (System.Reflection.PropertyInfo item in properties)
            {
                string name = item.Name; //名称
                object value = item.GetValue(t, null);  //值
                string des = ((DescriptionAttribute)Attribute.GetCustomAttribute(item, typeof(DescriptionAttribute))).Description;// 属性值

                if (item.PropertyType.IsValueType || item.PropertyType.Name.StartsWith("String"))
                {
                    tStr += string.Format("{0}:{1}:{2},", name, value, des);
                }
                else
                {
                    GetProperties(value);
                }
            }
            return tStr;
        }
    }
}
