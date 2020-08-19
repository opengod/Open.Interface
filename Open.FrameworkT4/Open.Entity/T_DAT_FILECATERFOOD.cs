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
    /// T_DAT_FILECATERFOOD 
    /// </summary>    
   [Serializable]
   [SugarTable("T_DAT_FILECATERFOOD")]
    public class T_DAT_FILECATERFOOD
    {
    
        /// <summary>
        /// a
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("a")]
        public decimal FILEFOOD_ID { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal FILEFOOD_FOODID { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal FILEFOOD_FILEID { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal FILEFOOD_SORT { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string FILEFOOD_ISMAIN { get; set; }
    }
}
