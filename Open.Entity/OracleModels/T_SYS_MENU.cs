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
    /// T_SYS_MENU 
    /// </summary>    
   [Serializable]
   [SugarTable("T_SYS_MENU")]
    public class T_SYS_MENU
    {
    
        /// <summary>
        /// ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("ID")]
        public decimal MENU_ID { get; set; }
    
        /// <summary>
        /// 菜单名称
        /// </summary>
        
        [Description("菜单名称")]
        public string MENU_NAME { get; set; }
    
        /// <summary>
        /// 上级菜单
        /// </summary>
        
        [Description("上级菜单")]
        public decimal MENU_PID { get; set; }
    
        /// <summary>
        /// 链接地址
        /// </summary>
        
        [Description("链接地址")]
        public string MENU_URL { get; set; }
    
        /// <summary>
        /// 菜单描述
        /// </summary>
        
        [Description("菜单描述")]
        public string MENU_MEMO { get; set; }
    
        /// <summary>
        /// 排序
        /// </summary>
        
        [Description("排序")]
        public decimal MENU_SORT { get; set; }
    
        /// <summary>
        /// 排序2
        /// </summary>
        
        [Description("排序2")]
        public decimal MENU_TSORT { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime MENU_CREATEDTIME { get; set; }
    
        /// <summary>
        /// 创建人
        /// </summary>
        
        [Description("创建人")]
        public decimal MENU_CREATEDBY { get; set; }
    
        /// <summary>
        /// 逻辑删除（T、:F）
        /// </summary>
        
        [Description("逻辑删除（T、:F）")]
        public string MENU_DEL { get; set; }
    }
}
