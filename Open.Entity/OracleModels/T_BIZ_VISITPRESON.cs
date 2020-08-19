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
    /// T_BIZ_VISITPRESON 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_VISITPRESON")]
    public class T_BIZ_VISITPRESON
    {
    
        /// <summary>
        /// 游客名称
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("游客名称")]
        public decimal ID { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string NAME { get; set; }
    
        /// <summary>
        /// 游客拼音
        /// </summary>
        
        [Description("游客拼音")]
        public string NAMEPINYIN { get; set; }
    
        /// <summary>
        /// 证件号
        /// </summary>
        
        [Description("证件号")]
        public string CREDENTIALS { get; set; }
    
        /// <summary>
        /// 证件类型
        /// </summary>
        
        [Description("证件类型")]
        public string CREDENTIALSTYPE { get; set; }
    
        /// <summary>
        /// 供应商自定义信息1
        /// </summary>
        
        [Description("供应商自定义信息1")]
        public string DEFINED1VALUE { get; set; }
    
        /// <summary>
        /// 供应商自定义信息2
        /// </summary>
        
        [Description("供应商自定义信息2")]
        public string DEFINED2VALUE { get; set; }
    
        /// <summary>
        /// 去哪网订单号
        /// </summary>
        
        [Description("去哪网订单号")]
        public string ORDERNO { get; set; }
    
        /// <summary>
        /// 加入时间
        /// </summary>
        
        [Description("加入时间")]
        public DateTime ADDTIME { get; set; }
    }
}
