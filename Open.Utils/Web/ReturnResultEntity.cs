using System;
using System.Collections.Generic;
using System.Text;

namespace Open.Utils
{
    /// <summary>
    /// 返回结果
    /// </summary>
    /// <typeparam name="T">实体</typeparam>
    public class ReturnResultEntity<T> where T : class
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        public bool success { get; set; } = true;
        /// <summary>
        /// 状态码
        /// </summary>
        public int statusCode { get; set; } = 200;
        /// <summary>
        /// 信息
        /// </summary>
        public string message { get; set; }
        /// <summary>
        /// 数据实体
        /// </summary>
        public T data { get; set; }
    }
}
