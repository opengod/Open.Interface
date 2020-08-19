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
    /// T_SYS_LIMIT 
    /// </summary>    
   [Serializable]
   [SugarTable("T_SYS_LIMIT")]
    public class T_SYS_LIMIT
    {
    
        /// <summary>
        /// 主键ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键ID")]
        public decimal LIMIT_ID { get; set; }
    
        /// <summary>
        /// 用户ID
        /// </summary>
        
        [Description("用户ID")]
        public decimal LIMIT_USERID { get; set; }
    
        /// <summary>
        /// 角色ID
        /// </summary>
        
        [Description("角色ID")]
        public decimal LIMIT_ROLEID { get; set; }
    
        /// <summary>
        /// 功能ID
        /// </summary>
        
        [Description("功能ID")]
        public decimal LIMIT_MODULEID { get; set; }
    
        /// <summary>
        /// 菜单ID
        /// </summary>
        
        [Description("菜单ID")]
        public decimal LIMIT_MENUID { get; set; }
    }
}
