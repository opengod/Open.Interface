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
    /// T_BIZ_PDT_TYPE 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_PDT_TYPE")]
    public class T_BIZ_PDT_TYPE
    {
    
        /// <summary>
        /// 门票类型ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("门票类型ID")]
        public decimal PDT_TYPE_ID { get; set; }
    
        /// <summary>
        /// 门票类型名称
        /// </summary>
        
        [Description("门票类型名称")]
        public string PDT_TYPE_NAME { get; set; }
    
        /// <summary>
        /// 逻辑删除
        /// </summary>
        
        [Description("逻辑删除")]
        public string PDT_TYPE_ISLOGIDEL { get; set; }
    
        /// <summary>
        /// 删除人ID
        /// </summary>
        
        [Description("删除人ID")]
        public decimal PDT_TYPE_DELID { get; set; }
    
        /// <summary>
        /// 套餐结算价
        /// </summary>
        
        [Description("套餐结算价")]
        public string PDT_TYPE_DELNAME { get; set; }
    
        /// <summary>
        /// 删除日期时间
        /// </summary>
        
        [Description("删除日期时间")]
        public DateTime PDT_TYPE_DELDATE { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal PDT_TYPE_CTID { get; set; }
    
        /// <summary>
        /// 创建人姓名
        /// </summary>
        
        [Description("创建人姓名")]
        public string PDT_TYPE_CTNAME { get; set; }
    
        /// <summary>
        /// 创建日期时间
        /// </summary>
        
        [Description("创建日期时间")]
        public DateTime PDT_TYPE_CTDATE { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal PDT_TYPE_ETID { get; set; }
    
        /// <summary>
        /// 修改人姓名
        /// </summary>
        
        [Description("修改人姓名")]
        public string PDT_TYPE_ETNAME { get; set; }
    
        /// <summary>
        /// 修改日期时间
        /// </summary>
        
        [Description("修改日期时间")]
        public DateTime PDT_TYPE_ETDATE { get; set; }
    }
}
