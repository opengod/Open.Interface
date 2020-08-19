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
    /// T_BIZ_ORDERSTATUS 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_ORDERSTATUS")]
    public class T_BIZ_ORDERSTATUS
    {
    
        /// <summary>
        /// 订单状态ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("订单状态ID")]
        public decimal ORDERSTATUS_ID { get; set; }
    
        /// <summary>
        /// 订单明细ID
        /// </summary>
        
        [Description("订单明细ID")]
        public decimal ORDERSTATUS_ITEMID { get; set; }
    
        /// <summary>
        /// F：已释放订单，B：作废，R：取消，N:未付款，S:已付款，G：已改签  H：已取纸质票，T:线上已检，O：线下已检M 已退款,E退款审核中,P：部分退票，A：全部退票,C 退票申请，D退票失败
        /// </summary>
        
        [Description("F：已释放订单，B：作废，R：取消，N:未付款，S:已付款，G：已改签  H：已取纸质票，T:线上已检，O：线下已检M 已退款,E退款审核中,P：部分退票，A：全部退票,C 退票申请，D退票失败")]
        public string ORDERSTATUS_STATUS { get; set; }
    
        /// <summary>
        /// 订单状态时间
        /// </summary>
        
        [Description("订单状态时间")]
        public DateTime ORDERSTATUS_TIME { get; set; }
    }
}
