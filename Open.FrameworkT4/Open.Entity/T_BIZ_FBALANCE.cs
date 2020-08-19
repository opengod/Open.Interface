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
    /// T_BIZ_FBALANCE 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_FBALANCE")]
    public class T_BIZ_FBALANCE
    {
    
        /// <summary>
        /// 分销商财务账户表ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("分销商财务账户表ID")]
        public decimal AGN_BALANCE_ID { get; set; }
    
        /// <summary>
        /// 分销商ID
        /// </summary>
        
        [Description("分销商ID")]
        public decimal AGN_BALANCE_OTAID { get; set; }
    
        /// <summary>
        /// 财务账号余额
        /// </summary>
        
        [Description("财务账号余额")]
        public decimal AGN_BALANCE_BALANCE { get; set; }
    
        /// <summary>
        /// 信用帐户额度
        /// </summary>
        
        [Description("信用帐户额度")]
        public decimal AGN_BALANCE_CREDIT { get; set; }
    
        /// <summary>
        /// 信用账号已用额度
        /// </summary>
        
        [Description("信用账号已用额度")]
        public decimal AGN_BALANCE_CREDIT_BL { get; set; }
    
        /// <summary>
        /// 最近更新时间
        /// </summary>
        
        [Description("最近更新时间")]
        public DateTime AGN_BALANCE_UPDATE { get; set; }
    
        /// <summary>
        /// 账户状态
        /// </summary>
        
        [Description("账户状态")]
        public decimal AGN_BALANCE_STATUS { get; set; }
    
        /// <summary>
        /// 景点ID
        /// </summary>
        
        [Description("景点ID")]
        public decimal AGN_BALANCE_PARKID { get; set; }
    
        /// <summary>
        /// 景区ID
        /// </summary>
        
        [Description("景区ID")]
        public decimal AGN_BALANCE_ORGID { get; set; }
    
        /// <summary>
        /// 逻辑删除
        /// </summary>
        
        [Description("逻辑删除")]
        public string ISLOGIDEL { get; set; }
    
        /// <summary>
        /// 删除人ID
        /// </summary>
        
        [Description("删除人ID")]
        public decimal AGN_BALANCE_DELID { get; set; }
    
        /// <summary>
        /// 删除人
        /// </summary>
        
        [Description("删除人")]
        public string AGN_BALANCE_DELNAME { get; set; }
    
        /// <summary>
        /// 删除日期
        /// </summary>
        
        [Description("删除日期")]
        public DateTime AGN_BALANCE_DELDATE { get; set; }
    
        /// <summary>
        /// 财务账号占用金额
        /// </summary>
        
        [Description("财务账号占用金额")]
        public decimal AGN_BALANCE_FROZEN { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal AGN_WARNINNG_AMOUNT { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal AGN_FBLANCE_TYPE { get; set; }
    }
}
