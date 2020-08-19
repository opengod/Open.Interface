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
    /// T_SYS_AREA 
    /// </summary>    
   [Serializable]
   [SugarTable("T_SYS_AREA")]
    public class T_SYS_AREA
    {
    
        /// <summary>
        /// 区域表ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("区域表ID")]
        public decimal AREA_ID { get; set; }
    
        /// <summary>
        /// 省份ID。1,2,3,4
        /// </summary>
        
        [Description("省份ID。1,2,3,4")]
        public string AREA_PID { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal AREA_CREATEID { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime AREA_DATE { get; set; }
    
        /// <summary>
        /// 修改人ID 
        /// </summary>
        
        [Description("修改人ID ")]
        public decimal AREA_EDITID { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime AREA_EDITDATE { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string AREA_REMARK { get; set; }
    
        /// <summary>
        /// 区域名称
        /// </summary>
        
        [Description("区域名称")]
        public string AREA_NAME { get; set; }
    
        /// <summary>
        /// 逻辑删除
        /// </summary>
        
        [Description("逻辑删除")]
        public string ISLOGIDEL { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal AREA_CID { get; set; }
    }
}
