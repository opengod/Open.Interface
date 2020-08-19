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
    /// T_BIZ_TOURISTS 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_TOURISTS")]
    public class T_BIZ_TOURISTS
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal TOURISTS_ID { get; set; }
    
        /// <summary>
        /// 信息来源
        /// </summary>
        
        [Description("信息来源")]
        public string TOURISTS_MSGFROMCODEVALUE { get; set; }
    
        /// <summary>
        /// 真实姓名
        /// </summary>
        
        [Description("真实姓名")]
        public string TOURISTS_REALNAME { get; set; }
    
        /// <summary>
        /// 性别
        /// </summary>
        
        [Description("性别")]
        public string TOURISTS_SEX { get; set; }
    
        /// <summary>
        /// 出生日期
        /// </summary>
        
        [Description("出生日期")]
        public string TOURISTS_BIRTHDATE { get; set; }
    
        /// <summary>
        /// 身份证号码
        /// </summary>
        
        [Description("身份证号码")]
        public string TOURISTS_IDCARD { get; set; }
    
        /// <summary>
        /// 家庭住址
        /// </summary>
        
        [Description("家庭住址")]
        public string TOURISTS_HOMEADDRESS { get; set; }
    
        /// <summary>
        /// 移动电话
        /// </summary>
        
        [Description("移动电话")]
        public string TOURISTS_MOBILE { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string TOURISTS_MEMO { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal TOURISTS_CREID { get; set; }
    
        /// <summary>
        /// 创建人姓名
        /// </summary>
        
        [Description("创建人姓名")]
        public string TOURISTS_CRENAME { get; set; }
    
        /// <summary>
        /// 创建人所在机构ID
        /// </summary>
        
        [Description("创建人所在机构ID")]
        public decimal TOURISTS_CREORGID { get; set; }
    
        /// <summary>
        /// 创建人所在机构名称
        /// </summary>
        
        [Description("创建人所在机构名称")]
        public string TOURISTS_CREORGNAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime TOURISTS_CREDATE { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal TOURISTS_UPID { get; set; }
    
        /// <summary>
        /// 修改人名称
        /// </summary>
        
        [Description("修改人名称")]
        public string TOURISTS_UPNAME { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime TOURISTS_UPDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string TOURISTS_ISDEL { get; set; }
    }
}
