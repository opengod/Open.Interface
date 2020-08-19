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
    /// T_BIZ_MESSAGE 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_MESSAGE")]
    public class T_BIZ_MESSAGE
    {
    
        /// <summary>
        /// 短信记录表主键ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("短信记录表主键ID")]
        public decimal MESSAGE_ID { get; set; }
    
        /// <summary>
        /// 订单号
        /// </summary>
        
        [Description("订单号")]
        public string ORDER_NO { get; set; }
    
        /// <summary>
        /// 订单明细号
        /// </summary>
        
        [Description("订单明细号")]
        public string ORDERITEMS_NO { get; set; }
    
        /// <summary>
        /// 短信内容
        /// </summary>
        
        [Description("短信内容")]
        public string MESSAGE_CONTENT { get; set; }
    
        /// <summary>
        /// 手机号
        /// </summary>
        
        [Description("手机号")]
        public string MESSAGE_TEL { get; set; }
    
        /// <summary>
        /// 是否发送成功
        /// </summary>
        
        [Description("是否发送成功")]
        public string MESSAGE_ISTRUE { get; set; }
    
        /// <summary>
        /// 发送时间
        /// </summary>
        
        [Description("发送时间")]
        public DateTime MESSAGE_DATE { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string MESSAGE_MEMO { get; set; }
    
        /// <summary>
        /// 逻辑删除
        /// </summary>
        
        [Description("逻辑删除")]
        public string MESSAGE_ISDEL { get; set; }
    }
}
