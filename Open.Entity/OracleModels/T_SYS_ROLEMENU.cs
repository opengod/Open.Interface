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
    /// T_SYS_ROLEMENU 
    /// </summary>    
   [Serializable]
   [SugarTable("T_SYS_ROLEMENU")]
    public class T_SYS_ROLEMENU
    {
    
        /// <summary>
        /// 角色菜单ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("角色菜单ID")]
        public decimal ROLEMENU_ID { get; set; }
    
        /// <summary>
        /// 角色ID
        /// </summary>
        
        [Description("角色ID")]
        public decimal ROLEMENU_USERID { get; set; }
    
        /// <summary>
        /// 菜单ID
        /// </summary>
        
        [Description("菜单ID")]
        public decimal ROLEMENU_MENUID { get; set; }
    
        /// <summary>
        /// 所属企业ID
        /// </summary>
        
        [Description("所属企业ID")]
        public decimal ROLEMENU_PARKID { get; set; }
    }
}
