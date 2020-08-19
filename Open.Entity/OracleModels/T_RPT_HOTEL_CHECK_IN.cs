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
    /// T_RPT_HOTEL_CHECK_IN 
    /// </summary>    
   [Serializable]
   [SugarTable("T_RPT_HOTEL_CHECK_IN")]
    public class T_RPT_HOTEL_CHECK_IN
    {
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string PERSON_NAME { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string PERSON_IDENTITYNO { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public DateTime INDATE { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public DateTime OUTDATE { get; set; }
    }
}
