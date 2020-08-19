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
    /// T_BIZ_PAYMODE 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_PAYMODE")]
    public class T_BIZ_PAYMODE
    {
    
        /// <summary>
        /// 支付方式ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("支付方式ID")]
        public decimal PAYMODE_ID { get; set; }
    
        /// <summary>
        /// 支付方式名称
        /// </summary>
        
        [Description("支付方式名称")]
        public string PAYMODE_NAME { get; set; }
    
        /// <summary>
        /// 逻辑删除
        /// </summary>
        
        [Description("逻辑删除")]
        public string ISLOGIDEL { get; set; }
    
        /// <summary>
        /// 创建人
        /// </summary>
        
        [Description("创建人")]
        public decimal CREATEBYID { get; set; }
    
        /// <summary>
        /// 创建人名称
        /// </summary>
        
        [Description("创建人名称")]
        public string CREATENAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime CREATEDATE { get; set; }
    
        /// <summary>
        /// 修改人
        /// </summary>
        
        [Description("修改人")]
        public decimal EDITBYID { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime EDITBYDATE { get; set; }
    
        /// <summary>
        /// 修改人名称
        /// </summary>
        
        [Description("修改人名称")]
        public string EDITNAME { get; set; }
    
        /// <summary>
        /// 删除人
        /// </summary>
        
        [Description("删除人")]
        public decimal DELETEBYID { get; set; }
    
        /// <summary>
        /// 删除人名称
        /// </summary>
        
        [Description("删除人名称")]
        public string DELETENAME { get; set; }
    
        /// <summary>
        /// 删除时间
        /// </summary>
        
        [Description("删除时间")]
        public DateTime DELETEDATE { get; set; }
    }
}
