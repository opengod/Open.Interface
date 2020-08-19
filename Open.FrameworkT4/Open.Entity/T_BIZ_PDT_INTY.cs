//-----------------------------------------------------------------------
// <Copyright>
// * copyright © 2020 open All Rights Reserved
// * version : 4.0.30319.42000
// * author  : open
// * history : Created by open 2020-08-19 11:17:17 
// </Copyright>
//-----------------------------------------------------------------------
using System;
using SqlSugar;
using System.ComponentModel;

namespace Open.Entity.Oracle
{
    /// <summary>
    /// T_BIZ_PDT_INTY 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_PDT_INTY")]
    public class T_BIZ_PDT_INTY
    {
    
        /// <summary>
        /// 景区门票库存表ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("景区门票库存表ID")]
        public decimal PDT_INTY_ID { get; set; }
    
        /// <summary>
        /// 景区ID
        /// </summary>
        
        [Description("景区ID")]
        public decimal PDT_INTY_PARKID { get; set; }
    
        /// <summary>
        /// 企业ID
        /// </summary>
        
        [Description("企业ID")]
        public decimal PDT_INTY_COMPANYID { get; set; }
    
        /// <summary>
        /// 产品ID
        /// </summary>
        
        [Description("产品ID")]
        public decimal PDT_INTY_PRODUCTID { get; set; }
    
        /// <summary>
        /// 星期
        /// </summary>
        
        [Description("星期")]
        public string PDT_INTY_WEEKDAY { get; set; }
    
        /// <summary>
        /// 总数量
        /// </summary>
        
        [Description("总数量")]
        public decimal PDT_INTY_SUMCOUNT { get; set; }
    
        /// <summary>
        /// 销售数量
        /// </summary>
        
        [Description("销售数量")]
        public decimal PDT_INTY_SALECOUNT { get; set; }
    
        /// <summary>
        /// 创建人
        /// </summary>
        
        [Description("创建人")]
        public string PDT_INTY_CREATENAME { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal PDT_INTY_CREATEID { get; set; }
    
        /// <summary>
        /// 修改人
        /// </summary>
        
        [Description("修改人")]
        public string PDT_INTY_EDITNAME { get; set; }
    
        /// <summary>
        /// 修改ID
        /// </summary>
        
        [Description("修改ID")]
        public decimal PDT_INTY_EDITID { get; set; }
    
        /// <summary>
        /// 是否启用总库存0是单日库存1是时间段内总库存
        /// </summary>
        
        [Description("是否启用总库存0是单日库存1是时间段内总库存")]
        public decimal PDT_INTY_FLAG { get; set; }
    
        /// <summary>
        /// 逻辑删除
        /// </summary>
        
        [Description("逻辑删除")]
        public string PDT_INTY_ISLOGIDEL { get; set; }
    
        /// <summary>
        /// 删除人ID
        /// </summary>
        
        [Description("删除人ID")]
        public decimal PDT_INTY_DELID { get; set; }
    
        /// <summary>
        /// 删除人姓名
        /// </summary>
        
        [Description("删除人姓名")]
        public string PDT_INTY_DELNAME { get; set; }
    
        /// <summary>
        /// 日期
        /// </summary>
        
        [Description("日期")]
        public DateTime PDT_INTY_DATE { get; set; }
    
        /// <summary>
        /// 有效期截止日期，原删除日期
        /// </summary>
        
        [Description("有效期截止日期，原删除日期")]
        public DateTime PDT_INTY_DELDATE { get; set; }
    
        /// <summary>
        /// 创建企业ID
        /// </summary>
        
        [Description("创建企业ID")]
        public decimal PDT_INTY_COMPANYCID { get; set; }
    
        /// <summary>
        /// 创建企业名称
        /// </summary>
        
        [Description("创建企业名称")]
        public string PDT_INTY_COMPANYNAME { get; set; }
    }
}
