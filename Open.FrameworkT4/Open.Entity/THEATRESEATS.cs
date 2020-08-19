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
    /// THEATRESEATS 
    /// </summary>    
   [Serializable]
   [SugarTable("THEATRESEATS")]
    public class THEATRESEATS
    {
    
        /// <summary>
        /// a
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("a")]
        public decimal ID { get; set; }
    
        /// <summary>
        /// 座位号
        /// </summary>
        
        [Description("座位号")]
        public string SEATNO { get; set; }
    
        /// <summary>
        /// 状态(6:可售1:已售4:锁定)
        /// </summary>
        
        [Description("状态(6:可售1:已售4:锁定)")]
        public string SEATSYSTATUS { get; set; }
    
        /// <summary>
        /// 座位坐标x
        /// </summary>
        
        [Description("座位坐标x")]
        public string SEATX { get; set; }
    
        /// <summary>
        /// 座位坐标y
        /// </summary>
        
        [Description("座位坐标y")]
        public string SEATY { get; set; }
    
        /// <summary>
        /// 分配状态（0：线下，1：B2B,2:B2C）
        /// </summary>
        
        [Description("分配状态（0：线下，1：B2B,2:B2C）")]
        public string STATUS { get; set; }
    
        /// <summary>
        /// 区域名称
        /// </summary>
        
        [Description("区域名称")]
        public string AREANAME { get; set; }
    
        /// <summary>
        /// 楼层
        /// </summary>
        
        [Description("楼层")]
        public string FLOOR { get; set; }
    
        /// <summary>
        /// 场次ID
        /// </summary>
        
        [Description("场次ID")]
        public decimal SCEENSID { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal AREAID { get; set; }
    }
}
