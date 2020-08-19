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
    /// T_TICKET_SETMEALHOTEL 
    /// </summary>    
   [Serializable]
   [SugarTable("T_TICKET_SETMEALHOTEL")]
    public class T_TICKET_SETMEALHOTEL
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal SETMEALHOTEL_ID { get; set; }
    
        /// <summary>
        /// 套餐ID
        /// </summary>
        
        [Description("套餐ID")]
        public decimal SETMEALHOTEL_SETMEALID { get; set; }
    
        /// <summary>
        /// 套餐编码
        /// </summary>
        
        [Description("套餐编码")]
        public string SETMEALHOTEL_SETMEALCODE { get; set; }
    
        /// <summary>
        /// 酒店ID
        /// </summary>
        
        [Description("酒店ID")]
        public decimal SETMEALHOTEL_HOTELID { get; set; }
    
        /// <summary>
        /// 酒店名称
        /// </summary>
        
        [Description("酒店名称")]
        public string SETMEALHOTEL_HOTELNAME { get; set; }
    
        /// <summary>
        /// 房型ID
        /// </summary>
        
        [Description("房型ID")]
        public decimal SETMEALHOTEL_ROOMID { get; set; }
    
        /// <summary>
        /// 房型名称
        /// </summary>
        
        [Description("房型名称")]
        public string SETMEALHOTEL_ROOMNAME { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string SETMEALHOTEL_MEMO { get; set; }
    
        /// <summary>
        /// 排序
        /// </summary>
        
        [Description("排序")]
        public decimal SETMEALHOTEL_SORT { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal SETMEALHOTEL_CREID { get; set; }
    
        /// <summary>
        /// 创建人姓名
        /// </summary>
        
        [Description("创建人姓名")]
        public string SETMEALHOTEL_CRENAME { get; set; }
    
        /// <summary>
        /// 创建人所在机构ID
        /// </summary>
        
        [Description("创建人所在机构ID")]
        public decimal SETMEALHOTEL_CREORGID { get; set; }
    
        /// <summary>
        /// 创建人所在机构名称
        /// </summary>
        
        [Description("创建人所在机构名称")]
        public string SETMEALHOTEL_CREORGNAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime SETMEALHOTEL_CREDATE { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal SETMEALHOTEL_UPID { get; set; }
    
        /// <summary>
        /// 修改人名称
        /// </summary>
        
        [Description("修改人名称")]
        public string SETMEALHOTEL_UPNAME { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime SETMEALHOTEL_UPDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string SETMEALHOTEL_ISDEL { get; set; }
    
        /// <summary>
        /// 套餐结算价
        /// </summary>
        
        [Description("套餐结算价")]
        public decimal SETMEALHOTEL_TOTALPRICE { get; set; }
    
        /// <summary>
        /// 酒店结算价
        /// </summary>
        
        [Description("酒店结算价")]
        public decimal SETMEALHOTEL_PRICE { get; set; }
    
        /// <summary>
        /// 所占比例(根据此比例分别计算酒店结算价)
        /// </summary>
        
        [Description("所占比例(根据此比例分别计算酒店结算价)")]
        public decimal SETMEALHOTEL_PERCENT { get; set; }
    }
}
