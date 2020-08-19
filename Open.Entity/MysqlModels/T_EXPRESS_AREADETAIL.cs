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
    /// T_EXPRESS_AREADETAIL 
    /// </summary>    
   [Serializable]
   [SugarTable("T_EXPRESS_AREADETAIL")]
    public class T_EXPRESS_AREADETAIL
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public long DETAIL_ID { get; set; }
    
        /// <summary>
        /// 运费模板ID
        /// </summary>
        
        [Description("运费模板ID")]
        public long DETAIL_TEMPLATEID { get; set; }
    
        /// <summary>
        /// 指定地区ID
        /// </summary>
        
        [Description("指定地区ID")]
        public long DETAIL_AREAID { get; set; }
    
        /// <summary>
        /// 省代码
        /// </summary>
        
        [Description("省代码")]
        public long DETAIL_PROVINCEID { get; set; }
    
        /// <summary>
        /// 省名称
        /// </summary>
        
        [Description("省名称")]
        public string DETAIL_PROVINCENAME { get; set; }
    
        /// <summary>
        /// 市代码
        /// </summary>
        
        [Description("市代码")]
        public long DETAIL_CITYID { get; set; }
    
        /// <summary>
        /// 市名称
        /// </summary>
        
        [Description("市名称")]
        public string DETAIL_CITYNAME { get; set; }
    
        /// <summary>
        /// 县区代码
        /// </summary>
        
        [Description("县区代码")]
        public long DETAIL_COUNTYID { get; set; }
    
        /// <summary>
        /// 县区名称
        /// </summary>
        
        [Description("县区名称")]
        public string DETAIL_COUNTYNAME { get; set; }
    
        /// <summary>
        /// 乡镇ID(逗号隔开)
        /// </summary>
        
        [Description("乡镇ID(逗号隔开)")]
        public string DETAIL_TOWNIDS { get; set; }
    
        /// <summary>
        /// 乡镇名称(逗号隔开)
        /// </summary>
        
        [Description("乡镇名称(逗号隔开)")]
        public string DETAIL_TOWNNAMES { get; set; }
    
        /// <summary>
        /// 最后一级地址ID
        /// </summary>
        
        [Description("最后一级地址ID")]
        public string DETAIL_REGIONID { get; set; }
    
        /// <summary>
        /// 地址全路径
        /// </summary>
        
        [Description("地址全路径")]
        public string DETAIL_REGIONPATH { get; set; }
    }
}
