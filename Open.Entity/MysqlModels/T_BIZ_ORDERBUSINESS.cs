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
    /// T_BIZ_ORDERBUSINESS 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_ORDERBUSINESS")]
    public class T_BIZ_ORDERBUSINESS
    {
    
        /// <summary>
        /// 订单主表主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("订单主表主键")]
        public decimal OB_ID { get; set; }
    
        /// <summary>
        /// 订单号
        /// </summary>
        
        [Description("订单号")]
        public string ORDER_NO { get; set; }
    
        /// <summary>
        /// 发起支付的订单号
        /// </summary>
        
        [Description("发起支付的订单号")]
        public string OB_ORDER_NO { get; set; }
    
        /// <summary>
        /// 商家id
        /// </summary>
        
        [Description("商家id")]
        public decimal OB_ORGID { get; set; }
    
        /// <summary>
        /// 物流单号
        /// </summary>
        
        [Description("物流单号")]
        public string OB_EXPRESSNO { get; set; }
    
        /// <summary>
        /// 物流费用
        /// </summary>
        
        [Description("物流费用")]
        public decimal OB_EXPRESSCOST { get; set; }
    
        /// <summary>
        /// 物流公司编码
        /// </summary>
        
        [Description("物流公司编码")]
        public string OB_EXPRESSCODE { get; set; }
    
        /// <summary>
        /// 用户配送地址表id
        /// </summary>
        
        [Description("用户配送地址表id")]
        public decimal OB_ADDRESSID { get; set; }
    
        /// <summary>
        /// 该订单中，此商家的订单总金额
        /// </summary>
        
        [Description("该订单中，此商家的订单总金额")]
        public decimal OB_AMOUNT { get; set; }
    
        /// <summary>
        /// 下单时间
        /// </summary>
        
        [Description("下单时间")]
        public DateTime OB_CREDATE { get; set; }
    
        /// <summary>
        /// 逻辑删除
        /// </summary>
        
        [Description("逻辑删除")]
        public string OB_ISDEL { get; set; }
    }
}
