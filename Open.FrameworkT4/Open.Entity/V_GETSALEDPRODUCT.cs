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
    /// V_GETSALEDPRODUCT 
    /// </summary>    
   [Serializable]
   [SugarTable("V_GETSALEDPRODUCT")]
    public class V_GETSALEDPRODUCT
    {
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal SALEDCOUNT { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal ORDERTYPEID { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal PRODUCTID { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string PLAYDATE { get; set; }
    }
}
