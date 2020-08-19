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
    /// T_B2C_LINK 
    /// </summary>    
   [Serializable]
   [SugarTable("T_B2C_LINK")]
    public class T_B2C_LINK
    {
    
        /// <summary>
        /// 友情链接主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("友情链接主键")]
        public decimal LINK_ID { get; set; }
    
        /// <summary>
        /// 友情链接名称
        /// </summary>
        
        [Description("友情链接名称")]
        public string LINK_NAME { get; set; }
    
        /// <summary>
        /// 友情链接地址
        /// </summary>
        
        [Description("友情链接地址")]
        public string LINK_URL { get; set; }
    
        /// <summary>
        /// 链接图片
        /// </summary>
        
        [Description("链接图片")]
        public string LINK_PICPATH { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string LINK_MEMO { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal LINK_CREID { get; set; }
    
        /// <summary>
        /// 创建人姓名
        /// </summary>
        
        [Description("创建人姓名")]
        public string LINK_CRENAME { get; set; }
    
        /// <summary>
        /// 创建人所在机构ID
        /// </summary>
        
        [Description("创建人所在机构ID")]
        public decimal LINK_CREORGID { get; set; }
    
        /// <summary>
        /// 创建人所在机构名称
        /// </summary>
        
        [Description("创建人所在机构名称")]
        public string LINK_CREORGNAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime LINK_CREDATE { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal LINK_UPID { get; set; }
    
        /// <summary>
        /// 修改人名称
        /// </summary>
        
        [Description("修改人名称")]
        public string LINK_UPNAME { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime LINK_UPDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string LINK_ISDEL { get; set; }
    }
}
