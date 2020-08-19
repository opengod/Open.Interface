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
    /// T_PARK_INFO 
    /// </summary>    
   [Serializable]
   [SugarTable("T_PARK_INFO")]
    public class T_PARK_INFO
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal PARKINFO_ID { get; set; }
    
        /// <summary>
        /// 景区ID
        /// </summary>
        
        [Description("景区ID")]
        public decimal PARKINFO_PARKID { get; set; }
    
        /// <summary>
        /// 供应商ID
        /// </summary>
        
        [Description("供应商ID")]
        public decimal PARKINFO_SUPID { get; set; }
    
        /// <summary>
        /// 供应商编码
        /// </summary>
        
        [Description("供应商编码")]
        public string PARKINFO_SUPCODE { get; set; }
    
        /// <summary>
        /// 供应商名称
        /// </summary>
        
        [Description("供应商名称")]
        public string PARKINFO_SUPNAME { get; set; }
    
        /// <summary>
        /// 供应商景区ID
        /// </summary>
        
        [Description("供应商景区ID")]
        public string PARKINFO_SUPPARKID { get; set; }
    
        /// <summary>
        /// 所属组别
        /// </summary>
        
        [Description("所属组别")]
        public string PARKINFO_GROUP { get; set; }
    
        /// <summary>
        /// 所属企业(云旅：QZYL，不填为空，判断是否走分销平台接口)
        /// </summary>
        
        [Description("所属企业(云旅：QZYL，不填为空，判断是否走分销平台接口)")]
        public string PARKINFO_BELONGORG { get; set; }
    
        /// <summary>
        /// 最低价格
        /// </summary>
        
        [Description("最低价格")]
        public decimal PARKINFO_MINPRICE { get; set; }
    
        /// <summary>
        /// 支付方式1：在线支付，2：只展示不支付
        /// </summary>
        
        [Description("支付方式1：在线支付，2：只展示不支付")]
        public string PARKINFO_PAYTYPE { get; set; }
    
        /// <summary>
        /// 景区名称
        /// </summary>
        
        [Description("景区名称")]
        public string PARKINFO_PARKNAME { get; set; }
    
        /// <summary>
        /// 景区二级分类
        /// </summary>
        
        [Description("景区二级分类")]
        public string PARKINFO_TAG { get; set; }
    
        /// <summary>
        /// 景区地址
        /// </summary>
        
        [Description("景区地址")]
        public string PARKINFO_ADDRESS { get; set; }
    
        /// <summary>
        /// 景区简介
        /// </summary>
        
        [Description("景区简介")]
        public string PARKINFO_BRIEF { get; set; }
    
        /// <summary>
        /// 景区信用评分
        /// </summary>
        
        [Description("景区信用评分")]
        public decimal PARKINFO_CREDIT { get; set; }
    
        /// <summary>
        /// 景区经度
        /// </summary>
        
        [Description("景区经度")]
        public decimal PARKINFO_LONGITUDE { get; set; }
    
        /// <summary>
        /// 景区纬度
        /// </summary>
        
        [Description("景区纬度")]
        public decimal PARKINFO_LATITUDE { get; set; }
    
        /// <summary>
        /// 景区描述
        /// </summary>
        
        [Description("景区描述")]
        public string PARKINFO_INTRODUCTION { get; set; }
    
        /// <summary>
        /// 购票须知
        /// </summary>
        
        [Description("购票须知")]
        public string PARKINFO_BUYNOTE { get; set; }
    
        /// <summary>
        /// 景区政策
        /// </summary>
        
        [Description("景区政策")]
        public string PARKINFO_POLICY { get; set; }
    
        /// <summary>
        /// 景区公告
        /// </summary>
        
        [Description("景区公告")]
        public string PARKINFO_NOTICE { get; set; }
    
        /// <summary>
        /// 客服电话
        /// </summary>
        
        [Description("客服电话")]
        public string PARKINFO_MOBILE { get; set; }
    
        /// <summary>
        /// 是否推荐
        /// </summary>
        
        [Description("是否推荐")]
        public string PARKINFO_ISHOT { get; set; }
    
        /// <summary>
        /// 景区等级
        /// </summary>
        
        [Description("景区等级")]
        public string PARKINFO_LEVEL { get; set; }
    
        /// <summary>
        /// 景区评分
        /// </summary>
        
        [Description("景区评分")]
        public decimal PARKINFO_SCORE { get; set; }
    
        /// <summary>
        /// 景区所属区域
        /// </summary>
        
        [Description("景区所属区域")]
        public string PARKINFO_AREA { get; set; }
    
        /// <summary>
        /// 是否新生
        /// </summary>
        
        [Description("是否新生")]
        public string PARKINFO_ISCUSTOMER { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        
        [Description("")]
        public string PARKINFO_LABLE { get; set; }
    
        /// <summary>
        /// 开放时间(节假日)
        /// </summary>
        
        [Description("开放时间(节假日)")]
        public string PARKINFO_HOLITIME { get; set; }
    
        /// <summary>
        /// 开放时间(非节假日)
        /// </summary>
        
        [Description("开放时间(非节假日)")]
        public string PARKINFO_NONHOLITIME { get; set; }
    
        /// <summary>
        /// 交通信息
        /// </summary>
        
        [Description("交通信息")]
        public string PARKINFO_TRANSINFO { get; set; }
    
        /// <summary>
        /// 住宿信息
        /// </summary>
        
        [Description("住宿信息")]
        public string PARKINFO_STAYINFO { get; set; }
    
        /// <summary>
        /// 用餐信息
        /// </summary>
        
        [Description("用餐信息")]
        public string PARKINFO_MEALINFO { get; set; }
    
        /// <summary>
        /// 预定限制
        /// </summary>
        
        [Description("预定限制")]
        public string PARKINFO_RESERVELIMIT { get; set; }
    
        /// <summary>
        /// 开票说明
        /// </summary>
        
        [Description("开票说明")]
        public string PARKINFO_TICKETEXPLAIN { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string PARKINFO_MEMO { get; set; }
    
        /// <summary>
        /// 排序
        /// </summary>
        
        [Description("排序")]
        public decimal PARKINFO_SORT { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal PARKINFO_CREID { get; set; }
    
        /// <summary>
        /// 创建人姓名
        /// </summary>
        
        [Description("创建人姓名")]
        public string PARKINFO_CRENAME { get; set; }
    
        /// <summary>
        /// 创建人所在机构ID
        /// </summary>
        
        [Description("创建人所在机构ID")]
        public decimal PARKINFO_CREORGID { get; set; }
    
        /// <summary>
        /// 创建人所在机构名称
        /// </summary>
        
        [Description("创建人所在机构名称")]
        public string PARKINFO_CREORGNAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime PARKINFO_CREDATE { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal PARKINFO_UPID { get; set; }
    
        /// <summary>
        /// 修改人名称
        /// </summary>
        
        [Description("修改人名称")]
        public string PARKINFO_UPNAME { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime PARKINFO_UPDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string PARKINFO_ISDEL { get; set; }
    }
}
