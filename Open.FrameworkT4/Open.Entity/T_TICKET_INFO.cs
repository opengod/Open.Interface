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
    /// T_TICKET_INFO 
    /// </summary>    
   [Serializable]
   [SugarTable("T_TICKET_INFO")]
    public class T_TICKET_INFO
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal TICINFO_ID { get; set; }
    
        /// <summary>
        /// 门票ID
        /// </summary>
        
        [Description("门票ID")]
        public decimal TICINFO_TICKETID { get; set; }
    
        /// <summary>
        /// 门票名称
        /// </summary>
        
        [Description("门票名称")]
        public string TICINFO_TICKETNAME { get; set; }
    
        /// <summary>
        /// 门票简介
        /// </summary>
        
        [Description("门票简介")]
        public string TICINFO_BRIEF { get; set; }
    
        /// <summary>
        /// 门票介绍
        /// </summary>
        
        [Description("门票介绍")]
        public string TICINFO_PRODUCTION { get; set; }
    
        /// <summary>
        /// 购票须知
        /// </summary>
        
        [Description("购票须知")]
        public string TICINFO_INFO { get; set; }
    
        /// <summary>
        /// 取票信息
        /// </summary>
        
        [Description("取票信息")]
        public string TICINFO_GETADDR { get; set; }
    
        /// <summary>
        /// 门票备注
        /// </summary>
        
        [Description("门票备注")]
        public string TICINFO_MEMO { get; set; }
    
        /// <summary>
        /// 排序
        /// </summary>
        
        [Description("排序")]
        public decimal TICINFO_SORT { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal TICINFO_CREID { get; set; }
    
        /// <summary>
        /// 创建人姓名
        /// </summary>
        
        [Description("创建人姓名")]
        public string TICINFO_CRENAME { get; set; }
    
        /// <summary>
        /// 创建人所在机构ID
        /// </summary>
        
        [Description("创建人所在机构ID")]
        public decimal TICINFO_CREORGID { get; set; }
    
        /// <summary>
        /// 创建人所在机构名称
        /// </summary>
        
        [Description("创建人所在机构名称")]
        public string TICINFO_CREORGNAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime TICINFO_CREDATE { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal TICINFO_UPID { get; set; }
    
        /// <summary>
        /// 修改人名称
        /// </summary>
        
        [Description("修改人名称")]
        public string TICINFO_UPNAME { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime TICINFO_UPDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string TICINFO_ISDEL { get; set; }
    }
}
