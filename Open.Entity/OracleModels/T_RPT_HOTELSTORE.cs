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
    /// T_RPT_HOTELSTORE 
    /// </summary>    
   [Serializable]
   [SugarTable("T_RPT_HOTELSTORE")]
    public class T_RPT_HOTELSTORE
    {
    
        /// <summary>
        /// a
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("a")]
        public decimal STOREID { get; set; }
    
        /// <summary>
        /// 房间ID
        /// </summary>
        
        [Description("房间ID")]
        public decimal ROOMID { get; set; }
    
        /// <summary>
        /// 销售库存
        /// </summary>
        
        [Description("销售库存")]
        public decimal SALEQUANTITY { get; set; }
    
        /// <summary>
        /// 使用库存
        /// </summary>
        
        [Description("使用库存")]
        public decimal USEQUANTITY { get; set; }
    
        /// <summary>
        /// 逻辑删除
        /// </summary>
        
        [Description("逻辑删除")]
        public string DEL { get; set; }
    
        /// <summary>
        /// 1正常使用，2维护中，3其他
        /// </summary>
        
        [Description("1正常使用，2维护中，3其他")]
        public string STATUS { get; set; }
    }
}
