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
    /// T_EXPRESS_AREA 
    /// </summary>    
   [Serializable]
   [SugarTable("T_EXPRESS_AREA")]
    public class T_EXPRESS_AREA
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public long AREA_ID { get; set; }
    
        /// <summary>
        /// 运费模板ID
        /// </summary>
        
        [Description("运费模板ID")]
        public long AREA_TEMPLATEID { get; set; }
    
        /// <summary>
        /// 是否默认：0-否；1-是
        /// </summary>
        
        [Description("是否默认：0-否；1-是")]
        public int AREA_ISDEFAULT { get; set; }
    
        /// <summary>
        /// 地区内容
        /// </summary>
        
        [Description("地区内容")]
        public string AREA_CONTENT { get; set; }
    
        /// <summary>
        /// 首重(默认1)
        /// </summary>
        
        [Description("首重(默认1)")]
        public decimal AREA_FIRSTUNIT { get; set; }
    
        /// <summary>
        /// 首重金额
        /// </summary>
        
        [Description("首重金额")]
        public decimal AREA_FIRSTMONEY { get; set; }
    
        /// <summary>
        /// 续重(默认1)
        /// </summary>
        
        [Description("续重(默认1)")]
        public decimal AREA_PLUSUNIT { get; set; }
    
        /// <summary>
        /// 续重金额
        /// </summary>
        
        [Description("续重金额")]
        public decimal AREA_PLUSMONEY { get; set; }
    }
}
