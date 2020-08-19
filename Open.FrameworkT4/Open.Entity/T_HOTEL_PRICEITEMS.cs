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
    /// T_HOTEL_PRICEITEMS 
    /// </summary>    
   [Serializable]
   [SugarTable("T_HOTEL_PRICEITEMS")]
    public class T_HOTEL_PRICEITEMS
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal PRICEITEMS_ID { get; set; }
    
        /// <summary>
        /// 订单号
        /// </summary>
        
        [Description("订单号")]
        public string ORDER_NO { get; set; }
    
        /// <summary>
        /// 订单明细号
        /// </summary>
        
        [Description("订单明细号")]
        public string ORDERITEMS_NO { get; set; }
    
        /// <summary>
        /// 外部订单号
        /// </summary>
        
        [Description("外部订单号")]
        public string ORDER_EXTERNALID { get; set; }
    
        /// <summary>
        /// 外部订单明细号
        /// </summary>
        
        [Description("外部订单明细号")]
        public string ORDERITEMS_EXTERNALID { get; set; }
    
        /// <summary>
        /// 是否担保
        /// </summary>
        
        [Description("是否担保")]
        public string PRICEITEMS_ISGUARANTE { get; set; }
    
        /// <summary>
        /// 担保金额
        /// </summary>
        
        [Description("担保金额")]
        public decimal PRICEITEMS_GUARANTEPRICE { get; set; }
    
        /// <summary>
        /// 是否预付款
        /// </summary>
        
        [Description("是否预付款")]
        public string PRICEITEMS_ISADVANCE { get; set; }
    
        /// <summary>
        /// 预付金额
        /// </summary>
        
        [Description("预付金额")]
        public decimal PRICEITEMS_ADVANCEPRICE { get; set; }
    
        /// <summary>
        /// 到店支付金额
        /// </summary>
        
        [Description("到店支付金额")]
        public decimal PRICEITEMS_ARRIVEPRICE { get; set; }
    
        /// <summary>
        /// 否含餐标
        /// </summary>
        
        [Description("否含餐标")]
        public string PRICEITEMS_ISREPAST { get; set; }
    
        /// <summary>
        /// 餐标类型
        /// </summary>
        
        [Description("餐标类型")]
        public string PRICEITEMS_REPASTTYPE { get; set; }
    
        /// <summary>
        /// 餐标价格
        /// </summary>
        
        [Description("餐标价格")]
        public decimal PRICEITEMS_REPASTPRICE { get; set; }
    
        /// <summary>
        /// 是否加床
        /// </summary>
        
        [Description("是否加床")]
        public string PRICEITEMS_ISADDBED { get; set; }
    
        /// <summary>
        /// 加床价格
        /// </summary>
        
        [Description("加床价格")]
        public decimal PRICEITEMS_BEDPRICE { get; set; }
    
        /// <summary>
        /// 产品单价
        /// </summary>
        
        [Description("产品单价")]
        public decimal PRICEITEMS_PRICE { get; set; }
    
        /// <summary>
        /// 产品数量
        /// </summary>
        
        [Description("产品数量")]
        public decimal PRICEITEMS_COUNT { get; set; }
    
        /// <summary>
        /// 日期
        /// </summary>
        
        [Description("日期")]
        public DateTime PRICEITEMS_DATE { get; set; }
    
        /// <summary>
        /// 当天总金额
        /// </summary>
        
        [Description("当天总金额")]
        public decimal PRICEITEMS_DAYAMOUNT { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string PRICEITEMS_MEMO { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string PRICEITEMS_ISDEL { get; set; }
    }
}
