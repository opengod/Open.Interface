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
    /// T_BIZ_POSPONE 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_POSPONE")]
    public class T_BIZ_POSPONE
    {
    
        /// <summary>
        /// 退票记录ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("退票记录ID")]
        public decimal ID { get; set; }
    
        /// <summary>
        /// 退票记时间
        /// </summary>
        
        [Description("退票记时间")]
        public DateTime DODATE { get; set; }
    
        /// <summary>
        /// 退票记用户ID
        /// </summary>
        
        [Description("退票记用户ID")]
        public decimal DOUSEID { get; set; }
    
        /// <summary>
        /// 退票记录用户名
        /// </summary>
        
        [Description("退票记录用户名")]
        public string DOUSENAME { get; set; }
    
        /// <summary>
        /// 退票记录企业ID
        /// </summary>
        
        [Description("退票记录企业ID")]
        public decimal DOOTAID { get; set; }
    
        /// <summary>
        /// 退票记录企业名称
        /// </summary>
        
        [Description("退票记录企业名称")]
        public string DOOTANAME { get; set; }
    
        /// <summary>
        /// 改签前开始时间
        /// </summary>
        
        [Description("改签前开始时间")]
        public DateTime OLDSTARTTIME { get; set; }
    
        /// <summary>
        /// 改签前结束时间
        /// </summary>
        
        [Description("改签前结束时间")]
        public DateTime OLDENDTIME { get; set; }
    
        /// <summary>
        /// 现在开始时间
        /// </summary>
        
        [Description("现在开始时间")]
        public DateTime NOWSTARTTTIME { get; set; }
    
        /// <summary>
        /// 现在结束时间
        /// </summary>
        
        [Description("现在结束时间")]
        public DateTime NOWENDTIME { get; set; }
    
        /// <summary>
        /// 串码号
        /// </summary>
        
        [Description("串码号")]
        public string ORDER_NO { get; set; }
    }
}
