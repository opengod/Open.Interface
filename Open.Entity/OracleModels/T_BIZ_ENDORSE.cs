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
    /// T_BIZ_ENDORSE 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_ENDORSE")]
    public class T_BIZ_ENDORSE
    {
    
        /// <summary>
        /// 改签记录ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("改签记录ID")]
        public decimal ENDORSE_ID { get; set; }
    
        /// <summary>
        /// 订单ID
        /// </summary>
        
        [Description("订单ID")]
        public decimal ENDORSE_ORDERID { get; set; }
    
        /// <summary>
        /// 联系人
        /// </summary>
        
        [Description("联系人")]
        public string ENDORSE_CONTRACT { get; set; }
    
        /// <summary>
        /// 联系电话
        /// </summary>
        
        [Description("联系电话")]
        public string ENDORSE_PHONE { get; set; }
    
        /// <summary>
        /// 证件号码
        /// </summary>
        
        [Description("证件号码")]
        public string ENDORSE_ICNO { get; set; }
    
        /// <summary>
        /// 游玩日期
        /// </summary>
        
        [Description("游玩日期")]
        public DateTime ENDORSE_PLAYDATE { get; set; }
    
        /// <summary>
        /// 开始日期
        /// </summary>
        
        [Description("开始日期")]
        public DateTime ENDORSE_STARTDATE { get; set; }
    
        /// <summary>
        /// 结束日期
        /// </summary>
        
        [Description("结束日期")]
        public DateTime ENDORSE_ENDDATE { get; set; }
    
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
    }
}
