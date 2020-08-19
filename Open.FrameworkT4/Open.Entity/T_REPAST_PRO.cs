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
    /// T_REPAST_PRO 
    /// </summary>    
   [Serializable]
   [SugarTable("T_REPAST_PRO")]
    public class T_REPAST_PRO
    {
    
        /// <summary>
        /// 餐厅产品表主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("餐厅产品表主键")]
        public decimal REPAST_ID { get; set; }
    
        /// <summary>
        /// 产品名称
        /// </summary>
        
        [Description("产品名称")]
        public string REPAST_PRONAME { get; set; }
    
        /// <summary>
        /// 产品编码
        /// </summary>
        
        [Description("产品编码")]
        public string REPAST_PROCODE { get; set; }
    
        /// <summary>
        /// 所属餐厅ID
        /// </summary>
        
        [Description("所属餐厅ID")]
        public decimal REPAST_ORGID { get; set; }
    
        /// <summary>
        /// 所属餐厅名称
        /// </summary>
        
        [Description("所属餐厅名称")]
        public string REPAST_ORGNAME { get; set; }
    
        /// <summary>
        /// 是否启用
        /// </summary>
        
        [Description("是否启用")]
        public string REPAST_ISENABLE { get; set; }
    
        /// <summary>
        /// 是否推荐
        /// </summary>
        
        [Description("是否推荐")]
        public string REPAST_ISHOT { get; set; }
    
        /// <summary>
        /// 门市价格
        /// </summary>
        
        [Description("门市价格")]
        public decimal REPAST_MARKETPRICE { get; set; }
    
        /// <summary>
        /// 售卖价格
        /// </summary>
        
        [Description("售卖价格")]
        public decimal REPAST_SELLPRICE { get; set; }
    
        /// <summary>
        /// 结算价格
        /// </summary>
        
        [Description("结算价格")]
        public decimal REPAST_SETTLEPRICE { get; set; }
    
        /// <summary>
        /// 产品特色
        /// </summary>
        
        [Description("产品特色")]
        public string REPAST_RECOMMENDED { get; set; }
    
        /// <summary>
        /// 产品详情
        /// </summary>
        
        [Description("产品详情")]
        public string REPAST_INFO { get; set; }
    
        /// <summary>
        /// 产品包含
        /// </summary>
        
        [Description("产品包含")]
        public string REPAST_COST { get; set; }
    
        /// <summary>
        /// 有效开始日期
        /// </summary>
        
        [Description("有效开始日期")]
        public DateTime REPAST_STARTDATE { get; set; }
    
        /// <summary>
        /// 有效结束日期
        /// </summary>
        
        [Description("有效结束日期")]
        public DateTime REPAST_ENDDATE { get; set; }
    
        /// <summary>
        /// 使用规则
        /// </summary>
        
        [Description("使用规则")]
        public string REPAST_RULE { get; set; }
    
        /// <summary>
        /// 使用时间
        /// </summary>
        
        [Description("使用时间")]
        public string REPAST_USETIME { get; set; }
    
        /// <summary>
        /// 不可用日期
        /// </summary>
        
        [Description("不可用日期")]
        public string REPAST_OFFDATE { get; set; }
    
        /// <summary>
        /// 是否需要预约
        /// </summary>
        
        [Description("是否需要预约")]
        public string REPAST_ISPLAN { get; set; }
    
        /// <summary>
        /// 已售数量
        /// </summary>
        
        [Description("已售数量")]
        public decimal REPAST_SOLD { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string REPAST_MEMO { get; set; }
    
        /// <summary>
        /// 排序
        /// </summary>
        
        [Description("排序")]
        public decimal REPAST_SORT { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal REPAST_CREID { get; set; }
    
        /// <summary>
        /// 创建人姓名
        /// </summary>
        
        [Description("创建人姓名")]
        public string REPAST_CRENAME { get; set; }
    
        /// <summary>
        /// 创建人所在机构ID
        /// </summary>
        
        [Description("创建人所在机构ID")]
        public decimal REPAST_CREORGID { get; set; }
    
        /// <summary>
        /// 创建人所在机构名称
        /// </summary>
        
        [Description("创建人所在机构名称")]
        public string REPAST_CREORGNAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime REPAST_CREDATE { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal REPAST_UPID { get; set; }
    
        /// <summary>
        /// 修改人名称
        /// </summary>
        
        [Description("修改人名称")]
        public string REPAST_UPNAME { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime REPAST_UPDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string REPAST_ISDEL { get; set; }
    }
}
