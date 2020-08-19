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
    /// T_B2C_MEMBER_VISITOR 
    /// </summary>    
   [Serializable]
   [SugarTable("T_B2C_MEMBER_VISITOR")]
    public class T_B2C_MEMBER_VISITOR
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal VISITOR_ID { get; set; }
    
        /// <summary>
        /// 会员ID
        /// </summary>
        
        [Description("会员ID")]
        public decimal VISITOR_MEMBERID { get; set; }
    
        /// <summary>
        /// 姓名
        /// </summary>
        
        [Description("姓名")]
        public string VISITOR_NAME { get; set; }
    
        /// <summary>
        /// 手机号
        /// </summary>
        
        [Description("手机号")]
        public string VISITOR_PHONE { get; set; }
    
        /// <summary>
        /// 身份证号码
        /// </summary>
        
        [Description("身份证号码")]
        public string VISITOR_IDCARD { get; set; }
    
        /// <summary>
        /// 证件类型，身份证0、港澳居民来往内地通行证1、台湾居民来往大陆通行证2、护照3
        /// </summary>
        
        [Description("证件类型，身份证0、港澳居民来往内地通行证1、台湾居民来往大陆通行证2、护照3")]
        public string VISITOR_CARDTYPE { get; set; }
    
        /// <summary>
        /// 是否默认：T默认，仅有一个默认
        /// </summary>
        
        [Description("是否默认：T默认，仅有一个默认")]
        public string VISITOR_ISDEFAULT { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime VISITOR_CREDATE { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime VISITOR_UPDATE { get; set; }
    
        /// <summary>
        /// 逻辑删除
        /// </summary>
        
        [Description("逻辑删除")]
        public string VISITOR_ISDEL { get; set; }
    }
}
