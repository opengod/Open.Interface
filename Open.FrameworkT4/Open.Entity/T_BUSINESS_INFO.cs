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
    /// T_BUSINESS_INFO 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BUSINESS_INFO")]
    public class T_BUSINESS_INFO
    {
    
        /// <summary>
        /// 商家详情表主键ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("商家详情表主键ID")]
        public decimal BUINFO_ID { get; set; }
    
        /// <summary>
        /// 商家ID
        /// </summary>
        
        [Description("商家ID")]
        public decimal BUINFO_ORGID { get; set; }
    
        /// <summary>
        /// 商家名称
        /// </summary>
        
        [Description("商家名称")]
        public string BUINFO_ORGNAME { get; set; }
    
        /// <summary>
        /// 商家类型
        /// </summary>
        
        [Description("商家类型")]
        public string BUINFO_TYPE { get; set; }
    
        /// <summary>
        /// 所属组别
        /// </summary>
        
        [Description("所属组别")]
        public string BUINFO_GROUP { get; set; }
    
        /// <summary>
        /// 支付方式1：在线支付，2到店支付，3：只展示不支付
        /// </summary>
        
        [Description("支付方式1：在线支付，2到店支付，3：只展示不支付")]
        public string BUINFO_PAYTYPE { get; set; }
    
        /// <summary>
        /// 是否推荐
        /// </summary>
        
        [Description("是否推荐")]
        public string BUINFO_ISHOT { get; set; }
    
        /// <summary>
        /// 所属区域
        /// </summary>
        
        [Description("所属区域")]
        public string BUINFO_AREA { get; set; }
    
        /// <summary>
        /// 地址
        /// </summary>
        
        [Description("地址")]
        public string BUINFO_ADDRESS { get; set; }
    
        /// <summary>
        /// 经度
        /// </summary>
        
        [Description("经度")]
        public decimal BUINFO_LONGITUDE { get; set; }
    
        /// <summary>
        /// 纬度
        /// </summary>
        
        [Description("纬度")]
        public decimal BUINFO_LATITUDE { get; set; }
    
        /// <summary>
        /// 客服电话
        /// </summary>
        
        [Description("客服电话")]
        public string BUINFO_MOBILE { get; set; }
    
        /// <summary>
        /// 人均消费
        /// </summary>
        
        [Description("人均消费")]
        public decimal BUINFO_CAPITA { get; set; }
    
        /// <summary>
        /// 特产购物二级分类
        /// </summary>
        
        [Description("特产购物二级分类")]
        public string BUINFO_TAG { get; set; }
    
        /// <summary>
        /// 标签（特产美食、特产礼品、伴手礼....)
        /// </summary>
        
        [Description("标签（特产美食、特产礼品、伴手礼....)")]
        public string BUINFO_FLAG { get; set; }
    
        /// <summary>
        /// 特色（、隔开， 新店优惠、回头客多...）
        /// </summary>
        
        [Description("特色（、隔开， 新店优惠、回头客多...）")]
        public string BUINFO_FEATURES { get; set; }
    
        /// <summary>
        /// 是否可预订
        /// </summary>
        
        [Description("是否可预订")]
        public string BUINFO_ISBOOK { get; set; }
    
        /// <summary>
        /// 商家详情
        /// </summary>
        
        [Description("商家详情")]
        public string BUINFO_INFO { get; set; }
    
        /// <summary>
        /// 商家推荐
        /// </summary>
        
        [Description("商家推荐")]
        public string BUINFO_RECOMMENDED { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string BUINFO_MEMO { get; set; }
    
        /// <summary>
        /// 排序
        /// </summary>
        
        [Description("排序")]
        public decimal BUINFO_SORT { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal BUINFO_CREID { get; set; }
    
        /// <summary>
        /// 创建人姓名
        /// </summary>
        
        [Description("创建人姓名")]
        public string BUINFO_CRENAME { get; set; }
    
        /// <summary>
        /// 创建人所在机构ID
        /// </summary>
        
        [Description("创建人所在机构ID")]
        public decimal BUINFO_CREORGID { get; set; }
    
        /// <summary>
        /// 创建人所在机构名称
        /// </summary>
        
        [Description("创建人所在机构名称")]
        public string BUINFO_CREORGNAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime BUINFO_CREDATE { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal BUINFO_UPID { get; set; }
    
        /// <summary>
        /// 修改人名称
        /// </summary>
        
        [Description("修改人名称")]
        public string BUINFO_UPNAME { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime BUINFO_UPDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string BUINFO_ISDEL { get; set; }
    }
}
