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
    /// T_B2C_MEMBER 
    /// </summary>    
   [Serializable]
   [SugarTable("T_B2C_MEMBER")]
    public class T_B2C_MEMBER
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal MEMBER_ID { get; set; }
    
        /// <summary>
        /// 会员认证方式（1身份证实名验证、2手机号验证）
        /// </summary>
        
        [Description("会员认证方式（1身份证实名验证、2手机号验证）")]
        public string MEMBER_CERTIFY { get; set; }
    
        /// <summary>
        /// 微信昵称
        /// </summary>
        
        [Description("微信昵称")]
        public string MEMBER_WENICK { get; set; }
    
        /// <summary>
        /// 微信头像链接
        /// </summary>
        
        [Description("微信头像链接")]
        public string MEMBER_WEPIC { get; set; }
    
        /// <summary>
        /// 会员姓名
        /// </summary>
        
        [Description("会员姓名")]
        public string MEMBER_NAME { get; set; }
    
        /// <summary>
        /// 信用评分
        /// </summary>
        
        [Description("信用评分")]
        public decimal MEMBER_CREDIT { get; set; }
    
        /// <summary>
        /// 会员性别
        /// </summary>
        
        [Description("会员性别")]
        public string MEMBER_SEX { get; set; }
    
        /// <summary>
        /// 会员生日
        /// </summary>
        
        [Description("会员生日")]
        public string MEMBER_BIRTHDATE { get; set; }
    
        /// <summary>
        /// 身份证号码
        /// </summary>
        
        [Description("身份证号码")]
        public string MEMBER_IDCARD { get; set; }
    
        /// <summary>
        /// 家庭地址
        /// </summary>
        
        [Description("家庭地址")]
        public string MEMBER_HOMEADDRESS { get; set; }
    
        /// <summary>
        /// 电子邮件
        /// </summary>
        
        [Description("电子邮件")]
        public string MEMBER_EMAIL { get; set; }
    
        /// <summary>
        /// 密码找回问题
        /// </summary>
        
        [Description("密码找回问题")]
        public string MEMBER_PWDQUESTION { get; set; }
    
        /// <summary>
        /// 密码找回答案
        /// </summary>
        
        [Description("密码找回答案")]
        public string MEMBER_PWDANSWER { get; set; }
    
        /// <summary>
        /// QQ
        /// </summary>
        
        [Description("QQ")]
        public string MEMBER_QQ { get; set; }
    
        /// <summary>
        /// 手机号码
        /// </summary>
        
        [Description("手机号码")]
        public string MEMBER_MOBILE { get; set; }
    
        /// <summary>
        /// 密码
        /// </summary>
        
        [Description("密码")]
        public string MEMBER_PWD { get; set; }
    
        /// <summary>
        /// 会员等级
        /// </summary>
        
        [Description("会员等级")]
        public string MEMBER_LEVELCODEVALUE { get; set; }
    
        /// <summary>
        /// 微信uid
        /// </summary>
        
        [Description("微信uid")]
        public string MEMBER_WEUID { get; set; }
    
        /// <summary>
        /// 微信openid
        /// </summary>
        
        [Description("微信openid")]
        public string MEMBER_WEOPENID { get; set; }
    
        /// <summary>
        /// 申请时间
        /// </summary>
        
        [Description("申请时间")]
        public DateTime MEMBER_APPLYDATE { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal MEMBER_UPID { get; set; }
    
        /// <summary>
        /// 修改人名称
        /// </summary>
        
        [Description("修改人名称")]
        public string MEMBER_UPNAME { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime MEMBER_UPDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string MEMBER_ISDEL { get; set; }
    
        /// <summary>
        /// 是否学生  T:是 F:否
        /// </summary>
        
        [Description("是否学生  T:是 F:否")]
        public string MEMBER_ISSTUDENT { get; set; }
    
        /// <summary>
        /// 学校
        /// </summary>
        
        [Description("学校")]
        public string MEMBER_SCHOOL { get; set; }
    
        /// <summary>
        /// 专业
        /// </summary>
        
        [Description("专业")]
        public string MEMBER_SPECIALTY { get; set; }
    
        /// <summary>
        /// 学号
        /// </summary>
        
        [Description("学号")]
        public string MEMBER_SNO { get; set; }
    
        /// <summary>
        /// 是否领取过高校新生活动的优惠  T:已经领取 F：还未领取
        /// </summary>
        
        [Description("是否领取过高校新生活动的优惠  T:已经领取 F：还未领取")]
        public string MEMBER_ISGET { get; set; }
    }
}
