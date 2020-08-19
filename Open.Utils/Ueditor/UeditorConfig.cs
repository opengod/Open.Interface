using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Open.Utils.Ueditor
{
    /// <summary>
    /// 百度编辑器UE配置文件操作文件操作
    /// </summary>
    public static class UeditorConfig
    {
        private static bool noCache = true;
        private static JObject BuildItems()
        {
            var json = File.ReadAllText(Common.GetWebRootPath(@"/Content/js/ueditor/config/config.json"));
            return JObject.Parse(json);
        }
        public static JObject Items
        {
            get
            {
                if (noCache || _Items == null)
                {
                    _Items = BuildItems();
                }
                return _Items;
            }
        }
        private static JObject _Items;

        public static T GetValue<T>(string key)
        {
            return Items[key].Value<T>();
        }

        public static string[] GetStringList(string key)
        {
            return Items[key].Select(x => x.Value<string>()).ToArray();
        }

        public static string GetString(string key)
        {
            return GetValue<string>(key);
        }

        public static int GetInt(string key)
        {
            return GetValue<int>(key);
        }
    }
}
