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
    /// T_SYS_BARCODE 
    /// </summary>    
   [Serializable]
   [SugarTable("T_SYS_BARCODE")]
    public class T_SYS_BARCODE
    {
    
        /// <summary>
        /// 串码ID
        /// </summary>
        
        [Description("串码ID")]
        public decimal BARCODE_ID { get; set; }
    
        /// <summary>
        /// 串码
        /// </summary>
        
        [Description("串码")]
        public string BARCODE_CODE { get; set; }
    
        /// <summary>
        /// 是否使用 0未使用 1已使用
        /// </summary>
        
        [Description("是否使用 0未使用 1已使用")]
        public decimal BARCODE_USE { get; set; }
    }
}
