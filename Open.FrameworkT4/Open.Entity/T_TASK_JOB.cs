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
    /// T_TASK_JOB 
    /// </summary>    
   [Serializable]
   [SugarTable("T_TASK_JOB")]
    public class T_TASK_JOB
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public string ID { get; set; }
    
        /// <summary>
        /// 服务名称
        /// </summary>
        
        [Description("服务名称")]
        public string Job_ServiceName { get; set; }
    
        /// <summary>
        /// 任务名称
        /// </summary>
        
        [Description("任务名称")]
        public string Job_Name { get; set; }
    
        /// <summary>
        /// 任务组名称
        /// </summary>
        
        [Description("任务组名称")]
        public string Job_Group { get; set; }
    
        /// <summary>
        /// 触发器名称
        /// </summary>
        
        [Description("触发器名称")]
        public string Trigger_Name { get; set; }
    
        /// <summary>
        /// 触发器组名称
        /// </summary>
        
        [Description("触发器组名称")]
        public string Trigger_Group { get; set; }
    
        /// <summary>
        /// 任务DLL路径
        /// </summary>
        
        [Description("任务DLL路径")]
        public string Job_DllPath { get; set; }
    
        /// <summary>
        /// 任务类名称
        /// </summary>
        
        [Description("任务类名称")]
        public string Job_ClassName { get; set; }
    
        /// <summary>
        /// 执行时间
        /// </summary>
        
        [Description("执行时间")]
        public string SetUpTime { get; set; }
    
        /// <summary>
        /// 执行次数
        /// </summary>
        
        [Description("执行次数")]
        public int FunctionCount { get; set; }
    
        /// <summary>
        /// 上次执行时间
        /// </summary>
        
        [Description("上次执行时间")]
        public string LastTime { get; set; }
    
        /// <summary>
        /// 处理时间
        /// </summary>
        
        [Description("处理时间")]
        public int ProcessTime { get; set; }
    
        /// <summary>
        /// 下次运行时间
        /// </summary>
        
        [Description("下次运行时间")]
        public string NextTime { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime CreateTime { get; set; }
    
        /// <summary>
        /// 任务状态
        /// </summary>
        
        [Description("任务状态")]
        public int Job_State { get; set; }
    }
}
