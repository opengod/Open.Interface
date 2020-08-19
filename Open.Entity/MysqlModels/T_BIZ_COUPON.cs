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
    /// T_BIZ_COUPON 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_COUPON")]
    public class T_BIZ_COUPON
    {
    
        /// <summary>
        /// 优惠券生成表主键ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("优惠券生成表主键ID")]
        public decimal COUPON_ID { get; set; }
    
        /// <summary>
        /// 优惠券生成码
        /// </summary>
        
        [Description("优惠券生成码")]
        public string COUPON_CODE { get; set; }
    
        /// <summary>
        /// 优惠卷产品ID
        /// </summary>
        
        [Description("优惠卷产品ID")]
        public string COUPON_PROID { get; set; }
    
        /// <summary>
        /// 优惠卷产品名称
        /// </summary>
        
        [Description("优惠卷产品名称")]
        public string COUPON_PRONAME { get; set; }
    
        /// <summary>
        /// 所属游客ID
        /// </summary>
        
        [Description("所属游客ID")]
        public decimal COUPON_MEMBERID { get; set; }
    
        /// <summary>
        /// 所属游客名称
        /// </summary>
        
        [Description("所属游客名称")]
        public string COUPON_MEMBERNAME { get; set; }
    
        /// <summary>
        /// 所属订单号
        /// </summary>
        
        [Description("所属订单号")]
        public string COUPON_ORDERNO { get; set; }
    
        /// <summary>
        /// 所属订单明细号
        /// </summary>
        
        [Description("所属订单明细号")]
        public string COUPON_ORDERITEMSNO { get; set; }
    
        /// <summary>
        /// 对应字典表活动类型
        /// </summary>
        
        [Description("对应字典表活动类型")]
        public string COUPON_TYPE { get; set; }
    
        /// <summary>
        /// 对应机构类型（P景点，L线路，R餐饮，H酒店，E休闲娱乐，B商品，C旅游通卡，T通用券）
        /// </summary>
        
        [Description("对应机构类型（P景点，L线路，R餐饮，H酒店，E休闲娱乐，B商品，C旅游通卡，T通用券）")]
        public string COUPON_ORGTYPE { get; set; }
    
        /// <summary>
        /// 所属企业ID
        /// </summary>
        
        [Description("所属企业ID")]
        public decimal COUPON_ORGID { get; set; }
    
        /// <summary>
        /// 所属企业名称
        /// </summary>
        
        [Description("所属企业名称")]
        public string COUPON_ORGNAME { get; set; }
    
        /// <summary>
        /// 所属产品id（门票、房间、旅游卡等）
        /// </summary>
        
        [Description("所属产品id（门票、房间、旅游卡等）")]
        public decimal COUPON_PRODUCTID { get; set; }
    
        /// <summary>
        /// 所属产品名称（门票、房间、旅游卡等）
        /// </summary>
        
        [Description("所属产品名称（门票、房间、旅游卡等）")]
        public string COUPON_PRODUCTNAME { get; set; }
    
        /// <summary>
        /// 是否新生优惠活动 T:是 F：否
        /// </summary>
        
        [Description("是否新生优惠活动 T:是 F：否")]
        public string COUPON_ISENTER { get; set; }
    
        /// <summary>
        /// 有效开始时间
        /// </summary>
        
        [Description("有效开始时间")]
        public DateTime COUPON_DATES { get; set; }
    
        /// <summary>
        /// 有效结束时间
        /// </summary>
        
        [Description("有效结束时间")]
        public DateTime COUPON_DATEE { get; set; }
    
        /// <summary>
        /// 是否可用，新增默认T，餐饮/休闲娱乐退款或取消，变成F
        /// </summary>
        
        [Description("是否可用，新增默认T，餐饮/休闲娱乐退款或取消，变成F")]
        public string COUPON_ISTRUE { get; set; }
    
        /// <summary>
        /// 是否使用，新增默认F，酒店/景区/线路下单支付后，为T
        /// </summary>
        
        [Description("是否使用，新增默认F，酒店/景区/线路下单支付后，为T")]
        public string COUPON_ISUSED { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string COUPON_ISDEL { get; set; }
    }
}
