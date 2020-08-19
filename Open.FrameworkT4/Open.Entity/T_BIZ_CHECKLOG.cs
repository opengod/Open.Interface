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
    /// T_BIZ_CHECKLOG 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_CHECKLOG")]
    public class T_BIZ_CHECKLOG
    {
    
        /// <summary>
        /// 核销主键ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("核销主键ID")]
        public decimal CHECKLOG_ID { get; set; }
    
        /// <summary>
        /// 订单号
        /// </summary>
        
        [Description("订单号")]
        public string ORDER_NO { get; set; }
    
        /// <summary>
        /// 订单明细号
        /// </summary>
        
        [Description("订单明细号")]
        public string ORDERITEMS_NO { get; set; }
    
        /// <summary>
        /// 产品类型
        /// </summary>
        
        [Description("产品类型")]
        public string CHECKLOG_PRODUCTTYPE { get; set; }
    
        /// <summary>
        /// 产品ID
        /// </summary>
        
        [Description("产品ID")]
        public decimal CHECKLOG_PRODUCTID { get; set; }
    
        /// <summary>
        /// 产品名称
        /// </summary>
        
        [Description("产品名称")]
        public string CHECKLOG_PRODUCTNAME { get; set; }
    
        /// <summary>
        /// 产品所属机构ID
        /// </summary>
        
        [Description("产品所属机构ID")]
        public decimal CHECKLOG_PROORGID { get; set; }
    
        /// <summary>
        /// 产品所属机构名称
        /// </summary>
        
        [Description("产品所属机构名称")]
        public string CHECKLOG_PROORGNAME { get; set; }
    
        /// <summary>
        /// 订单渠道ID
        /// </summary>
        
        [Description("订单渠道ID")]
        public decimal CHECKLOG_CHANNELID { get; set; }
    
        /// <summary>
        /// 订单渠道名称
        /// </summary>
        
        [Description("订单渠道名称")]
        public string CHECKLOG_CHANNELNAME { get; set; }
    
        /// <summary>
        /// 核销设备ID
        /// </summary>
        
        [Description("核销设备ID")]
        public decimal CHECKLOG_DEVICEID { get; set; }
    
        /// <summary>
        /// 核销设备名称
        /// </summary>
        
        [Description("核销设备名称")]
        public string CHECKLOG_DEVICENAME { get; set; }
    
        /// <summary>
        /// 核销者ID
        /// </summary>
        
        [Description("核销者ID")]
        public decimal CHECKLOG_PEOPLEID { get; set; }
    
        /// <summary>
        /// 核销者名称
        /// </summary>
        
        [Description("核销者名称")]
        public string CHECKLOG_PEOPLENAME { get; set; }
    
        /// <summary>
        /// 核销凭证
        /// </summary>
        
        [Description("核销凭证")]
        public string CHECKLOG_CODE { get; set; }
    
        /// <summary>
        /// 核销时间
        /// </summary>
        
        [Description("核销时间")]
        public DateTime CHECKLOG_TIME { get; set; }
    
        /// <summary>
        /// 核销数量
        /// </summary>
        
        [Description("核销数量")]
        public decimal CHECKLOG_COUNT { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string CHECKLOG_MEMO { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string CHECKLOG_ISDEL { get; set; }
    }
}
