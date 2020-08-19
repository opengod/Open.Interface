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
    /// T_VISIT_PAGE 
    /// </summary>    
   [Serializable]
   [SugarTable("T_VISIT_PAGE")]
    public class T_VISIT_PAGE
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal PAGE_ID { get; set; }
    
        /// <summary>
        /// 查询时间
        /// </summary>
        
        [Description("查询时间")]
        public DateTime PAGE_REFDATE { get; set; }
    
        /// <summary>
        /// 	页面路径
        /// </summary>
        
        [Description("	页面路径")]
        public string PAGE_PATH { get; set; }
    
        /// <summary>
        /// 访问次数
        /// </summary>
        
        [Description("访问次数")]
        public string PAGE_VISITPV { get; set; }
    
        /// <summary>
        /// 访问人数
        /// </summary>
        
        [Description("访问人数")]
        public string PAGE_VISITUV { get; set; }
    
        /// <summary>
        /// 次均停留时长
        /// </summary>
        
        [Description("次均停留时长")]
        public string PAGE_STAYTIMEPV { get; set; }
    
        /// <summary>
        /// 进入页次数
        /// </summary>
        
        [Description("进入页次数")]
        public string PAGE_ENTRYPAGEPV { get; set; }
    
        /// <summary>
        /// 退出页次数
        /// </summary>
        
        [Description("退出页次数")]
        public string PAGE_EXITPAGEPV { get; set; }
    
        /// <summary>
        /// 转发次数
        /// </summary>
        
        [Description("转发次数")]
        public string PAGE_SHAREPV { get; set; }
    
        /// <summary>
        /// 转发次数
        /// </summary>
        
        [Description("转发次数")]
        public string PAGE_SHAREUV { get; set; }
    
        /// <summary>
        /// 模块名称
        /// </summary>
        
        [Description("模块名称")]
        public string PAGE_NAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime PAGE_CREATEDATE { get; set; }
    }
}
