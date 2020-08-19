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
    /// T_BIZ_PAG_DTLPRO 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_PAG_DTLPRO")]
    public class T_BIZ_PAG_DTLPRO
    {
    
        /// <summary>
        /// a
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("a")]
        public decimal PAG_DTLPRO_ID { get; set; }
    
        /// <summary>
        /// 产品包ID
        /// </summary>
        
        [Description("产品包ID")]
        public decimal PAG_DTLPRO_PACKID { get; set; }
    
        /// <summary>
        /// 产品包价格明细ID
        /// </summary>
        
        [Description("产品包价格明细ID")]
        public decimal PAG_DTLPRO_FEEID { get; set; }
    
        /// <summary>
        /// 产品ID
        /// </summary>
        
        [Description("产品ID")]
        public decimal PAG_DTLPRO_PROID { get; set; }
    }
}
