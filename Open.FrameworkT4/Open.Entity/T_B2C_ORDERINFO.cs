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
    /// T_B2C_ORDERINFO 
    /// </summary>    
   [Serializable]
   [SugarTable("T_B2C_ORDERINFO")]
    public class T_B2C_ORDERINFO
    {
    
        /// <summary>
        /// a
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("a")]
        public decimal ORDERINFO_ID { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal ORDERINFO_ORDERID { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string ORDERINFO_CODE { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal ORDERINFO_CREATEBY { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public DateTime ORDERINFO_CREATETIME { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string ORDERINFO_DEL { get; set; }
    }
}
