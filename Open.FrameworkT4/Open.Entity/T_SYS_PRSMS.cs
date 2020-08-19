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
    /// T_SYS_PRSMS 
    /// </summary>    
   [Serializable]
   [SugarTable("T_SYS_PRSMS")]
    public class T_SYS_PRSMS
    {
    
        /// <summary>
        /// 购买短信记录ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("购买短信记录ID")]
        public decimal PRSMS_ID { get; set; }
    
        /// <summary>
        /// 企业id
        /// </summary>
        
        [Description("企业id")]
        public decimal PRSMS_ORGID { get; set; }
    
        /// <summary>
        /// 短信商品id
        /// </summary>
        
        [Description("短信商品id")]
        public decimal PRSMS_SMSPRODUCTID { get; set; }
    
        /// <summary>
        /// 短信数量
        /// </summary>
        
        [Description("短信数量")]
        public decimal PRSMS_NUM { get; set; }
    
        /// <summary>
        /// 短信金额
        /// </summary>
        
        [Description("短信金额")]
        public decimal PRSMS_ACCOUNT { get; set; }
    
        /// <summary>
        /// 是否支付 0 未支付 1已支付
        /// </summary>
        
        [Description("是否支付 0 未支付 1已支付")]
        public decimal PRSMS_ISPAY { get; set; }
    
        /// <summary>
        /// 支付类型  支付宝  微信
        /// </summary>
        
        [Description("支付类型  支付宝  微信")]
        public string PRSMS_PTYPE { get; set; }
    
        /// <summary>
        /// 交易流水号
        /// </summary>
        
        [Description("交易流水号")]
        public string PRSMS_SERIALNO { get; set; }
    
        /// <summary>
        /// 第三方交易号
        /// </summary>
        
        [Description("第三方交易号")]
        public string PRSMS_PSERIALNO { get; set; }
    
        /// <summary>
        /// 操作人姓名
        /// </summary>
        
        [Description("操作人姓名")]
        public string PRSMS_OPNAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime PRSMS_CDATE { get; set; }
    }
}
