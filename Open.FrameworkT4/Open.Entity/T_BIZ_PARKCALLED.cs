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
    /// T_BIZ_PARKCALLED 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_PARKCALLED")]
    public class T_BIZ_PARKCALLED
    {
    
        /// <summary>
        /// a
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("a")]
        public decimal ID { get; set; }
    
        /// <summary>
        /// 串码
        /// </summary>
        
        [Description("串码")]
        public string ORDERNO { get; set; }
    
        /// <summary>
        /// 入园人身份证
        /// </summary>
        
        [Description("入园人身份证")]
        public string PERSONICNO { get; set; }
    }
}
