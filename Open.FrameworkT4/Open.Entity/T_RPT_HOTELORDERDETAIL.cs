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
    /// T_RPT_HOTELORDERDETAIL 
    /// </summary>    
   [Serializable]
   [SugarTable("T_RPT_HOTELORDERDETAIL")]
    public class T_RPT_HOTELORDERDETAIL
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal DETAILID { get; set; }
    
        /// <summary>
        /// 订单表ID
        /// </summary>
        
        [Description("订单表ID")]
        public decimal ORDERID { get; set; }
    
        /// <summary>
        /// 最后更新时间
        /// </summary>
        
        [Description("最后更新时间")]
        public DateTime LASTUPDATETIME { get; set; }
    }
}
