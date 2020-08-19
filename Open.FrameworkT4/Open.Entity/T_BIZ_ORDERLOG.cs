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
    /// T_BIZ_ORDERLOG 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_ORDERLOG")]
    public class T_BIZ_ORDERLOG
    {
    
        /// <summary>
        /// 订单日志主键ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("订单日志主键ID")]
        public decimal ORDERLOG_ID { get; set; }
    
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
        /// 操作行为
        /// </summary>
        
        [Description("操作行为")]
        public string ORDERLOG_EVENT { get; set; }
    
        /// <summary>
        /// 订单状态（N创建成功，I已支付待取货，E未支付待取货（到店支付），S支付成功，D酒店待确认，B酒店已确认，R退款成功，K部分退款成功，M退款审核中，P退款审核成功，O退款失败，A订单取消，C订单改期，T订单部分核销，V订单全部核销）
        /// </summary>
        
        [Description("订单状态（N创建成功，I已支付待取货，E未支付待取货（到店支付），S支付成功，D酒店待确认，B酒店已确认，R退款成功，K部分退款成功，M退款审核中，P退款审核成功，O退款失败，A订单取消，C订单改期，T订单部分核销，V订单全部核销）")]
        public string ORDERLOG_STATUS { get; set; }
    
        /// <summary>
        /// 时间
        /// </summary>
        
        [Description("时间")]
        public DateTime ORDERLOG_DATE { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string ORDERLOG_MEMO { get; set; }
    
        /// <summary>
        /// 逻辑删除
        /// </summary>
        
        [Description("逻辑删除")]
        public string ORDERLOG_ISDEL { get; set; }
    }
}
