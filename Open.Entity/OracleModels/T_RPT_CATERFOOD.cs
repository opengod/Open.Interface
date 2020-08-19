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
    /// T_RPT_CATERFOOD 
    /// </summary>    
   [Serializable]
   [SugarTable("T_RPT_CATERFOOD")]
    public class T_RPT_CATERFOOD
    {
    
        /// <summary>
        /// a
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("a")]
        public decimal CATERFOOD_ID { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal CATERFOOD_CATERID { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string CATERFOOD_CUISINEID { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string CATERFOOD_EFFECTID { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string CATERFOOD_FLAVORID { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string CATERFOOD_NAME { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string CATERFOOD_TIP { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string CATERFOOD_RULE { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string CATERFOOD_DATES { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string CATERFOOD_DATEE { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string CATERFOOD_TIMES { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string CATERFOOD_TIMEE { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal CATERFOOD_OPRICE { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal CATERFOOD_PRICE { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string CATERFOOD_PAYTYPE { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public DateTime CATERFOOD_CTIME { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal CATERFOOD_CREATEBY { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string CATERFOOD_DEL { get; set; }
    }
}
