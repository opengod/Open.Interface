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
    /// T_GIS_BUSINESS 
    /// </summary>    
   [Serializable]
   [SugarTable("T_GIS_BUSINESS")]
    public class T_GIS_BUSINESS
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal BUSINESS_ID { get; set; }
    
        /// <summary>
        /// 商家名称
        /// </summary>
        
        [Description("商家名称")]
        public string BUSINESS_NAME { get; set; }
    
        /// <summary>
        /// 经维度类型
        /// </summary>
        
        [Description("经维度类型")]
        public string BUSINESS_TUDETYPE { get; set; }
    
        /// <summary>
        /// 商家经度
        /// </summary>
        
        [Description("商家经度")]
        public decimal BUSINESS_LONGITUDE { get; set; }
    
        /// <summary>
        /// 商家维度
        /// </summary>
        
        [Description("商家维度")]
        public decimal BUSINESS_LATITUDE { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string BUSINESS_MEMO { get; set; }
    
        /// <summary>
        /// 排序
        /// </summary>
        
        [Description("排序")]
        public decimal BUSINESS_SORT { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal BUSINESS_CREID { get; set; }
    
        /// <summary>
        /// 创建人姓名
        /// </summary>
        
        [Description("创建人姓名")]
        public string BUSINESS_CRENAME { get; set; }
    
        /// <summary>
        /// 创建人所在机构ID
        /// </summary>
        
        [Description("创建人所在机构ID")]
        public decimal BUSINESS_CREORGID { get; set; }
    
        /// <summary>
        /// 创建人所在机构名称
        /// </summary>
        
        [Description("创建人所在机构名称")]
        public string BUSINESS_CREORGNAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime BUSINESS_CREDATE { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal BUSINESS_UPID { get; set; }
    
        /// <summary>
        /// 修改人名称
        /// </summary>
        
        [Description("修改人名称")]
        public string BUSINESS_UPNAME { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime BUSINESS_UPDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string BUSINESS_ISDEL { get; set; }
    }
}
