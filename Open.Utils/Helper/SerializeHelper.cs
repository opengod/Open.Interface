using Newtonsoft.Json;
using StackExchange.Redis;
using System.Text;

namespace Open.Utils.Helper
{
    public class SerializeHelper
    {
        /// <summary>
        /// 序列化
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static byte[] Serialize(object item)
        {
            var jsonString = JsonConvert.SerializeObject(item);
            return Encoding.UTF8.GetBytes(jsonString);
        }

        /// <summary>
        /// 反序列化
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public static T Deserialize<T>(byte[] value)
        {
            if (typeof(T).Name.Equals(typeof(string).Name))
            {
                return JsonConvert.DeserializeObject<T>($"'{value}'");
            }
            return JsonConvert.DeserializeObject<T>(Encoding.UTF8.GetString(value));
        }

        /// <summary>
        /// 反序列化
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public static T ConvertObj<T>(RedisValue value)
        {
            JsonSerializerSettings jsonConfig = new JsonSerializerSettings()
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                NullValueHandling = NullValueHandling.Ignore
            };

            if (typeof(T).Name.Equals(typeof(string).Name))
            {
                return JsonConvert.DeserializeObject<T>($"'{value}'", jsonConfig);
            }
            if (value.HasValue)
            {
                return JsonConvert.DeserializeObject<T>(value, jsonConfig);
            }
            return default(T);
        }
    }
}
