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
    /// T_DATA_TARVELINFO 
    /// </summary>    
   [Serializable]
   [SugarTable("T_DATA_TARVELINFO")]
    public class T_DATA_TARVELINFO
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal TRAVEL_ID { get; set; }
    
        /// <summary>
        /// 旅行社数
        /// </summary>
        
        [Description("旅行社数")]
        public string TRAVEL_AGENCYNUM { get; set; }
    
        /// <summary>
        /// 导游人数
        /// </summary>
        
        [Description("导游人数")]
        public string TRAVEL_GUIDENUM { get; set; }
    
        /// <summary>
        /// 旅游大巴
        /// </summary>
        
        [Description("旅游大巴")]
        public string TRAVEL_BUSNUM { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime TRAVEL_CREDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string TRAVEL_ISDEL { get; set; }
    }
}
