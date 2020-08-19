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
    /// T_DATA_MESSAGETEMP 
    /// </summary>    
   [Serializable]
   [SugarTable("T_DATA_MESSAGETEMP")]
    public class T_DATA_MESSAGETEMP
    {
    
        /// <summary>
        /// ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("ID")]
        public decimal MESSAGETEMP_ID { get; set; }
    
        /// <summary>
        /// 模板名称
        /// </summary>
        
        [Description("模板名称")]
        public string MESSAGETEMP_NAME { get; set; }
    
        /// <summary>
        /// 标题
        /// </summary>
        
        [Description("标题")]
        public string MESSAGETEMP_TITLE { get; set; }
    
        /// <summary>
        /// 模板内容
        /// </summary>
        
        [Description("模板内容")]
        public string MESSAGETEMP_CONTENT { get; set; }
    
        /// <summary>
        /// 模板类型（短信：SMS彩信:MMS）
        /// </summary>
        
        [Description("模板类型（短信：SMS彩信:MMS）")]
        public string MESSAGETEMP_TYPE { get; set; }
    
        /// <summary>
        /// 所在ID
        /// </summary>
        
        [Description("所在ID")]
        public decimal MESSAGETEMP_ORGID { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal MESSAGETEMP_CREATEBY { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime MESSAGETEMP_CREATETIME { get; set; }
    
        /// <summary>
        /// 逻辑删除
        /// </summary>
        
        [Description("逻辑删除")]
        public string MESSAGETEMP_DEL { get; set; }
    
        /// <summary>
        /// 发送类型(未支付：N,已支付：S,改签：G)
        /// </summary>
        
        [Description("发送类型(未支付：N,已支付：S,改签：G)")]
        public string MESSAGETEMP_STYPE { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string MESSAGETEMP_KIND { get; set; }
    }
}
