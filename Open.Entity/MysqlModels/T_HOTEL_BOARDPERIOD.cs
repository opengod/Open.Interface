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
    /// T_HOTEL_BOARDPERIOD 
    /// </summary>    
   [Serializable]
   [SugarTable("T_HOTEL_BOARDPERIOD")]
    public class T_HOTEL_BOARDPERIOD
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal PERIOD_ID { get; set; }
    
        /// <summary>
        /// 会议室ID
        /// </summary>
        
        [Description("会议室ID")]
        public decimal PERIOD_BOARDID { get; set; }
    
        /// <summary>
        /// 会议室产品编码
        /// </summary>
        
        [Description("会议室产品编码")]
        public string PERIOD_BOARDCODE { get; set; }
    
        /// <summary>
        /// 时段
        /// </summary>
        
        [Description("时段")]
        public string PERIOD_NAME { get; set; }
    
        /// <summary>
        /// 时段基础价格
        /// </summary>
        
        [Description("时段基础价格")]
        public decimal PERIOD_PRICE { get; set; }
    
        /// <summary>
        /// 可使用时间起
        /// </summary>
        
        [Description("可使用时间起")]
        public DateTime PERIOD_USETIMES { get; set; }
    
        /// <summary>
        /// 可使用时间至
        /// </summary>
        
        [Description("可使用时间至")]
        public DateTime PERIOD_USETIMEE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string PERIOD_ISDEL { get; set; }
    }
}
