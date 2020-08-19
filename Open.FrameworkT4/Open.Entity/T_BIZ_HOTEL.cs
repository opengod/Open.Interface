//-----------------------------------------------------------------------
// <Copyright>
// * copyright © 2020 open All Rights Reserved
// * version : 4.0.30319.42000
// * author  : open
// * history : Created by open 2020-08-19 11:17:17 
// </Copyright>
//-----------------------------------------------------------------------
using System;
using SqlSugar;
using System.ComponentModel;

namespace Open.Entity.Oracle
{
    /// <summary>
    /// T_BIZ_HOTEL 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_HOTEL")]
    public class T_BIZ_HOTEL
    {
    
        /// <summary>
        /// 酒店产品ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("酒店产品ID")]
        public decimal HOTEL_ID { get; set; }
    
        /// <summary>
        /// 酒店产品名称
        /// </summary>
        
        [Description("酒店产品名称")]
        public string HOTEL_NAME { get; set; }
    
        /// <summary>
        /// 酒店产品房型ID
        /// </summary>
        
        [Description("酒店产品房型ID")]
        public decimal HOTEL_ROOM_TYPEID { get; set; }
    
        /// <summary>
        /// 酒店产品床型ID
        /// </summary>
        
        [Description("酒店产品床型ID")]
        public decimal HOTEL_BED_TYPEID { get; set; }
    
        /// <summary>
        /// 酒店产品基础价格
        /// </summary>
        
        [Description("酒店产品基础价格")]
        public decimal HOTEL_BASICSPRICE { get; set; }
    
        /// <summary>
        /// 酒店产品实际价格
        /// </summary>
        
        [Description("酒店产品实际价格")]
        public decimal HOTEL_PRICE { get; set; }
    
        /// <summary>
        /// 酒店产品上架日期
        /// </summary>
        
        [Description("酒店产品上架日期")]
        public DateTime HOTEL_UDATE { get; set; }
    
        /// <summary>
        /// 酒店产品下架日期
        /// </summary>
        
        [Description("酒店产品下架日期")]
        public DateTime HOTEL_DDATE { get; set; }
    
        /// <summary>
        /// 酒店产品状态:0 正常 1暂停 2作废
        /// </summary>
        
        [Description("酒店产品状态:0 正常 1暂停 2作废")]
        public decimal HOTEL_STATUS { get; set; }
    
        /// <summary>
        /// 周一是否可售 0可售 1不可售
        /// </summary>
        
        [Description("周一是否可售 0可售 1不可售")]
        public decimal HOTEL_ISMONDAY { get; set; }
    
        /// <summary>
        /// 周二是否可售 0可售 1不可售
        /// </summary>
        
        [Description("周二是否可售 0可售 1不可售")]
        public decimal HOTEL_ISTUESDAY { get; set; }
    
        /// <summary>
        /// 周三是否可售 0可售 1不可售
        /// </summary>
        
        [Description("周三是否可售 0可售 1不可售")]
        public decimal HOTEL_ISWEDNESDAY { get; set; }
    
        /// <summary>
        /// 周四是否可售 0可售 1不可售
        /// </summary>
        
        [Description("周四是否可售 0可售 1不可售")]
        public decimal HOTEL_ISTHURSDAY { get; set; }
    
        /// <summary>
        /// 周五是否可售 0可售 1不可售
        /// </summary>
        
        [Description("周五是否可售 0可售 1不可售")]
        public decimal HOTEL_ISFRIDAY { get; set; }
    
        /// <summary>
        /// 周六是否可售 0可售 1不可售
        /// </summary>
        
        [Description("周六是否可售 0可售 1不可售")]
        public decimal HOTEL_ISSATURDAY { get; set; }
    
        /// <summary>
        /// 周日是否可售 0可售 1不可售
        /// </summary>
        
        [Description("周日是否可售 0可售 1不可售")]
        public decimal HOTEL_ISSUNDAY { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal HOTEL_CREATEID { get; set; }
    
        /// <summary>
        /// 创建人名称
        /// </summary>
        
        [Description("创建人名称")]
        public string HOTEL_CREATENAME { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal HOTEL_EDITID { get; set; }
    
        /// <summary>
        /// 修改人名称
        /// </summary>
        
        [Description("修改人名称")]
        public string HOTEL_EDITNAME { get; set; }
    
        /// <summary>
        /// 是否逻辑删除 否F 是T
        /// </summary>
        
        [Description("是否逻辑删除 否F 是T")]
        public string HOTEL_ISDEL { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public DateTime HOTEL_CDATE { get; set; }
    
        /// <summary>
        /// 修改日期
        /// </summary>
        
        [Description("修改日期")]
        public DateTime HOTEL_EDITDATE { get; set; }
    }
}
