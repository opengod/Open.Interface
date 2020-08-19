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
    /// T_SYS_LOG 
    /// </summary>    
   [Serializable]
   [SugarTable("T_SYS_LOG")]
    public class T_SYS_LOG
    {
    
        /// <summary>
        /// 编号
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("编号")]
        public long Id { get; set; }
    
        /// <summary>
        /// 接口名称
        /// </summary>
        
        [Description("接口名称")]
        public string ApiLabel { get; set; }
    
        /// <summary>
        /// 接口地址
        /// </summary>
        
        [Description("接口地址")]
        public string ApiPath { get; set; }
    
        /// <summary>
        /// 接口提交方法
        /// </summary>
        
        [Description("接口提交方法")]
        public string ApiMethod { get; set; }
    
        /// <summary>
        /// 昵称
        /// </summary>
        
        [Description("昵称")]
        public string NickName { get; set; }
    
        /// <summary>
        /// IP
        /// </summary>
        
        [Description("IP")]
        public string IP { get; set; }
    
        /// <summary>
        /// 浏览器
        /// </summary>
        
        [Description("浏览器")]
        public string Browser { get; set; }
    
        /// <summary>
        /// 操作系统
        /// </summary>
        
        [Description("操作系统")]
        public string Os { get; set; }
    
        /// <summary>
        /// 设备
        /// </summary>
        
        [Description("设备")]
        public string Device { get; set; }
    
        /// <summary>
        /// 浏览器信息
        /// </summary>
        
        [Description("浏览器信息")]
        public string BrowserInfo { get; set; }
    
        /// <summary>
        /// 耗时（毫秒）
        /// </summary>
        
        [Description("耗时（毫秒）")]
        public long ElapsedMilliseconds { get; set; }
    
        /// <summary>
        /// 操作状态
        /// </summary>
        
        [Description("操作状态")]
        public bool Status { get; set; }
    
        /// <summary>
        /// 操作消息
        /// </summary>
        
        [Description("操作消息")]
        public string Msg { get; set; }
    
        /// <summary>
        /// 操作结果
        /// </summary>
        
        [Description("操作结果")]
        public string Result { get; set; }
    
        /// <summary>
        /// 操作参数
        /// </summary>
        
        [Description("操作参数")]
        public string Params { get; set; }
    
        /// <summary>
        /// 创建者Id
        /// </summary>
        
        [Description("创建者Id")]
        public long CreatedUserId { get; set; }
    
        /// <summary>
        /// 创建者
        /// </summary>
        
        [Description("创建者")]
        public string CreatedUserName { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime CreatedTime { get; set; }
    }
}
