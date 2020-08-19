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
    /// T_RPT_TOURISMLINEITEM 
    /// </summary>    
   [Serializable]
   [SugarTable("T_RPT_TOURISMLINEITEM")]
    public class T_RPT_TOURISMLINEITEM
    {
    
        /// <summary>
        /// a
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("a")]
        public decimal ITEM_ID { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string ITEM_ORDERNO { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal ITEM_ORDERID { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string ITEM_GORDERNO { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string ITEM_TYPE { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public DateTime ITEM_CDATE { get; set; }
    }
}
