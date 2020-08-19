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
    /// T_SYS_USER 
    /// </summary>    
   [Serializable]
   [SugarTable("T_SYS_USER")]
    public class T_SYS_USER
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
        /// 创建人
        /// </summary>
        
        [Description("创建人")]
        public decimal USER_CREATEDBY { get; set; }
    
        /// <summary>
        /// 逻辑删除（T、:F）
        /// </summary>
        
        [Description("逻辑删除（T、:F）")]
        public string USER_DEL { get; set; }
    
        /// <summary>
        /// 邮箱
        /// </summary>
        
        [Description("邮箱")]
        public string USER_EMAIL { get; set; }
    
        /// <summary>
        /// 身份证号码
        /// </summary>
        
        [Description("身份证号码")]
        public string USER_IDENTITYNO { get; set; }
    
        /// <summary>
        /// 所在机构
        /// </summary>
        
        [Description("所在机构")]
        public decimal USER_ORGID { get; set; }
    
        /// <summary>
        /// 是否启用
        /// </summary>
        
        [Description("是否启用")]
        public string USER_ISENABLE { get; set; }
    
        /// <summary>
        /// 是否锁定
        /// </summary>
        
        [Description("是否锁定")]
        public string USER_ISLOCK { get; set; }
    
        /// <summary>
        /// 登陆密码
        /// </summary>
        
        [Description("登陆密码")]
        public string USER_PASSWORD { get; set; }
    
        /// <summary>
        /// 登录名
        /// </summary>
        
        [Description("登录名")]
        public string USER_USERNAME { get; set; }
    
        /// <summary>
        /// 用户电话
        /// </summary>
        
        [Description("用户电话")]
        public string USER_TEL { get; set; }
    
        /// <summary>
        /// 用户生日
        /// </summary>
        
        [Description("用户生日")]
        public string USER_BIRTHDAY { get; set; }
    
        /// <summary>
        /// 用户性别
        /// </summary>
        
        [Description("用户性别")]
        public string USER_SEX { get; set; }
    
        /// <summary>
        /// 删除人ID
        /// </summary>
        
        [Description("删除人ID")]
        public decimal USER_DELID { get; set; }
    
        /// <summary>
        /// 删除人姓名
        /// </summary>
        
        [Description("删除人姓名")]
        public string USER_DELNAME { get; set; }
    
        /// <summary>
        /// 删除日期
        /// </summary>
        
        [Description("删除日期")]
        public DateTime USER_DELDATE { get; set; }
    }
}
