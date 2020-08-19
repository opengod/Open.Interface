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
    /// T_BIZ_QUOTA 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_QUOTA")]
    public class T_BIZ_QUOTA
    {
    
        /// <summary>
        /// 主键ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键ID")]
        public decimal QUOTA_ID { get; set; }
    
        /// <summary>
        /// 使用时间
        /// </summary>
        
        [Description("使用时间")]
        public DateTime QUOTA_UDATE { get; set; }
    
        /// <summary>
        /// 旅行社名称
        /// </summary>
        
        [Description("旅行社名称")]
        public string QUOTA_CMNAME { get; set; }
    
        /// <summary>
        /// 旅行社ID
        /// </summary>
        
        [Description("旅行社ID")]
        public decimal QUOTA_CMID { get; set; }
    
        /// <summary>
        /// 最小销售额度
        /// </summary>
        
        [Description("最小销售额度")]
        public decimal QUOTA_SALEMIN { get; set; }
    
        /// <summary>
        /// 最大销售额
        /// </summary>
        
        [Description("最大销售额")]
        public decimal QUOTA_SALEMAX { get; set; }
    
        /// <summary>
        /// 已经销售额
        /// </summary>
        
        [Description("已经销售额")]
        public decimal QUOTA_SALEOUT { get; set; }
    
        /// <summary>
        /// 剩余销售数量
        /// </summary>
        
        [Description("剩余销售数量")]
        public decimal QUOTA_SALERM { get; set; }
    
        /// <summary>
        /// 销售星期
        /// </summary>
        
        [Description("销售星期")]
        public string QUOTA_SALEWEEK { get; set; }
    
        /// <summary>
        /// 最高销售量调整
        /// </summary>
        
        [Description("最高销售量调整")]
        public decimal QUOTA_SALEADD { get; set; }
    
        /// <summary>
        /// 景点ID
        /// </summary>
        
        [Description("景点ID")]
        public decimal QUOTA_PARKID { get; set; }
    
        /// <summary>
        /// 景点名称
        /// </summary>
        
        [Description("景点名称")]
        public string QUOTA_PARKNAME { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal QUOTA_CREATEID { get; set; }
    
        /// <summary>
        /// 创建人名称
        /// </summary>
        
        [Description("创建人名称")]
        public string QUOTA_CREATENAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime QUOTA_CREATETIME { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal QUOTA_EDITID { get; set; }
    
        /// <summary>
        /// 修改人名称
        /// </summary>
        
        [Description("修改人名称")]
        public string QUOTA_EDITNAME { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime QUOTA_EDITTIME { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string QUOTA_ISLOGIDEL { get; set; }
    
        /// <summary>
        /// 删除人ID
        /// </summary>
        
        [Description("删除人ID")]
        public decimal QUOTA_DELID { get; set; }
    
        /// <summary>
        /// 删除人名称
        /// </summary>
        
        [Description("删除人名称")]
        public string QUOTA_DELNAME { get; set; }
    
        /// <summary>
        /// 删除时间
        /// </summary>
        
        [Description("删除时间")]
        public DateTime QUOTA_DELTIME { get; set; }
    
        /// <summary>
        /// 创建企业ID
        /// </summary>
        
        [Description("创建企业ID")]
        public decimal QUOTA_COMPANYCID { get; set; }
    
        /// <summary>
        /// 创建企业名称
        /// </summary>
        
        [Description("创建企业名称")]
        public string QUOTA_COMPANYNAME { get; set; }
    }
}
