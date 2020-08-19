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
    /// T_B2C_ACTIVITE_USER 
    /// </summary>    
   [Serializable]
   [SugarTable("T_B2C_ACTIVITE_USER")]
    public class T_B2C_ACTIVITE_USER
    {
    
        /// <summary>
        /// 主键ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键ID")]
        public decimal USER_ID { get; set; }
    
        /// <summary>
        /// 微信用户表ID
        /// </summary>
        
        [Description("微信用户表ID")]
        public decimal MEMBER_ID { get; set; }
    
        /// <summary>
        /// 活动表ID
        /// </summary>
        
        [Description("活动表ID")]
        public decimal ACTIVIT_ID { get; set; }
    
        /// <summary>
        /// fromid。用户发送模板消息
        /// </summary>
        
        [Description("fromid。用户发送模板消息")]
        public string USER_FORMID { get; set; }
    
        /// <summary>
        /// 姓名
        /// </summary>
        
        [Description("姓名")]
        public string USER_NAME { get; set; }
    
        /// <summary>
        /// 小程序openid
        /// </summary>
        
        [Description("小程序openid")]
        public string USER_OPENID { get; set; }
    
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
        /// 地址
        /// </summary>
        
        [Description("地址")]
        public string USER_ADDRESS { get; set; }
    
        /// <summary>
        /// 报名状态 0：审核中 1：审核通过 2：审核不通过
        /// </summary>
        
        [Description("报名状态 0：审核中 1：审核通过 2：审核不通过")]
        public string USER_STATE { get; set; }
    
        /// <summary>
        /// 报名备注，是否带儿童、家属等，在报名时需备注
        /// </summary>
        
        [Description("报名备注，是否带儿童、家属等，在报名时需备注")]
        public string USER_MEMO { get; set; }
    
        /// <summary>
        /// 审核时备注，主要针对审核不通过时填写的理由
        /// </summary>
        
        [Description("审核时备注，主要针对审核不通过时填写的理由")]
        public string USER_CHECKMEMO { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string USER_ISDEL { get; set; }
    }
}
