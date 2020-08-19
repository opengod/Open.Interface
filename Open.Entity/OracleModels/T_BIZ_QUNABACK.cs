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
    /// T_BIZ_QUNABACK 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_QUNABACK")]
    public class T_BIZ_QUNABACK
    {
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal ID { get; set; }
    
        /// <summary>
        /// 平台订单号
        /// </summary>
        
        [Description("平台订单号")]
        public string PARTNERORDERID { get; set; }
    
        /// <summary>
        /// 退款流水号
        /// </summary>
        
        [Description("退款流水号")]
        public string REFUNDSEQ { get; set; }
    
        /// <summary>
        /// 订单金额
        /// </summary>
        
        [Description("订单金额")]
        public decimal ORDERPRICE { get; set; }
    
        /// <summary>
        /// 订单数量
        /// </summary>
        
        [Description("订单数量")]
        public decimal ORDERQUANTITY { get; set; }
    
        /// <summary>
        /// 退款数量
        /// </summary>
        
        [Description("退款数量")]
        public decimal REFUNDQUANTITY { get; set; }
    
        /// <summary>
        /// 退款原因
        /// </summary>
        
        [Description("退款原因")]
        public string REFUNDRESON { get; set; }
    
        /// <summary>
        /// 退款说明
        /// </summary>
        
        [Description("退款说明")]
        public string REFUNDEXPLAIN { get; set; }
    
        /// <summary>
        /// 退款手续费
        /// </summary>
        
        [Description("退款手续费")]
        public decimal ORDERREFUNDCHARGE { get; set; }
    
        /// <summary>
        /// 退款是否成功F失败,T成功
        /// </summary>
        
        [Description("退款是否成功F失败,T成功")]
        public string ISBACKTRUE { get; set; }
    
        /// <summary>
        /// 添加时间
        /// </summary>
        
        [Description("添加时间")]
        public DateTime ADDTIME { get; set; }
    
        /// <summary>
        /// 是否回掉    1是回调
        /// </summary>
        
        [Description("是否回掉    1是回调")]
        public decimal BACKMETHOD { get; set; }
    }
}
