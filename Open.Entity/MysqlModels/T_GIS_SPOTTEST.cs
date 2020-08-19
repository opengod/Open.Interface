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
    /// T_GIS_SPOTTEST 
    /// </summary>    
   [Serializable]
   [SugarTable("T_GIS_SPOTTEST")]
    public class T_GIS_SPOTTEST
    {
    
        /// <summary>
        /// 名称
        /// </summary>
        
        [Description("名称")]
        public string SPOTGIS_NAME { get; set; }
    
        /// <summary>
        /// 说明
        /// </summary>
        
        [Description("说明")]
        public string SPOTGIS_EXPLAIN { get; set; }
    }
}
