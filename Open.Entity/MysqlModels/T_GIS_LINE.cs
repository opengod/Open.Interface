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
    /// T_GIS_LINE 
    /// </summary>    
   [Serializable]
   [SugarTable("T_GIS_LINE")]
    public class T_GIS_LINE
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal GISLINE_ID { get; set; }
    
        /// <summary>
        /// 线路名称
        /// </summary>
        
        [Description("线路名称")]
        public string GISLINE_NAME { get; set; }
    
        /// <summary>
        /// 线路景区数量
        /// </summary>
        
        [Description("线路景区数量")]
        public decimal GISLINE_SPOTQTY { get; set; }
    
        /// <summary>
        /// 线路类别：全天，半天等
        /// </summary>
        
        [Description("线路类别：全天，半天等")]
        public string GISLINE_TYPE { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string GISLINE_MEMO { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal GISLINE_CREID { get; set; }
    
        /// <summary>
        /// 创建人姓名
        /// </summary>
        
        [Description("创建人姓名")]
        public string GISLINE_CRENAME { get; set; }
    
        /// <summary>
        /// 创建人所在机构ID
        /// </summary>
        
        [Description("创建人所在机构ID")]
        public decimal GISLINE_CREORGID { get; set; }
    
        /// <summary>
        /// 创建人所在机构名称
        /// </summary>
        
        [Description("创建人所在机构名称")]
        public string GISLINE_CREORGNAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime GISLINE_CREDATE { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal GISLINE_UPID { get; set; }
    
        /// <summary>
        /// 修改人名称
        /// </summary>
        
        [Description("修改人名称")]
        public string GISLINE_UPNAME { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime GISLINE_UPDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string GISLINE_ISDEL { get; set; }
    
        /// <summary>
        /// 0：景区 1：景点
        /// </summary>
        
        [Description("0：景区 1：景点")]
        public decimal GISLINE_GENRE { get; set; }
    
        /// <summary>
        /// 排序
        /// </summary>
        
        [Description("排序")]
        public decimal GISLINE_SORT { get; set; }
    
        /// <summary>
        /// 景区id
        /// </summary>
        
        [Description("景区id")]
        public decimal GISLINE_PARKID { get; set; }
    
        /// <summary>
        /// 景区类别
        /// </summary>
        
        [Description("景区类别")]
        public string GISLINE_PARKTYPE { get; set; }
    
        /// <summary>
        /// 线路标识
        /// </summary>
        
        [Description("线路标识")]
        public string GISLINE_FLAG { get; set; }
    }
}
