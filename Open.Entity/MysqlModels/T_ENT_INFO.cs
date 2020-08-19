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
    /// T_ENT_INFO 
    /// </summary>    
   [Serializable]
   [SugarTable("T_ENT_INFO")]
    public class T_ENT_INFO
    {
    
        /// <summary>
        /// 娱乐场所详情表主键ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("娱乐场所详情表主键ID")]
        public decimal ENTINFO_ID { get; set; }
    
        /// <summary>
        /// 娱乐场所D
        /// </summary>
        
        [Description("娱乐场所D")]
        public decimal ENTINFO_ORGID { get; set; }
    
        /// <summary>
        /// 娱乐场所名称
        /// </summary>
        
        [Description("娱乐场所名称")]
        public string ENTINFO_ORGNAME { get; set; }
    
        /// <summary>
        /// 商家类型
        /// </summary>
        
        [Description("商家类型")]
        public string ENTINFO_TYPE { get; set; }
    
        /// <summary>
        /// 所属组别
        /// </summary>
        
        [Description("所属组别")]
        public string ENTINFO_GROUP { get; set; }
    
        /// <summary>
        /// 优惠券ID
        /// </summary>
        
        [Description("优惠券ID")]
        public string ENTINFO_COUPONID { get; set; }
    
        /// <summary>
        /// 支付方式1：在线支付，2到店支付，3：只展示不支付
        /// </summary>
        
        [Description("支付方式1：在线支付，2到店支付，3：只展示不支付")]
        public string ENTINFO_PAYTYPE { get; set; }
    
        /// <summary>
        /// 是否推荐
        /// </summary>
        
        [Description("是否推荐")]
        public string ENTINFO_ISHOT { get; set; }
    
        /// <summary>
        /// 所属区域
        /// </summary>
        
        [Description("所属区域")]
        public string ENTINFO_AREA { get; set; }
    
        /// <summary>
        /// 地址
        /// </summary>
        
        [Description("地址")]
        public string ENTINFO_ADDRESS { get; set; }
    
        /// <summary>
        /// 经度
        /// </summary>
        
        [Description("经度")]
        public decimal ENTINFO_LONGITUDE { get; set; }
    
        /// <summary>
        /// 纬度
        /// </summary>
        
        [Description("纬度")]
        public decimal ENTINFO_LATITUDE { get; set; }
    
        /// <summary>
        /// 客服电话
        /// </summary>
        
        [Description("客服电话")]
        public string ENTINFO_MOBILE { get; set; }
    
        /// <summary>
        /// 人均消费
        /// </summary>
        
        [Description("人均消费")]
        public decimal ENTINFO_CAPITA { get; set; }
    
        /// <summary>
        /// 标签（健身、保龄球、台球、洗浴、按摩....)
        /// </summary>
        
        [Description("标签（健身、保龄球、台球、洗浴、按摩....)")]
        public string ENTINFO_FLAG { get; set; }
    
        /// <summary>
        /// 特色（,隔开/新店优惠、回头客多...）
        /// </summary>
        
        [Description("特色（,隔开/新店优惠、回头客多...）")]
        public string ENTINFO_FEATURES { get; set; }
    
        /// <summary>
        /// 是否可预订
        /// </summary>
        
        [Description("是否可预订")]
        public string ENTINFO_ISBOOK { get; set; }
    
        /// <summary>
        /// 详情
        /// </summary>
        
        [Description("详情")]
        public string ENTINFO_ENTINFO { get; set; }
    
        /// <summary>
        /// 推荐
        /// </summary>
        
        [Description("推荐")]
        public string ENTINFO_RECOMMENDED { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string ENTINFO_MEMO { get; set; }
    
        /// <summary>
        /// 排序
        /// </summary>
        
        [Description("排序")]
        public decimal ENTINFO_SORT { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal ENTINFO_CREID { get; set; }
    
        /// <summary>
        /// 创建人姓名
        /// </summary>
        
        [Description("创建人姓名")]
        public string ENTINFO_CRENAME { get; set; }
    
        /// <summary>
        /// 创建人所在机构ID
        /// </summary>
        
        [Description("创建人所在机构ID")]
        public decimal ENTINFO_CREORGID { get; set; }
    
        /// <summary>
        /// 创建人所在机构名称
        /// </summary>
        
        [Description("创建人所在机构名称")]
        public string ENTINFO_CREORGNAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime ENTINFO_CREDATE { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal ENTINFO_UPID { get; set; }
    
        /// <summary>
        /// 修改人名称
        /// </summary>
        
        [Description("修改人名称")]
        public string ENTINFO_UPNAME { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime ENTINFO_UPDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string ENTINFO_ISDEL { get; set; }
    
        /// <summary>
        /// 娱乐标签
        /// </summary>
        
        [Description("娱乐标签")]
        public string ENTINFO_TAG { get; set; }
    }
}
