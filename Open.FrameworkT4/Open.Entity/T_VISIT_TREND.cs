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
    /// T_VISIT_TREND 
    /// </summary>    
   [Serializable]
   [SugarTable("T_VISIT_TREND")]
    public class T_VISIT_TREND
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal TREND_ID { get; set; }
    
        /// <summary>
        /// 时间
        /// </summary>
        
        [Description("时间")]
        public DateTime TREND_REFDATE { get; set; }
    
        /// <summary>
        /// 打开次数
        /// </summary>
        
        [Description("打开次数")]
        public string TREND_SESSIONCNT { get; set; }
    
        /// <summary>
        /// 访问次数
        /// </summary>
        
        [Description("访问次数")]
        public string TREND_VISITPV { get; set; }
    
        /// <summary>
        /// 访问人数
        /// </summary>
        
        [Description("访问人数")]
        public string TREND_VISITUV { get; set; }
    
        /// <summary>
        /// 新用户数
        /// </summary>
        
        [Description("新用户数")]
        public string TREND_VISITUVNEW { get; set; }
    
        /// <summary>
        /// 人均停留时长
        /// </summary>
        
        [Description("人均停留时长")]
        public string TREND_STAYTIMEUV { get; set; }
    
        /// <summary>
        /// 次均停留时长
        /// </summary>
        
        [Description("次均停留时长")]
        public string TREND_STAYTIMESESSION { get; set; }
    
        /// <summary>
        /// 平均访问深度 
        /// </summary>
        
        [Description("平均访问深度 ")]
        public string TREND_VISITDEPTH { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime TREND_CREATEDATE { get; set; }
    }
}
