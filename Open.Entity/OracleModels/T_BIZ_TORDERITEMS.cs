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
    /// T_BIZ_TORDERITEMS 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_TORDERITEMS")]
    public class T_BIZ_TORDERITEMS
    {
    
        /// <summary>
        /// 订单明细ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("订单明细ID")]
        public decimal TITEMS_ID { get; set; }
    
        /// <summary>
        /// 订单ID
        /// </summary>
        
        [Description("订单ID")]
        public decimal TITEMS_TORDERID { get; set; }
    
        /// <summary>
        /// otaid
        /// </summary>
        
        [Description("otaid")]
        public decimal TITEMS_OTAID { get; set; }
    
        /// <summary>
        /// 订单号
        /// </summary>
        
        [Description("订单号")]
        public string TITEMS_TORDERNO { get; set; }
    
        /// <summary>
        /// 订单日期
        /// </summary>
        
        [Description("订单日期")]
        public DateTime TITEMS_CDATE { get; set; }
    
        /// <summary>
        /// 产品包ID
        /// </summary>
        
        [Description("产品包ID")]
        public decimal TITEMS_PACKID { get; set; }
    
        /// <summary>
        /// 产品ID
        /// </summary>
        
        [Description("产品ID")]
        public decimal TITEMS_PRODUCTID { get; set; }
    
        /// <summary>
        /// 产品名称
        /// </summary>
        
        [Description("产品名称")]
        public string TITEMS_PRODUCTNAME { get; set; }
    
        /// <summary>
        /// 产品价格
        /// </summary>
        
        [Description("产品价格")]
        public decimal TITEMS_PRODUCTPRICE { get; set; }
    
        /// <summary>
        /// 产品数量
        /// </summary>
        
        [Description("产品数量")]
        public decimal TITEMS_NUMBER { get; set; }
    
        /// <summary>
        /// 小计
        /// </summary>
        
        [Description("小计")]
        public decimal TITEMS_AMOUNT { get; set; }
    
        /// <summary>
        /// 出票(入园)人数
        /// </summary>
        
        [Description("出票(入园)人数")]
        public decimal TITEMS_INCOUNT { get; set; }
    
        /// <summary>
        /// 出票金额
        /// </summary>
        
        [Description("出票金额")]
        public decimal TITEMS_INAMOUNT { get; set; }
    
        /// <summary>
        /// 景区ID
        /// </summary>
        
        [Description("景区ID")]
        public decimal TITEMS_PARKID { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string TITEMS_ISSMS { get; set; }
    }
}
