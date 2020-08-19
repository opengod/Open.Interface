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
    /// T_SWIFT_LOG 
    /// </summary>    
   [Serializable]
   [SugarTable("T_SWIFT_LOG")]
    public class T_SWIFT_LOG
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal LOG_ID { get; set; }
    
        /// <summary>
        /// SYS：系统日志，OPT：操作日志，EXP：异常日志，ERR：错误日志。
        /// </summary>
        
        [Description("SYS：系统日志，OPT：操作日志，EXP：异常日志，ERR：错误日志。")]
        public string LOG_TYPE { get; set; }
    
        /// <summary>
        /// 动作
        /// </summary>
        
        [Description("动作")]
        public string LOG_ACTION { get; set; }
    
        /// <summary>
        /// 动作描述
        /// </summary>
        
        [Description("动作描述")]
        public string LOG_ACTIONMEMO { get; set; }
    
        /// <summary>
        /// 操作人
        /// </summary>
        
        [Description("操作人")]
        public string LOG_OPERATER { get; set; }
    
        /// <summary>
        /// 操作时间
        /// </summary>
        
        [Description("操作时间")]
        public DateTime LOG_OPERATEDATE { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string LOG_MEMO { get; set; }
    
        /// <summary>
        /// 日志地址
        /// </summary>
        
        [Description("日志地址")]
        public string LOG_FILE { get; set; }
    
        /// <summary>
        /// 系统时间
        /// </summary>
        
        [Description("系统时间")]
        public DateTime LOG_SYSDATE { get; set; }
    
        /// <summary>
        /// 操作IP地址
        /// </summary>
        
        [Description("操作IP地址")]
        public string LOG_IP { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string LOG_ISDEL { get; set; }
    }
}
