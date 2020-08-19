//-----------------------------------------------------------------------
// <Copyright>
// * copyright © 2020 open All Rights Reserved
// * version : 4.0.30319.42000
// * author  : open
// * history : Created by open 2020-08-19 11:20:13 
// </Copyright>
//-----------------------------------------------------------------------
using System;
using SqlSugar;
using System.ComponentModel;

namespace Open.Entity.Mysql
{
    /// <summary>
    /// T_BUSINESS_CART 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BUSINESS_CART")]
    public class T_BUSINESS_CART
    {
    
        /// <summary>
        /// 商家商品表主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("商家商品表主键")]
        public decimal CART_ID { get; set; }
    
        /// <summary>
        /// 用户id
        /// </summary>
        
        [Description("用户id")]
        public decimal CART_MEMBERID { get; set; }
    
        /// <summary>
        /// 产品ID
        /// </summary>
        
        [Description("产品ID")]
        public decimal CART_PROID { get; set; }
    
        /// <summary>
        /// 产品名称
        /// </summary>
        
        [Description("产品名称")]
        public string CART_PRONAME { get; set; }
    
        /// <summary>
        /// 所属商家ID
        /// </summary>
        
        [Description("所属商家ID")]
        public decimal CART_ORGID { get; set; }
    
        /// <summary>
        /// 所属商家名称
        /// </summary>
        
        [Description("所属商家名称")]
        public string CART_ORGNAME { get; set; }
    
        /// <summary>
        /// 售卖价格
        /// </summary>
        
        [Description("售卖价格")]
        public decimal CART_PRICE { get; set; }
    
        /// <summary>
        /// 购买数量
        /// </summary>
        
        [Description("购买数量")]
        public decimal CART_NUM { get; set; }
    
        /// <summary>
        /// 总价
        /// </summary>
        
        [Description("总价")]
        public decimal CART_COUNT { get; set; }
    
        /// <summary>
        /// 特产主图
        /// </summary>
        
        [Description("特产主图")]
        public string CART_IMAGE { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime CART_CREDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string CART_ISDEL { get; set; }
    }
}
