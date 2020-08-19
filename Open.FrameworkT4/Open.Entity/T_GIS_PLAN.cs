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
    /// T_GIS_PLAN 
    /// </summary>    
   [Serializable]
   [SugarTable("T_GIS_PLAN")]
    public class T_GIS_PLAN
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal PLANGIS_ID { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        
        [Description("")]
        public string PLANGIS_NAME { get; set; }
    
        /// <summary>
        /// 景区ID
        /// </summary>
        
        [Description("景区ID")]
        public decimal PLANGIS_SPOTID { get; set; }
    
        /// <summary>
        /// 起点经度
        /// </summary>
        
        [Description("起点经度")]
        public decimal PLANGIS_LONGITUDE { get; set; }
    
        /// <summary>
        /// 起点纬度
        /// </summary>
        
        [Description("起点纬度")]
        public decimal PLANGIS_LATITUDE { get; set; }
    
        /// <summary>
        /// 排序
        /// </summary>
        
        [Description("排序")]
        public decimal PLANGIS_SORT { get; set; }
    
        /// <summary>
        /// 用户openid
        /// </summary>
        
        [Description("用户openid")]
        public string PLANGIS_OPENID { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime PLANGIS_CREATEDATE { get; set; }
    
        /// <summary>
        /// 规划编号
        /// </summary>
        
        [Description("规划编号")]
        public string PLANGIS_LINENUM { get; set; }
    
        /// <summary>
        /// 游玩天数
        /// </summary>
        
        [Description("游玩天数")]
        public string PLANGIS_TYPE { get; set; }
    
        /// <summary>
        /// 是否回到起点
        /// </summary>
        
        [Description("是否回到起点")]
        public string PLANGIS_ISBACK { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        
        [Description("")]
        public string PLANGIS_ISDEL { get; set; }
    }
}
