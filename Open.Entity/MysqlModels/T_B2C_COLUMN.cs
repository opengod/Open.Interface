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
    /// T_B2C_COLUMN 
    /// </summary>    
   [Serializable]
   [SugarTable("T_B2C_COLUMN")]
    public class T_B2C_COLUMN
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal COLUMN_ID { get; set; }
    
        /// <summary>
        /// 栏目名称
        /// </summary>
        
        [Description("栏目名称")]
        public string COLUMN_NAME { get; set; }
    
        /// <summary>
        /// 栏目图标
        /// </summary>
        
        [Description("栏目图标")]
        public string COLUMN_PICTURE { get; set; }
    
        /// <summary>
        /// 栏目父级ID
        /// </summary>
        
        [Description("栏目父级ID")]
        public decimal COLUMN_PID { get; set; }
    
        /// <summary>
        /// 栏目级别(1、2、3、4)
        /// </summary>
        
        [Description("栏目级别(1、2、3、4)")]
        public decimal COLUMN_LEVEL { get; set; }
    
        /// <summary>
        /// 栏目链接
        /// </summary>
        
        [Description("栏目链接")]
        public string COLUMN_LINK { get; set; }
    
        /// <summary>
        /// 排序
        /// </summary>
        
        [Description("排序")]
        public decimal COLUMN_SORT { get; set; }
    
        /// <summary>
        /// 是否启用
        /// </summary>
        
        [Description("是否启用")]
        public string COLUMN_ISUSED { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string COLUMN_MEMO { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal COLUMN_CREID { get; set; }
    
        /// <summary>
        /// 创建人姓名
        /// </summary>
        
        [Description("创建人姓名")]
        public string COLUMN_CRENAME { get; set; }
    
        /// <summary>
        /// 创建人所在机构ID
        /// </summary>
        
        [Description("创建人所在机构ID")]
        public decimal COLUMN_CREORGID { get; set; }
    
        /// <summary>
        /// 创建人所在机构名称
        /// </summary>
        
        [Description("创建人所在机构名称")]
        public string COLUMN_CREORGNAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime COLUMN_CREDATE { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal COLUMN_UPID { get; set; }
    
        /// <summary>
        /// 修改人名称
        /// </summary>
        
        [Description("修改人名称")]
        public string COLUMN_UPNAME { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime COLUMN_UPDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string COLUMN_ISDEL { get; set; }
    }
}
