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
    /// T_BIZ_QRCODEINFO 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_QRCODEINFO")]
    public class T_BIZ_QRCODEINFO
    {
    
        /// <summary>
        /// a
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("a")]
        public decimal QRCODEINFO_ID { get; set; }
    
        /// <summary>
        /// 景区ID
        /// </summary>
        
        [Description("景区ID")]
        public decimal QRCODEINFO_PARKID { get; set; }
    
        /// <summary>
        /// 产品id
        /// </summary>
        
        [Description("产品id")]
        public decimal QRCODEINFO_PRODUCTID { get; set; }
    
        /// <summary>
        /// 二维码路径
        /// </summary>
        
        [Description("二维码路径")]
        public string QRCODEINFO_URL { get; set; }
    
        /// <summary>
        /// 二维码有效开始时间
        /// </summary>
        
        [Description("二维码有效开始时间")]
        public DateTime QRCODEINFO_STARTDATE { get; set; }
    
        /// <summary>
        /// 二维码失效时间
        /// </summary>
        
        [Description("二维码失效时间")]
        public DateTime QRCODEINFO_ENDDATE { get; set; }
    }
}
