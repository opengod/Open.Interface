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
    /// T_BIZ_OTA_INTY 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_OTA_INTY")]
    public class T_BIZ_OTA_INTY
    {
    
        /// <summary>
        /// ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("ID")]
        public decimal OTAINTY_ID { get; set; }
    
        /// <summary>
        /// 开始日期
        /// </summary>
        
        [Description("开始日期")]
        public DateTime OTAINTY_DATES { get; set; }
    
        /// <summary>
        /// 结束日期
        /// </summary>
        
        [Description("结束日期")]
        public DateTime OTAINTY_DATEE { get; set; }
    
        /// <summary>
        /// 产品ID
        /// </summary>
        
        [Description("产品ID")]
        public decimal OTAINTY_PDT_ID { get; set; }
    
        /// <summary>
        /// 产品名称
        /// </summary>
        
        [Description("产品名称")]
        public string OTAINTY_PDT_NAME { get; set; }
    
        /// <summary>
        /// OTAID
        /// </summary>
        
        [Description("OTAID")]
        public decimal OTAINTY_OTA_ID { get; set; }
    
        /// <summary>
        /// OTA名称
        /// </summary>
        
        [Description("OTA名称")]
        public string OTAINTY_OTA_NAME { get; set; }
    
        /// <summary>
        /// 景区ID
        /// </summary>
        
        [Description("景区ID")]
        public decimal OTAINTY_PARK_ID { get; set; }
    
        /// <summary>
        /// 景点名称
        /// </summary>
        
        [Description("景点名称")]
        public string OTAINTY_PARKNAME { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal OTAINTY_CREATEID { get; set; }
    
        /// <summary>
        /// 创建人名称
        /// </summary>
        
        [Description("创建人名称")]
        public string OTAINTY_CREATENAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime OTAINTY_CREATETIME { get; set; }
    
        /// <summary>
        /// 产品总数量
        /// </summary>
        
        [Description("产品总数量")]
        public decimal OTAINTY_COUNT { get; set; }
    
        /// <summary>
        /// 产品已售数量
        /// </summary>
        
        [Description("产品已售数量")]
        public decimal OTAINTY_SALEOUT { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string OTAINTY_DEL { get; set; }
    }
}
