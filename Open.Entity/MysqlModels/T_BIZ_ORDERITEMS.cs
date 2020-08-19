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
    /// T_BIZ_ORDERITEMS 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_ORDERITEMS")]
    public class T_BIZ_ORDERITEMS
    {
    
        /// <summary>
        /// 订单明细主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("订单明细主键")]
        public decimal ORDERITEMS_ID { get; set; }
    
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
        /// 供应商ID
        /// </summary>
        
        [Description("供应商ID")]
        public decimal ORDERITEMS_SUPID { get; set; }
    
        /// <summary>
        /// 供应商编码
        /// </summary>
        
        [Description("供应商编码")]
        public string ORDERITEMS_SUPCODE { get; set; }
    
        /// <summary>
        /// 供应商名称
        /// </summary>
        
        [Description("供应商名称")]
        public string ORDERITEMS_SUPNAME { get; set; }
    
        /// <summary>
        /// 供应商订单ID
        /// </summary>
        
        [Description("供应商订单ID")]
        public string ORDER_SUPORDERID { get; set; }
    
        /// <summary>
        /// 供应商订单号
        /// </summary>
        
        [Description("供应商订单号")]
        public string ORDER_SUPORDERNO { get; set; }
    
        /// <summary>
        /// 供应商订单明细号
        /// </summary>
        
        [Description("供应商订单明细号")]
        public string ORDERITEMS_SUPORDERNO { get; set; }
    
        /// <summary>
        /// 订单类型（P景点，L线路，R餐饮，H酒店，E休闲娱乐，B商品，C旅游通卡）
        /// </summary>
        
        [Description("订单类型（P景点，L线路，R餐饮，H酒店，E休闲娱乐，B商品，C旅游通卡）")]
        public string ORDERITEMS_TYPE { get; set; }
    
        /// <summary>
        /// 产品类型（P景区，PT门票，PP套餐，H酒店，HR房间，HB会议室，L线路，C评论，T投诉，R餐饮，RP餐饮套餐，E休闲娱乐，EP娱乐套餐，B商店，BP商店商品）
        /// </summary>
        
        [Description("产品类型（P景区，PT门票，PP套餐，H酒店，HR房间，HB会议室，L线路，C评论，T投诉，R餐饮，RP餐饮套餐，E休闲娱乐，EP娱乐套餐，B商店，BP商店商品）")]
        public string ORDERITEMS_PRODUCTTYPE { get; set; }
    
        /// <summary>
        /// 产品ID
        /// </summary>
        
        [Description("产品ID")]
        public decimal ORDERITEMS_PRODUCTID { get; set; }
    
        /// <summary>
        /// 产品编码
        /// </summary>
        
        [Description("产品编码")]
        public string ORDERITEMS_PRODUCTCODE { get; set; }
    
        /// <summary>
        /// 产品名称
        /// </summary>
        
        [Description("产品名称")]
        public string ORDERITEMS_PRODUCTNAME { get; set; }
    
        /// <summary>
        /// 产品所属机构ID
        /// </summary>
        
        [Description("产品所属机构ID")]
        public decimal ORDERITEMS_PROORGID { get; set; }
    
        /// <summary>
        /// 产品所属机构名称
        /// </summary>
        
        [Description("产品所属机构名称")]
        public string ORDERITEMS_PROORGNAME { get; set; }
    
        /// <summary>
        /// 产品包ID
        /// </summary>
        
        [Description("产品包ID")]
        public decimal ORDERITEMS_PACKAGEID { get; set; }
    
        /// <summary>
        /// 产品包编码
        /// </summary>
        
        [Description("产品包编码")]
        public string ORDERITEMS_PACKAGECODE { get; set; }
    
        /// <summary>
        /// 产品包名称
        /// </summary>
        
        [Description("产品包名称")]
        public string ORDERITEMS_PACKAGENAME { get; set; }
    
        /// <summary>
        /// 优惠券ID
        /// </summary>
        
        [Description("优惠券ID")]
        public string ORDERITEMS_COUPONID { get; set; }
    
        /// <summary>
        /// 优惠券金额
        /// </summary>
        
        [Description("优惠券金额")]
        public decimal ORDERITEMS_COUPONPRICE { get; set; }
    
        /// <summary>
        /// 价格日历编码
        /// </summary>
        
        [Description("价格日历编码")]
        public string ORDERITEMS_CALCODE { get; set; }
    
        /// <summary>
        /// 价格日历名称
        /// </summary>
        
        [Description("价格日历名称")]
        public string ORDERITEMS_CALNAME { get; set; }
    
        /// <summary>
        /// 预定天数
        /// </summary>
        
        [Description("预定天数")]
        public decimal ORDERITEMS_BOOKDAYS { get; set; }
    
        /// <summary>
        /// 预定入住日期
        /// </summary>
        
        [Description("预定入住日期")]
        public DateTime ORDERITEMS_BOOKDATES { get; set; }
    
        /// <summary>
        /// 预定离店日期
        /// </summary>
        
        [Description("预定离店日期")]
        public DateTime ORDERITEMS_BOOKDATEE { get; set; }
    
        /// <summary>
        /// 最晚到店时间
        /// </summary>
        
        [Description("最晚到店时间")]
        public DateTime ORDERITEMS_ARRIVEDATE { get; set; }
    
        /// <summary>
        /// 是否担保订单
        /// </summary>
        
        [Description("是否担保订单")]
        public string ORDERITEMS_ISNEEDINVOICE { get; set; }
    
        /// <summary>
        /// 是否担保订单
        /// </summary>
        
        [Description("是否担保订单")]
        public string ORDERITEMS_ISGUARANTE { get; set; }
    
        /// <summary>
        /// 担保金额
        /// </summary>
        
        [Description("担保金额")]
        public decimal ORDERITEMS_GUARANTEPRICE { get; set; }
    
        /// <summary>
        /// 是否预付款
        /// </summary>
        
        [Description("是否预付款")]
        public string ORDERITEMS_ISADVANCE { get; set; }
    
        /// <summary>
        /// 预付款金额
        /// </summary>
        
        [Description("预付款金额")]
        public decimal ORDERITEMS_ADVANCEPRICE { get; set; }
    
        /// <summary>
        /// 到店支付金额金额
        /// </summary>
        
        [Description("到店支付金额金额")]
        public decimal ORDERITEMS_ARRIVEPRICE { get; set; }
    
        /// <summary>
        /// 游玩开始时间（实际到店时间）
        /// </summary>
        
        [Description("游玩开始时间（实际到店时间）")]
        public DateTime ORDERITEMS_DATES { get; set; }
    
        /// <summary>
        /// 游玩结束时间（实际离店时间）
        /// </summary>
        
        [Description("游玩结束时间（实际离店时间）")]
        public DateTime ORDERITEMS_DATEE { get; set; }
    
        /// <summary>
        /// 游玩人
        /// </summary>
        
        [Description("游玩人")]
        public string ORDERITEMS_NAME { get; set; }
    
        /// <summary>
        /// 游玩人电话
        /// </summary>
        
        [Description("游玩人电话")]
        public string ORDERITEMS_TEL { get; set; }
    
        /// <summary>
        /// 游玩人身份证
        /// </summary>
        
        [Description("游玩人身份证")]
        public string ORDERITEMS_ICNO { get; set; }
    
        /// <summary>
        /// 游玩人邮箱
        /// </summary>
        
        [Description("游玩人邮箱")]
        public string ORDERITEMS_EMAIL { get; set; }
    
        /// <summary>
        /// 是否含餐标
        /// </summary>
        
        [Description("是否含餐标")]
        public string ORDERITEMS_ISREPAST { get; set; }
    
        /// <summary>
        /// 餐标类型
        /// </summary>
        
        [Description("餐标类型")]
        public string ORDERITEMS_REPASTTYPE { get; set; }
    
        /// <summary>
        /// 餐标价格
        /// </summary>
        
        [Description("餐标价格")]
        public decimal ORDERITEMS_REPASTPRICE { get; set; }
    
        /// <summary>
        /// 是否加床
        /// </summary>
        
        [Description("是否加床")]
        public string ORDERITEMS_ISADDBED { get; set; }
    
        /// <summary>
        /// 加床价格
        /// </summary>
        
        [Description("加床价格")]
        public decimal ORDERITEMS_BEDPRICE { get; set; }
    
        /// <summary>
        /// 产品单价
        /// </summary>
        
        [Description("产品单价")]
        public decimal ORDERITEMS_PRICE { get; set; }
    
        /// <summary>
        /// 产品数量
        /// </summary>
        
        [Description("产品数量")]
        public decimal ORDERITEMS_COUNT { get; set; }
    
        /// <summary>
        /// 总金额
        /// </summary>
        
        [Description("总金额")]
        public decimal ORDERITEMS_AMOUNT { get; set; }
    
        /// <summary>
        /// 订单状态（N创建成功，I已支付待取货，E未支付待取货（到店支付），S支付成功，D酒店待确认，B酒店已确认，R退款成功，K部分退款成功，M退款审核中，P退款审核成功，O退款失败，A订单取消，C订单改期，T订单部分核销，V订单全部核销，H已支付待发货，G已支付已发货）
        /// </summary>
        
        [Description("订单状态（N创建成功，I已支付待取货，E未支付待取货（到店支付），S支付成功，D酒店待确认，B酒店已确认，R退款成功，K部分退款成功，M退款审核中，P退款审核成功，O退款失败，A订单取消，C订单改期，T订单部分核销，V订单全部核销，H已支付待发货，G已支付已发货）")]
        public string ORDERITEMS_STATUS { get; set; }
    
        /// <summary>
        /// 支付状态（I支付请求，S付款成功，J退款请求，R退款成功，K部分退款成功，M退款审核中，P退款审核成功，O退款失败；）
        /// </summary>
        
        [Description("支付状态（I支付请求，S付款成功，J退款请求，R退款成功，K部分退款成功，M退款审核中，P退款审核成功，O退款失败；）")]
        public string ORDERITEMS_PAYSTATUS { get; set; }
    
        /// <summary>
        /// 支付交易号
        /// </summary>
        
        [Description("支付交易号")]
        public string ORDERITEMS_PAYNO { get; set; }
    
        /// <summary>
        /// 支付方式 W：微信支付，D：到店支付,U：银联支付
        /// </summary>
        
        [Description("支付方式 W：微信支付，D：到店支付,U：银联支付")]
        public string ORDERITEMS_PAYTYPE { get; set; }
    
        /// <summary>
        /// 下单时间
        /// </summary>
        
        [Description("下单时间")]
        public DateTime ORDERITEMS_CREATEDATE { get; set; }
    
        /// <summary>
        /// 核销凭证
        /// </summary>
        
        [Description("核销凭证")]
        public string ORDERITEMS_CODE { get; set; }
    
        /// <summary>
        /// 核销时间
        /// </summary>
        
        [Description("核销时间")]
        public DateTime ORDERITEMS_CHETIME { get; set; }
    
        /// <summary>
        /// 核销总数量
        /// </summary>
        
        [Description("核销总数量")]
        public decimal ORDERITEMS_CHECOUNT { get; set; }
    
        /// <summary>
        /// 线上核销数量
        /// </summary>
        
        [Description("线上核销数量")]
        public decimal ORDERITEMS_CHEONLINE { get; set; }
    
        /// <summary>
        /// 线下核销数量
        /// </summary>
        
        [Description("线下核销数量")]
        public decimal ORDERITEMS_CHEOFFLINE { get; set; }
    
        /// <summary>
        /// 核销金额
        /// </summary>
        
        [Description("核销金额")]
        public decimal ORDERITEMS_CHEAMOUNT { get; set; }
    
        /// <summary>
        /// 退款时间
        /// </summary>
        
        [Description("退款时间")]
        public DateTime ORDERITEMS_REFTIME { get; set; }
    
        /// <summary>
        /// 退款人数
        /// </summary>
        
        [Description("退款人数")]
        public decimal ORDERITEMS_REFCOUNT { get; set; }
    
        /// <summary>
        /// 退款金额
        /// </summary>
        
        [Description("退款金额")]
        public decimal ORDERITEMS_REFAMOUNT { get; set; }
    
        /// <summary>
        /// 退款手续费
        /// </summary>
        
        [Description("退款手续费")]
        public decimal ORDERITEMS_REFPOUNDAGE { get; set; }
    
        /// <summary>
        /// 退款交易号
        /// </summary>
        
        [Description("退款交易号")]
        public string ORDERITEMS_REFNO { get; set; }
    
        /// <summary>
        /// 是否调用银联接口，生成分账订单
        /// </summary>
        
        [Description("是否调用银联接口，生成分账订单")]
        public string ORDERITEMS_ISDIVISION { get; set; }
    
        /// <summary>
        /// 商家分账总金额：所有商品结算价
        /// </summary>
        
        [Description("商家分账总金额：所有商品结算价")]
        public decimal ORDERITEMS_PLATFORMAMOUNT { get; set; }
    
        /// <summary>
        /// 平台所得利润（总金额-商户分账金额）
        /// </summary>
        
        [Description("平台所得利润（总金额-商户分账金额）")]
        public decimal ORDERITEMS_PROFITAMOUNT { get; set; }
    
        /// <summary>
        /// 是否已同步线下
        /// </summary>
        
        [Description("是否已同步线下")]
        public string ORDERITEMS_ISOFFLINE { get; set; }
    
        /// <summary>
        /// 是否已发送短信
        /// </summary>
        
        [Description("是否已发送短信")]
        public string ORDERITEMS_ISSMS { get; set; }
    
        /// <summary>
        /// 是否评论
        /// </summary>
        
        [Description("是否评论")]
        public string ORDERITEMS_ISCOMMENT { get; set; }
    
        /// <summary>
        /// 图片地址
        /// </summary>
        
        [Description("图片地址")]
        public string ORDERITEMS_IMAGEURL { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string ORDERITEMS_MEMO { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string ORDERITEMS_ISDEL { get; set; }
    }
}
