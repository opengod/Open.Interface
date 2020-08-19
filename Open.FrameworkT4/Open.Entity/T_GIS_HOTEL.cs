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
    /// T_GIS_HOTEL 
    /// </summary>    
   [Serializable]
   [SugarTable("T_GIS_HOTEL")]
    public class T_GIS_HOTEL
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal HOTELGIS_ID { get; set; }
    
        /// <summary>
        /// 酒店ID
        /// </summary>
        
        [Description("酒店ID")]
        public decimal HOTELGIS_HOTELID { get; set; }
    
        /// <summary>
        /// 酒店名称
        /// </summary>
        
        [Description("酒店名称")]
        public string HOTELGIS_HOTELNAME { get; set; }
    
        /// <summary>
        /// 经维度类型
        /// </summary>
        
        [Description("经维度类型")]
        public string HOTELGIS_TUDETYPE { get; set; }
    
        /// <summary>
        /// 酒店经度
        /// </summary>
        
        [Description("酒店经度")]
        public decimal HOTELGIS_LONGITUDE { get; set; }
    
        /// <summary>
        /// 酒店纬度
        /// </summary>
        
        [Description("酒店纬度")]
        public decimal HOTELGIS_LATITUDE { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string HOTELGIS_MEMO { get; set; }
    
        /// <summary>
        /// 排序
        /// </summary>
        
        [Description("排序")]
        public decimal HOTELGIS_SORT { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal HOTELGIS_CREID { get; set; }
    
        /// <summary>
        /// 创建人姓名
        /// </summary>
        
        [Description("创建人姓名")]
        public string HOTELGIS_CRENAME { get; set; }
    
        /// <summary>
        /// 创建人所在机构ID
        /// </summary>
        
        [Description("创建人所在机构ID")]
        public decimal HOTELGIS_CREORGID { get; set; }
    
        /// <summary>
        /// 创建人所在机构名称
        /// </summary>
        
        [Description("创建人所在机构名称")]
        public string HOTELGIS_CREORGNAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime HOTELGIS_CREDATE { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal HOTELGIS_UPID { get; set; }
    
        /// <summary>
        /// 修改人名称
        /// </summary>
        
        [Description("修改人名称")]
        public string HOTELGIS_UPNAME { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime HOTELGIS_UPDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string HOTELGIS_ISDEL { get; set; }
    }
}
