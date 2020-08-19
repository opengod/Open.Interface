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
    /// PAY_ORDERS 
    /// </summary>    
   [Serializable]
   [SugarTable("PAY_ORDERS")]
    public class PAY_ORDERS
    {
    
        /// <summary>
        /// a
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("a")]
        public decimal ORDER_ID { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string ORDER_NO { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string ORDER_TRADE_NO { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string ORDER_PAY_TYPE { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string ORDER_NAME { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal ORDER_MONEY { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string ORDER_STATUS { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string MERCHANTS_APPID { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string MERCHANTS_FILENAME { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal ORDER_REFUND { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string GOODSDETAILS { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string TRANS_DATE { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string UPDATE_DATE { get; set; }
    }
}
