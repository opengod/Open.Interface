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
    /// T_RPT_TOURISMLINE 
    /// </summary>    
   [Serializable]
   [SugarTable("T_RPT_TOURISMLINE")]
    public class T_RPT_TOURISMLINE
    {
    
        /// <summary>
        /// a
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("a")]
        public decimal TOURISMLINE_ID { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string TOURISMLINE_NAME { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string TOURISMLINE_TYPE { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal TOURISMLINE_MINNUM { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal TOURISMLINE_MAXNUM { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string TOURISMLINE_MEMO { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string TOURISMLINE_KNOW { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string TOURISMLINE_TIP { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string TOURISMLINE_RIDE { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal TOURISMLINE_DAYS { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string TOURISMLINE_FEES { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string TOURISMLINE_CONTENT { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal TOURISMLINE_OPRICE { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal TOURISMLINE_PRICE { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public DateTime TOURISMLINE_CTIME { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal TOURISMLINE_CREATEBY { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal TOURISMLINE_OID { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal TOURISMLINE_SORT { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string TOURISMLINE_DEL { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal TOURISMLINE_ORGID { get; set; }
    }
}
