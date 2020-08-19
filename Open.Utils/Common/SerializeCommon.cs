using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Open.Utils
{
    public static class SerializeCommon
    {
        #region 将Json数据格式转换为List

        public static List<T> JsonDeserialize<T>(string sJson)
        {
            List<T> list = new List<T>();

            //.net framework下
            //JavaScriptSerializer serializer = new JavaScriptSerializer();
            //var res = serializer.Serialize(YourObject);

            //.net core 下使用Newtonsoft.Json
            list = JsonConvert.DeserializeObject<List<T>>(sJson);
            return list;
        }

        public static T JsonDeserizlize<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
        #endregion

        #region 将List数据格式转换为Json
        /// <summary>
        /// 将List数据格式转换为Json
        /// </summary>
        /// <param name="list">List数据</param>
        /// <returns></returns>
        public static string ListSerializeJson<T>(List<T> list)
        {
            try
            {
                string sJson = "";
                sJson = JsonConvert.SerializeObject(list);
                return sJson;
            }
            catch (Exception ex) { throw ex; }
        }
        /// <summary>
        /// 将对象转为json字符串，并转换时间格式，时间戳转换
        /// </summary>
        /// <param name="t">json数据</param>
        /// <returns></returns>
        public static string ObjectSerializeJson<T>(T t)
        {
            try
            {
                var sJson = JsonConvert.SerializeObject(t);
                //转换时间格式，时间戳转换
                sJson = Regex.Replace(sJson, @"\\/Date\((\d+)\)\\/", match =>
                {
                    DateTime dt = new DateTime(1970, 1, 1);
                    dt = dt.AddMilliseconds(long.Parse(match.Groups[1].Value));
                    dt = dt.ToLocalTime();
                    return dt.ToString(); ;
                });
                return sJson;
            }
            catch (Exception ex) { throw ex; }
        }
        #endregion

        /// <summary>
        /// 将对象转为json字符串，并忽略为null的字段
        /// </summary>
        /// <param name="t">json数据</param>
        /// <returns></returns>
        public static string ObjectToJson<T>(T t)
        {
            try
            {
                var setting = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore };
                var ojson = JsonConvert.SerializeObject(t, setting);
                return ojson;
            }
            catch (Exception ex) { throw ex; }
        }

        /// <summary>
        /// 将json数据反序列化为Dictionary
        /// </summary>
        /// <param name="jsonData">json数据</param>
        /// <returns></returns>
        public static Dictionary<string, object> JsonToDictionary(string jsonData)
        {
            //实例化JavaScriptSerializer类的新实例
            try
            {
                //将指定的 JSON 字符串转换为 Dictionary<string, object> 类型的对象
                return JsonConvert.DeserializeObject<Dictionary<string, object>>(jsonData);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// 将Dictionary序列化为json数据
        /// </summary>
        /// <param name="jsonData">json数据</param>
        /// <returns></returns>
        public static string DictionaryToJson(Dictionary<string, object> dic)
        {
            //实例化JavaScriptSerializer类的新实例
            try
            {
                //将指定的 JSON 字符串转换为 Dictionary<string, object> 类型的对象
                return JsonConvert.SerializeObject(dic);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
