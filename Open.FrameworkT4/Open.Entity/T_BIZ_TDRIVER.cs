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
    /// T_BIZ_TDRIVER 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_TDRIVER")]
    public class T_BIZ_TDRIVER
    {
    
        /// <summary>
        /// ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("ID")]
        public decimal TDRIVER_ID { get; set; }
    
        /// <summary>
        /// 订单ID
        /// </summary>
        
        [Description("订单ID")]
        public decimal TDRIVER_TORDERID { get; set; }
    
        /// <summary>
        /// 订单号
        /// </summary>
        
        [Description("订单号")]
        public string TDRIVER_TORDERNO { get; set; }
    
        /// <summary>
        /// 司机姓名
        /// </summary>
        
        [Description("司机姓名")]
        public string TDRIVER_NAME { get; set; }
    
        /// <summary>
        /// 车牌号
        /// </summary>
        
        [Description("车牌号")]
        public string TDRIVER_CARTNO { get; set; }
    }
}
