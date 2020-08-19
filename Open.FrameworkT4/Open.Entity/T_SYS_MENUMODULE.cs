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
    /// T_SYS_MENUMODULE 
    /// </summary>    
   [Serializable]
   [SugarTable("T_SYS_MENUMODULE")]
    public class T_SYS_MENUMODULE
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal MODULE_ID { get; set; }
    
        /// <summary>
        /// 名称
        /// </summary>
        
        [Description("名称")]
        public string MODULE_NAME { get; set; }
    
        /// <summary>
        /// 所属菜单
        /// </summary>
        
        [Description("所属菜单")]
        public decimal MODULE_MENUID { get; set; }
    
        /// <summary>
        /// 上级
        /// </summary>
        
        [Description("上级")]
        public decimal MODULE_PID { get; set; }
    
        /// <summary>
        /// 位置(1:初始化，2：选中状态)
        /// </summary>
        
        [Description("位置(1:初始化，2：选中状态)")]
        public string MODULE_POSITION { get; set; }
    
        /// <summary>
        /// 事件（点击触发事件）
        /// </summary>
        
        [Description("事件（点击触发事件）")]
        public string MODULE_EVENT { get; set; }
    
        /// <summary>
        /// 图标
        /// </summary>
        
        [Description("图标")]
        public string MODULE_ICO { get; set; }
    
        /// <summary>
        /// 排序
        /// </summary>
        
        [Description("排序")]
        public decimal MODULE_SORT { get; set; }
    
        /// <summary>
        /// 链接
        /// </summary>
        
        [Description("链接")]
        public string MODULE_URL { get; set; }
    
        /// <summary>
        /// 是否启用
        /// </summary>
        
        [Description("是否启用")]
        public string MODULE_ISENABLE { get; set; }
    
        /// <summary>
        /// 是否公共
        /// </summary>
        
        [Description("是否公共")]
        public string MODULE_ISPUBLIC { get; set; }
    
        /// <summary>
        /// 是否分开线
        /// </summary>
        
        [Description("是否分开线")]
        public string MODULE_ISLINE { get; set; }
    
        /// <summary>
        /// 允许编辑
        /// </summary>
        
        [Description("允许编辑")]
        public string MODULE_ISEDIT { get; set; }
    
        /// <summary>
        /// 允许删除
        /// </summary>
        
        [Description("允许删除")]
        public string MODULE_ISDEL { get; set; }
    }
}
