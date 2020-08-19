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
    /// T_SYS_SMSNOTES 
    /// </summary>    
   [Serializable]
   [SugarTable("T_SYS_SMSNOTES")]
    public class T_SYS_SMSNOTES
    {
    
        /// <summary>
        /// 短信发送记录ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("短信发送记录ID")]
        public decimal SMSNOTES_ID { get; set; }
    
        /// <summary>
        /// 短信发送记录返回状态
        /// </summary>
        
        [Description("短信发送记录返回状态")]
        public string SMSNOTES_STATUS { get; set; }
    
        /// <summary>
        /// 短信发送记录备注
        /// </summary>
        
        [Description("短信发送记录备注")]
        public string SMSNOTES_REMARK { get; set; }
    
        /// <summary>
        /// 短信发送记录操作人姓名
        /// </summary>
        
        [Description("短信发送记录操作人姓名")]
        public string SMSNOTES_OPNAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime SMSNOTES_CDATE { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal SMSNOTES_SMSID { get; set; }
    }
}
