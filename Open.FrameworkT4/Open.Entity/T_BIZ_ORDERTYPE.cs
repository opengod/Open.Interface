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
    /// T_BIZ_ORDERTYPE 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_ORDERTYPE")]
    public class T_BIZ_ORDERTYPE
    {
    
        /// <summary>
        /// 订单类型表ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("订单类型表ID")]
        public decimal ORDERTYPE_ID { get; set; }
    
        /// <summary>
        /// 订单类型名称
        /// </summary>
        
        [Description("订单类型名称")]
        public string ORDERTYPE_NAME { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string ISLOGIDEL { get; set; }
    }
}
