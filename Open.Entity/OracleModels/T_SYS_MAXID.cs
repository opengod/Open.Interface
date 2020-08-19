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
    /// T_SYS_MAXID 
    /// </summary>    
   [Serializable]
   [SugarTable("T_SYS_MAXID")]
    public class T_SYS_MAXID
    {
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal ID { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string DBUSER { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string TNAME { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal MAXID { get; set; }
    }
}
