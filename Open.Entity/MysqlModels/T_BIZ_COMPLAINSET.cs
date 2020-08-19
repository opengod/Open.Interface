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
    /// T_BIZ_COMPLAINSET 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_COMPLAINSET")]
    public class T_BIZ_COMPLAINSET
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal SET_ID { get; set; }
    
        /// <summary>
        /// 轻微投诉扣除商家信用分数
        /// </summary>
        
        [Description("轻微投诉扣除商家信用分数")]
        public decimal SET_SMALL { get; set; }
    
        /// <summary>
        /// 中等投诉扣除商家信用分数
        /// </summary>
        
        [Description("中等投诉扣除商家信用分数")]
        public decimal SET_MIDDLE { get; set; }
    
        /// <summary>
        /// 严重投诉扣除商家信用分数
        /// </summary>
        
        [Description("严重投诉扣除商家信用分数")]
        public decimal SET_SERIOUS { get; set; }
    
        /// <summary>
        /// 虚假投诉扣除用户信用分数
        /// </summary>
        
        [Description("虚假投诉扣除用户信用分数")]
        public decimal SET_FALSE { get; set; }
    }
}
