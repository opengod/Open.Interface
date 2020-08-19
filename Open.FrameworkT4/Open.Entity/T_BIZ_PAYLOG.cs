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
    /// T_BIZ_PAYLOG 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_PAYLOG")]
    public class T_BIZ_PAYLOG
    {
    
        /// <summary>
        /// 交易日志主键ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("交易日志主键ID")]
        public decimal PAYLOG_ID { get; set; }
    
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
        /// 交易号
        /// </summary>
        
        [Description("交易号")]
        public string PAYLOG_PAYNO { get; set; }
    
        /// <summary>
        /// 银联支付返回：时间戳
        /// </summary>
        
        [Description("银联支付返回：时间戳")]
        public string PAYLOG_TIMESTAMP { get; set; }
    
        /// <summary>
        /// 银联支付返回：签名
        /// </summary>
        
        [Description("银联支付返回：签名")]
        public string PAYLOG_PAYSIGN { get; set; }
    
        /// <summary>
        /// 银联支付返回：签名方式
        /// </summary>
        
        [Description("银联支付返回：签名方式")]
        public string PAYLOG_SIGNTYPE { get; set; }
    
        /// <summary>
        /// 银联支付返回：随机字符串
        /// </summary>
        
        [Description("银联支付返回：随机字符串")]
        public string PAYLOG_NONCESTR { get; set; }
    
        /// <summary>
        /// 退款交易号
        /// </summary>
        
        [Description("退款交易号")]
        public string PAYLOG_REFNO { get; set; }
    
        /// <summary>
        /// 总金额
        /// </summary>
        
        [Description("总金额")]
        public decimal PAYLOG_AMOUNT { get; set; }
    
        /// <summary>
        /// 操作行为
        /// </summary>
        
        [Description("操作行为")]
        public string PAYLOG_EVENT { get; set; }
    
        /// <summary>
        /// 支付方式(W微信)
        /// </summary>
        
        [Description("支付方式(W微信)")]
        public string PAYLOG_TYPE { get; set; }
    
        /// <summary>
        /// 支付状态（I支付请求，S付款成功，J退款请求，R退款成功，K部分退款成功，M退款审核中，P退款审核成功，O退款失败）
        /// </summary>
        
        [Description("支付状态（I支付请求，S付款成功，J退款请求，R退款成功，K部分退款成功，M退款审核中，P退款审核成功，O退款失败）")]
        public string PAYLOG_STATUS { get; set; }
    
        /// <summary>
        /// 支付时间
        /// </summary>
        
        [Description("支付时间")]
        public DateTime PAYLOG_DATE { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string PAYLOG_MEMO { get; set; }
    
        /// <summary>
        /// 逻辑删除
        /// </summary>
        
        [Description("逻辑删除")]
        public string PAYLOG_ISDEL { get; set; }
    }
}
