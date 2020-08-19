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
    /// T_BIZ_RECHARGE 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_RECHARGE")]
    public class T_BIZ_RECHARGE
    {
    
        /// <summary>
        /// 充值明细ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("充值明细ID")]
        public decimal RECHARGE_ID { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public DateTime RECHARGE_DATE { get; set; }
    
        /// <summary>
        /// 人员ID
        /// </summary>
        
        [Description("人员ID")]
        public decimal RECHARGE_USERID { get; set; }
    
        /// <summary>
        /// 金额
        /// </summary>
        
        [Description("金额")]
        public decimal RECHARGE_AMOUNT { get; set; }
    
        /// <summary>
        /// 充值类型ID
        /// </summary>
        
        [Description("充值类型ID")]
        public decimal RECHARGE_CHAGEID { get; set; }
    
        /// <summary>
        /// 操作人电脑IP
        /// </summary>
        
        [Description("操作人电脑IP")]
        public string RECHARGE_IP { get; set; }
    
        /// <summary>
        /// OTAID
        /// </summary>
        
        [Description("OTAID")]
        public decimal RECHARGE_OTAID { get; set; }
    
        /// <summary>
        /// 景区ID
        /// </summary>
        
        [Description("景区ID")]
        public decimal RECHARGE_PARKID { get; set; }
    
        /// <summary>
        /// 财务账户ID
        /// </summary>
        
        [Description("财务账户ID")]
        public decimal BALANCE_ID { get; set; }
    
        /// <summary>
        /// 逻辑删除
        /// </summary>
        
        [Description("逻辑删除")]
        public string RECHARGE_ISLOGIDEL { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string RECHARGE_SERIALNO { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string RECHARGE_TPSERIALNO { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string RECHARGE_BANKCODE { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string RECHARGE_ISFINISH { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string RECHARGE_ORDERNO { get; set; }
    }
}
