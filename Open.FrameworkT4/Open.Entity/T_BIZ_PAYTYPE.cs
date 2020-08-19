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
    /// T_BIZ_PAYTYPE 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_PAYTYPE")]
    public class T_BIZ_PAYTYPE
    {
    
        /// <summary>
        /// 支付类型ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("支付类型ID")]
        public decimal PAYTYPE_ID { get; set; }
    
        /// <summary>
        /// 支付类型
        /// </summary>
        
        [Description("支付类型")]
        public string PAYTYPE_NAME { get; set; }
    
        /// <summary>
        /// 逻辑删除
        /// </summary>
        
        [Description("逻辑删除")]
        public string PAYTYPE_ISLOGIDEL { get; set; }
    
        /// <summary>
        /// 删除人ID
        /// </summary>
        
        [Description("删除人ID")]
        public decimal DELETEBYID { get; set; }
    
        /// <summary>
        /// 删除人姓名
        /// </summary>
        
        [Description("删除人姓名")]
        public string DELETENAME { get; set; }
    
        /// <summary>
        /// 删除日期
        /// </summary>
        
        [Description("删除日期")]
        public DateTime DELETEDATE { get; set; }
    }
}
