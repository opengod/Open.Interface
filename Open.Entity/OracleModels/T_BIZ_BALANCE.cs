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
    /// T_BIZ_BALANCE 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_BALANCE")]
    public class T_BIZ_BALANCE
    {
    
        /// <summary>
        /// 分销商财务账户表ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("分销商财务账户表ID")]
        public decimal BALANCE_ID { get; set; }
    
        /// <summary>
        /// 分销商ID
        /// </summary>
        
        [Description("分销商ID")]
        public decimal BALANCE_OTAID { get; set; }
    
        /// <summary>
        /// 财务账号余额
        /// </summary>
        
        [Description("财务账号余额")]
        public decimal BALANCE_BALANCE { get; set; }
    
        /// <summary>
        /// 信用帐户额度
        /// </summary>
        
        [Description("信用帐户额度")]
        public decimal BALANCE_CREDIT { get; set; }
    
        /// <summary>
        /// 信用账号已用额度
        /// </summary>
        
        [Description("信用账号已用额度")]
        public decimal BALANCE_CREDIT_BL { get; set; }
    
        /// <summary>
        /// 最近更新时间
        /// </summary>
        
        [Description("最近更新时间")]
        public DateTime BALANCE_UPDATE { get; set; }
    
        /// <summary>
        /// 账户状态
        /// </summary>
        
        [Description("账户状态")]
        public decimal BALANCE_STATUS { get; set; }
    
        /// <summary>
        /// 逻辑删除
        /// </summary>
        
        [Description("逻辑删除")]
        public string BALANCE_DEL { get; set; }
    }
}
