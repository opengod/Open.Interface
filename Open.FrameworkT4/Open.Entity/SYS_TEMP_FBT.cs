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
    /// SYS_TEMP_FBT 
    /// </summary>    
   [Serializable]
   [SugarTable("SYS_TEMP_FBT")]
    public class SYS_TEMP_FBT
    {
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string SCHEMA { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string OBJECT_NAME { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal OBJECT# { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public UROWID RID { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string ACTION { get; set; }
    }
}
