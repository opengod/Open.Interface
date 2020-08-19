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
    /// T_BIZ_TORDER 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_TORDER")]
    public class T_BIZ_TORDER
    {
    
        /// <summary>
        /// 订单ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("订单ID")]
        public decimal TORDER_ID { get; set; }
    
        /// <summary>
        /// otaid
        /// </summary>
        
        [Description("otaid")]
        public decimal TORDER_OTAID { get; set; }
    
        /// <summary>
        /// 订单号
        /// </summary>
        
        [Description("订单号")]
        public string TORDER_NO { get; set; }
    
        /// <summary>
        /// 订单日期
        /// </summary>
        
        [Description("订单日期")]
        public DateTime TORDER_CDATE { get; set; }
    
        /// <summary>
        /// 下单人姓名
        /// </summary>
        
        [Description("下单人姓名")]
        public string TORDER_NAME { get; set; }
    
        /// <summary>
        /// 下单人手机号
        /// </summary>
        
        [Description("下单人手机号")]
        public string TORDER_PHONE { get; set; }
    
        /// <summary>
        /// 游玩日期
        /// </summary>
        
        [Description("游玩日期")]
        public DateTime TORDER_PDATE { get; set; }
    
        /// <summary>
        /// 是否支付 0未支付 1已支付
        /// </summary>
        
        [Description("是否支付 0未支付 1已支付")]
        public decimal TORDER_ISPAY { get; set; }
    
        /// <summary>
        /// 是否已同步 0未同步1已同步
        /// </summary>
        
        [Description("是否已同步 0未同步1已同步")]
        public decimal TORDER_ISOUT { get; set; }
    
        /// <summary>
        /// 是否审核 0未审核 1已审核 3已完成
        /// </summary>
        
        [Description("是否审核 0未审核 1已审核 3已完成")]
        public decimal TORDER_ISCHECK { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string TORDER_REMARK { get; set; }
    
        /// <summary>
        /// 支付类型 D定存 F到付
        /// </summary>
        
        [Description("支付类型 D定存 F到付")]
        public string TORDER_PAYTYPE { get; set; }
    
        /// <summary>
        /// 景区ID
        /// </summary>
        
        [Description("景区ID")]
        public decimal TORDER_PARKID { get; set; }
    
        /// <summary>
        /// 审核人id
        /// </summary>
        
        [Description("审核人id")]
        public decimal TORDER_CHECKUSERID { get; set; }
    
        /// <summary>
        /// 审核人名称
        /// </summary>
        
        [Description("审核人名称")]
        public string TORDER_CHECKUSERNAME { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public DateTime TORDER_ETIME { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string TORDER_EUSER { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public DateTime TORDER_BTIME { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string TORDER_BUSER { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string TORDER_SEALERID { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string TORDER_OWNERID { get; set; }
    }
}
