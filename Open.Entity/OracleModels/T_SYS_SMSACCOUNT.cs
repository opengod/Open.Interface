//-----------------------------------------------------------------------
// <Copyright>
// * copyright © 2020 open All Rights Reserved
// * version : 4.0.30319.42000
// * author  : open
// * history : Created by open 2020-08-19 11:17:17 
// </Copyright>
//-----------------------------------------------------------------------
using System;
using SqlSugar;
using System.ComponentModel;

namespace Open.Entity.Oracle
{
    /// <summary>
    /// T_SYS_SMSACCOUNT 
    /// </summary>    
   [Serializable]
   [SugarTable("T_SYS_SMSACCOUNT")]
    public class T_SYS_SMSACCOUNT
    {
    
        /// <summary>
        /// 短信账户信息ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("短信账户信息ID")]
        public decimal SMSACCOUNT_ID { get; set; }
    
        /// <summary>
        /// 企业ID
        /// </summary>
        
        [Description("企业ID")]
        public decimal SMSACCOUNT_ORGID { get; set; }
    
        /// <summary>
        /// 短信数量
        /// </summary>
        
        [Description("短信数量")]
        public decimal SMSACCOUNT_NUM { get; set; }
    
        /// <summary>
        /// 预警数量
        /// </summary>
        
        [Description("预警数量")]
        public decimal SMSACCOUNT_WARNNUM { get; set; }
    
        /// <summary>
        /// 预警接受人手机号
        /// </summary>
        
        [Description("预警接受人手机号")]
        public string SMSACCOUNT_PHONE { get; set; }
    
        /// <summary>
        /// 创建日期
        /// </summary>
        
        [Description("创建日期")]
        public DateTime SMSACCOUNT_CDATE { get; set; }
    }
}
