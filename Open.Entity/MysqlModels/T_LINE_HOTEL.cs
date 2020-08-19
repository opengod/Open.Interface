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
    /// T_LINE_HOTEL 
    /// </summary>    
   [Serializable]
   [SugarTable("T_LINE_HOTEL")]
    public class T_LINE_HOTEL
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal LINEHOTEL_ID { get; set; }
    
        /// <summary>
        /// 线路ID
        /// </summary>
        
        [Description("线路ID")]
        public decimal LINEHOTEL_LINEID { get; set; }
    
        /// <summary>
        /// 线路编码
        /// </summary>
        
        [Description("线路编码")]
        public string LINEHOTEL_LINECODE { get; set; }
    
        /// <summary>
        /// 酒店ID
        /// </summary>
        
        [Description("酒店ID")]
        public decimal LINEHOTEL_HOTELID { get; set; }
    
        /// <summary>
        /// 酒店名称
        /// </summary>
        
        [Description("酒店名称")]
        public string LINEHOTEL_HOTELNAME { get; set; }
    
        /// <summary>
        /// 房型ID
        /// </summary>
        
        [Description("房型ID")]
        public decimal LINEHOTEL_ROOMID { get; set; }
    
        /// <summary>
        /// 房型名称
        /// </summary>
        
        [Description("房型名称")]
        public string LINEHOTEL_ROOMNAME { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string LINEHOTEL_MEMO { get; set; }
    
        /// <summary>
        /// 排序
        /// </summary>
        
        [Description("排序")]
        public decimal LINEHOTEL_SORT { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal LINEHOTEL_CREID { get; set; }
    
        /// <summary>
        /// 创建人姓名
        /// </summary>
        
        [Description("创建人姓名")]
        public string LINEHOTEL_CRENAME { get; set; }
    
        /// <summary>
        /// 创建人所在机构ID
        /// </summary>
        
        [Description("创建人所在机构ID")]
        public decimal LINEHOTEL_CREORGID { get; set; }
    
        /// <summary>
        /// 创建人所在机构名称
        /// </summary>
        
        [Description("创建人所在机构名称")]
        public string LINEHOTEL_CREORGNAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime LINEHOTEL_CREDATE { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal LINEHOTEL_UPID { get; set; }
    
        /// <summary>
        /// 修改人名称
        /// </summary>
        
        [Description("修改人名称")]
        public string LINEHOTEL_UPNAME { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime LINEHOTEL_UPDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string LINEHOTEL_ISDEL { get; set; }
    }
}
