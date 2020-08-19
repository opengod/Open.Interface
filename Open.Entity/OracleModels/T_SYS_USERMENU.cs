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
    /// T_SYS_USERMENU 
    /// </summary>    
   [Serializable]
   [SugarTable("T_SYS_USERMENU")]
    public class T_SYS_USERMENU
    {
    
        /// <summary>
        /// 用户菜单ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("用户菜单ID")]
        public decimal USERMENU_ID { get; set; }
    
        /// <summary>
        /// 菜单ID
        /// </summary>
        
        [Description("菜单ID")]
        public decimal USERMENU_MENUID { get; set; }
    
        /// <summary>
        /// 用户ID
        /// </summary>
        
        [Description("用户ID")]
        public decimal USERMENU_USERID { get; set; }
    }
}
