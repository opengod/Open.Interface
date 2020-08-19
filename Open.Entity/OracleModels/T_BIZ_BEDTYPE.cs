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
    /// T_BIZ_BEDTYPE 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_BEDTYPE")]
    public class T_BIZ_BEDTYPE
    {
    
        /// <summary>
        /// 酒店床型ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("酒店床型ID")]
        public decimal BEDTYPE_ID { get; set; }
    
        /// <summary>
        /// 是否逻辑删除 F否 T是
        /// </summary>
        
        [Description("是否逻辑删除 F否 T是")]
        public string BEDTYPE_ISDEL { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal BEDTYPE_CREATEID { get; set; }
    
        /// <summary>
        /// 创建人名称
        /// </summary>
        
        [Description("创建人名称")]
        public string BEDTYPE_CREATENAME { get; set; }
    
        /// <summary>
        /// 修改人名称
        /// </summary>
        
        [Description("修改人名称")]
        public string BEDTYPE_EDITNAME { get; set; }
    
        /// <summary>
        /// 创建日期
        /// </summary>
        
        [Description("创建日期")]
        public DateTime BEDTYPE_CDATE { get; set; }
    
        /// <summary>
        /// 修改日期
        /// </summary>
        
        [Description("修改日期")]
        public DateTime BEDTYPE_EDITDATE { get; set; }
    }
}
