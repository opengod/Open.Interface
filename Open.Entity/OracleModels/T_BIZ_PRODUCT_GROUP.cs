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
    /// T_BIZ_PRODUCT_GROUP 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_PRODUCT_GROUP")]
    public class T_BIZ_PRODUCT_GROUP
    {
    
        /// <summary>
        /// 产品组别ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("产品组别ID")]
        public decimal GROUP_ID { get; set; }
    
        /// <summary>
        /// 产品组别名称
        /// </summary>
        
        [Description("产品组别名称")]
        public string GROUP_NAME { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string GROUP_COMMENT { get; set; }
    
        /// <summary>
        /// 逻辑删除
        /// </summary>
        
        [Description("逻辑删除")]
        public string GROUP_ISLOGIDEL { get; set; }
    
        /// <summary>
        /// 删除人ID
        /// </summary>
        
        [Description("删除人ID")]
        public decimal GROUP_DELID { get; set; }
    
        /// <summary>
        /// 删除人姓名
        /// </summary>
        
        [Description("删除人姓名")]
        public string GROUP_DELNAME { get; set; }
    
        /// <summary>
        /// 删除日期
        /// </summary>
        
        [Description("删除日期")]
        public DateTime GROUP_DELDATE { get; set; }
    }
}
