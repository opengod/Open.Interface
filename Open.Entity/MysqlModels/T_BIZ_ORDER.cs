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
    /// T_BIZ_ORDER 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_ORDER")]
    public class T_BIZ_ORDER
    {
    
        /// <summary>
        /// 订单主表主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("订单主表主键")]
        public decimal ORDER_ID { get; set; }
    
        /// <summary>
        /// 订单号
        /// </summary>
        
        [Description("订单号")]
        public string ORDER_NO { get; set; }
    
        /// <summary>
        /// 外部订单号
        /// </summary>
        
        [Description("外部订单号")]
        public string ORDER_EXTERNALID { get; set; }
    
        /// <summary>
        /// 订单类型（P景点，L线路，R餐饮，H酒店，E休闲娱乐，B商品，C旅游通卡）
        /// </summary>
        
        [Description("订单类型（P景点，L线路，R餐饮，H酒店，E休闲娱乐，B商品，C旅游通卡）")]
        public string ORDER_TYPE { get; set; }
    
        /// <summary>
        /// 产品ID（目前只有旅游通卡使用）
        /// </summary>
        
        [Description("产品ID（目前只有旅游通卡使用）")]
        public decimal ORDER_PRODUCTID { get; set; }
    
        /// <summary>
        /// 产品名称（目前只有旅游通卡使用）
        /// </summary>
        
        [Description("产品名称（目前只有旅游通卡使用）")]
        public string ORDER_PRODUCTNAME { get; set; }
    
        /// <summary>
        /// 游客ID
        /// </summary>
        
        [Description("游客ID")]
        public decimal ORDER_MEMBERID { get; set; }
    
        /// <summary>
        /// 订单人姓名
        /// </summary>
        
        [Description("订单人姓名")]
        public string ORDER_NAME { get; set; }
    
        /// <summary>
        /// 订单人手机号
        /// </summary>
        
        [Description("订单人手机号")]
        public string ORDER_TEL { get; set; }
    
        /// <summary>
        /// 订单人身份证
        /// </summary>
        
        [Description("订单人身份证")]
        public string ORDER_ICNO { get; set; }
    
        /// <summary>
        /// 订单人邮箱
        /// </summary>
        
        [Description("订单人邮箱")]
        public string ORDER_EMAIL { get; set; }
    
        /// <summary>
        /// 支付方式 W：微信支付，D：到店支付,U：银联支付
        /// </summary>
        
        [Description("支付方式 W：微信支付，D：到店支付,U：银联支付")]
        public string ORDER_PAYTYPE { get; set; }
    
        /// <summary>
        /// 订单状态（N创建成功，I已支付待取货，E未支付待取货（到店支付），S支付成功，D酒店待确认，B酒店已确认，R退款成功，K部分退款成功，M退款审核中，P退款审核成功，O退款失败，A订单取消，C订单改期，T订单部分核销，V订单全部核销，H已支付待发货，G已支付已发货）
        /// </summary>
        
        [Description("订单状态（N创建成功，I已支付待取货，E未支付待取货（到店支付），S支付成功，D酒店待确认，B酒店已确认，R退款成功，K部分退款成功，M退款审核中，P退款审核成功，O退款失败，A订单取消，C订单改期，T订单部分核销，V订单全部核销，H已支付待发货，G已支付已发货）")]
        public string ORDER_STATUS { get; set; }
    
        /// <summary>
        /// 支付状态（I支付请求，S付款成功，J退款请求，R退款成功，K部分退款成功，M退款审核中，P退款审核成功，O退款失败；）
        /// </summary>
        
        [Description("支付状态（I支付请求，S付款成功，J退款请求，R退款成功，K部分退款成功，M退款审核中，P退款审核成功，O退款失败；）")]
        public string ORDER_PAYSTATUS { get; set; }
    
        /// <summary>
        /// 物流单号
        /// </summary>
        
        [Description("物流单号")]
        public string ORDER_EXPRESSNO { get; set; }
    
        /// <summary>
        /// 物流费用
        /// </summary>
        
        [Description("物流费用")]
        public decimal ORDER_EXPRESSCOST { get; set; }
    
        /// <summary>
        /// 物流公司编码
        /// </summary>
        
        [Description("物流公司编码")]
        public string ORDER_EXPRESSCODE { get; set; }
    
        /// <summary>
        /// 用户配送地址表id
        /// </summary>
        
        [Description("用户配送地址表id")]
        public decimal ORDER_ADDRESSID { get; set; }
    
        /// <summary>
        /// 支付交易号
        /// </summary>
        
        [Description("支付交易号")]
        public string ORDER_PAYNO { get; set; }
    
        /// <summary>
        /// 支付时间
        /// </summary>
        
        [Description("支付时间")]
        public DateTime ORDER_PAYTIME { get; set; }
    
        /// <summary>
        /// 优惠券ID
        /// </summary>
        
        [Description("优惠券ID")]
        public decimal ORDER_COUPONID { get; set; }
    
        /// <summary>
        /// 优惠券编码
        /// </summary>
        
        [Description("优惠券编码")]
        public string ORDER_COUPONCODE { get; set; }
    
        /// <summary>
        /// 优惠券金额
        /// </summary>
        
        [Description("优惠券金额")]
        public decimal ORDER_COUPONPRICE { get; set; }
    
        /// <summary>
        /// 优惠券名称
        /// </summary>
        
        [Description("优惠券名称")]
        public string ORDER_COUPONNAME { get; set; }
    
        /// <summary>
        /// 下单时间
        /// </summary>
        
        [Description("下单时间")]
        public DateTime ORDER_CREATEDATE { get; set; }
    
        /// <summary>
        /// 渠道ID
        /// </summary>
        
        [Description("渠道ID")]
        public decimal ORDER_CHANNELID { get; set; }
    
        /// <summary>
        /// 渠道编号
        /// </summary>
        
        [Description("渠道编号")]
        public string ORDER_CHANNELCODE { get; set; }
    
        /// <summary>
        /// 渠道名称
        /// </summary>
        
        [Description("渠道名称")]
        public string ORDER_CHANNELNAME { get; set; }
    
        /// <summary>
        /// 订单标识符（OB：特产多商户订单）
        /// </summary>
        
        [Description("订单标识符（OB：特产多商户订单）")]
        public string ORDER_FLAG { get; set; }
    
        /// <summary>
        /// 订单总金额（包含快递费用）
        /// </summary>
        
        [Description("订单总金额（包含快递费用）")]
        public decimal ORDER_AMOUNT { get; set; }
    
        /// <summary>
        /// 是否调用银联接口，生成分账订单
        /// </summary>
        
        [Description("是否调用银联接口，生成分账订单")]
        public string ORDER_ISDIVISION { get; set; }
    
        /// <summary>
        /// 商家分账总金额：所有商品结算价+快递费用
        /// </summary>
        
        [Description("商家分账总金额：所有商品结算价+快递费用")]
        public decimal ORDER_PLATFORMAMOUNT { get; set; }
    
        /// <summary>
        /// 平台所得利润（总金额-商户分账金额）
        /// </summary>
        
        [Description("平台所得利润（总金额-商户分账金额）")]
        public decimal ORDER_PROFITAMOUNT { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string ORDER_MEMO { get; set; }
    
        /// <summary>
        /// 逻辑删除
        /// </summary>
        
        [Description("逻辑删除")]
        public string ORDER_ISDEL { get; set; }
    }
}
