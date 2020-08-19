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
    /// T_SYS_SUBDIVISIONS 
    /// </summary>    
   [Serializable]
   [SugarTable("T_SYS_SUBDIVISIONS")]
    public class T_SYS_SUBDIVISIONS
    {
    
        /// <summary>
        /// a
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("a")]
        public decimal ID { get; set; }
    
        /// <summary>
        /// 国家ID:T_SYS_CodeCountry.ID--中国1
        /// </summary>
        
        [Description("国家ID:T_SYS_CodeCountry.ID--中国1")]
        public decimal CID { get; set; }
    
        /// <summary>
        /// 行政区划的种类 T_SYS_CodeAdstKind.ID
        /// </summary>
        
        [Description("行政区划的种类 T_SYS_CodeAdstKind.ID")]
        public decimal KIND { get; set; }
    
        /// <summary>
        /// 本表ID:T_SYS_Regionalism.ID
        /// </summary>
        
        [Description("本表ID:T_SYS_Regionalism.ID")]
        public decimal PID { get; set; }
    
        /// <summary>
        /// 身份证识别码
        /// </summary>
        
        [Description("身份证识别码")]
        public string FIX { get; set; }
    
        /// <summary>
        /// 电话区号
        /// </summary>
        
        [Description("电话区号")]
        public string TELFIX { get; set; }
    
        /// <summary>
        /// 邮政编码
        /// </summary>
        
        [Description("邮政编码")]
        public string POSTCODE { get; set; }
    
        /// <summary>
        /// 名称
        /// </summary>
        
        [Description("名称")]
        public string NAME { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal SORT { get; set; }
    
        /// <summary>
        /// 树型排序
        /// </summary>
        
        [Description("树型排序")]
        public decimal TSORT { get; set; }
    
        /// <summary>
        /// 树型级别
        /// </summary>
        
        [Description("树型级别")]
        public string OLEVEL { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string SOLID { get; set; }
    
        /// <summary>
        /// 逻辑删除
        /// </summary>
        
        [Description("逻辑删除")]
        public string DEL { get; set; }
    
        /// <summary>
        /// 查询帮助
        /// </summary>
        
        [Description("查询帮助")]
        public string QHELP { get; set; }
    
        /// <summary>
        /// 所有下级ID字符串
        /// </summary>
        
        [Description("所有下级ID字符串")]
        public string SUBIDSTRING { get; set; }
    }
}
