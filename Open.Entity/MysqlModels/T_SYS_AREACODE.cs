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
    /// T_SYS_AREACODE 
    /// </summary>    
   [Serializable]
   [SugarTable("T_SYS_AREACODE")]
    public class T_SYS_AREACODE
    {
    
        /// <summary>
        /// 中国区域代码表主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("中国区域代码表主键")]
        public int ID { get; set; }
    
        /// <summary>
        /// 区域代码
        /// </summary>
        
        [Description("区域代码")]
        public string CODE { get; set; }
    
        /// <summary>
        /// 省级名称
        /// </summary>
        
        [Description("省级名称")]
        public string PROVINCE { get; set; }
    
        /// <summary>
        /// 地级市名称
        /// </summary>
        
        [Description("地级市名称")]
        public string CITY { get; set; }
    
        /// <summary>
        /// 区县名称
        /// </summary>
        
        [Description("区县名称")]
        public string COUNTY { get; set; }
    
        /// <summary>
        /// 详细名称
        /// </summary>
        
        [Description("详细名称")]
        public string AREA { get; set; }
    }
}
