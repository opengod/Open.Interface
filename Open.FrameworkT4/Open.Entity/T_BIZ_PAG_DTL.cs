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
    /// T_BIZ_PAG_DTL 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_PAG_DTL")]
    public class T_BIZ_PAG_DTL
    {
    
        /// <summary>
        /// 产品包价格明细ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("产品包价格明细ID")]
        public decimal PAG_DTL_ID { get; set; }
    
        /// <summary>
        /// 产品包ID
        /// </summary>
        
        [Description("产品包ID")]
        public decimal PACKAGE_ID { get; set; }
    
        /// <summary>
        /// 产品ID
        /// </summary>
        
        [Description("产品ID")]
        public decimal PRODUCT_ID { get; set; }
    
        /// <summary>
        /// 产品包编码
        /// </summary>
        
        [Description("产品包编码")]
        public string PAG_DTL_PACKCODE { get; set; }
    
        /// <summary>
        /// 产品编码
        /// </summary>
        
        [Description("产品编码")]
        public string PAG_DTL_PDTCODE { get; set; }
    
        /// <summary>
        /// 产品包名称
        /// </summary>
        
        [Description("产品包名称")]
        public string PAG_DTL_PACNAME { get; set; }
    
        /// <summary>
        /// 产品名称
        /// </summary>
        
        [Description("产品名称")]
        public string PAG_DTL_PDTNAME { get; set; }
    
        /// <summary>
        /// 产品包价格
        /// </summary>
        
        [Description("产品包价格")]
        public decimal PAG_DTL_PRICE { get; set; }
    
        /// <summary>
        /// 产品包价格明细日期
        /// </summary>
        
        [Description("产品包价格明细日期")]
        public DateTime PAG_DTL_SDATE { get; set; }
    
        /// <summary>
        /// 星期几
        /// </summary>
        
        [Description("星期几")]
        public string PAG_DTL_WEEKDAY { get; set; }
    
        /// <summary>
        /// 逻辑删除
        /// </summary>
        
        [Description("逻辑删除")]
        public string ISLOGIDEL { get; set; }
    
        /// <summary>
        /// 删除人ID
        /// </summary>
        
        [Description("删除人ID")]
        public decimal DTL_DELID { get; set; }
    
        /// <summary>
        /// 删除人
        /// </summary>
        
        [Description("删除人")]
        public string DTL_DELNAME { get; set; }
    
        /// <summary>
        /// 删除日期
        /// </summary>
        
        [Description("删除日期")]
        public DateTime DTL_DELDATE { get; set; }
    
        /// <summary>
        /// 创建企业ID
        /// </summary>
        
        [Description("创建企业ID")]
        public decimal DTL_COMPANYCID { get; set; }
    
        /// <summary>
        /// 创建企业名称
        /// </summary>
        
        [Description("创建企业名称")]
        public string DTL_COMPANYYNAME { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal PAG_DTL_PRICE1 { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal PAG_DTL_PRICE2 { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal PAG_DTL_PRICE3 { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal PAG_DTL_PRICE4 { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal PAG_DTL_PRICE5 { get; set; }
    }
}
