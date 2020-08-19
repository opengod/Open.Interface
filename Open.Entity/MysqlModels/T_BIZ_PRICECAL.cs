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
    /// T_BIZ_PRICECAL 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_PRICECAL")]
    public class T_BIZ_PRICECAL
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal PRICECAL_ID { get; set; }
    
        /// <summary>
        /// 产品ID
        /// </summary>
        
        [Description("产品ID")]
        public decimal PRICECAL_PRODUCTID { get; set; }
    
        /// <summary>
        /// 产品编码
        /// </summary>
        
        [Description("产品编码")]
        public string PRICECAL_PRODUCTCODE { get; set; }
    
        /// <summary>
        /// 产品名称
        /// </summary>
        
        [Description("产品名称")]
        public string PRICECAL_PRODUCTNAME { get; set; }
    
        /// <summary>
        /// 产品类型（P景区，PT门票，PP套餐，H酒店，HR房间，HB会议室，L线路，C评论，T投诉，R餐饮，RP餐饮套餐，E休闲娱乐，EP娱乐套餐，B商店，BP商店商品）
        /// </summary>
        
        [Description("产品类型（P景区，PT门票，PP套餐，H酒店，HR房间，HB会议室，L线路，C评论，T投诉，R餐饮，RP餐饮套餐，E休闲娱乐，EP娱乐套餐，B商店，BP商店商品）")]
        public string PRICECAL_PRODUCTTYPE { get; set; }
    
        /// <summary>
        /// 售卖价格
        /// </summary>
        
        [Description("售卖价格")]
        public decimal PRICECAL_PRODUCTPRICE { get; set; }
    
        /// <summary>
        /// 结算价格
        /// </summary>
        
        [Description("结算价格")]
        public decimal PRICECAL_SETTLEPRICE { get; set; }
    
        /// <summary>
        /// 日期
        /// </summary>
        
        [Description("日期")]
        public DateTime PRICECAL_DATE { get; set; }
    
        /// <summary>
        /// 星期
        /// </summary>
        
        [Description("星期")]
        public string PRICECAL_WEEKDAY { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string PRICECAL_MEMO { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal PRICECAL_CREID { get; set; }
    
        /// <summary>
        /// 创建人姓名
        /// </summary>
        
        [Description("创建人姓名")]
        public string PRICECAL_CRENAME { get; set; }
    
        /// <summary>
        /// 创建人所在机构ID
        /// </summary>
        
        [Description("创建人所在机构ID")]
        public decimal PRICECAL_CREORGID { get; set; }
    
        /// <summary>
        /// 创建人所在机构名称
        /// </summary>
        
        [Description("创建人所在机构名称")]
        public string PRICECAL_CREORGNAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime PRICECAL_CREDATE { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal PRICECAL_UPID { get; set; }
    
        /// <summary>
        /// 修改人名称
        /// </summary>
        
        [Description("修改人名称")]
        public string PRICECAL_UPNAME { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime PRICECAL_UPDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string PRICECAL_ISDEL { get; set; }
    }
}
