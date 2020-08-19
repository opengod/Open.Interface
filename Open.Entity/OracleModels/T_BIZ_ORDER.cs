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
    /// T_BIZ_ORDER 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_ORDER")]
    public class T_BIZ_ORDER
    {
    
        /// <summary>
        /// 订单ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("订单ID")]
        public decimal ORDER_ID { get; set; }
    
        /// <summary>
        /// 订单号
        /// </summary>
        
        [Description("订单号")]
        public string ORDER_NO { get; set; }
    
        /// <summary>
        /// 外部订单ID
        /// </summary>
        
        [Description("外部订单ID")]
        public string ORDER_EXTERNALID { get; set; }
    
        /// <summary>
        /// 外部订单描述
        /// </summary>
        
        [Description("外部订单描述")]
        public string ORDER_EXTERNALDESC { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime ORDER_CREATETIME { get; set; }
    
        /// <summary>
        /// OTA旅行社ID
        /// </summary>
        
        [Description("OTA旅行社ID")]
        public decimal ORDER_OTAID { get; set; }
    
        /// <summary>
        /// OTA旅行社名称
        /// </summary>
        
        [Description("OTA旅行社名称")]
        public string ORDER_OTANAME { get; set; }
    
        /// <summary>
        /// 退票总金额
        /// </summary>
        
        [Description("退票总金额")]
        public decimal ORDER_BACKAMOUNT { get; set; }
    
        /// <summary>
        /// 检票金额
        /// </summary>
        
        [Description("检票金额")]
        public decimal ORDER_CHECKAMOUNT { get; set; }
    
        /// <summary>
        /// 订单金额
        /// </summary>
        
        [Description("订单金额")]
        public decimal ORDER_AMOUNT { get; set; }
    
        /// <summary>
        /// 订单人的姓名
        /// </summary>
        
        [Description("订单人的姓名")]
        public string ORDER_NAME { get; set; }
    
        /// <summary>
        /// 订单人的手机
        /// </summary>
        
        [Description("订单人的手机")]
        public string ORDER_PHONE { get; set; }
    
        /// <summary>
        /// 订单人的身份证
        /// </summary>
        
        [Description("订单人的身份证")]
        public string ORDER_ICNO { get; set; }
    
        /// <summary>
        /// 订单备注
        /// </summary>
        
        [Description("订单备注")]
        public string ORDER_REMARK { get; set; }
    
        /// <summary>
        /// 支付时间
        /// </summary>
        
        [Description("支付时间")]
        public DateTime ORDER_PAYTIME { get; set; }
    
        /// <summary>
        /// 逻辑删除
        /// </summary>
        
        [Description("逻辑删除")]
        public string ISLOGIDEL { get; set; }
    
        /// <summary>
        /// 邮箱
        /// </summary>
        
        [Description("邮箱")]
        public string ORDER_EMAIL { get; set; }
    
        /// <summary>
        /// 地址
        /// </summary>
        
        [Description("地址")]
        public string ORDER_ADDRESS { get; set; }
    
        /// <summary>
        /// 银行流水号
        /// </summary>
        
        [Description("银行流水号")]
        public string ORDER_PAYNO { get; set; }
    
        /// <summary>
        /// 去哪网发码回调标识0是未回调1是回调成功
        /// </summary>
        
        [Description("去哪网发码回调标识0是未回调1是回调成功")]
        public decimal ORDER_SENDQUNAFLAG { get; set; }
    }
}
