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
    /// T_HOTEL_ROOMDETAIL 
    /// </summary>    
   [Serializable]
   [SugarTable("T_HOTEL_ROOMDETAIL")]
    public class T_HOTEL_ROOMDETAIL
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal DETAIL_ID { get; set; }
    
        /// <summary>
        /// 酒店ID
        /// </summary>
        
        [Description("酒店ID")]
        public decimal DETAIL_HOTELID { get; set; }
    
        /// <summary>
        /// 酒店名称
        /// </summary>
        
        [Description("酒店名称")]
        public string DETAIL_HOTELNAME { get; set; }
    
        /// <summary>
        /// 房间ID
        /// </summary>
        
        [Description("房间ID")]
        public decimal DETAIL_ROOMID { get; set; }
    
        /// <summary>
        /// 房间类型编码
        /// </summary>
        
        [Description("房间类型编码")]
        public string DETAIL_ROOMCODE { get; set; }
    
        /// <summary>
        /// 房间名称
        /// </summary>
        
        [Description("房间名称")]
        public string DETAIL_NAME { get; set; }
    
        /// <summary>
        /// 宽带（免费、有线免费、收费、无）
        /// </summary>
        
        [Description("宽带（免费、有线免费、收费、无）")]
        public string DETAIL_BROADBAND { get; set; }
    
        /// <summary>
        /// 设施（吹风机，电视等）
        /// </summary>
        
        [Description("设施（吹风机，电视等）")]
        public string DETAIL_FACILITIES { get; set; }
    
        /// <summary>
        /// 面积
        /// </summary>
        
        [Description("面积")]
        public string DETAIL_AREA { get; set; }
    
        /// <summary>
        /// 楼层
        /// </summary>
        
        [Description("楼层")]
        public string DETAIL_FLOOR { get; set; }
    
        /// <summary>
        /// 创建人所在机构ID
        /// </summary>
        
        [Description("创建人所在机构ID")]
        public decimal DETAIL_CREORGID { get; set; }
    
        /// <summary>
        /// 创建人所在机构名称
        /// </summary>
        
        [Description("创建人所在机构名称")]
        public string DETAIL_CREORGNAME { get; set; }
    
        /// <summary>
        /// 创建人姓名
        /// </summary>
        
        [Description("创建人姓名")]
        public string DETAIL_CRENAME { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal DETAIL_CREID { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime DETAIL_CREDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string DETAIL_ISDEL { get; set; }
    }
}
