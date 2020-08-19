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
    /// T_DIS_LEVEL 
    /// </summary>    
   [Serializable]
   [SugarTable("T_DIS_LEVEL")]
    public class T_DIS_LEVEL
    {
    
        /// <summary>
        /// a
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("a")]
        public decimal DISLEVEL_ID { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal DISLEVEL_ORGID { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string DISLEVEL_LEVELNAME { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal DISLEVEL_LEVEL { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal DISLEVEL_NUM { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public DateTime DISLEVEL_CDATE { get; set; }
    }
}
