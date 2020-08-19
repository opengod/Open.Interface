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
    /// T_GIS_TRAIL 
    /// </summary>    
   [Serializable]
   [SugarTable("T_GIS_TRAIL")]
    public class T_GIS_TRAIL
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal TRAILGIS_ID { get; set; }
    
        /// <summary>
        /// 用户OPENID
        /// </summary>
        
        [Description("用户OPENID")]
        public string TRAILGIS_WEOPENID { get; set; }
    
        /// <summary>
        /// 经度
        /// </summary>
        
        [Description("经度")]
        public decimal TRAILGIS_LONGITUDE { get; set; }
    
        /// <summary>
        /// 纬度
        /// </summary>
        
        [Description("纬度")]
        public decimal TRAILGIS_LATITUDE { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime TRAILGIS_CREATEDATE { get; set; }
    }
}
