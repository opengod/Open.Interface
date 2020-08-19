using System;
using System.Collections.Generic;
using System.Text;

namespace Open.Utils.Extensions
{
    public class User_DataSet_Policies
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// 表名
        /// </summary>
        public string TableName { get; set; }
        /// <summary>
        /// 策略所需字段
        /// </summary>
        public string PolicyField { get; set; }
        /// <summary>
        /// 策略所需要值
        /// </summary>
        public string PolicyValue { get; set; }
        /// <summary>
        /// 策略操作符
        /// </summary>
        public string PolicyOperation { get; set; }
    }
}
