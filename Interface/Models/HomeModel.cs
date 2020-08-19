using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Interface.Models
{
    public class HomeModel
    {
        /// <summary>
        /// 会员ID
        /// </summary>
        [Description("会员ID")]
        public decimal ID { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        [Description("姓名")]
        public string Name { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        [Description("手机号")]
        public string Tel { get; set; }
        /// <summary>
        /// 身份证
        /// </summary>
        [Description("身份证")]
        public string Icno { get; set; }
        /// <summary>
        /// 预约数量
        /// </summary>
        [Description("预约数量")]
        public int Num { get; set; }
    }
}
