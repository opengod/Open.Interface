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
    /// T_RPT_CATERING 
    /// </summary>    
   [Serializable]
   [SugarTable("T_RPT_CATERING")]
    public class T_RPT_CATERING
    {
    
        /// <summary>
        /// a
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("a")]
        public decimal CATERING_ID { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string CATERING_NAME { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal CATERING_TYPE { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string CATERING_NATION { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string CATERING_AREA { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string CATERING_PROVINCE { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string CATERING_CITY { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string CATERING_COUNTRY { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string CATERING_TEL { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string CATERING_LINKTYPE { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal CATERING_POSITIONX { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal CATERING_POSITIONY { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string CATERING_MEMO { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string CATERING_SERVICE { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string CATERING_TRANSPORT { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string CATERING_IMPRESSION { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public DateTime CATERING_TIME { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public DateTime CATERING_RENOVATIONTIME { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string CATERING_ISREFEE { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string CATERING_ISORDER { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public DateTime CATERING_CTIME { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal CATERING_CREATEBY { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal CATERING_SORT { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string CATERING_DEL { get; set; }
    }
}
