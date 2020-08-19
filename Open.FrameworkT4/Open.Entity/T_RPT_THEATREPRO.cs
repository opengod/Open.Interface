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
    /// T_RPT_THEATREPRO 
    /// </summary>    
   [Serializable]
   [SugarTable("T_RPT_THEATREPRO")]
    public class T_RPT_THEATREPRO
    {
    
        /// <summary>
        /// a
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("a")]
        public decimal THEATREPRO_ID { get; set; }
    
        /// <summary>
        /// 门票ID
        /// </summary>
        
        [Description("门票ID")]
        public decimal THEATREPRO_PRODUCTID { get; set; }
    
        /// <summary>
        /// 剧场ID
        /// </summary>
        
        [Description("剧场ID")]
        public decimal THEATREPRO_THEATREID { get; set; }
    
        /// <summary>
        /// 层数ID
        /// </summary>
        
        [Description("层数ID")]
        public decimal THEATREPRO_FLOORID { get; set; }
    
        /// <summary>
        /// 区域ID
        /// </summary>
        
        [Description("区域ID")]
        public decimal THEATREPRO_AREAID { get; set; }
    
        /// <summary>
        /// 场次ID
        /// </summary>
        
        [Description("场次ID")]
        public decimal THEATREPRO_SHOWID { get; set; }
    }
}
