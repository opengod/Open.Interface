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
    /// T_BIZ_RTT 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_RTT")]
    public class T_BIZ_RTT
    {
    
        /// <summary>
        /// 退票信息ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("退票信息ID")]
        public decimal RTT_ID { get; set; }
    
        /// <summary>
        /// 退票单号
        /// </summary>
        
        [Description("退票单号")]
        public string RTT_CODE { get; set; }
    
        /// <summary>
        /// 订单号
        /// </summary>
        
        [Description("订单号")]
        public string RTT_ORDERNO { get; set; }
    
        /// <summary>
        /// 退票费用状态0是退票没费用1是固定值2是退票率
        /// </summary>
        
        [Description("退票费用状态0是退票没费用1是固定值2是退票率")]
        public decimal RTT_DISSTATUS { get; set; }
    
        /// <summary>
        /// 退票固定值
        /// </summary>
        
        [Description("退票固定值")]
        public decimal RTT_DISAMOUNT { get; set; }
    
        /// <summary>
        /// 退票比例
        /// </summary>
        
        [Description("退票比例")]
        public decimal RTT_DISRATE { get; set; }
    
        /// <summary>
        /// 是否退票0是否1是
        /// </summary>
        
        [Description("是否退票0是否1是")]
        public decimal RTT_BACKSTATUS { get; set; }
    
        /// <summary>
        /// 退票手续费
        /// </summary>
        
        [Description("退票手续费")]
        public decimal RTT_AMOUT { get; set; }
    
        /// <summary>
        /// 退票是否审核0是否1是
        /// </summary>
        
        [Description("退票是否审核0是否1是")]
        public decimal RTT_CHECKSTATUS { get; set; }
    
        /// <summary>
        /// 退票单价
        /// </summary>
        
        [Description("退票单价")]
        public decimal RTT_PRICE { get; set; }
    
        /// <summary>
        /// 退票数量
        /// </summary>
        
        [Description("退票数量")]
        public decimal RTT_COUNT { get; set; }
    
        /// <summary>
        /// 退票总价
        /// </summary>
        
        [Description("退票总价")]
        public decimal RTT_SUMAMOUT { get; set; }
    
        /// <summary>
        /// 退票时间
        /// </summary>
        
        [Description("退票时间")]
        public DateTime RTT_DATE { get; set; }
    
        /// <summary>
        /// 退票门票ID
        /// </summary>
        
        [Description("退票门票ID")]
        public decimal RTT_ITEMID { get; set; }
    
        /// <summary>
        /// 退票审核人ID
        /// </summary>
        
        [Description("退票审核人ID")]
        public decimal RTT_PEOPLEID { get; set; }
    
        /// <summary>
        /// 退票审核时间
        /// </summary>
        
        [Description("退票审核时间")]
        public DateTime RTT_CHECKTIME { get; set; }
    
        /// <summary>
        /// 订单明细ID
        /// </summary>
        
        [Description("订单明细ID")]
        public decimal RTT_ORDERITEMID { get; set; }
    
        /// <summary>
        /// 退票规则ID
        /// </summary>
        
        [Description("退票规则ID")]
        public decimal RTT_BACKROLE_ID { get; set; }
    
        /// <summary>
        /// 退往企业ID
        /// </summary>
        
        [Description("退往企业ID")]
        public decimal RTT_ORG_ID { get; set; }
    
        /// <summary>
        /// 逻辑删除
        /// </summary>
        
        [Description("逻辑删除")]
        public string RTT_ISLOGIDEL { get; set; }
    
        /// <summary>
        /// 退票产品包ID
        /// </summary>
        
        [Description("退票产品包ID")]
        public decimal RTT_PACKID { get; set; }
    
        /// <summary>
        /// 旅行社OTAID
        /// </summary>
        
        [Description("旅行社OTAID")]
        public decimal RTT_OTAID { get; set; }
    
        /// <summary>
        /// 创建者,用户ID
        /// </summary>
        
        [Description("创建者,用户ID")]
        public decimal RTT_CREATOR { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string RTT_MEMO { get; set; }
    
        /// <summary>
        /// 去哪回调0是未调用，1是调用
        /// </summary>
        
        [Description("去哪回调0是未调用，1是调用")]
        public decimal QUNAFLAG { get; set; }
    
        /// <summary>
        /// 退款流水号（美团）
        /// </summary>
        
        [Description("退款流水号（美团）")]
        public string REFUNDID { get; set; }
    }
}
