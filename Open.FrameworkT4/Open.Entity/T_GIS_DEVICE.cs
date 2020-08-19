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
    /// T_GIS_DEVICE 
    /// </summary>    
   [Serializable]
   [SugarTable("T_GIS_DEVICE")]
    public class T_GIS_DEVICE
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal DEVICEGIS_ID { get; set; }
    
        /// <summary>
        /// 服务点地理信息ID
        /// </summary>
        
        [Description("服务点地理信息ID")]
        public decimal DEVICEGIS_GISID { get; set; }
    
        /// <summary>
        /// 设施编码
        /// </summary>
        
        [Description("设施编码")]
        public string DEVICEGIS_CODE { get; set; }
    
        /// <summary>
        /// 设施名称
        /// </summary>
        
        [Description("设施名称")]
        public string DEVICEGIS_NAME { get; set; }
    
        /// <summary>
        /// 经维度类型
        /// </summary>
        
        [Description("经维度类型")]
        public string DEVICEGIS_TUDETYPE { get; set; }
    
        /// <summary>
        /// 设施经度
        /// </summary>
        
        [Description("设施经度")]
        public decimal DEVICEGIS_LONGITUDE { get; set; }
    
        /// <summary>
        /// 设施维度
        /// </summary>
        
        [Description("设施维度")]
        public decimal DEVICEGIS_LATITUDE { get; set; }
    
        /// <summary>
        /// 设施维护人
        /// </summary>
        
        [Description("设施维护人")]
        public string DEVICEGIS_MAN { get; set; }
    
        /// <summary>
        /// 设施故障联系电话
        /// </summary>
        
        [Description("设施故障联系电话")]
        public string DEVICEGIS_PHONE { get; set; }
    
        /// <summary>
        /// 景区ID
        /// </summary>
        
        [Description("景区ID")]
        public decimal DEVICEGIS_PARKID { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string DEVICEGIS_MEMO { get; set; }
    
        /// <summary>
        /// 排序
        /// </summary>
        
        [Description("排序")]
        public decimal DEVICEGIS_SORT { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal DEVICEGIS_CREID { get; set; }
    
        /// <summary>
        /// 创建人姓名
        /// </summary>
        
        [Description("创建人姓名")]
        public string DEVICEGIS_CRENAME { get; set; }
    
        /// <summary>
        /// 创建人所在机构ID
        /// </summary>
        
        [Description("创建人所在机构ID")]
        public decimal DEVICEGIS_CREORGID { get; set; }
    
        /// <summary>
        /// 创建人所在机构名称
        /// </summary>
        
        [Description("创建人所在机构名称")]
        public string DEVICEGIS_CREORGNAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime DEVICEGIS_CREDATE { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal DEVICEGIS_UPID { get; set; }
    
        /// <summary>
        /// 修改人名称
        /// </summary>
        
        [Description("修改人名称")]
        public string DEVICEGIS_UPNAME { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime DEVICEGIS_UPDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string DEVICEGIS_ISDEL { get; set; }
    }
}
