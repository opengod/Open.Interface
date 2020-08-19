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
    /// T_RPT_HOTELSTOREDETAIL 
    /// </summary>    
   [Serializable]
   [SugarTable("T_RPT_HOTELSTOREDETAIL")]
    public class T_RPT_HOTELSTOREDETAIL
    {
    
        /// <summary>
        /// a
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("a")]
        public decimal STOREDETAILID { get; set; }
    
        /// <summary>
        /// 库存ID
        /// </summary>
        
        [Description("库存ID")]
        public decimal STOREID { get; set; }
    
        /// <summary>
        /// 订单ID
        /// </summary>
        
        [Description("订单ID")]
        public decimal ORDERID { get; set; }
    }
}
