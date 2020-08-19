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
    /// T_SYS_USER 
    /// </summary>    
   [Serializable]
   [SugarTable("T_SYS_USER")]
    public class T_SYS_USER
    {
    
        /// <summary>
        /// 主键ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键ID")]
        public decimal USER_ID { get; set; }
    
        /// <summary>
        /// 用户名
        /// </summary>
        
        [Description("用户名")]
        public string USER_USERNAME { get; set; }
    
        /// <summary>
        /// 用户密码
        /// </summary>
        
        [Description("用户密码")]
        public string USER_PASSWORD { get; set; }
    
        /// <summary>
        /// 姓名
        /// </summary>
        
        [Description("姓名")]
        public string USER_NAME { get; set; }
    
        /// <summary>
        /// 性别
        /// </summary>
        
        [Description("性别")]
        public string USER_SEX { get; set; }
    
        /// <summary>
        /// 联系电话
        /// </summary>
        
        [Description("联系电话")]
        public string USER_TEL { get; set; }
    
        /// <summary>
        /// QQ
        /// </summary>
        
        [Description("QQ")]
        public string USER_QQ { get; set; }
    
        /// <summary>
        /// 邮箱
        /// </summary>
        
        [Description("邮箱")]
        public string USER_EMAIL { get; set; }
    
        /// <summary>
        /// 身份证号
        /// </summary>
        
        [Description("身份证号")]
        public string USER_ICNO { get; set; }
    
        /// <summary>
        /// 头像
        /// </summary>
        
        [Description("头像")]
        public string USER_IMG { get; set; }
    
        /// <summary>
        /// 是否停用
        /// </summary>
        
        [Description("是否停用")]
        public string USER_ISENABLE { get; set; }
    
        /// <summary>
        /// 用户角色
        /// </summary>
        
        [Description("用户角色")]
        public decimal USER_ROLEID { get; set; }
    
        /// <summary>
        /// 所在机构
        /// </summary>
        
        [Description("所在机构")]
        public decimal USER_DEPARTMENTID { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string USER_MEMO { get; set; }
    
        /// <summary>
        /// 排序
        /// </summary>
        
        [Description("排序")]
        public decimal USER_SORT { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal USER_CREID { get; set; }
    
        /// <summary>
        /// 创建人姓名
        /// </summary>
        
        [Description("创建人姓名")]
        public string USER_CRENAME { get; set; }
    
        /// <summary>
        /// 创建人所在机构ID
        /// </summary>
        
        [Description("创建人所在机构ID")]
        public decimal USER_CREORGID { get; set; }
    
        /// <summary>
        /// 创建人所在机构名称
        /// </summary>
        
        [Description("创建人所在机构名称")]
        public string USER_CREORGNAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime USER_CREDATE { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal USER_UPID { get; set; }
    
        /// <summary>
        /// 修改人姓名
        /// </summary>
        
        [Description("修改人姓名")]
        public string USER_UPNAME { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime USER_UPDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string USER_ISDEL { get; set; }
    }
}
