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
    /// T_BIZ_PAKUSE 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_PAKUSE")]
    public class T_BIZ_PAKUSE
    {
    
        /// <summary>
        /// 产品包应用ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("产品包应用ID")]
        public decimal PAKUSE_ID { get; set; }
    
        /// <summary>
        /// 产品包ID
        /// </summary>
        
        [Description("产品包ID")]
        public decimal PAKUSE_PACKID { get; set; }
    
        /// <summary>
        /// 产品包名称
        /// </summary>
        
        [Description("产品包名称")]
        public string PAKUSE_PACKNAME { get; set; }
    
        /// <summary>
        /// 应用方企业ID
        /// </summary>
        
        [Description("应用方企业ID")]
        public decimal PAKUSE_OTAID { get; set; }
    
        /// <summary>
        /// 应用方企业名称
        /// </summary>
        
        [Description("应用方企业名称")]
        public string PAKUSE_OTANAME { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal PAKUSE_CREATEID { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime PAKUSE_CREATEDATE { get; set; }
    
        /// <summary>
        /// 创建人
        /// </summary>
        
        [Description("创建人")]
        public string PAKUSE_CREATENAME { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal PAKUSE_EDITBYID { get; set; }
    
        /// <summary>
        /// 修改人名称
        /// </summary>
        
        [Description("修改人名称")]
        public string PAKUSE_EDITBYNAME { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime PAKUSE_EDITBYDATE { get; set; }
    
        /// <summary>
        /// 逻辑删除F:T
        /// </summary>
        
        [Description("逻辑删除F:T")]
        public string ISLOGIDEL { get; set; }
    
        /// <summary>
        /// 删除人ID
        /// </summary>
        
        [Description("删除人ID")]
        public decimal DELETEBYID { get; set; }
    
        /// <summary>
        /// 删除人
        /// </summary>
        
        [Description("删除人")]
        public string DELETENAME { get; set; }
    
        /// <summary>
        /// 删除时间
        /// </summary>
        
        [Description("删除时间")]
        public DateTime DELETEDATE { get; set; }
    
        /// <summary>
        /// 创建企业ID
        /// </summary>
        
        [Description("创建企业ID")]
        public decimal PAKUSE_COMPANYCID { get; set; }
    
        /// <summary>
        /// 创建企业名称
        /// </summary>
        
        [Description("创建企业名称")]
        public string PAKUSE_COMPANYNAME { get; set; }
    
        /// <summary>
        /// 景区ID
        /// </summary>
        
        [Description("景区ID")]
        public decimal PAKUSE_PARKID { get; set; }
    
        /// <summary>
        /// 景区名称
        /// </summary>
        
        [Description("景区名称")]
        public string PAKUSE_PARKNAME { get; set; }
    }
}
