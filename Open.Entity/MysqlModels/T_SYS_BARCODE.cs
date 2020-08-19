//-----------------------------------------------------------------------
// <Copyright>
// * copyright © 2020 open All Rights Reserved
// * version : 4.0.30319.42000
// * author  : open
// * history : Created by open 2020-08-19 11:20:13 
// </Copyright>
//-----------------------------------------------------------------------
using System;
using SqlSugar;
using System.ComponentModel;

namespace Open.Entity.Mysql
{
    /// <summary>
    /// T_SYS_BARCODE 
    /// </summary>    
   [Serializable]
   [SugarTable("T_SYS_BARCODE")]
    public class T_SYS_BARCODE
    {
    
        /// <summary>
        /// 
        /// </summary>
        
        [Description("")]
        public decimal BARCODE_ID { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        
        [Description("")]
        public string BARCODE_CODE { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        
        [Description("")]
        public decimal BARCODE_USE { get; set; }
    }
}
