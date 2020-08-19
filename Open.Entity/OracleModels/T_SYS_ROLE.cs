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
    /// T_SYS_ROLE 
    /// </summary>    
   [Serializable]
   [SugarTable("T_SYS_ROLE")]
    public class T_SYS_ROLE
    {
    
        /// <summary>
        /// ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("ID")]
        public decimal ROLE_ID { get; set; }
    
        /// <summary>
        /// 角色名称
        /// </summary>
        
        [Description("角色名称")]
        public string ROLE_NAME { get; set; }
    
        /// <summary>
        /// 角色描述
        /// </summary>
        
        [Description("角色描述")]
        public string ROLE_MEMO { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime ROLE_CREATEDTIME { get; set; }
    
        /// <summary>
        /// 创建人
        /// </summary>
        
        [Description("创建人")]
        public decimal ROLE_CREATEDBY { get; set; }
    
        /// <summary>
        /// 逻辑删除（T、:F）
        /// </summary>
        
        [Description("逻辑删除（T、:F）")]
        public string ROLE_DEL { get; set; }
    
        /// <summary>
        /// 修改人
        /// </summary>
        
        [Description("修改人")]
        public decimal ROLE_EDITBY { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime ROLE_EDITDATE { get; set; }
    
        /// <summary>
        /// 删除人
        /// </summary>
        
        [Description("删除人")]
        public decimal ROLE_DELETEBYID { get; set; }
    
        /// <summary>
        /// 删除时间
        /// </summary>
        
        [Description("删除时间")]
        public DateTime ROLE_DELETEDATE { get; set; }
    
        /// <summary>
        /// 创建人名称
        /// </summary>
        
        [Description("创建人名称")]
        public string ROLE_CREATENAME { get; set; }
    
        /// <summary>
        /// 修改人名称
        /// </summary>
        
        [Description("修改人名称")]
        public string ROLE_EDITNAME { get; set; }
    
        /// <summary>
        /// 删除人名称
        /// </summary>
        
        [Description("删除人名称")]
        public string ROLE_DELETENAME { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal ROLE_MARKID { get; set; }
    
        /// <summary>
        /// 所属企业ID
        /// </summary>
        
        [Description("所属企业ID")]
        public decimal ROLE_PARKID { get; set; }
    }
}
