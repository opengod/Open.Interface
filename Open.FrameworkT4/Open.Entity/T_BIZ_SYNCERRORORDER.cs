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
    /// T_BIZ_SYNCERRORORDER 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_SYNCERRORORDER")]
    public class T_BIZ_SYNCERRORORDER
    {
    
        /// <summary>
        /// a
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("a")]
        public decimal ERRORID { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string ORDERID { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal ERRORNUM { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public DateTime LASTERRORTIME { get; set; }
    }
}
