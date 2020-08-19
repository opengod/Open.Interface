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
    /// T_RPT_HOTELORDERS 
    /// </summary>    
   [Serializable]
   [SugarTable("T_RPT_HOTELORDERS")]
    public class T_RPT_HOTELORDERS
    {
    
        /// <summary>
        /// a
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("a")]
        public decimal HOTELORDERS_ID { get; set; }
    
        /// <summary>
        /// 产品包编码
        /// </summary>
        
        [Description("产品包编码")]
        public string HOTELORDERS_PACKCODE { get; set; }
    
        /// <summary>
        /// 酒店ID
        /// </summary>
        
        [Description("酒店ID")]
        public decimal HOTELORDERS_HOTELID { get; set; }
    
        /// <summary>
        /// 酒店名称
        /// </summary>
        
        [Description("酒店名称")]
        public string HOTELORDERS_HOTELNAME { get; set; }
    
        /// <summary>
        /// 房间ID
        /// </summary>
        
        [Description("房间ID")]
        public decimal HOTELORDERS_ROOMID { get; set; }
    
        /// <summary>
        /// 房间名称
        /// </summary>
        
        [Description("房间名称")]
        public string HOTELORDERS_ROOMNAME { get; set; }
    
        /// <summary>
        /// 订单号
        /// </summary>
        
        [Description("订单号")]
        public string HOTELORDERS_CODE { get; set; }
    
        /// <summary>
        /// 外部订单号
        /// </summary>
        
        [Description("外部订单号")]
        public string HOTELORDERS_EXTERNALID { get; set; }
    
        /// <summary>
        /// 外部订单明细号
        /// </summary>
        
        [Description("外部订单明细号")]
        public string HOTELORDERS_EXTERNALITEMID { get; set; }
    
        /// <summary>
        /// 外部订单描述
        /// </summary>
        
        [Description("外部订单描述")]
        public string HOTELORDERS_EXTERNALDESC { get; set; }
    
        /// <summary>
        /// 外部订单明细描述
        /// </summary>
        
        [Description("外部订单明细描述")]
        public string HOTELORDERS_EXTERNALITEMDESC { get; set; }
    
        /// <summary>
        /// 网上价格（冗余）
        /// </summary>
        
        [Description("网上价格（冗余）")]
        public decimal HOTELORDERS_PRICE { get; set; }
    
        /// <summary>
        /// 原价格（冗余）
        /// </summary>
        
        [Description("原价格（冗余）")]
        public decimal HOTELORDERS_OPRICE { get; set; }
    
        /// <summary>
        /// 入住日期
        /// </summary>
        
        [Description("入住日期")]
        public DateTime HOTELORDERS_INDATE { get; set; }
    
        /// <summary>
        /// 入住天数
        /// </summary>
        
        [Description("入住天数")]
        public decimal HOTELORDERS_DAYS { get; set; }
    
        /// <summary>
        /// 实际入住日期
        /// </summary>
        
        [Description("实际入住日期")]
        public DateTime HOTELORDERS_REALINDATE { get; set; }
    
        /// <summary>
        /// 实际入住天数
        /// </summary>
        
        [Description("实际入住天数")]
        public decimal HOTELORDERS_REALDAYS { get; set; }
    
        /// <summary>
        /// 最晚入住时间
        /// </summary>
        
        [Description("最晚入住时间")]
        public DateTime HOTELORDERS_INTIME { get; set; }
    
        /// <summary>
        /// 总金额
        /// </summary>
        
        [Description("总金额")]
        public decimal HOTELORDERS_TOTALMONEY { get; set; }
    
        /// <summary>
        /// 实际总金额
        /// </summary>
        
        [Description("实际总金额")]
        public decimal HOTELORDERS_REALTOTALMONEY { get; set; }
    
        /// <summary>
        /// 订单人
        /// </summary>
        
        [Description("订单人")]
        public string HOTELORDERS_PERSON { get; set; }
    
        /// <summary>
        /// 订单人身份证号
        /// </summary>
        
        [Description("订单人身份证号")]
        public string HOTELORDERS_IDENTITYNO { get; set; }
    
        /// <summary>
        /// 订单人手机号码
        /// </summary>
        
        [Description("订单人手机号码")]
        public string HOTELORDERS_TEL { get; set; }
    
        /// <summary>
        /// F：已释放订单，B：作废，R：取消，N:未付款，S:已付款，G：已改签  H：已取纸质票，T:线上已检，O：线下已检M 已退款,E退款审核中,I:已入住
        /// </summary>
        
        [Description("F：已释放订单，B：作废，R：取消，N:未付款，S:已付款，G：已改签  H：已取纸质票，T:线上已检，O：线下已检M 已退款,E退款审核中,I:已入住")]
        public string HOTELORDERS_STATUS { get; set; }
    
        /// <summary>
        /// 原因（）
        /// </summary>
        
        [Description("原因（）")]
        public string HOTELORDERS_REASON { get; set; }
    
        /// <summary>
        /// --支付方式（1：在线，2：到付，3：不限）
        /// </summary>
        
        [Description("--支付方式（1：在线，2：到付，3：不限）")]
        public string HOTELORDERS_PAYTYPE { get; set; }
    
        /// <summary>
        /// 申请退款时间
        /// </summary>
        
        [Description("申请退款时间")]
        public DateTime HOTELORDERS_RDATE { get; set; }
    
        /// <summary>
        /// 退款审核通过时间
        /// </summary>
        
        [Description("退款审核通过时间")]
        public DateTime HOTELORDERS_RSDATE { get; set; }
    
        /// <summary>
        /// 下单时间
        /// </summary>
        
        [Description("下单时间")]
        public DateTime HOTELORDERS_CTIME { get; set; }
    
        /// <summary>
        /// 下单人
        /// </summary>
        
        [Description("下单人")]
        public decimal HOTELORDERS_CREATEBY { get; set; }
    
        /// <summary>
        /// 逻辑删除
        /// </summary>
        
        [Description("逻辑删除")]
        public string HOTELORDERS_DEL { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal HOTELORDERS_PACKID { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal ORDERQUANTITY { get; set; }
    
        /// <summary>
        /// 支付后短信是否发送成功
        /// </summary>
        
        [Description("支付后短信是否发送成功")]
        public string HOTELORDERS_ISMSM { get; set; }
    
        /// <summary>
        /// 改签后短信是否发送成功
        /// </summary>
        
        [Description("改签后短信是否发送成功")]
        public string HOTELORDERS_ISSMS { get; set; }
    
        /// <summary>
        /// 是否是平台发，1为平台发
        /// </summary>
        
        [Description("是否是平台发，1为平台发")]
        public decimal ISPLATSENT { get; set; }
    }
}
