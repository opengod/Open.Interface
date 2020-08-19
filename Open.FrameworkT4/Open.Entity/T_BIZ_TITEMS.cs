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
    /// T_BIZ_TITEMS 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_TITEMS")]
    public class T_BIZ_TITEMS
    {
    
        /// <summary>
        /// 带团订单明细ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("带团订单明细ID")]
        public string TITEMS_ID { get; set; }
    
        /// <summary>
        /// 带团订单ID
        /// </summary>
        
        [Description("带团订单ID")]
        public string TITEMS_TORDERID { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string TITEMS_TORDERNO { get; set; }
    
        /// <summary>
        /// 产品所属企业ID
        /// </summary>
        
        [Description("产品所属企业ID")]
        public string TITEMS_SEALERID { get; set; }
    
        /// <summary>
        /// 产品ID
        /// </summary>
        
        [Description("产品ID")]
        public string TITEMS_PRODUCTID { get; set; }
    
        /// <summary>
        /// 产品名称
        /// </summary>
        
        [Description("产品名称")]
        public string TITEMS_PRODUCTNAME { get; set; }
    
        /// <summary>
        /// 产品名称
        /// </summary>
        
        [Description("产品名称")]
        public decimal TITEMS_PRODUCTPRICE { get; set; }
    
        /// <summary>
        /// 产品预订数量
        /// </summary>
        
        [Description("产品预订数量")]
        public decimal TITEMS_NUMBER { get; set; }
    
        /// <summary>
        /// 产品实到数量
        /// </summary>
        
        [Description("产品实到数量")]
        public decimal TITEMS_AMOUNT { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal TITEMS_INCOUNT { get; set; }
    
        /// <summary>
        /// 产品实到金额
        /// </summary>
        
        [Description("产品实到金额")]
        public decimal TITEMS_INAMOUNT { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string TITEMS_ISSMS { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string TITEMS_ECODE { get; set; }
    }
}
