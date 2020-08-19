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
    /// T_BIZ_ROOMTYPE 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_ROOMTYPE")]
    public class T_BIZ_ROOMTYPE
    {
    
        /// <summary>
        /// 酒店房型ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("酒店房型ID")]
        public decimal ROOMTYPE_ID { get; set; }
    
        /// <summary>
        /// 是否逻辑删除 是T 否F
        /// </summary>
        
        [Description("是否逻辑删除 是T 否F")]
        public string ROOMTYPE_ISDEL { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal ROOMTYPE_CREATEID { get; set; }
    
        /// <summary>
        /// 创建人名称
        /// </summary>
        
        [Description("创建人名称")]
        public string ROOMTYPE_CREATENAME { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal ROOMTYPE_EDITID { get; set; }
    
        /// <summary>
        /// 修改人名称
        /// </summary>
        
        [Description("修改人名称")]
        public string ROOMTYPE_EDITNAME { get; set; }
    
        /// <summary>
        /// 创建日期
        /// </summary>
        
        [Description("创建日期")]
        public DateTime ROOMTYPE_CDATE { get; set; }
    
        /// <summary>
        /// 修改日期
        /// </summary>
        
        [Description("修改日期")]
        public DateTime ROOMTYPE_EDITDATE { get; set; }
    }
}
