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
    /// T_SYS_CODECOUNTRY 
    /// </summary>    
   [Serializable]
   [SugarTable("T_SYS_CODECOUNTRY")]
    public class T_SYS_CODECOUNTRY
    {
    
        /// <summary>
        /// a
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("a")]
        public decimal ID { get; set; }
    
        /// <summary>
        /// 国家名称
        /// </summary>
        
        [Description("国家名称")]
        public string NAME { get; set; }
    
        /// <summary>
        /// 所属洲
        /// </summary>
        
        [Description("所属洲")]
        public decimal CID { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal SORT { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string DEL { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string QHELP { get; set; }
    }
}
