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
    /// T_BIZ_COMPLAIN_copy 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_COMPLAIN_copy")]
    public class T_BIZ_COMPLAIN_copy
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal COMPLAIN_ID { get; set; }
    
        /// <summary>
        /// 投诉编码
        /// </summary>
        
        [Description("投诉编码")]
        public string COMPLAIN_NO { get; set; }
    
        /// <summary>
        /// 类型 T投诉，Z咨询
        /// </summary>
        
        [Description("类型 T投诉，Z咨询")]
        public string COMPLAIN_TYPE { get; set; }
    
        /// <summary>
        /// 用户id
        /// </summary>
        
        [Description("用户id")]
        public decimal COMPLAIN_MEMBERID { get; set; }
    
        /// <summary>
        /// 部门id
        /// </summary>
        
        [Description("部门id")]
        public decimal COMPLAIN_ORGID { get; set; }
    
        /// <summary>
        /// 部门名称
        /// </summary>
        
        [Description("部门名称")]
        public string COMPLAIN_ORGNAME { get; set; }
    
        /// <summary>
        /// 标题
        /// </summary>
        
        [Description("标题")]
        public string COMPLAIN_TITLE { get; set; }
    
        /// <summary>
        /// 姓名
        /// </summary>
        
        [Description("姓名")]
        public string COMPLAIN_NAME { get; set; }
    
        /// <summary>
        /// 电话
        /// </summary>
        
        [Description("电话")]
        public string COMPLAIN_MOBILE { get; set; }
    
        /// <summary>
        /// Email
        /// </summary>
        
        [Description("Email")]
        public string COMPLAIN_EMAIL { get; set; }
    
        /// <summary>
        /// 投诉（咨询）内容
        /// </summary>
        
        [Description("投诉（咨询）内容")]
        public string COMPLAIN_CONTENT { get; set; }
    
        /// <summary>
        /// 投诉（咨询）反馈
        /// </summary>
        
        [Description("投诉（咨询）反馈")]
        public string COMPLAIN_REPLY { get; set; }
    
        /// <summary>
        /// 投诉等级（轻微，中等，严重：下拉选择）
        /// </summary>
        
        [Description("投诉等级（轻微，中等，严重：下拉选择）")]
        public string COMPLAIN_GRADE { get; set; }
    
        /// <summary>
        /// 状态（N创建成功，S已完结，I无效投诉，F虚假投诉
        /// </summary>
        
        [Description("状态（N创建成功，S已完结，I无效投诉，F虚假投诉")]
        public string COMPLAIN_STATUS { get; set; }
    
        /// <summary>
        /// 扣除商家信用分数
        /// </summary>
        
        [Description("扣除商家信用分数")]
        public decimal COMPLAIN_ORGSCORE { get; set; }
    
        /// <summary>
        /// 扣除用户信用分数
        /// </summary>
        
        [Description("扣除用户信用分数")]
        public decimal COMPLAIN_USERSCORE { get; set; }
    
        /// <summary>
        /// 投诉结果
        /// </summary>
        
        [Description("投诉结果")]
        public string COMPLAIN_RESULT { get; set; }
    
        /// <summary>
        /// 是否已发送短信
        /// </summary>
        
        [Description("是否已发送短信")]
        public string COMPLAIN_ISSMS { get; set; }
    
        /// <summary>
        /// 排序
        /// </summary>
        
        [Description("排序")]
        public decimal COMPLAIN_SORT { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string COMPLAIN_MEMO { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime COMPLAIN_CREDATE { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal COMPLAIN_UPID { get; set; }
    
        /// <summary>
        /// 修改人姓名
        /// </summary>
        
        [Description("修改人姓名")]
        public string COMPLAIN_UPNAME { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime COMPLAIN_UPDATE { get; set; }
    
        /// <summary>
        /// 是否删除
        /// </summary>
        
        [Description("是否删除")]
        public string COMPLAIN_ISDEL { get; set; }
    }
}
