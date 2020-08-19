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
    /// T_B2C_PRODUCTINFO 
    /// </summary>    
   [Serializable]
   [SugarTable("T_B2C_PRODUCTINFO")]
    public class T_B2C_PRODUCTINFO
    {
    
        /// <summary>
        /// a
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("a")]
        public decimal PRODUCTINFO_ID { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal PRODUCTINFO_PDTID { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string PRODUCTINFO_PDTNAME { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal PRODUCTINFO_PRICE { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal PRODUCTINFO_CPRICE { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string PRODUCTINFO_CHARGETYPE { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string PRODUCTINFO_DEL { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public DateTime PRODUCTINFO_DATES { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public DateTime PRODUCTINFO_DATEE { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string PRODUCTINFO_SEASON { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string PRODUCTINFO_MEMO { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string PRODUCTINFO_OFF { get; set; }
    }
}
