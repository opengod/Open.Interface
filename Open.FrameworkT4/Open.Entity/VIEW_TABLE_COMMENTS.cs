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
    /// VIEW_TABLE_COMMENTS 
    /// </summary>    
   [Serializable]
   [SugarTable("VIEW_TABLE_COMMENTS")]
    public class VIEW_TABLE_COMMENTS
    {
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string TABLE_NAME { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string TABLE_COMMENTS { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string COLUMN_NAME { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string COLUMN_COMMENTS { get; set; }
    }
}
