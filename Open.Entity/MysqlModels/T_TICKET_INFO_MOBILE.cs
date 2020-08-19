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
    /// T_TICKET_INFO_MOBILE 
    /// </summary>    
   [Serializable]
   [SugarTable("T_TICKET_INFO_MOBILE")]
    public class T_TICKET_INFO_MOBILE
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal TICINFOM_ID { get; set; }
    
        /// <summary>
        /// 门票ID
        /// </summary>
        
        [Description("门票ID")]
        public decimal TICINFOM_TICKETID { get; set; }
    
        /// <summary>
        /// 门票名称
        /// </summary>
        
        [Description("门票名称")]
        public string TICINFOM_TICKETNAME { get; set; }
    
        /// <summary>
        /// 门票介绍
        /// </summary>
        
        [Description("门票介绍")]
        public string TICINFOM_PRODUCTION { get; set; }
    
        /// <summary>
        /// 门票详情
        /// </summary>
        
        [Description("门票详情")]
        public string TICINFOM_INFO { get; set; }
    
        /// <summary>
        /// 门票备注
        /// </summary>
        
        [Description("门票备注")]
        public string TICINFOM_MEMO { get; set; }
    
        /// <summary>
        /// 排序
        /// </summary>
        
        [Description("排序")]
        public decimal TICINFOM_SORT { get; set; }
    
        /// <summary>
        /// 创建人所在机构
        /// </summary>
        
        [Description("创建人所在机构")]
        public decimal TICINFOM_CREORGID { get; set; }
    
        /// <summary>
        /// 创建人所在机构名称
        /// </summary>
        
        [Description("创建人所在机构名称")]
        public string TICINFOM_CREORGNAME { get; set; }
    
        /// <summary>
        /// 创建人姓名
        /// </summary>
        
        [Description("创建人姓名")]
        public string TICINFOM_CRENAME { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal TICINFOM_CREID { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime TICINFOM_CREDATE { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal TICINFOM_UPID { get; set; }
    
        /// <summary>
        /// 修改人姓名
        /// </summary>
        
        [Description("修改人姓名")]
        public string TICINFOM_UPNAME { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime TICINFOM_UPDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string TICINFOM_ISDEL { get; set; }
    }
}
