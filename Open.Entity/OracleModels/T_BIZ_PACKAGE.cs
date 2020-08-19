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
    /// T_BIZ_PACKAGE 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_PACKAGE")]
    public class T_BIZ_PACKAGE
    {
    
        /// <summary>
        /// 产品包ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("产品包ID")]
        public decimal PACKAGE_ID { get; set; }
    
        /// <summary>
        /// 产品包名称
        /// </summary>
        
        [Description("产品包名称")]
        public string PACKAGE_CNNAME { get; set; }
    
        /// <summary>
        /// 产品包英文
        /// </summary>
        
        [Description("产品包英文")]
        public string PACKAGE_ENNAME { get; set; }
    
        /// <summary>
        /// 产品包编码
        /// </summary>
        
        [Description("产品包编码")]
        public string PACKAGE_CODE { get; set; }
    
        /// <summary>
        /// 是否缺省0是缺省1是否
        /// </summary>
        
        [Description("是否缺省0是缺省1是否")]
        public decimal PACKAGE_DEFAULTFLAG { get; set; }
    
        /// <summary>
        /// 是否启用0是启用1是未启用
        /// </summary>
        
        [Description("是否启用0是启用1是未启用")]
        public decimal PACKAGE_USEFLAG { get; set; }
    
        /// <summary>
        /// 景区ID
        /// </summary>
        
        [Description("景区ID")]
        public decimal PACKAGE_PARKID { get; set; }
    
        /// <summary>
        /// 景区名称
        /// </summary>
        
        [Description("景区名称")]
        public string PACKAGE_PARKNAME { get; set; }
    
        /// <summary>
        /// 企业ID
        /// </summary>
        
        [Description("企业ID")]
        public decimal PACKAGE_COMPANYID { get; set; }
    
        /// <summary>
        /// 企业名称
        /// </summary>
        
        [Description("企业名称")]
        public string PACKAGE_COMPANYNAME { get; set; }
    
        /// <summary>
        /// 逻辑删除
        /// </summary>
        
        [Description("逻辑删除")]
        public string ISLOGIDEL { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal PACKAGE_CREATEID { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime PACKAGE_CREATEDATE { get; set; }
    
        /// <summary>
        /// 修改人
        /// </summary>
        
        [Description("修改人")]
        public decimal PACKAGE_EDITID { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime PACKAGE_EDITDATE { get; set; }
    
        /// <summary>
        /// 删除人ID
        /// </summary>
        
        [Description("删除人ID")]
        public decimal PACKAGE_DELID { get; set; }
    
        /// <summary>
        /// 删除人
        /// </summary>
        
        [Description("删除人")]
        public string PACKAGE_DELNAME { get; set; }
    
        /// <summary>
        /// 删除日期
        /// </summary>
        
        [Description("删除日期")]
        public DateTime PACKAGE_DELDATE { get; set; }
    
        /// <summary>
        /// 创建企业ID
        /// </summary>
        
        [Description("创建企业ID")]
        public decimal PACKAGE_COMPANYCID { get; set; }
    
        /// <summary>
        /// 创建企业名称
        /// </summary>
        
        [Description("创建企业名称")]
        public string PACKAGE_COMPANGNAME { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string PACKAGE_STATUS { get; set; }
    }
}
