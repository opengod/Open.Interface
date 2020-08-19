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
    /// T_HOTEL_BOARDINFO 
    /// </summary>    
   [Serializable]
   [SugarTable("T_HOTEL_BOARDINFO")]
    public class T_HOTEL_BOARDINFO
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal INFO_ID { get; set; }
    
        /// <summary>
        /// 会议室ID
        /// </summary>
        
        [Description("会议室ID")]
        public decimal INFO_BOARDID { get; set; }
    
        /// <summary>
        /// 会议室编码
        /// </summary>
        
        [Description("会议室编码")]
        public string INFO_BOARDCODE { get; set; }
    
        /// <summary>
        /// 面积
        /// </summary>
        
        [Description("面积")]
        public string INFO_AREA { get; set; }
    
        /// <summary>
        /// 层高
        /// </summary>
        
        [Description("层高")]
        public string INFO_STOREY { get; set; }
    
        /// <summary>
        /// 立柱（有，无）
        /// </summary>
        
        [Description("立柱（有，无）")]
        public string INFO_COLUMNS { get; set; }
    
        /// <summary>
        /// 楼层
        /// </summary>
        
        [Description("楼层")]
        public string INFO_FLOOR { get; set; }
    
        /// <summary>
        /// 简介
        /// </summary>
        
        [Description("简介")]
        public string INFO_BRIEF { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string INFO_MEMO { get; set; }
    
        /// <summary>
        /// 详情
        /// </summary>
        
        [Description("详情")]
        public string INFO_PRODUCTION { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string INFO_ISDEL { get; set; }
    }
}
