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
    /// T_HOTEL_ADVANCE 
    /// </summary>    
   [Serializable]
   [SugarTable("T_HOTEL_ADVANCE")]
    public class T_HOTEL_ADVANCE
    {
    
        /// <summary>
        /// 主键ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键ID")]
        public decimal ADVANCE_ID { get; set; }
    
        /// <summary>
        /// 是否预付款
        /// </summary>
        
        [Description("是否预付款")]
        public string ADVANCE_ISOPEN { get; set; }
    
        /// <summary>
        /// 预付金额类别(P百分比，F金额)
        /// </summary>
        
        [Description("预付金额类别(P百分比，F金额)")]
        public string ADVANCE_PRICETYPE { get; set; }
    
        /// <summary>
        /// 金额
        /// </summary>
        
        [Description("金额")]
        public decimal ADVANCE_PRICE { get; set; }
    
        /// <summary>
        /// 预付百分比
        /// </summary>
        
        [Description("预付百分比")]
        public decimal ADVANCE_PERCENT { get; set; }
    
        /// <summary>
        /// 预付描述
        /// </summary>
        
        [Description("预付描述")]
        public string ADVANCE_DESCRIBE { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string ADVANCE_MEMO { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal ADVANCE_CREID { get; set; }
    
        /// <summary>
        /// 创建人姓名
        /// </summary>
        
        [Description("创建人姓名")]
        public string ADVANCE_CRENAME { get; set; }
    
        /// <summary>
        /// 创建人所在机构ID
        /// </summary>
        
        [Description("创建人所在机构ID")]
        public decimal ADVANCE_CREORGID { get; set; }
    
        /// <summary>
        /// 创建人所在机构名称
        /// </summary>
        
        [Description("创建人所在机构名称")]
        public string ADVANCE_CREORGNAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime ADVANCE_CREDATE { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal ADVANCE_UPID { get; set; }
    
        /// <summary>
        /// 修改人名称
        /// </summary>
        
        [Description("修改人名称")]
        public string ADVANCE_UPNAME { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime ADVANCE_UPDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string ADVANCE_ISDEL { get; set; }
    }
}
