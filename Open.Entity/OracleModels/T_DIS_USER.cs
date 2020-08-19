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
    /// T_DIS_USER 
    /// </summary>    
   [Serializable]
   [SugarTable("T_DIS_USER")]
    public class T_DIS_USER
    {
    
        /// <summary>
        /// a
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("a")]
        public decimal USER_ID { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal USER_PID { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal USER_ORGID { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string USER_CODE { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string USER_NAME { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string USER_PHONE { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string USER_PASSWORD { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string USER_STATUS { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string USER_INVITECODE { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string USER_TYPE { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal USER_AMOUNT { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal USER_CPAMOUNT { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal USER_CSAMOUNT { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal USER_LEVELID { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal USER_LAYER { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public DateTime USER_CDATE { get; set; }
    }
}
