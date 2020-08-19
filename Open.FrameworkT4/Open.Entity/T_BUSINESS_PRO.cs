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
    /// T_BUSINESS_PRO 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BUSINESS_PRO")]
    public class T_BUSINESS_PRO
    {
    
        /// <summary>
        /// 商家商品表主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("商家商品表主键")]
        public decimal BUPRO_ID { get; set; }
    
        /// <summary>
        /// 产品名称
        /// </summary>
        
        [Description("产品名称")]
        public string BUPRO_PRONAME { get; set; }
    
        /// <summary>
        /// 产品编码
        /// </summary>
        
        [Description("产品编码")]
        public string BUPRO_PROCODE { get; set; }
    
        /// <summary>
        /// 所属商家ID
        /// </summary>
        
        [Description("所属商家ID")]
        public decimal BUPRO_ORGID { get; set; }
    
        /// <summary>
        /// 所属商家名称
        /// </summary>
        
        [Description("所属商家名称")]
        public string BUPRO_ORGNAME { get; set; }
    
        /// <summary>
        /// 商品类别（F特产美食、G特产礼品）
        /// </summary>
        
        [Description("商品类别（F特产美食、G特产礼品）")]
        public string BUPRO_CATEGORY { get; set; }
    
        /// <summary>
        /// 产品类型，用于左侧菜单筛选
        /// </summary>
        
        [Description("产品类型，用于左侧菜单筛选")]
        public string BUPRO_TYPE { get; set; }
    
        /// <summary>
        /// 是否启用
        /// </summary>
        
        [Description("是否启用")]
        public string BUPRO_ISENABLE { get; set; }
    
        /// <summary>
        /// 是否推荐
        /// </summary>
        
        [Description("是否推荐")]
        public string BUPRO_ISHOT { get; set; }
    
        /// <summary>
        /// 门市价格
        /// </summary>
        
        [Description("门市价格")]
        public decimal BUPRO_MARKETPRICE { get; set; }
    
        /// <summary>
        /// 售卖价格
        /// </summary>
        
        [Description("售卖价格")]
        public decimal BUPRO_SELLPRICE { get; set; }
    
        /// <summary>
        /// 结算价格
        /// </summary>
        
        [Description("结算价格")]
        public decimal BUPRO_SETTLEPRICE { get; set; }
    
        /// <summary>
        /// 产品特色
        /// </summary>
        
        [Description("产品特色")]
        public string BUPRO_RECOMMENDED { get; set; }
    
        /// <summary>
        /// 产品详情
        /// </summary>
        
        [Description("产品详情")]
        public string BUPRO_INFO { get; set; }
    
        /// <summary>
        /// 产品包含
        /// </summary>
        
        [Description("产品包含")]
        public string BUPRO_COST { get; set; }
    
        /// <summary>
        /// 有效开始日期
        /// </summary>
        
        [Description("有效开始日期")]
        public DateTime BUPRO_STARTDATE { get; set; }
    
        /// <summary>
        /// 有效结束日期
        /// </summary>
        
        [Description("有效结束日期")]
        public DateTime BUPRO_ENDDATE { get; set; }
    
        /// <summary>
        /// 购买规则
        /// </summary>
        
        [Description("购买规则")]
        public string BUPRO_RULE { get; set; }
    
        /// <summary>
        /// 已售数量
        /// </summary>
        
        [Description("已售数量")]
        public decimal BUPRO_SOLD { get; set; }
    
        /// <summary>
        /// 是否包邮(T:是 F:否)
        /// </summary>
        
        [Description("是否包邮(T:是 F:否)")]
        public string BUPRO_ISFREE { get; set; }
    
        /// <summary>
        /// 是否允许物流配送：T，用户下单选择配送地址，F：用户不选地址，直接在线支付
        /// </summary>
        
        [Description("是否允许物流配送：T，用户下单选择配送地址，F：用户不选地址，直接在线支付")]
        public string BUPRO_ISEXPRESS { get; set; }
    
        /// <summary>
        /// 物流配送模板id
        /// </summary>
        
        [Description("物流配送模板id")]
        public decimal BUPRO_TEMPLATEID { get; set; }
    
        /// <summary>
        /// 重量（KG）
        /// </summary>
        
        [Description("重量（KG）")]
        public decimal BUPRO_WEIGHT { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string BUPRO_MEMO { get; set; }
    
        /// <summary>
        /// 排序
        /// </summary>
        
        [Description("排序")]
        public decimal BUPRO_SORT { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal BUPRO_CREID { get; set; }
    
        /// <summary>
        /// 创建人姓名
        /// </summary>
        
        [Description("创建人姓名")]
        public string BUPRO_CRENAME { get; set; }
    
        /// <summary>
        /// 创建人所在机构ID
        /// </summary>
        
        [Description("创建人所在机构ID")]
        public decimal BUPRO_CREORGID { get; set; }
    
        /// <summary>
        /// 创建人所在机构名称
        /// </summary>
        
        [Description("创建人所在机构名称")]
        public string BUPRO_CREORGNAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime BUPRO_CREDATE { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal BUPRO_UPID { get; set; }
    
        /// <summary>
        /// 修改人名称
        /// </summary>
        
        [Description("修改人名称")]
        public string BUPRO_UPNAME { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime BUPRO_UPDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string BUPRO_ISDEL { get; set; }
    }
}
