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
    /// T_REPAST_INFO 
    /// </summary>    
   [Serializable]
   [SugarTable("T_REPAST_INFO")]
    public class T_REPAST_INFO
    {
    
        /// <summary>
        /// 餐厅详情表主键ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("餐厅详情表主键ID")]
        public decimal RINFO_ID { get; set; }
    
        /// <summary>
        /// 餐厅ID
        /// </summary>
        
        [Description("餐厅ID")]
        public decimal RINFO_ORGID { get; set; }
    
        /// <summary>
        /// 餐厅名称
        /// </summary>
        
        [Description("餐厅名称")]
        public string RINFO_ORGNAME { get; set; }
    
        /// <summary>
        /// 所属组别
        /// </summary>
        
        [Description("所属组别")]
        public string RINFO_GROUP { get; set; }
    
        /// <summary>
        /// 优惠券ID
        /// </summary>
        
        [Description("优惠券ID")]
        public string RINFO_COUPONID { get; set; }
    
        /// <summary>
        /// 支付方式1：在线支付，2到店支付，3：只展示不支付
        /// </summary>
        
        [Description("支付方式1：在线支付，2到店支付，3：只展示不支付")]
        public string RINFO_PAYTYPE { get; set; }
    
        /// <summary>
        /// 是否推荐
        /// </summary>
        
        [Description("是否推荐")]
        public string RINFO_ISHOT { get; set; }
    
        /// <summary>
        /// 所属区域
        /// </summary>
        
        [Description("所属区域")]
        public string RINFO_AREA { get; set; }
    
        /// <summary>
        /// 餐厅地址
        /// </summary>
        
        [Description("餐厅地址")]
        public string RINFO_ADDRESS { get; set; }
    
        /// <summary>
        /// 餐厅经度
        /// </summary>
        
        [Description("餐厅经度")]
        public decimal RINFO_LONGITUDE { get; set; }
    
        /// <summary>
        /// 餐厅纬度
        /// </summary>
        
        [Description("餐厅纬度")]
        public decimal RINFO_LATITUDE { get; set; }
    
        /// <summary>
        /// 客服电话
        /// </summary>
        
        [Description("客服电话")]
        public string RINFO_MOBILE { get; set; }
    
        /// <summary>
        /// 人均消费
        /// </summary>
        
        [Description("人均消费")]
        public decimal RINFO_CAPITA { get; set; }
    
        /// <summary>
        /// 餐厅标签（特色小吃、海鲜、东北菜、泰国菜、火锅....)
        /// </summary>
        
        [Description("餐厅标签（特色小吃、海鲜、东北菜、泰国菜、火锅....)")]
        public string RINFO_FLAG { get; set; }
    
        /// <summary>
        /// 餐厅特色（,隔开/泉州十大名小吃、新店优惠、回头客多...）
        /// </summary>
        
        [Description("餐厅特色（,隔开/泉州十大名小吃、新店优惠、回头客多...）")]
        public string RINFO_FEATURES { get; set; }
    
        /// <summary>
        /// 是否可预订
        /// </summary>
        
        [Description("是否可预订")]
        public string RINFO_ISBOOK { get; set; }
    
        /// <summary>
        /// 餐厅详情
        /// </summary>
        
        [Description("餐厅详情")]
        public string RINFO_REPASTINFO { get; set; }
    
        /// <summary>
        /// 餐厅推荐
        /// </summary>
        
        [Description("餐厅推荐")]
        public string RINFO_RECOMMENDED { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string RINFO_MEMO { get; set; }
    
        /// <summary>
        /// 排序
        /// </summary>
        
        [Description("排序")]
        public decimal RINFO_SORT { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal RINFO_CREID { get; set; }
    
        /// <summary>
        /// 创建人姓名
        /// </summary>
        
        [Description("创建人姓名")]
        public string RINFO_CRENAME { get; set; }
    
        /// <summary>
        /// 创建人所在机构ID
        /// </summary>
        
        [Description("创建人所在机构ID")]
        public decimal RINFO_CREORGID { get; set; }
    
        /// <summary>
        /// 创建人所在机构名称
        /// </summary>
        
        [Description("创建人所在机构名称")]
        public string RINFO_CREORGNAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime RINFO_CREDATE { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal RINFO_UPID { get; set; }
    
        /// <summary>
        /// 修改人名称
        /// </summary>
        
        [Description("修改人名称")]
        public string RINFO_UPNAME { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime RINFO_UPDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string RINFO_ISDEL { get; set; }
    
        /// <summary>
        /// 餐饮标签
        /// </summary>
        
        [Description("餐饮标签")]
        public string RINFO_TAG { get; set; }
    }
}
