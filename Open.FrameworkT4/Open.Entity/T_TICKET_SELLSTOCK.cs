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
    /// T_TICKET_SELLSTOCK 
    /// </summary>    
   [Serializable]
   [SugarTable("T_TICKET_SELLSTOCK")]
    public class T_TICKET_SELLSTOCK
    {
    
        /// <summary>
        /// 门票库存表主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("门票库存表主键")]
        public decimal STOCK_ID { get; set; }
    
        /// <summary>
        /// 景点ID
        /// </summary>
        
        [Description("景点ID")]
        public decimal STOCK_PARKID { get; set; }
    
        /// <summary>
        /// 景点名称
        /// </summary>
        
        [Description("景点名称")]
        public string STOCK_PARKNAME { get; set; }
    
        /// <summary>
        /// 门票ID
        /// </summary>
        
        [Description("门票ID")]
        public decimal STOCK_TICKETID { get; set; }
    
        /// <summary>
        /// 门票名称
        /// </summary>
        
        [Description("门票名称")]
        public string STOCK_TICKETNAME { get; set; }
    
        /// <summary>
        /// 分销商ID
        /// </summary>
        
        [Description("分销商ID")]
        public decimal STOCK_DISTRIBUTEID { get; set; }
    
        /// <summary>
        /// 分销商名称
        /// </summary>
        
        [Description("分销商名称")]
        public string STOCK_DISTRIBUTENAME { get; set; }
    
        /// <summary>
        /// 供应商ID
        /// </summary>
        
        [Description("供应商ID")]
        public decimal STOCK_SUPID { get; set; }
    
        /// <summary>
        /// 供应商编码
        /// </summary>
        
        [Description("供应商编码")]
        public string STOCK_SUPCODE { get; set; }
    
        /// <summary>
        /// 供应商名称
        /// </summary>
        
        [Description("供应商名称")]
        public string STOCK_SUPNAME { get; set; }
    
        /// <summary>
        /// 库存数量
        /// </summary>
        
        [Description("库存数量")]
        public decimal STOCK_COUNT { get; set; }
    
        /// <summary>
        /// 已使用数量
        /// </summary>
        
        [Description("已使用数量")]
        public decimal STOCK_USED { get; set; }
    
        /// <summary>
        /// 有效时间起
        /// </summary>
        
        [Description("有效时间起")]
        public DateTime STOCK_DATES { get; set; }
    
        /// <summary>
        /// 有效时间至
        /// </summary>
        
        [Description("有效时间至")]
        public DateTime STOCK_DATEE { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal STOCK_CREID { get; set; }
    
        /// <summary>
        /// 创建人姓名
        /// </summary>
        
        [Description("创建人姓名")]
        public string STOCK_CRENAME { get; set; }
    
        /// <summary>
        /// 创建人所在机构ID
        /// </summary>
        
        [Description("创建人所在机构ID")]
        public decimal STOCK_CREORGID { get; set; }
    
        /// <summary>
        /// 创建人所在机构名称
        /// </summary>
        
        [Description("创建人所在机构名称")]
        public string STOCK_CREORGNAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime STOCK_CREDATE { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal STOCK_UPID { get; set; }
    
        /// <summary>
        /// 修改人名称
        /// </summary>
        
        [Description("修改人名称")]
        public string STOCK_UPNAME { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime STOCK_UPDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string STOCK_ISDEL { get; set; }
    }
}
