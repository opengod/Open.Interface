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
    /// T_SYS_MAXID 
    /// </summary>    
   [Serializable]
   [SugarTable("T_SYS_MAXID")]
    public class T_SYS_MAXID
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal ID { get; set; }
    
        /// <summary>
        /// 实例名
        /// </summary>
        
        [Description("实例名")]
        public string DBUSER { get; set; }
    
        /// <summary>
        /// 数据表名
        /// </summary>
        
        [Description("数据表名")]
        public string TNAME { get; set; }
    
        /// <summary>
        /// 最大值ID
        /// </summary>
        
        [Description("最大值ID")]
        public decimal MAXID { get; set; }
    }
}
