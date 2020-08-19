using System;
using System.Collections.Generic;
using System.Text;

namespace Open.Utils
{
    public class FieldValueParam
    {
        /// <summary>
        /// 字段名称
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 数据值
        /// </summary>
        public object value { get; set; }
        /// <summary>
        /// 数据类型
        /// </summary>
        public int type { get; set; }
        /// <summary>
        /// 操作符
        /// </summary>
        public string operation { get; set; }
    }
}
