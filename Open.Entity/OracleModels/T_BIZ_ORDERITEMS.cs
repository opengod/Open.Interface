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
    /// T_BIZ_ORDERITEMS 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_ORDERITEMS")]
    public class T_BIZ_ORDERITEMS
    {
    
        /// <summary>
        /// 订单明细表ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("订单明细表ID")]
        public decimal ORDERITEMS_ID { get; set; }
    
        /// <summary>
        /// 订单号
        /// </summary>
        
        [Description("订单号")]
        public string ORDER_NO { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string ORDER_SERIALNO { get; set; }
    
        /// <summary>
        /// 订单ID
        /// </summary>
        
        [Description("订单ID")]
        public decimal ORDER_ID { get; set; }
    
        /// <summary>
        /// 订单类型ID
        /// </summary>
        
        [Description("订单类型ID")]
        public decimal ORDER_TYPEID { get; set; }
    
        /// <summary>
        /// 外部订单号（ota订单号）
        /// </summary>
        
        [Description("外部订单号（ota订单号）")]
        public string ORDERITEMS_EXTERNALID { get; set; }
    
        /// <summary>
        /// 外部订单明细号（ota平台明细号）
        /// </summary>
        
        [Description("外部订单明细号（ota平台明细号）")]
        public string ORDERITEMS_EXTERNALITEMID { get; set; }
    
        /// <summary>
        /// 外部订单描述
        /// </summary>
        
        [Description("外部订单描述")]
        public string ORDERITEMS_EXTERNALDESC { get; set; }
    
        /// <summary>
        /// 外部订单明细描述
        /// </summary>
        
        [Description("外部订单明细描述")]
        public string ORDERITEMS_EXTERNALITEMDESC { get; set; }
    
        /// <summary>
        /// 产品ID
        /// </summary>
        
        [Description("产品ID")]
        public decimal ORDERITEMS_PRODUCTID { get; set; }
    
        /// <summary>
        /// 产品名称
        /// </summary>
        
        [Description("产品名称")]
        public string ORDERITEMS_PRODUCTNAME { get; set; }
    
        /// <summary>
        /// 景区ID
        /// </summary>
        
        [Description("景区ID")]
        public decimal ORDERITEMS_PARKID { get; set; }
    
        /// <summary>
        /// 景区名称
        /// </summary>
        
        [Description("景区名称")]
        public string ORDERITEMS_PARKNAME { get; set; }
    
        /// <summary>
        /// 数量
        /// </summary>
        
        [Description("数量")]
        public decimal ORDERITEMS_COUNT { get; set; }
    
        /// <summary>
        /// 单价
        /// </summary>
        
        [Description("单价")]
        public decimal ORDERITEMS_PRICE { get; set; }
    
        /// <summary>
        /// 折扣状态0是不折扣1是固定值2是折扣率
        /// </summary>
        
        [Description("折扣状态0是不折扣1是固定值2是折扣率")]
        public decimal ORDERITEMS_DISCOUNT { get; set; }
    
        /// <summary>
        /// 折扣固定值
        /// </summary>
        
        [Description("折扣固定值")]
        public decimal ORDERITEMS_DISAMOUNT { get; set; }
    
        /// <summary>
        /// 折扣率
        /// </summary>
        
        [Description("折扣率")]
        public decimal ORDERITEMS_DISRATE { get; set; }
    
        /// <summary>
        /// 金额小计
        /// </summary>
        
        [Description("金额小计")]
        public decimal ORDERITEMS_AMOUT { get; set; }
    
        /// <summary>
        /// 实际取票数量
        /// </summary>
        
        [Description("实际取票数量")]
        public decimal ORDERITEMS_REALCOUNT { get; set; }
    
        /// <summary>
        /// 实际金额小计
        /// </summary>
        
        [Description("实际金额小计")]
        public decimal ORDERITEMS_REALAMOUNT { get; set; }
    
        /// <summary>
        /// 结算单价
        /// </summary>
        
        [Description("结算单价")]
        public decimal ORDERITEMS_PAYPRICE { get; set; }
    
        /// <summary>
        /// 结算总价
        /// </summary>
        
        [Description("结算总价")]
        public decimal ORDERITEMS_PAYAMOUNT { get; set; }
    
        /// <summary>
        /// 支付方式ID
        /// </summary>
        
        [Description("支付方式ID")]
        public decimal OPDERITEMS_PAYID { get; set; }
    
        /// <summary>
        /// 取票人姓名
        /// </summary>
        
        [Description("取票人姓名")]
        public string ORDERITEMS_NAME { get; set; }
    
        /// <summary>
        /// 取票人身份证
        /// </summary>
        
        [Description("取票人身份证")]
        public string ORDERITEMS_ICNO { get; set; }
    
        /// <summary>
        /// 取票人的手机
        /// </summary>
        
        [Description("取票人的手机")]
        public string ORDERITEMS_PHONE { get; set; }
    
        /// <summary>
        /// 取票人邮箱
        /// </summary>
        
        [Description("取票人邮箱")]
        public string ORDERITEMS_EMAIL { get; set; }
    
        /// <summary>
        /// 游玩开始日期时间
        /// </summary>
        
        [Description("游玩开始日期时间")]
        public DateTime ORDERITEMS_STARTDAY { get; set; }
    
        /// <summary>
        /// 游玩结束日期时间
        /// </summary>
        
        [Description("游玩结束日期时间")]
        public DateTime ORDERITEMS_ENDDAY { get; set; }
    
        /// <summary>
        /// 检票总人数
        /// </summary>
        
        [Description("检票总人数")]
        public decimal ORDERITEMS_CHECKPEOPLE { get; set; }
    
        /// <summary>
        /// 线上检票人数
        /// </summary>
        
        [Description("线上检票人数")]
        public decimal ORDERITEMS_CHECKONLINE { get; set; }
    
        /// <summary>
        /// 线下检票人数
        /// </summary>
        
        [Description("线下检票人数")]
        public decimal ORDERITEMS_CHECKOFFLINE { get; set; }
    
        /// <summary>
        /// 产品包编码
        /// </summary>
        
        [Description("产品包编码")]
        public string ORDERITEMS_PACKCODE { get; set; }
    
        /// <summary>
        /// 是否同步到景区标识
        /// </summary>
        
        [Description("是否同步到景区标识")]
        public string ORDERITEMS_FLAG { get; set; }
    
        /// <summary>
        /// 是否发送彩信标识(是否营业外)
        /// </summary>
        
        [Description("是否发送彩信标识(是否营业外)")]
        public string ORDERITEMS_ISMMS { get; set; }
    
        /// <summary>
        /// 电子串码
        /// </summary>
        
        [Description("电子串码")]
        public string ORDERITEMS_CODE { get; set; }
    
        /// <summary>
        /// 逻辑删除
        /// </summary>
        
        [Description("逻辑删除")]
        public string ISLOGIDEL { get; set; }
    
        /// <summary>
        /// 产品包ID
        /// </summary>
        
        [Description("产品包ID")]
        public decimal ORDERITEMS_PACKID { get; set; }
    
        /// <summary>
        /// 预约使用时间，原订单老时间
        /// </summary>
        
        [Description("预约使用时间，原订单老时间")]
        public DateTime ORDERITEMS_OLDTIME { get; set; }
    
        /// <summary>
        /// 订单状态
        /// </summary>
        
        [Description("订单状态")]
        public string ORDERITEMS_ORDERSTATUS { get; set; }
    
        /// <summary>
        /// 是否平台发送短信标识 1：平台发送 2：OTA发送
        /// </summary>
        
        [Description("是否平台发送短信标识 1：平台发送 2：OTA发送")]
        public string ISPLATSENT { get; set; }
    
        /// <summary>
        /// 退票数量
        /// </summary>
        
        [Description("退票数量")]
        public decimal ORDERITEMS_REFUNDCOUNT { get; set; }
    
        /// <summary>
        /// 银行或第三方支付编码(001 现金 002 银联 003 支付宝 004微信005 Apple Pay)
        /// </summary>
        
        [Description("银行或第三方支付编码(001 现金 002 银联 003 支付宝 004微信005 Apple Pay)")]
        public string ORDERITEMS_SYSPAYTYPE { get; set; }
    
        /// <summary>
        /// 是否预定时间限制，不限制为0，限制时间xx小时
        /// </summary>
        
        [Description("是否预定时间限制，不限制为0，限制时间xx小时")]
        public decimal ORDERITEMS_NCNUM { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public DateTime ORDERITEMS_NCDATE { get; set; }
    }
}
