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
    /// T_HOTEL_INFO 
    /// </summary>    
   [Serializable]
   [SugarTable("T_HOTEL_INFO")]
    public class T_HOTEL_INFO
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal HOTELINFO_ID { get; set; }
    
        /// <summary>
        /// 酒店ID
        /// </summary>
        
        [Description("酒店ID")]
        public decimal HOTELINFO_HOTELID { get; set; }
    
        /// <summary>
        /// 酒店名称
        /// </summary>
        
        [Description("酒店名称")]
        public string HOTELINFO_HOTELNAME { get; set; }
    
        /// <summary>
        /// 所属组别
        /// </summary>
        
        [Description("所属组别")]
        public string HOTELINFO_GROUP { get; set; }
    
        /// <summary>
        /// 支付方式1：在线支付，2：只展示不支付
        /// </summary>
        
        [Description("支付方式1：在线支付，2：只展示不支付")]
        public string HOTELINFO_PAYTYPE { get; set; }
    
        /// <summary>
        /// 酒店等级
        /// </summary>
        
        [Description("酒店等级")]
        public decimal HOTELINFO_LEVEL { get; set; }
    
        /// <summary>
        /// 酒店品牌
        /// </summary>
        
        [Description("酒店品牌")]
        public decimal HOTELINFO_BRAND { get; set; }
    
        /// <summary>
        /// 酒店主题
        /// </summary>
        
        [Description("酒店主题")]
        public decimal HOTELINFO_THEME { get; set; }
    
        /// <summary>
        /// 开业时间
        /// </summary>
        
        [Description("开业时间")]
        public string HOTELINFO_OPENTIME { get; set; }
    
        /// <summary>
        /// 退改规则
        /// </summary>
        
        [Description("退改规则")]
        public string HOTELINFO_RTTRULE { get; set; }
    
        /// <summary>
        /// 酒店服务（前台）
        /// </summary>
        
        [Description("酒店服务（前台）")]
        public string HOTELINFO_SERVICE { get; set; }
    
        /// <summary>
        /// 客房服务
        /// </summary>
        
        [Description("客房服务")]
        public string HOTELINFO_ROOMSERVICE { get; set; }
    
        /// <summary>
        /// 交通服务
        /// </summary>
        
        [Description("交通服务")]
        public string HOTELINFO_TRAFFICSERVICE { get; set; }
    
        /// <summary>
        /// 增值税普通发票或专用发票说明
        /// </summary>
        
        [Description("增值税普通发票或专用发票说明")]
        public string HOTELINFO_ISINVOICE { get; set; }
    
        /// <summary>
        /// 酒店信用评分
        /// </summary>
        
        [Description("酒店信用评分")]
        public decimal HOTELINFO_CREDIT { get; set; }
    
        /// <summary>
        /// 酒店评论分数
        /// </summary>
        
        [Description("酒店评论分数")]
        public decimal HOTELINFO_SCORE { get; set; }
    
        /// <summary>
        /// 经度
        /// </summary>
        
        [Description("经度")]
        public decimal HOTELINFO_LONGTUDE { get; set; }
    
        /// <summary>
        /// 纬度
        /// </summary>
        
        [Description("纬度")]
        public decimal HOTELINFO_LATITUDE { get; set; }
    
        /// <summary>
        /// 政策
        /// </summary>
        
        [Description("政策")]
        public string HOTELINFO_POLICY { get; set; }
    
        /// <summary>
        /// 详情
        /// </summary>
        
        [Description("详情")]
        public string HOTELINFO_PRODUCTION { get; set; }
    
        /// <summary>
        /// 设施
        /// </summary>
        
        [Description("设施")]
        public string HOTELINFO_FACILITIES { get; set; }
    
        /// <summary>
        /// 地址
        /// </summary>
        
        [Description("地址")]
        public string HOTELINFO_ADDRESS { get; set; }
    
        /// <summary>
        /// 所属区域
        /// </summary>
        
        [Description("所属区域")]
        public string HOTELINFO_AREA { get; set; }
    
        /// <summary>
        /// 客服电话
        /// </summary>
        
        [Description("客服电话")]
        public string HOTELINFO_MOBILE { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string HOTELINFO_MEMO { get; set; }
    
        /// <summary>
        /// 简介
        /// </summary>
        
        [Description("简介")]
        public string HOTELINFO_BRIEF { get; set; }
    
        /// <summary>
        /// 是否推荐
        /// </summary>
        
        [Description("是否推荐")]
        public string HOTELINFO_ISHOT { get; set; }
    
        /// <summary>
        /// 是否限制下单时间
        /// </summary>
        
        [Description("是否限制下单时间")]
        public string HOTELINFO_ISLIMITTIME { get; set; }
    
        /// <summary>
        /// 下单开始时间
        /// </summary>
        
        [Description("下单开始时间")]
        public DateTime HOTELINFO_STARTIME { get; set; }
    
        /// <summary>
        /// 下单结束时间
        /// </summary>
        
        [Description("下单结束时间")]
        public DateTime HOTELINFO_ENDTIME { get; set; }
    
        /// <summary>
        /// 排序
        /// </summary>
        
        [Description("排序")]
        public decimal HOTELINFO_SORT { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal HOTELINFO_CREID { get; set; }
    
        /// <summary>
        /// 创建人姓名
        /// </summary>
        
        [Description("创建人姓名")]
        public string HOTELINFO_CRENAME { get; set; }
    
        /// <summary>
        /// 创建人所在机构ID
        /// </summary>
        
        [Description("创建人所在机构ID")]
        public decimal HOTELINFO_CREORGID { get; set; }
    
        /// <summary>
        /// 创建人所在机构名称
        /// </summary>
        
        [Description("创建人所在机构名称")]
        public string HOTELINFO_CREORGNAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime HOTELINFO_CREDATE { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal HOTELINFO_UPID { get; set; }
    
        /// <summary>
        /// 修改人姓名
        /// </summary>
        
        [Description("修改人姓名")]
        public string HOTELINFO_UPNAME { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime HOTELINFO_UPDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string HOTELINFO_ISDEL { get; set; }
    
        /// <summary>
        /// 酒店标签
        /// </summary>
        
        [Description("酒店标签")]
        public string HOTELINFO_TAG { get; set; }
    }
}
