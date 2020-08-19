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
    /// T_BIZ_TGUIDE 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_TGUIDE")]
    public class T_BIZ_TGUIDE
    {
    
        /// <summary>
        /// ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("ID")]
        public decimal TGUIDE_ID { get; set; }
    
        /// <summary>
        /// 订单ID
        /// </summary>
        
        [Description("订单ID")]
        public decimal TGUIDE_TORDERID { get; set; }
    
        /// <summary>
        /// 订单号
        /// </summary>
        
        [Description("订单号")]
        public string TGUIDE_TORDERNO { get; set; }
    
        /// <summary>
        /// 导游姓名
        /// </summary>
        
        [Description("导游姓名")]
        public string TGUIDE_NAME { get; set; }
    
        /// <summary>
        /// 导游手机号
        /// </summary>
        
        [Description("导游手机号")]
        public string TGUIDE_PHONE { get; set; }
    
        /// <summary>
        /// 证件号
        /// </summary>
        
        [Description("证件号")]
        public string TGUIDE_CARDNO { get; set; }
    }
}
