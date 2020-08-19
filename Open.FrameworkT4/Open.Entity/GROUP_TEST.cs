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
    /// GROUP_TEST 
    /// </summary>    
   [Serializable]
   [SugarTable("GROUP_TEST")]
    public class GROUP_TEST
    {
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string GROUP_ID { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string JOB { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string NAME { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal SALARY { get; set; }
    }
}
