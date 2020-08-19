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
    /// T_SYS_USERROLE 
    /// </summary>    
   [Serializable]
   [SugarTable("T_SYS_USERROLE")]
    public class T_SYS_USERROLE
    {
    
        /// <summary>
        /// ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("ID")]
        public decimal USERROLE_ID { get; set; }
    
        /// <summary>
        /// 角色id
        /// </summary>
        
        [Description("角色id")]
        public decimal USERROLE_ROLEID { get; set; }
    
        /// <summary>
        /// 用户ID
        /// </summary>
        
        [Description("用户ID")]
        public decimal USERROLE_USERID { get; set; }
    
        /// <summary>
        /// 删除人ID
        /// </summary>
        
        [Description("删除人ID")]
        public decimal USERROLE_DELETEID { get; set; }
    
        /// <summary>
        /// 创建人名称
        /// </summary>
        
        [Description("创建人名称")]
        public string USERROLE_DELETENAME { get; set; }
    
        /// <summary>
        /// 删除时间
        /// </summary>
        
        [Description("删除时间")]
        public DateTime USERROLE_DELETETIME { get; set; }
    
        /// <summary>
        /// 逻辑删除（T、:F）
        /// </summary>
        
        [Description("逻辑删除（T、:F）")]
        public string USERROLE_DEL { get; set; }
    
        /// <summary>
        /// 所属企业ID
        /// </summary>
        
        [Description("所属企业ID")]
        public decimal USERROLE_PARKID { get; set; }
    }
}
