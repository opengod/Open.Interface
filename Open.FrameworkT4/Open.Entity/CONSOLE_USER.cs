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
    /// CONSOLE_USER 
    /// </summary>    
   [Serializable]
   [SugarTable("CONSOLE_USER")]
    public class CONSOLE_USER
    {
    
        /// <summary>
        /// ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("ID")]
        public decimal USER_ID { get; set; }
    
        /// <summary>
        /// 用户姓名
        /// </summary>
        
        [Description("用户姓名")]
        public string USER_NAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime USER_CREATEDTIME { get; set; }
    
        /// <summary>
        /// 权限等级
        /// </summary>
        
        [Description("权限等级")]
        public decimal USER_LEVEL { get; set; }
    
        /// <summary>
        /// 所在机构
        /// </summary>
        
        [Description("所在机构")]
        public string USER_ORGID { get; set; }
    
        /// <summary>
        /// 登录密码
        /// </summary>
        
        [Description("登录密码")]
        public string USER_PASSWORD { get; set; }
    
        /// <summary>
        /// 登录帐号
        /// </summary>
        
        [Description("登录帐号")]
        public string USER_USERNAME { get; set; }
    }
}
