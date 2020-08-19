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
    /// T_BIZ_DISORDER 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_DISORDER")]
    public class T_BIZ_DISORDER
    {
    
        /// <summary>
        /// id
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("id")]
        public decimal DISORDER_ID { get; set; }
    
        /// <summary>
        /// 创建日期
        /// </summary>
        
        [Description("创建日期")]
        public DateTime DISORDER_CREATETIME { get; set; }
    
        /// <summary>
        /// 分销商ID
        /// </summary>
        
        [Description("分销商ID")]
        public decimal DISORDER_DISID { get; set; }
    
        /// <summary>
        /// 分销商名称
        /// </summary>
        
        [Description("分销商名称")]
        public string DISORDER_DISNAME { get; set; }
    
        /// <summary>
        /// 分销单备注
        /// </summary>
        
        [Description("分销单备注")]
        public string DISORDER_REMARK { get; set; }
    
        /// <summary>
        /// 删除标识 F不删除 T已删除
        /// </summary>
        
        [Description("删除标识 F不删除 T已删除")]
        public string DISORDER_DEL { get; set; }
    }
}
