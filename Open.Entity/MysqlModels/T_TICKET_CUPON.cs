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
    /// T_TICKET_CUPON 
    /// </summary>    
   [Serializable]
   [SugarTable("T_TICKET_CUPON")]
    public class T_TICKET_CUPON
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal CUPON_ID { get; set; }
    
        /// <summary>
        /// 联票产品ID
        /// </summary>
        
        [Description("联票产品ID")]
        public decimal CUPON_TICKETID { get; set; }
    
        /// <summary>
        /// 联票产品名称
        /// </summary>
        
        [Description("联票产品名称")]
        public string CUPON_TICKETNAME { get; set; }
    
        /// <summary>
        /// 子产品ID
        /// </summary>
        
        [Description("子产品ID")]
        public decimal CUPON_PDTID { get; set; }
    
        /// <summary>
        /// 子产品名称
        /// </summary>
        
        [Description("子产品名称")]
        public string CUPON_PDTNAME { get; set; }
    
        /// <summary>
        /// 景点ID
        /// </summary>
        
        [Description("景点ID")]
        public decimal CUPON_PARKID { get; set; }
    
        /// <summary>
        /// 景点名称
        /// </summary>
        
        [Description("景点名称")]
        public string CUPON_PARKNAME { get; set; }
    
        /// <summary>
        /// 可使用人数
        /// </summary>
        
        [Description("可使用人数")]
        public decimal CUPON_PERSONS { get; set; }
    
        /// <summary>
        /// 门票数量
        /// </summary>
        
        [Description("门票数量")]
        public decimal CUPON_NUMBER { get; set; }
    
        /// <summary>
        /// 联票结算价
        /// </summary>
        
        [Description("联票结算价")]
        public decimal CUPON_TOTALSETTLEPRICE { get; set; }
    
        /// <summary>
        /// 景区结算价
        /// </summary>
        
        [Description("景区结算价")]
        public decimal CUPON_SETTLEPRICE { get; set; }
    
        /// <summary>
        /// 所占比例(根据此比例分别计算景区结算价)
        /// </summary>
        
        [Description("所占比例(根据此比例分别计算景区结算价)")]
        public decimal CUPON_PERCENT { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal CUPON_CREID { get; set; }
    
        /// <summary>
        /// 创建人姓名
        /// </summary>
        
        [Description("创建人姓名")]
        public string CUPON_CRENAME { get; set; }
    
        /// <summary>
        /// 创建人所在机构ID
        /// </summary>
        
        [Description("创建人所在机构ID")]
        public decimal CUPON_CREORGID { get; set; }
    
        /// <summary>
        /// 创建人所在机构名称
        /// </summary>
        
        [Description("创建人所在机构名称")]
        public string CUPON_CREORGNAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime CUPON_CREDATE { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal CUPON_UPID { get; set; }
    
        /// <summary>
        /// 修改人名称
        /// </summary>
        
        [Description("修改人名称")]
        public string CUPON_UPNAME { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime CUPON_UPDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string CUPON_ISDEL { get; set; }
    }
}
