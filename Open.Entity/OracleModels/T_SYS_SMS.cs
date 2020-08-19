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
    /// T_SYS_SMS 
    /// </summary>    
   [Serializable]
   [SugarTable("T_SYS_SMS")]
    public class T_SYS_SMS
    {
    
        /// <summary>
        /// 待发短信ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("待发短信ID")]
        public decimal SMS_ID { get; set; }
    
        /// <summary>
        /// 企业id(短信发送)
        /// </summary>
        
        [Description("企业id(短信发送)")]
        public decimal SMS_ORGID { get; set; }
    
        /// <summary>
        /// 待发短信接收人手机号
        /// </summary>
        
        [Description("待发短信接收人手机号")]
        public string SMS_PHONE { get; set; }
    
        /// <summary>
        /// 待发短信内容
        /// </summary>
        
        [Description("待发短信内容")]
        public string SMS_CONTENT { get; set; }
    
        /// <summary>
        /// 待发短信最多尝试发送数量
        /// </summary>
        
        [Description("待发短信最多尝试发送数量")]
        public decimal SMS_NUM { get; set; }
    
        /// <summary>
        /// 待发短信状态 0待发送 1已发送 2发送失败
        /// </summary>
        
        [Description("待发短信状态 0待发送 1已发送 2发送失败")]
        public decimal SMS_STATUS { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime SMS_DATE { get; set; }
    }
}
