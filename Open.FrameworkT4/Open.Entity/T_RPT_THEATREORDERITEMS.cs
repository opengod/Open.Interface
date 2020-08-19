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
    /// T_RPT_THEATREORDERITEMS 
    /// </summary>    
   [Serializable]
   [SugarTable("T_RPT_THEATREORDERITEMS")]
    public class T_RPT_THEATREORDERITEMS
    {
    
        /// <summary>
        /// a
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("a")]
        public decimal THEATREORDERITEMS_ID { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal THEATREORDERITEMS_ITEMID { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string THEATREORDERITEMS_THEATRENAME { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string THEATREORDERITEMS_AREANAME { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string THEATREORDERITEMS_SHOWNAME { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string THEATREORDERITEMS_SHOWTIMES { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string THEATREORDERITEMS_SHOWTIMEE { get; set; }
    }
}
