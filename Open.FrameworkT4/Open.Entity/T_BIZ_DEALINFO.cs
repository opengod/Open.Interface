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
    /// T_BIZ_DEALINFO 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_DEALINFO")]
    public class T_BIZ_DEALINFO
    {
    
        /// <summary>
        /// 企业ID
        /// </summary>
        
        [Description("企业ID")]
        public decimal DEALINFO_ORG_ID { get; set; }
    
        /// <summary>
        /// 交易金额
        /// </summary>
        
        [Description("交易金额")]
        public decimal DEALINFO_AMOUNT { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime DEALINFO_CREATEDATE { get; set; }
    
        /// <summary>
        /// 标识
        /// </summary>
        
        [Description("标识")]
        public decimal DEALINFO_MARK { get; set; }
    
        /// <summary>
        /// 标识明细
        /// </summary>
        
        [Description("标识明细")]
        public string DEALINFO_MEMO { get; set; }
    
        /// <summary>
        /// 关联订单号
        /// </summary>
        
        [Description("关联订单号")]
        public string DEALINFO_ORDER_NO { get; set; }
    }
}
