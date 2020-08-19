//-----------------------------------------------------------------------
// <Copyright>
// * copyright © 2020 open All Rights Reserved
// * version : 4.0.30319.42000
// * author  : open
// * history : Created by open 2020-08-19 11:20:13 
// </Copyright>
//-----------------------------------------------------------------------
using System;
using SqlSugar;
using System.ComponentModel;

namespace Open.Entity.Mysql
{
    /// <summary>
    /// T_LINE_ORDER 
    /// </summary>    
   [Serializable]
   [SugarTable("T_LINE_ORDER")]
    public class T_LINE_ORDER
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal LINEORDER_ID { get; set; }
    
        /// <summary>
        /// 线路订单号
        /// </summary>
        
        [Description("线路订单号")]
        public string LINEORDER_ORDERNO { get; set; }
    
        /// <summary>
        /// 线路ID
        /// </summary>
        
        [Description("线路ID")]
        public decimal LINEORDER_LINEID { get; set; }
    
        /// <summary>
        /// 线路编号
        /// </summary>
        
        [Description("线路编号")]
        public string LINEORDER_LINECODE { get; set; }
    
        /// <summary>
        /// 线路名称
        /// </summary>
        
        [Description("线路名称")]
        public string LINEORDER_LINENAME { get; set; }
    
        /// <summary>
        /// 订单标识符
        /// </summary>
        
        [Description("订单标识符")]
        public string LINEORDER_FLAG { get; set; }
    
        /// <summary>
        /// 订单人姓名
        /// </summary>
        
        [Description("订单人姓名")]
        public string LINEORDER_NAME { get; set; }
    
        /// <summary>
        /// 订单人手机号
        /// </summary>
        
        [Description("订单人手机号")]
        public string LINEORDER_TEL { get; set; }
    
        /// <summary>
        /// 订单人身份证
        /// </summary>
        
        [Description("订单人身份证")]
        public string LINEORDER_ICNO { get; set; }
    
        /// <summary>
        /// 支付方式
        /// </summary>
        
        [Description("支付方式")]
        public DateTime LINEORDER_PAYTYPE { get; set; }
    
        /// <summary>
        /// 下单时间
        /// </summary>
        
        [Description("下单时间")]
        public DateTime LINEORDER_CREATTIME { get; set; }
    
        /// <summary>
        /// 是否包团
        /// </summary>
        
        [Description("是否包团")]
        public string LINEORDER_ISTEAM { get; set; }
    
        /// <summary>
        /// 成团人数
        /// </summary>
        
        [Description("成团人数")]
        public decimal LINEORDER_TEAMPEO { get; set; }
    
        /// <summary>
        /// 游客人数
        /// </summary>
        
        [Description("游客人数")]
        public decimal LINEORDER_VISITORPEO { get; set; }
    
        /// <summary>
        /// 订单总金额
        /// </summary>
        
        [Description("订单总金额")]
        public decimal LINEORDER_AMOUNT { get; set; }
    
        /// <summary>
        /// 线路单价
        /// </summary>
        
        [Description("线路单价")]
        public decimal LINEORDER_PRICE { get; set; }
    
        /// <summary>
        /// 开始日期
        /// </summary>
        
        [Description("开始日期")]
        public DateTime LINEORDER_STARTDAY { get; set; }
    
        /// <summary>
        /// 结束日期
        /// </summary>
        
        [Description("结束日期")]
        public DateTime LINEORDER_ENDDAY { get; set; }
    
        /// <summary>
        /// 订单状态
        /// </summary>
        
        [Description("订单状态")]
        public string LINEORDER_STATUS { get; set; }
    
        /// <summary>
        /// 支付状态
        /// </summary>
        
        [Description("支付状态")]
        public string LINEORDER_PAYSTATUS { get; set; }
    
        /// <summary>
        /// 支付交易号
        /// </summary>
        
        [Description("支付交易号")]
        public string LINEORDER_PAYNO { get; set; }
    
        /// <summary>
        /// 退款时间
        /// </summary>
        
        [Description("退款时间")]
        public DateTime LINEORDER_REFUNDTIME { get; set; }
    
        /// <summary>
        /// 退款人数
        /// </summary>
        
        [Description("退款人数")]
        public decimal LINEORDER_REFUNDPEO { get; set; }
    
        /// <summary>
        /// 退款金额
        /// </summary>
        
        [Description("退款金额")]
        public decimal LINEORDER_REFUNDAMOUNT { get; set; }
    
        /// <summary>
        /// 退款交易号
        /// </summary>
        
        [Description("退款交易号")]
        public string LINEORDER_REFUNDNO { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string LINEORDER_ISDEL { get; set; }
    }
}
