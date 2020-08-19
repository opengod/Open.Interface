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
    /// T_ORDERNO_LOG 
    /// </summary>    
   [Serializable]
   [SugarTable("T_ORDERNO_LOG")]
    public class T_ORDERNO_LOG
    {
    
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("")]
        public decimal TRANSID { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        
        [Description("")]
        public string TRANSDATE { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        
        [Description("")]
        public string MSG { get; set; }
    }
}
