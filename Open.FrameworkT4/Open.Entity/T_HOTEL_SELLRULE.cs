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
    /// T_HOTEL_SELLRULE 
    /// </summary>    
   [Serializable]
   [SugarTable("T_HOTEL_SELLRULE")]
    public class T_HOTEL_SELLRULE
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal SELLRULE_ID { get; set; }
    
        /// <summary>
        /// 规则名称
        /// </summary>
        
        [Description("规则名称")]
        public string SELLRULE_NAME { get; set; }
    
        /// <summary>
        /// 产品类型（房间：HR，会议室：HB）
        /// </summary>
        
        [Description("产品类型（房间：HR，会议室：HB）")]
        public string SELLRULE_PRODUCTTYPE { get; set; }
    
        /// <summary>
        /// 是否允许超额销售
        /// </summary>
        
        [Description("是否允许超额销售")]
        public string SELLRULE_ISEXCESS { get; set; }
    
        /// <summary>
        /// 是否提供发票
        /// </summary>
        
        [Description("是否提供发票")]
        public string SELLRULE_ISINVOICE { get; set; }
    
        /// <summary>
        /// 支付方式
        /// </summary>
        
        [Description("支付方式")]
        public string SELLRULE_PAYTYPE { get; set; }
    
        /// <summary>
        /// 房客信息包含（姓名，身份证，拼音，邮箱）
        /// </summary>
        
        [Description("房客信息包含（姓名，身份证，拼音，邮箱）")]
        public string SELLRULE_TENANT { get; set; }
    
        /// <summary>
        /// 是否证件票
        /// </summary>
        
        [Description("是否证件票")]
        public string SELLRULE_ISCREDENTIAL { get; set; }
    
        /// <summary>
        /// 证件票类型
        /// </summary>
        
        [Description("证件票类型")]
        public string SELLRULE_CREDENTIALTYPE { get; set; }
    
        /// <summary>
        /// 是否限制到店时间
        /// </summary>
        
        [Description("是否限制到店时间")]
        public string SELLRULE_ISARRIVELIMIT { get; set; }
    
        /// <summary>
        /// 到店时间类型
        /// </summary>
        
        [Description("到店时间类型")]
        public string SELLRULE_ARRIVETIMETYPE { get; set; }
    
        /// <summary>
        /// 是否限制手机预订
        /// </summary>
        
        [Description("是否限制手机预订")]
        public string SELLRULE_ISPHONE { get; set; }
    
        /// <summary>
        /// 手机限制日期类型
        /// </summary>
        
        [Description("手机限制日期类型")]
        public string SELLRULE_PHONEDATE { get; set; }
    
        /// <summary>
        /// 手机限制单位类型（单位，人数）
        /// </summary>
        
        [Description("手机限制单位类型（单位，人数）")]
        public string SELLRULE_PHONETYPE { get; set; }
    
        /// <summary>
        /// 手机限制数量
        /// </summary>
        
        [Description("手机限制数量")]
        public decimal SELLRULE_PHONENUMBER { get; set; }
    
        /// <summary>
        /// 是否限制身份证预订
        /// </summary>
        
        [Description("是否限制身份证预订")]
        public string SELLRULE_ISICNO { get; set; }
    
        /// <summary>
        /// 身份证限制日期类型
        /// </summary>
        
        [Description("身份证限制日期类型")]
        public string SELLRULE_ICNODATE { get; set; }
    
        /// <summary>
        /// 身份证限制单位类型（订单，人数）
        /// </summary>
        
        [Description("身份证限制单位类型（订单，人数）")]
        public string SELLRULE_ICNOTYPE { get; set; }
    
        /// <summary>
        /// 身份证限制数量
        /// </summary>
        
        [Description("身份证限制数量")]
        public decimal SELLRULE_ICNONUMBER { get; set; }
    
        /// <summary>
        /// 是否限制提前预定天数
        /// </summary>
        
        [Description("是否限制提前预定天数")]
        public string SELLRULE_ISADVANCE { get; set; }
    
        /// <summary>
        /// 提前预定天数
        /// </summary>
        
        [Description("提前预定天数")]
        public decimal SELLRULE_ADVANCEDAYS { get; set; }
    
        /// <summary>
        /// 不支付自动取消时间（分钟）
        /// </summary>
        
        [Description("不支付自动取消时间（分钟）")]
        public decimal SELLRULE_AUTOTIME { get; set; }
    
        /// <summary>
        /// 创建人名称
        /// </summary>
        
        [Description("创建人名称")]
        public string SELLRULE_CRENAME { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal SELLRULE_CREID { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime SELLRULE_CREDATE { get; set; }
    
        /// <summary>
        /// 创建人所在机构ID
        /// </summary>
        
        [Description("创建人所在机构ID")]
        public decimal SELLRULE_CREORGID { get; set; }
    
        /// <summary>
        /// 创建人所在机构名称
        /// </summary>
        
        [Description("创建人所在机构名称")]
        public string SELLRULE_CREORGNAME { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal SELLRULE_UPID { get; set; }
    
        /// <summary>
        /// 修改人姓名
        /// </summary>
        
        [Description("修改人姓名")]
        public string SELLRULE_UPNAME { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime SELLRULE_UPDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string SELLRULE_ISDEL { get; set; }
    }
}
