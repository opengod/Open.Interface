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
    /// T_BIZ_DISORDERITEMS 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_DISORDERITEMS")]
    public class T_BIZ_DISORDERITEMS
    {
    
        /// <summary>
        /// id
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("id")]
        public decimal DISORDERITEM_ID { get; set; }
    
        /// <summary>
        /// 分销单id
        /// </summary>
        
        [Description("分销单id")]
        public decimal DISORDERITEM_DISORDERID { get; set; }
    
        /// <summary>
        /// 分销单分录号
        /// </summary>
        
        [Description("分销单分录号")]
        public string DISORDERITEM_ENUM { get; set; }
    
        /// <summary>
        /// 创建日期
        /// </summary>
        
        [Description("创建日期")]
        public DateTime DISORDERITEM_CREATETIME { get; set; }
    
        /// <summary>
        /// 分销商ID
        /// </summary>
        
        [Description("分销商ID")]
        public decimal DISORDERITEM_DISID { get; set; }
    
        /// <summary>
        /// 卖家id
        /// </summary>
        
        [Description("卖家id")]
        public decimal DISORDERITEM_SELLERID { get; set; }
    
        /// <summary>
        /// 产品Id
        /// </summary>
        
        [Description("产品Id")]
        public decimal DISORDERITEM_PRODUCTID { get; set; }
    
        /// <summary>
        /// 产品名称
        /// </summary>
        
        [Description("产品名称")]
        public string DISORDERITEM_PRODUCTNAME { get; set; }
    
        /// <summary>
        /// 产品单价
        /// </summary>
        
        [Description("产品单价")]
        public decimal DISORDERITEM_PRODUCTPRICE { get; set; }
    
        /// <summary>
        /// 产品数量
        /// </summary>
        
        [Description("产品数量")]
        public decimal DISORDERITEM_PRODUCTNUM { get; set; }
    
        /// <summary>
        /// 配票数量
        /// </summary>
        
        [Description("配票数量")]
        public decimal DISORDERITEM_DISNUM { get; set; }
    
        /// <summary>
        /// 订单明细状态
        /// </summary>
        
        [Description("订单明细状态")]
        public string DISORDERITEM_STATUS { get; set; }
    }
}
