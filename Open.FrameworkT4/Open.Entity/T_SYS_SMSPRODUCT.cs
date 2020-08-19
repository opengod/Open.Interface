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
    /// T_SYS_SMSPRODUCT 
    /// </summary>    
   [Serializable]
   [SugarTable("T_SYS_SMSPRODUCT")]
    public class T_SYS_SMSPRODUCT
    {
    
        /// <summary>
        /// 短信产品ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("短信产品ID")]
        public decimal SMSPRODUCT_ID { get; set; }
    
        /// <summary>
        /// 短信产品名称
        /// </summary>
        
        [Description("短信产品名称")]
        public string SMSPRODUCT_NAME { get; set; }
    
        /// <summary>
        /// 短信产品单价
        /// </summary>
        
        [Description("短信产品单价")]
        public decimal SMSPRODUCT_PRICE { get; set; }
    
        /// <summary>
        /// 短信产品数量
        /// </summary>
        
        [Description("短信产品数量")]
        public decimal SMSPRODUCT_NUMBER { get; set; }
    
        /// <summary>
        /// 短信产品售卖总价
        /// </summary>
        
        [Description("短信产品售卖总价")]
        public decimal SMSPRODUCT_SAMOUNT { get; set; }
    
        /// <summary>
        /// 短信产品售卖开始时间
        /// </summary>
        
        [Description("短信产品售卖开始时间")]
        public DateTime SMSPRODUCT_SDATE { get; set; }
    
        /// <summary>
        /// 短信产品售卖结束时间
        /// </summary>
        
        [Description("短信产品售卖结束时间")]
        public DateTime SMSPRODUCT_EDATE { get; set; }
    
        /// <summary>
        /// 操作人姓名
        /// </summary>
        
        [Description("操作人姓名")]
        public string SMSPRODUCT_OPNAME { get; set; }
    
        /// <summary>
        /// 操作时间
        /// </summary>
        
        [Description("操作时间")]
        public DateTime SMSPRODUCT_OPDATE { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime SMSPRODUCT_CDATE { get; set; }
    
        /// <summary>
        /// 是否上架 0否 1是

        /// </summary>
        
        [Description("是否上架 0否 1是
")]
        public decimal SMSPRODUCT_ISUP { get; set; }
    }
}
