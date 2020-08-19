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
    /// T_SYS_ORDERNO 
    /// </summary>    
   [Serializable]
   [SugarTable("T_SYS_ORDERNO")]
    public class T_SYS_ORDERNO
    {
    
        /// <summary>
        /// ID
        /// </summary>
        
        [Description("ID")]
        public decimal ORDERNO_ID { get; set; }
    
        /// <summary>
        /// 日期
        /// </summary>
        
        [Description("日期")]
        public DateTime ORDERNO_DATE { get; set; }
    
        /// <summary>
        /// 首字母
        /// </summary>
        
        [Description("首字母")]
        public string ORDERNO_FLETTER { get; set; }
    
        /// <summary>
        /// 累计数量
        /// </summary>
        
        [Description("累计数量")]
        public decimal ORDERNO_NUMBER { get; set; }
    }
}
