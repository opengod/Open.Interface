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
    /// T_HOTEL_ROOM 
    /// </summary>    
   [Serializable]
   [SugarTable("T_HOTEL_ROOM")]
    public class T_HOTEL_ROOM
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal ROOM_ID { get; set; }
    
        /// <summary>
        /// 房间名称
        /// </summary>
        
        [Description("房间名称")]
        public string ROOM_NAME { get; set; }
    
        /// <summary>
        /// 酒店ID
        /// </summary>
        
        [Description("酒店ID")]
        public decimal ROOM_HOTELID { get; set; }
    
        /// <summary>
        /// 酒店名称
        /// </summary>
        
        [Description("酒店名称")]
        public string ROOM_HOTELNAME { get; set; }
    
        /// <summary>
        /// 房间类型编号
        /// </summary>
        
        [Description("房间类型编号")]
        public string ROOM_CODE { get; set; }
    
        /// <summary>
        /// 房间类型
        /// </summary>
        
        [Description("房间类型")]
        public string ROOM_TYPE { get; set; }
    
        /// <summary>
        /// 售卖规则ID
        /// </summary>
        
        [Description("售卖规则ID")]
        public decimal ROOM_SELLRULEID { get; set; }
    
        /// <summary>
        /// 退订规则ID
        /// </summary>
        
        [Description("退订规则ID")]
        public decimal ROOM_RTTRULEID { get; set; }
    
        /// <summary>
        /// 售价
        /// </summary>
        
        [Description("售价")]
        public decimal ROOM_SELLPRICE { get; set; }
    
        /// <summary>
        /// 票面价格
        /// </summary>
        
        [Description("票面价格")]
        public decimal ROOM_MARKETPRICE { get; set; }
    
        /// <summary>
        /// 结算价格
        /// </summary>
        
        [Description("结算价格")]
        public decimal ROOM_SETTLEPRICE { get; set; }
    
        /// <summary>
        /// 床型（大床，双床）
        /// </summary>
        
        [Description("床型（大床，双床）")]
        public string ROOM_BEDTYPE { get; set; }
    
        /// <summary>
        /// 可入住人数
        /// </summary>
        
        [Description("可入住人数")]
        public decimal ROOM_PEOPLE { get; set; }
    
        /// <summary>
        /// 是否能加床
        /// </summary>
        
        [Description("是否能加床")]
        public string ROOM_ISADDBED { get; set; }
    
        /// <summary>
        /// 加床价格
        /// </summary>
        
        [Description("加床价格")]
        public decimal ROOM_BEDPRICE { get; set; }
    
        /// <summary>
        /// 是否含餐标
        /// </summary>
        
        [Description("是否含餐标")]
        public string ROOM_ISREPAST { get; set; }
    
        /// <summary>
        /// 餐标类型
        /// </summary>
        
        [Description("餐标类型")]
        public string ROOM_REPASTTYPE { get; set; }
    
        /// <summary>
        /// 排序
        /// </summary>
        
        [Description("排序")]
        public decimal ROOM_SORT { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal ROOM_CREID { get; set; }
    
        /// <summary>
        /// 创建人姓名
        /// </summary>
        
        [Description("创建人姓名")]
        public string ROOM_CRENAME { get; set; }
    
        /// <summary>
        /// 创建人所在机构ID
        /// </summary>
        
        [Description("创建人所在机构ID")]
        public decimal ROOM_CREORGID { get; set; }
    
        /// <summary>
        /// 创建人所在机构名称
        /// </summary>
        
        [Description("创建人所在机构名称")]
        public string ROOM_CREORGNAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime ROOM_CREDATE { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal ROOM_UPID { get; set; }
    
        /// <summary>
        /// 修改人姓名
        /// </summary>
        
        [Description("修改人姓名")]
        public string ROOM_UPNAME { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime ROOM_UPDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string ROOM_ISDEL { get; set; }
    }
}
