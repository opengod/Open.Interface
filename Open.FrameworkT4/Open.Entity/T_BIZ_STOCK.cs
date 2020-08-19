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
    /// T_BIZ_STOCK 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_STOCK")]
    public class T_BIZ_STOCK
    {
    
        /// <summary>
        /// 库存主键ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("库存主键ID")]
        public decimal STOCK_ID { get; set; }
    
        /// <summary>
        /// 产品ID
        /// </summary>
        
        [Description("产品ID")]
        public decimal STOCK_PRODUCTID { get; set; }
    
        /// <summary>
        /// 产品编码
        /// </summary>
        
        [Description("产品编码")]
        public string STOCK_PRODUCTCODE { get; set; }
    
        /// <summary>
        /// 产品名称
        /// </summary>
        
        [Description("产品名称")]
        public string STOCK_PRODUCTNAME { get; set; }
    
        /// <summary>
        /// 产品类型（P景区，PT门票，PP套餐，H酒店，HR房间，HB会议室，L线路，C评论，T投诉，R餐饮，RP餐饮套餐，E休闲娱乐，EP娱乐套餐，B商店，BP商店商品）
        /// </summary>
        
        [Description("产品类型（P景区，PT门票，PP套餐，H酒店，HR房间，HB会议室，L线路，C评论，T投诉，R餐饮，RP餐饮套餐，E休闲娱乐，EP娱乐套餐，B商店，BP商店商品）")]
        public string STOCK_PRODUCTTYPE { get; set; }
    
        /// <summary>
        /// 库存类型(L按时间段设置；D按日设置)
        /// </summary>
        
        [Description("库存类型(L按时间段设置；D按日设置)")]
        public string STOCK_TYPE { get; set; }
    
        /// <summary>
        /// 是否允许超额
        /// </summary>
        
        [Description("是否允许超额")]
        public string STOCK_ISEXCESS { get; set; }
    
        /// <summary>
        /// 总库存
        /// </summary>
        
        [Description("总库存")]
        public decimal STOCK_TOTAL { get; set; }
    
        /// <summary>
        /// 剩余库存
        /// </summary>
        
        [Description("剩余库存")]
        public decimal STOCK_SURPLUS { get; set; }
    
        /// <summary>
        /// 超额数量
        /// </summary>
        
        [Description("超额数量")]
        public decimal STOCK_EXCESS { get; set; }
    
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
        /// 日总库存
        /// </summary>
        
        [Description("日总库存")]
        public decimal STOCK_DAYTOTAL { get; set; }
    
        /// <summary>
        /// 日剩余库存
        /// </summary>
        
        [Description("日剩余库存")]
        public decimal STOCK_DAYSURPLUS { get; set; }
    
        /// <summary>
        /// 日超额数量
        /// </summary>
        
        [Description("日超额数量")]
        public decimal STOCK_DAYEXCESS { get; set; }
    
        /// <summary>
        /// 日期
        /// </summary>
        
        [Description("日期")]
        public DateTime STOCK_DAYDATE { get; set; }
    
        /// <summary>
        /// 星期
        /// </summary>
        
        [Description("星期")]
        public string STOCK_WEEKDAY { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string STOCK_MEMO { get; set; }
    
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
