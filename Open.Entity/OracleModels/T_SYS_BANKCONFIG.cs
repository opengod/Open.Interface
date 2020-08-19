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
    /// T_SYS_BANKCONFIG 
    /// </summary>    
   [Serializable]
   [SugarTable("T_SYS_BANKCONFIG")]
    public class T_SYS_BANKCONFIG
    {
    
        /// <summary>
        /// a
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("a")]
        public decimal BANKCONFIG_ID { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal BANKCONFIG_ORGID { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string BANKCONFIG_BANKTYPE { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string BANKCONFIG_MERCHANTID { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string BANKCONFIG_MERCHANTNO { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string BANKCONFIG_KEY { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string BANKCONFIG_SSLCERTPATH { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string BANKCONFIG_SSLCERTPASSWORD { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public DateTime BANKCONFIG_CDATE { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string BANKCONFIG_APPSECRET { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string BANKCONFIG_ISLOGDEL { get; set; }
    }
}
