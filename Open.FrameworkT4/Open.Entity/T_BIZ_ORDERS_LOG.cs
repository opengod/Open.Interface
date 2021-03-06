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
    /// T_BIZ_ORDERS_LOG 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_ORDERS_LOG")]
    public class T_BIZ_ORDERS_LOG
    {
    
        /// <summary>
        /// id
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("id")]
        public decimal LOGID { get; set; }
    
        /// <summary>
        /// 订单号
        /// </summary>
        
        [Description("订单号")]
        public string ORDER_NO { get; set; }
    
        /// <summary>
        /// 操作形式
        /// </summary>
        
        [Description("操作形式")]
        public string OPTACTION { get; set; }
    
        /// <summary>
        /// 操作人
        /// </summary>
        
        [Description("操作人")]
        public decimal USER_ID { get; set; }
    
        /// <summary>
        /// 操作时间
        /// </summary>
        
        [Description("操作时间")]
        public DateTime ORDERS_DATE { get; set; }
    
        /// <summary>
        /// 逻辑删除
        /// </summary>
        
        [Description("逻辑删除")]
        public string ORDERS_DEL { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string MEMO { get; set; }
    }
}
