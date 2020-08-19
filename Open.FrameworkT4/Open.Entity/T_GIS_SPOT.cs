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
    /// T_GIS_SPOT 
    /// </summary>    
   [Serializable]
   [SugarTable("T_GIS_SPOT")]
    public class T_GIS_SPOT
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal SPOTGIS_ID { get; set; }
    
        /// <summary>
        /// 机构名称
        /// </summary>
        
        [Description("机构名称")]
        public string SPOTGIS_NAME { get; set; }
    
        /// <summary>
        /// 机构类别
        /// </summary>
        
        [Description("机构类别")]
        public string SPOTGIS_TYPE { get; set; }
    
        /// <summary>
        /// 机构容量
        /// </summary>
        
        [Description("机构容量")]
        public decimal SPOTGIS_CAPACITY { get; set; }
    
        /// <summary>
        /// 联系人
        /// </summary>
        
        [Description("联系人")]
        public string SPOTGIS_MAN { get; set; }
    
        /// <summary>
        /// 联系电话
        /// </summary>
        
        [Description("联系电话")]
        public string SPOTGIS_PHONE { get; set; }
    
        /// <summary>
        /// 基础信息
        /// </summary>
        
        [Description("基础信息")]
        public string SPOTGIS_INFO { get; set; }
    
        /// <summary>
        /// 经维度类型
        /// </summary>
        
        [Description("经维度类型")]
        public string SPOTGIS_TUDETYPE { get; set; }
    
        /// <summary>
        /// 机构经度
        /// </summary>
        
        [Description("机构经度")]
        public decimal SPOTGIS_LONGITUDE { get; set; }
    
        /// <summary>
        /// 机构维度
        /// </summary>
        
        [Description("机构维度")]
        public decimal SPOTGIS_LATITUDE { get; set; }
    
        /// <summary>
        /// 机构ID
        /// </summary>
        
        [Description("机构ID")]
        public decimal SPOTGIS_PARKID { get; set; }
    
        /// <summary>
        /// 语音地址
        /// </summary>
        
        [Description("语音地址")]
        public string SPOTGIS_VOICEURL { get; set; }
    
        /// <summary>
        /// 机构详细地址
        /// </summary>
        
        [Description("机构详细地址")]
        public string SPOTGIS_ADDRESS { get; set; }
    
        /// <summary>
        /// 机构详情介绍
        /// </summary>
        
        [Description("机构详情介绍")]
        public string SPOTGIS_EXPLAIN { get; set; }
    
        /// <summary>
        /// 区域
        /// </summary>
        
        [Description("区域")]
        public string SPOTGIS_REGION { get; set; }
    
        /// <summary>
        /// 是否推荐
        /// </summary>
        
        [Description("是否推荐")]
        public string SPOTGIS_ISHOT { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string SPOTGIS_MEMO { get; set; }
    
        /// <summary>
        /// 排序
        /// </summary>
        
        [Description("排序")]
        public decimal SPOTGIS_SORT { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal SPOTGIS_CREID { get; set; }
    
        /// <summary>
        /// 创建人姓名
        /// </summary>
        
        [Description("创建人姓名")]
        public string SPOTGIS_CRENAME { get; set; }
    
        /// <summary>
        /// 创建人所在机构ID
        /// </summary>
        
        [Description("创建人所在机构ID")]
        public decimal SPOTGIS_CREORGID { get; set; }
    
        /// <summary>
        /// 创建人所在机构名称
        /// </summary>
        
        [Description("创建人所在机构名称")]
        public string SPOTGIS_CREORGNAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime SPOTGIS_CREDATE { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal SPOTGIS_UPID { get; set; }
    
        /// <summary>
        /// 修改人名称
        /// </summary>
        
        [Description("修改人名称")]
        public string SPOTGIS_UPNAME { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime SPOTGIS_UPDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string SPOTGIS_ISDEL { get; set; }
    
        /// <summary>
        /// 标签
        /// </summary>
        
        [Description("标签")]
        public string SPOTGIS_TAG { get; set; }
    }
}
