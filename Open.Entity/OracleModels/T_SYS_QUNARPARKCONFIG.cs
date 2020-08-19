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
    /// T_SYS_QUNARPARKCONFIG 
    /// </summary>    
   [Serializable]
   [SugarTable("T_SYS_QUNARPARKCONFIG")]
    public class T_SYS_QUNARPARKCONFIG
    {
    
        /// <summary>
        /// a
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("a")]
        public decimal QUNARCONFIG_ID { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal QUNARCONFIG_PARKID { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal QUNARCONFIG_OTAID { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string QUNARCONFIG_ACCOUNT { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string QUNARCONFIG_KEY { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string QUNARCONFIG_ALLRETURN { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string QUNARCONFIG_ISPLATSEND { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string QUNARCONFIG_DEL { get; set; }
    }
}
