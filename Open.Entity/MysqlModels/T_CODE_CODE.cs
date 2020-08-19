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
    /// T_CODE_CODE 
    /// </summary>    
   [Serializable]
   [SugarTable("T_CODE_CODE")]
    public class T_CODE_CODE
    {
    
        /// <summary>
        /// 主键ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键ID")]
        public decimal CODE_ID { get; set; }
    
        /// <summary>
        /// 类型名称
        /// </summary>
        
        [Description("类型名称")]
        public string CODE_TYPENAME { get; set; }
    
        /// <summary>
        /// 类型
        /// </summary>
        
        [Description("类型")]
        public string CODE_TYPE { get; set; }
    
        /// <summary>
        /// 值名称
        /// </summary>
        
        [Description("值名称")]
        public string CODE_NAME { get; set; }
    
        /// <summary>
        /// 值
        /// </summary>
        
        [Description("值")]
        public string CODE_VALUE { get; set; }
    
        /// <summary>
        /// 父级ID
        /// </summary>
        
        [Description("父级ID")]
        public decimal CODE_PID { get; set; }
    
        /// <summary>
        /// 排序
        /// </summary>
        
        [Description("排序")]
        public decimal CODE_SORT { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string CODE_ISDEL { get; set; }
    }
}
