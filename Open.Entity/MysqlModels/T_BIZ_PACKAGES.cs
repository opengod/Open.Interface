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
    /// T_BIZ_PACKAGES 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_PACKAGES")]
    public class T_BIZ_PACKAGES
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal PACKAGES_ID { get; set; }
    
        /// <summary>
        /// 产品包名称
        /// </summary>
        
        [Description("产品包名称")]
        public string PACKAGES_NAME { get; set; }
    
        /// <summary>
        /// 产品包编码
        /// </summary>
        
        [Description("产品包编码")]
        public string PACKAGES_CODE { get; set; }
    
        /// <summary>
        /// 产品包市场价
        /// </summary>
        
        [Description("产品包市场价")]
        public decimal PACKAGES_MARKETPRICE { get; set; }
    
        /// <summary>
        /// 产品包售卖价
        /// </summary>
        
        [Description("产品包售卖价")]
        public decimal PACKAGES_SELLPRICE { get; set; }
    
        /// <summary>
        /// 产品包结算价
        /// </summary>
        
        [Description("产品包结算价")]
        public decimal PACKAGES_SETTLERPRICE { get; set; }
    
        /// <summary>
        /// 排序
        /// </summary>
        
        [Description("排序")]
        public decimal PACKAGES_SORT { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string PACKAGES_MEMO { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal PACKAGES_CREID { get; set; }
    
        /// <summary>
        /// 创建人姓名
        /// </summary>
        
        [Description("创建人姓名")]
        public string PACKAGES_CRENAME { get; set; }
    
        /// <summary>
        /// 创建人所在机构
        /// </summary>
        
        [Description("创建人所在机构")]
        public decimal PACKAGES_CREORGID { get; set; }
    
        /// <summary>
        /// 创建人所在机构名称
        /// </summary>
        
        [Description("创建人所在机构名称")]
        public string PACKAGES_CREORGNAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime PACKAGES_CREDATE { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal PACKAGES_UPID { get; set; }
    
        /// <summary>
        /// 修改人姓名
        /// </summary>
        
        [Description("修改人姓名")]
        public string PACKAGES_UPNAME { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime PACKAGES_UPDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string PACKAGES_ISDEL { get; set; }
    }
}
