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
    /// T_GIS_LINE_DETAIL 
    /// </summary>    
   [Serializable]
   [SugarTable("T_GIS_LINE_DETAIL")]
    public class T_GIS_LINE_DETAIL
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal GISLINED_ID { get; set; }
    
        /// <summary>
        /// 线路主表ID
        /// </summary>
        
        [Description("线路主表ID")]
        public decimal GISLINE_ID { get; set; }
    
        /// <summary>
        /// 线路具体名称
        /// </summary>
        
        [Description("线路具体名称")]
        public string GISLINED_NAME { get; set; }
    
        /// <summary>
        /// 景区ID
        /// </summary>
        
        [Description("景区ID")]
        public decimal GISLINED_PARKID { get; set; }
    
        /// <summary>
        /// 景点ID
        /// </summary>
        
        [Description("景点ID")]
        public decimal GISLINED_SPOTID { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string GISLINED_MEMO { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal GISLINED_CREID { get; set; }
    
        /// <summary>
        /// 创建人姓名
        /// </summary>
        
        [Description("创建人姓名")]
        public string GISLINED_CRENAME { get; set; }
    
        /// <summary>
        /// 创建人所在机构ID
        /// </summary>
        
        [Description("创建人所在机构ID")]
        public decimal GISLINED_CREORGID { get; set; }
    
        /// <summary>
        /// 创建人所在机构名称
        /// </summary>
        
        [Description("创建人所在机构名称")]
        public string GISLINED_CREORGNAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime GISLINED_CREDATE { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal GISLINED_UPID { get; set; }
    
        /// <summary>
        /// 修改人名称
        /// </summary>
        
        [Description("修改人名称")]
        public string GISLINED_UPNAME { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime GISLINED_UPDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string GISLINED_ISDEL { get; set; }
    
        /// <summary>
        /// 排序
        /// </summary>
        
        [Description("排序")]
        public decimal GISLINED_SORT { get; set; }
    }
}
