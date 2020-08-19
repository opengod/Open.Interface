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
    /// T_ENT_PRO 
    /// </summary>    
   [Serializable]
   [SugarTable("T_ENT_PRO")]
    public class T_ENT_PRO
    {
    
        /// <summary>
        /// 娱乐产品表主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("娱乐产品表主键")]
        public decimal ENTPRO_ID { get; set; }
    
        /// <summary>
        /// 产品名称
        /// </summary>
        
        [Description("产品名称")]
        public string ENTPRO_PRONAME { get; set; }
    
        /// <summary>
        /// 产品编码
        /// </summary>
        
        [Description("产品编码")]
        public string ENTPRO_PROCODE { get; set; }
    
        /// <summary>
        /// 所属娱乐场所ID
        /// </summary>
        
        [Description("所属娱乐场所ID")]
        public decimal ENTPRO_ORGID { get; set; }
    
        /// <summary>
        /// 所属娱乐场所名称
        /// </summary>
        
        [Description("所属娱乐场所名称")]
        public string ENTPRO_ORGNAME { get; set; }
    
        /// <summary>
        /// 是否启用
        /// </summary>
        
        [Description("是否启用")]
        public string ENTPRO_ISENABLE { get; set; }
    
        /// <summary>
        /// 是否推荐
        /// </summary>
        
        [Description("是否推荐")]
        public string ENTPRO_ISHOT { get; set; }
    
        /// <summary>
        /// 门市价格
        /// </summary>
        
        [Description("门市价格")]
        public decimal ENTPRO_MARKETPRICE { get; set; }
    
        /// <summary>
        /// 售卖价格
        /// </summary>
        
        [Description("售卖价格")]
        public decimal ENTPRO_SELLPRICE { get; set; }
    
        /// <summary>
        /// 结算价格
        /// </summary>
        
        [Description("结算价格")]
        public decimal ENTPRO_SETTLEPRICE { get; set; }
    
        /// <summary>
        /// 产品特色
        /// </summary>
        
        [Description("产品特色")]
        public string ENTPRO_RECOMMENDED { get; set; }
    
        /// <summary>
        /// 产品详情
        /// </summary>
        
        [Description("产品详情")]
        public string ENTPRO_INFO { get; set; }
    
        /// <summary>
        /// 产品包含
        /// </summary>
        
        [Description("产品包含")]
        public string ENTPRO_COST { get; set; }
    
        /// <summary>
        /// 有效开始日期
        /// </summary>
        
        [Description("有效开始日期")]
        public DateTime ENTPRO_STARTDATE { get; set; }
    
        /// <summary>
        /// 有效结束日期
        /// </summary>
        
        [Description("有效结束日期")]
        public DateTime ENTPRO_ENDDATE { get; set; }
    
        /// <summary>
        /// 使用规则
        /// </summary>
        
        [Description("使用规则")]
        public string ENTPRO_RULE { get; set; }
    
        /// <summary>
        /// 使用时间
        /// </summary>
        
        [Description("使用时间")]
        public string ENTPRO_USETIME { get; set; }
    
        /// <summary>
        /// 不可用日期
        /// </summary>
        
        [Description("不可用日期")]
        public string ENTPRO_OFFDATE { get; set; }
    
        /// <summary>
        /// 是否需要预约
        /// </summary>
        
        [Description("是否需要预约")]
        public string ENTPRO_ISPLAN { get; set; }
    
        /// <summary>
        /// 已售数量
        /// </summary>
        
        [Description("已售数量")]
        public decimal ENTPRO_SOLD { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string ENTPRO_MEMO { get; set; }
    
        /// <summary>
        /// 排序
        /// </summary>
        
        [Description("排序")]
        public decimal ENTPRO_SORT { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal ENTPRO_CREID { get; set; }
    
        /// <summary>
        /// 创建人姓名
        /// </summary>
        
        [Description("创建人姓名")]
        public string ENTPRO_CRENAME { get; set; }
    
        /// <summary>
        /// 创建人所在机构ID
        /// </summary>
        
        [Description("创建人所在机构ID")]
        public decimal ENTPRO_CREORGID { get; set; }
    
        /// <summary>
        /// 创建人所在机构名称
        /// </summary>
        
        [Description("创建人所在机构名称")]
        public string ENTPRO_CREORGNAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime ENTPRO_CREDATE { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal ENTPRO_UPID { get; set; }
    
        /// <summary>
        /// 修改人名称
        /// </summary>
        
        [Description("修改人名称")]
        public string ENTPRO_UPNAME { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime ENTPRO_UPDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string ENTPRO_ISDEL { get; set; }
    }
}
