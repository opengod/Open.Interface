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
    /// T_BIZ_AGMT 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_AGMT")]
    public class T_BIZ_AGMT
    {
    
        /// <summary>
        /// 旅行社景区合作协议表ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("旅行社景区合作协议表ID")]
        public decimal AGMT_ID { get; set; }
    
        /// <summary>
        /// 旅行社企业ID
        /// </summary>
        
        [Description("旅行社企业ID")]
        public decimal AGMT_AGENETID { get; set; }
    
        /// <summary>
        /// 景区企业ID
        /// </summary>
        
        [Description("景区企业ID")]
        public decimal AGMT_PARKID { get; set; }
    
        /// <summary>
        /// 合作状态
        /// </summary>
        
        [Description("合作状态")]
        public string AGMT_STATUS { get; set; }
    
        /// <summary>
        /// 协议创建时间
        /// </summary>
        
        [Description("协议创建时间")]
        public DateTime AGMT_CREATEDATE { get; set; }
    
        /// <summary>
        /// 协议周期是否不限
        /// </summary>
        
        [Description("协议周期是否不限")]
        public decimal AGMT_ISLIMIT { get; set; }
    
        /// <summary>
        /// 协议开始日期
        /// </summary>
        
        [Description("协议开始日期")]
        public DateTime AGMT_STARTDATE { get; set; }
    
        /// <summary>
        /// 协议结束日期
        /// </summary>
        
        [Description("协议结束日期")]
        public DateTime AGMT_ENDDATE { get; set; }
    
        /// <summary>
        /// 协议类型
        /// </summary>
        
        [Description("协议类型")]
        public string AGMT_TYPE { get; set; }
    
        /// <summary>
        /// 支付类型ID
        /// </summary>
        
        [Description("支付类型ID")]
        public decimal AGMT_TPAYID { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal AGMT_CREATEID { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime AGMT_CRDATE { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal AGMT_EDITID { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime AGMT_EDITDATE { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string AGMT_REMARK { get; set; }
    
        /// <summary>
        /// 是否逻辑删除 F不删除 T删除
        /// </summary>
        
        [Description("是否逻辑删除 F不删除 T删除")]
        public string AGMT_DEL { get; set; }
    
        /// <summary>
        /// 删除人ID
        /// </summary>
        
        [Description("删除人ID")]
        public decimal AGMT_DELID { get; set; }
    
        /// <summary>
        /// 删除日期
        /// </summary>
        
        [Description("删除日期")]
        public DateTime AGMT_DELDATE { get; set; }
    
        /// <summary>
        /// 删除人姓名
        /// </summary>
        
        [Description("删除人姓名")]
        public string AGMT_DELNAME { get; set; }
    
        /// <summary>
        /// 支付方式 1在线支付 2景区到付 0全部
        /// </summary>
        
        [Description("支付方式 1在线支付 2景区到付 0全部")]
        public decimal AGMT_PAYTYPE { get; set; }
    
        /// <summary>
        /// 结算方式 0立即结算 1定期结算
        /// </summary>
        
        [Description("结算方式 0立即结算 1定期结算")]
        public decimal AGMT_SETTLEMENTTYPE { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string AGMT_ISSALENOWPRODUCT { get; set; }
    
        /// <summary>
        /// F：平台发送；T：OTA发送
        /// </summary>
        
        [Description("F：平台发送；T：OTA发送")]
        public string AGMT_ISPLANTSEND { get; set; }
    }
}
