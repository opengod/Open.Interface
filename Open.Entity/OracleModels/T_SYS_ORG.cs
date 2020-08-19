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
    /// T_SYS_ORG 
    /// </summary>    
   [Serializable]
   [SugarTable("T_SYS_ORG")]
    public class T_SYS_ORG
    {
    
        /// <summary>
        /// ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("ID")]
        public decimal ORG_ID { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal ORG_PID { get; set; }
    
        /// <summary>
        /// 企业名称
        /// </summary>
        
        [Description("企业名称")]
        public string ORG_NAME { get; set; }
    
        /// <summary>
        /// 企业描述
        /// </summary>
        
        [Description("企业描述")]
        public string ORG_MEMO { get; set; }
    
        /// <summary>
        /// 企业备注
        /// </summary>
        
        [Description("企业备注")]
        public string ORG_REMARK { get; set; }
    
        /// <summary>
        /// 企业类型
        /// </summary>
        
        [Description("企业类型")]
        public decimal ORG_TYPEID { get; set; }
    
        /// <summary>
        /// 工商注册号
        /// </summary>
        
        [Description("工商注册号")]
        public string ORG_REGISTEREDNO { get; set; }
    
        /// <summary>
        /// 登陆账号
        /// </summary>
        
        [Description("登陆账号")]
        public string ORG_LOGINNAME { get; set; }
    
        /// <summary>
        /// 企业密钥
        /// </summary>
        
        [Description("企业密钥")]
        public string ORG_PASSWROD { get; set; }
    
        /// <summary>
        /// 联系人
        /// </summary>
        
        [Description("联系人")]
        public string ORG_LINKPERSON { get; set; }
    
        /// <summary>
        /// 联系人电话
        /// </summary>
        
        [Description("联系人电话")]
        public string ORG_LINKTEL { get; set; }
    
        /// <summary>
        /// 企业邮箱
        /// </summary>
        
        [Description("企业邮箱")]
        public string ORG_EMAIL { get; set; }
    
        /// <summary>
        /// 是否部门
        /// </summary>
        
        [Description("是否部门")]
        public string ORG_ISDEPARTMENT { get; set; }
    
        /// <summary>
        /// 是否锁定
        /// </summary>
        
        [Description("是否锁定")]
        public string ORG_ISLOCK { get; set; }
    
        /// <summary>
        /// 是否启用
        /// </summary>
        
        [Description("是否启用")]
        public string ORG_ISENABLE { get; set; }
    
        /// <summary>
        /// 企业编号
        /// </summary>
        
        [Description("企业编号")]
        public string ORG_NUMBER { get; set; }
    
        /// <summary>
        /// 组织机构代码
        /// </summary>
        
        [Description("组织机构代码")]
        public string ORG_CODE { get; set; }
    
        /// <summary>
        /// 国家
        /// </summary>
        
        [Description("国家")]
        public decimal ORG_NATION { get; set; }
    
        /// <summary>
        /// 省份
        /// </summary>
        
        [Description("省份")]
        public decimal ORG_PROVINCE { get; set; }
    
        /// <summary>
        /// 区域
        /// </summary>
        
        [Description("区域")]
        public decimal ORG_AREA { get; set; }
    
        /// <summary>
        /// 县
        /// </summary>
        
        [Description("县")]
        public decimal ORG_COUNTY { get; set; }
    
        /// <summary>
        /// 市
        /// </summary>
        
        [Description("市")]
        public decimal ORG_CITY { get; set; }
    
        /// <summary>
        /// 级别
        /// </summary>
        
        [Description("级别")]
        public decimal ORG_LEVEL { get; set; }
    
        /// <summary>
        /// 排序
        /// </summary>
        
        [Description("排序")]
        public decimal ORG_SORT { get; set; }
    
        /// <summary>
        /// 排序2
        /// </summary>
        
        [Description("排序2")]
        public decimal ORG_TSORT { get; set; }
    
        /// <summary>
        /// 地址
        /// </summary>
        
        [Description("地址")]
        public string ORG_ADDRESS { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime ORG_CREATEDTIME { get; set; }
    
        /// <summary>
        /// 创建人
        /// </summary>
        
        [Description("创建人")]
        public decimal ORG_CREATEDBY { get; set; }
    
        /// <summary>
        /// 逻辑删除（T、:F）
        /// </summary>
        
        [Description("逻辑删除（T、:F）")]
        public string ORG_DEL { get; set; }
    
        /// <summary>
        /// 淘宝商户号
        /// </summary>
        
        [Description("淘宝商户号")]
        public string ORG_TBMERCHANTNO { get; set; }
    
        /// <summary>
        /// 景区、景点使用系统的截止有效期
        /// </summary>
        
        [Description("景区、景点使用系统的截止有效期")]
        public DateTime ORG_VALIDDATE { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string ORG_FLAG { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string ORG_NOTICEURL { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string ORG_CREATE { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string ORG_SELLTICKET { get; set; }
    }
}
