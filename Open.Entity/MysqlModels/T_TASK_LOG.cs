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
    /// T_TASK_LOG 
    /// </summary>    
   [Serializable]
   [SugarTable("T_TASK_LOG")]
    public class T_TASK_LOG
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public string ID { get; set; }
    
        /// <summary>
        /// 任务表主键
        /// </summary>
        
        [Description("任务表主键")]
        public string Taskid { get; set; }
    
        /// <summary>
        /// 日志主题
        /// </summary>
        
        [Description("日志主题")]
        public string Title { get; set; }
    
        /// <summary>
        /// 日志内容
        /// </summary>
        
        [Description("日志内容")]
        public string Logtext { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime Creattime { get; set; }
    }
}
