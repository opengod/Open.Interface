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
    /// T_BIZ_STARLEVEL 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_STARLEVEL")]
    public class T_BIZ_STARLEVEL
    {
    
        /// <summary>
        /// 酒店星级ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("酒店星级ID")]
        public decimal STARLEVEL_ID { get; set; }
    
        /// <summary>
        /// 酒店星级名称
        /// </summary>
        
        [Description("酒店星级名称")]
        public string STARLEVEL_NAME { get; set; }
    
        /// <summary>
        /// 是否逻辑删除 T是 F否
        /// </summary>
        
        [Description("是否逻辑删除 T是 F否")]
        public string STARLEVEL_ISDEL { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal STARLEVEL_CREATEID { get; set; }
    
        /// <summary>
        /// 创建人名称
        /// </summary>
        
        [Description("创建人名称")]
        public string STARLEVEL_CREATENAME { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal STARLEVEL_EDITID { get; set; }
    
        /// <summary>
        /// 修改人名称
        /// </summary>
        
        [Description("修改人名称")]
        public string STARLEVEL_EDITNAME { get; set; }
    
        /// <summary>
        /// 创建日期
        /// </summary>
        
        [Description("创建日期")]
        public DateTime STARLEVEL_CDATE { get; set; }
    
        /// <summary>
        /// 修改日期
        /// </summary>
        
        [Description("修改日期")]
        public DateTime STARLEVEL_EDITDATE { get; set; }
    }
}
