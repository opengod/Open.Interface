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
    /// T_BIZ_TWBTRN 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_TWBTRN")]
    public class T_BIZ_TWBTRN
    {
    
        /// <summary>
        /// 检票信息ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("检票信息ID")]
        public decimal TWBTRN_ID { get; set; }
    
        /// <summary>
        /// 检票时间
        /// </summary>
        
        [Description("检票时间")]
        public DateTime TWBTRN_DATE { get; set; }
    
        /// <summary>
        /// 检票订单号
        /// </summary>
        
        [Description("检票订单号")]
        public string TWBTRN_ORDERCODE { get; set; }
    
        /// <summary>
        /// 产品ID
        /// </summary>
        
        [Description("产品ID")]
        public decimal TICKET_ID { get; set; }
    
        /// <summary>
        /// 闸机ID
        /// </summary>
        
        [Description("闸机ID")]
        public decimal TWBTRN_TERMINALID { get; set; }
    
        /// <summary>
        /// 检票人
        /// </summary>
        
        [Description("检票人")]
        public decimal TWBTRN_PEOPLEID { get; set; }
    
        /// <summary>
        /// 串码
        /// </summary>
        
        [Description("串码")]
        public string TWBTRN_IDCODE { get; set; }
    
        /// <summary>
        /// 景区ID
        /// </summary>
        
        [Description("景区ID")]
        public decimal TWBTRN_PARKID { get; set; }
    
        /// <summary>
        /// 订单明细ID
        /// </summary>
        
        [Description("订单明细ID")]
        public decimal ORDERITEMS_ID { get; set; }
    
        /// <summary>
        /// 逻辑删除
        /// </summary>
        
        [Description("逻辑删除")]
        public string ISLOGIDEL { get; set; }
    
        /// <summary>
        /// 去哪网更新标记0是未更新1是更新
        /// </summary>
        
        [Description("去哪网更新标记0是未更新1是更新")]
        public decimal TWBTRN_QUNAFLAG { get; set; }
    
        /// <summary>
        /// 检票人数
        /// </summary>
        
        [Description("检票人数")]
        public decimal TWBTRN_COUNT { get; set; }
    
        /// <summary>
        /// OTA的ID
        /// </summary>
        
        [Description("OTA的ID")]
        public decimal TWB_OTAID { get; set; }
    }
}
