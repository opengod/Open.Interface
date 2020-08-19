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
    /// T_RPT_HOTELRTT 
    /// </summary>    
   [Serializable]
   [SugarTable("T_RPT_HOTELRTT")]
    public class T_RPT_HOTELRTT
    {
    
        /// <summary>
        /// 退票信息ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("退票信息ID")]
        public decimal HOTELRTT_ID { get; set; }
    
        /// <summary>
        /// 订单号
        /// </summary>
        
        [Description("订单号")]
        public string HOTELRTT_ORDERNO { get; set; }
    
        /// <summary>
        /// 退款费用状态0是退票没费用1是固定值2是退票率
        /// </summary>
        
        [Description("退款费用状态0是退票没费用1是固定值2是退票率")]
        public decimal HOTELRTT_DISSTATUS { get; set; }
    
        /// <summary>
        /// 退款固定值
        /// </summary>
        
        [Description("退款固定值")]
        public decimal HOTELRTT_DISAMOUNT { get; set; }
    
        /// <summary>
        /// 退款比例
        /// </summary>
        
        [Description("退款比例")]
        public decimal HOTELRTT_DISRATE { get; set; }
    
        /// <summary>
        /// 是否退款0是否1是
        /// </summary>
        
        [Description("是否退款0是否1是")]
        public decimal HOTELRTT_BACKSTATUS { get; set; }
    
        /// <summary>
        /// 退款手续费
        /// </summary>
        
        [Description("退款手续费")]
        public decimal HOTELRTT_AMOUT { get; set; }
    
        /// <summary>
        /// 退款是否审核0是否1是
        /// </summary>
        
        [Description("退款是否审核0是否1是")]
        public decimal HOTELRTT_CHECKSTATUS { get; set; }
    
        /// <summary>
        /// 退款单价
        /// </summary>
        
        [Description("退款单价")]
        public decimal HOTELRTT_PRICE { get; set; }
    
        /// <summary>
        /// 退款数量
        /// </summary>
        
        [Description("退款数量")]
        public decimal HOTELRTT_COUNT { get; set; }
    
        /// <summary>
        /// 退款总价
        /// </summary>
        
        [Description("退款总价")]
        public decimal HOTELRTT_SUMAMOUT { get; set; }
    
        /// <summary>
        /// 退款时间
        /// </summary>
        
        [Description("退款时间")]
        public DateTime HOTELRTT_DATE { get; set; }
    
        /// <summary>
        /// 退款房间ID
        /// </summary>
        
        [Description("退款房间ID")]
        public decimal HOTELRTT_ROOMID { get; set; }
    
        /// <summary>
        /// 退款审核人ID
        /// </summary>
        
        [Description("退款审核人ID")]
        public decimal HOTELRTT_PEOPLEID { get; set; }
    
        /// <summary>
        /// 退款审核时间
        /// </summary>
        
        [Description("退款审核时间")]
        public DateTime HOTELRTT_CHECKTIME { get; set; }
    
        /// <summary>
        /// 订单明细ID
        /// </summary>
        
        [Description("订单明细ID")]
        public decimal HOTELRTT_ORDERITEMID { get; set; }
    
        /// <summary>
        /// 退款规则ID
        /// </summary>
        
        [Description("退款规则ID")]
        public decimal HOTELRTT_BACKROLE_ID { get; set; }
    
        /// <summary>
        /// 退往企业ID
        /// </summary>
        
        [Description("退往企业ID")]
        public decimal HOTELRTT_ORG_ID { get; set; }
    
        /// <summary>
        /// 逻辑删除
        /// </summary>
        
        [Description("逻辑删除")]
        public string HOTELRTT_ISLOGIDEL { get; set; }
    
        /// <summary>
        /// 退款产品包ID
        /// </summary>
        
        [Description("退款产品包ID")]
        public decimal HOTELRTT_PACKID { get; set; }
    
        /// <summary>
        /// 旅行社OTAID
        /// </summary>
        
        [Description("旅行社OTAID")]
        public decimal HOTELRTT_OTAID { get; set; }
    }
}
