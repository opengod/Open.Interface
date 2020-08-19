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
    /// T_TRAVEL_STRATEGY 
    /// </summary>    
   [Serializable]
   [SugarTable("T_TRAVEL_STRATEGY")]
    public class T_TRAVEL_STRATEGY
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal STRATEGY_ID { get; set; }
    
        /// <summary>
        /// 攻略编码
        /// </summary>
        
        [Description("攻略编码")]
        public string STRATEGY_CODE { get; set; }
    
        /// <summary>
        /// 攻略名称
        /// </summary>
        
        [Description("攻略名称")]
        public string STRATEGY_NAME { get; set; }
    
        /// <summary>
        /// 主标题
        /// </summary>
        
        [Description("主标题")]
        public string STRATEGY_MAINTITLE { get; set; }
    
        /// <summary>
        /// 副标题
        /// </summary>
        
        [Description("副标题")]
        public string STRATEGY_SUBTITLE { get; set; }
    
        /// <summary>
        /// 类型（L：游玩线路，R：美食线路）
        /// </summary>
        
        [Description("类型（L：游玩线路，R：美食线路）")]
        public string STRATEGY_TYPE { get; set; }
    
        /// <summary>
        /// 前言
        /// </summary>
        
        [Description("前言")]
        public string STRATEGY_PREFACE { get; set; }
    
        /// <summary>
        /// 行程一览
        /// </summary>
        
        [Description("行程一览")]
        public string STRATEGY_GENERAL { get; set; }
    
        /// <summary>
        /// 推荐理由
        /// </summary>
        
        [Description("推荐理由")]
        public string STRATEGY_REASONS { get; set; }
    
        /// <summary>
        /// 交通指南
        /// </summary>
        
        [Description("交通指南")]
        public string STRATEGY_GUIDE { get; set; }
    
        /// <summary>
        /// 游玩天数
        /// </summary>
        
        [Description("游玩天数")]
        public decimal STRATEGY_DAYS { get; set; }
    
        /// <summary>
        /// 精品攻略推荐
        /// </summary>
        
        [Description("精品攻略推荐")]
        public string STRATEGY_RECOMMEND { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string STRATEGY_MEMO { get; set; }
    
        /// <summary>
        /// 排序
        /// </summary>
        
        [Description("排序")]
        public decimal STRATEGY_SORT { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal STRATEGY_CREID { get; set; }
    
        /// <summary>
        /// 创建人姓名
        /// </summary>
        
        [Description("创建人姓名")]
        public string STRATEGY_CRENAME { get; set; }
    
        /// <summary>
        /// 创建人所在机构ID
        /// </summary>
        
        [Description("创建人所在机构ID")]
        public decimal STRATEGY_CREORGID { get; set; }
    
        /// <summary>
        /// 创建人所在机构名称
        /// </summary>
        
        [Description("创建人所在机构名称")]
        public string STRATEGY_CREORGNAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime STRATEGY_CREDATE { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal STRATEGY_UPID { get; set; }
    
        /// <summary>
        /// 修改人姓名
        /// </summary>
        
        [Description("修改人姓名")]
        public string STRATEGY_UPNAME { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime STRATEGY_UPDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string STRATEGY_ISDEL { get; set; }
    }
}
