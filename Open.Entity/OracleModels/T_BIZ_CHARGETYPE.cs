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
    /// T_BIZ_CHARGETYPE 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_CHARGETYPE")]
    public class T_BIZ_CHARGETYPE
    {
    
        /// <summary>
        /// 充值类型ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("充值类型ID")]
        public decimal CHARGETYPE_ID { get; set; }
    
        /// <summary>
        /// 充值类型名称
        /// </summary>
        
        [Description("充值类型名称")]
        public string CHARGETYPE_NAME { get; set; }
    
        /// <summary>
        /// 逻辑删除
        /// </summary>
        
        [Description("逻辑删除")]
        public string CHARGETYPE_DEL { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal CHARGETYPE_CREATEBYID { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime CHARGETYPE_CREATEDATE { get; set; }
    
        /// <summary>
        /// 创建人名称
        /// </summary>
        
        [Description("创建人名称")]
        public string CHARGETYPE_CREATENAME { get; set; }
    
        /// <summary>
        /// 修改人
        /// </summary>
        
        [Description("修改人")]
        public decimal CHARGETYPE_EDITBYID { get; set; }
    
        /// <summary>
        /// 修改人名称
        /// </summary>
        
        [Description("修改人名称")]
        public string CHARGETYPE_EDITBYNAME { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime CHARGETYPE_EDITDATE { get; set; }
    
        /// <summary>
        /// 删除人
        /// </summary>
        
        [Description("删除人")]
        public decimal CHARGETYPE_DELETEBYID { get; set; }
    
        /// <summary>
        /// 删除人名称
        /// </summary>
        
        [Description("删除人名称")]
        public string CHARGETYPE_DELETEBYNAME { get; set; }
    
        /// <summary>
        /// 删除时间
        /// </summary>
        
        [Description("删除时间")]
        public DateTime CHARGETYPE_DELETEDATE { get; set; }
    }
}
