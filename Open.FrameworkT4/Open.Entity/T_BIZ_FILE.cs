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
    /// T_BIZ_FILE 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_FILE")]
    public class T_BIZ_FILE
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal FILE_ID { get; set; }
    
        /// <summary>
        /// 原文件名
        /// </summary>
        
        [Description("原文件名")]
        public string FILE_NAME { get; set; }
    
        /// <summary>
        /// 文件名
        /// </summary>
        
        [Description("文件名")]
        public string FILE_FILENAME { get; set; }
    
        /// <summary>
        /// 文件地址
        /// </summary>
        
        [Description("文件地址")]
        public string FILE_PATH { get; set; }
    
        /// <summary>
        /// 文件大小
        /// </summary>
        
        [Description("文件大小")]
        public decimal FILE_SIZE { get; set; }
    
        /// <summary>
        /// IP地址
        /// </summary>
        
        [Description("IP地址")]
        public string FILE_IP { get; set; }
    
        /// <summary>
        /// 上传人所在机构ID
        /// </summary>
        
        [Description("上传人所在机构ID")]
        public decimal FILE_CREORGID { get; set; }
    
        /// <summary>
        /// 上传人所在机构名称
        /// </summary>
        
        [Description("上传人所在机构名称")]
        public string FILE_CREORGNAME { get; set; }
    
        /// <summary>
        /// 上传人姓名
        /// </summary>
        
        [Description("上传人姓名")]
        public string FILE_CRENAME { get; set; }
    
        /// <summary>
        /// 上传人ID
        /// </summary>
        
        [Description("上传人ID")]
        public decimal FILE_CREID { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime FILE_CREDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string FILE_ISDEL { get; set; }
    }
}
