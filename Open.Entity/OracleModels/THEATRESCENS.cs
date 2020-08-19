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
    /// THEATRESCENS 
    /// </summary>    
   [Serializable]
   [SugarTable("THEATRESCENS")]
    public class THEATRESCENS
    {
    
        /// <summary>
        /// a
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("a")]
        public decimal ID { get; set; }
    
        /// <summary>
        /// 场次ID
        /// </summary>
        
        [Description("场次ID")]
        public decimal SCENIDS { get; set; }
    
        /// <summary>
        /// 场次名称
        /// </summary>
        
        [Description("场次名称")]
        public string SCENNAME { get; set; }
    
        /// <summary>
        /// 景区名称
        /// </summary>
        
        [Description("景区名称")]
        public string PARK { get; set; }
    
        /// <summary>
        /// 时间版本
        /// </summary>
        
        [Description("时间版本")]
        public string TIMEVER { get; set; }
    
        /// <summary>
        /// 售卖状态（0:暂停售卖 1：开启售卖）
        /// </summary>
        
        [Description("售卖状态（0:暂停售卖 1：开启售卖）")]
        public string OPENSTATE { get; set; }
    
        /// <summary>
        /// 开演时间
        /// </summary>
        
        [Description("开演时间")]
        public DateTime STARTTIME { get; set; }
    
        /// <summary>
        /// 结束时间
        /// </summary>
        
        [Description("结束时间")]
        public DateTime ENDTIME { get; set; }
    }
}
