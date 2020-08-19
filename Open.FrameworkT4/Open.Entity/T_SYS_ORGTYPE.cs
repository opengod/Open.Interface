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
    /// T_SYS_ORGTYPE 
    /// </summary>    
   [Serializable]
   [SugarTable("T_SYS_ORGTYPE")]
    public class T_SYS_ORGTYPE
    {
    
        /// <summary>
        /// ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("ID")]
        public decimal ORGTYPE_ID { get; set; }
    
        /// <summary>
        /// 类型名称
        /// </summary>
        
        [Description("类型名称")]
        public string ORGTYPE_NAME { get; set; }
    
        /// <summary>
        /// 类型描述
        /// </summary>
        
        [Description("类型描述")]
        public string ORGTYPE_MEMO { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime ORGTYPE_CREATEDTIME { get; set; }
    
        /// <summary>
        /// 创建人
        /// </summary>
        
        [Description("创建人")]
        public decimal ORGTYPE_CREATEDBY { get; set; }
    
        /// <summary>
        /// 逻辑删除（T、:F）
        /// </summary>
        
        [Description("逻辑删除（T、:F）")]
        public string ORGTYPE_DEL { get; set; }
    }
}
