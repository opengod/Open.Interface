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
    /// T_LINE_SELLRULE 
    /// </summary>    
   [Serializable]
   [SugarTable("T_LINE_SELLRULE")]
    public class T_LINE_SELLRULE
    {
    
        /// <summary>
        /// 线路售卖规则主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("线路售卖规则主键")]
        public decimal SELLRULE_ID { get; set; }
    
        /// <summary>
        /// 售卖规则名称
        /// </summary>
        
        [Description("售卖规则名称")]
        public string SELLRULE_NAME { get; set; }
    
        /// <summary>
        /// 是否需要下单人信息
        /// </summary>
        
        [Description("是否需要下单人信息")]
        public string SELLRULE_ISCONTACT { get; set; }
    
        /// <summary>
        /// 下单人信息包含（姓名、拼音、邮箱、地址邮编）
        /// </summary>
        
        [Description("下单人信息包含（姓名、拼音、邮箱、地址邮编）")]
        public string SELLRULE_CONTACT { get; set; }
    
        /// <summary>
        /// 是否需要游客信息
        /// </summary>
        
        [Description("是否需要游客信息")]
        public string SELLRULE_ISVISITOR { get; set; }
    
        /// <summary>
        /// 游客信息包含（姓名、拼音、邮箱、地址邮编）
        /// </summary>
        
        [Description("游客信息包含（姓名、拼音、邮箱、地址邮编）")]
        public string SELLRULE_VISITOR { get; set; }
    
        /// <summary>
        /// 每几人共享一个游客信息
        /// </summary>
        
        [Description("每几人共享一个游客信息")]
        public decimal SELLRULE_VISITORS { get; set; }
    
        /// <summary>
        /// 是否需要证件
        /// </summary>
        
        [Description("是否需要证件")]
        public string SELLRULE_ISIDCARD { get; set; }
    
        /// <summary>
        /// 所需证件类型（身份证、护照、台胞证、港澳通行证）
        /// </summary>
        
        [Description("所需证件类型（身份证、护照、台胞证、港澳通行证）")]
        public string SELLRULE_IDCARDTYPE { get; set; }
    
        /// <summary>
        /// 支付方式
        /// </summary>
        
        [Description("支付方式")]
        public string SELLRULE_PAYTYPE { get; set; }
    
        /// <summary>
        /// 是否需要发票
        /// </summary>
        
        [Description("是否需要发票")]
        public string SELLRULE_ISINVOICE { get; set; }
    
        /// <summary>
        /// 是否限制手机预定
        /// </summary>
        
        [Description("是否限制手机预定")]
        public string SELLRULE_ISPHONE { get; set; }
    
        /// <summary>
        /// 是否限制身份证预定
        /// </summary>
        
        [Description("是否限制身份证预定")]
        public string SELLRULE_ISICNO { get; set; }
    
        /// <summary>
        /// 手机限制日期类型
        /// </summary>
        
        [Description("手机限制日期类型")]
        public string SELLRULE_PHONEDATE { get; set; }
    
        /// <summary>
        /// 身份证限制日期类型
        /// </summary>
        
        [Description("身份证限制日期类型")]
        public string SELLRULE_ICNODATE { get; set; }
    
        /// <summary>
        /// 手机限制数量
        /// </summary>
        
        [Description("手机限制数量")]
        public decimal SELLRULE_PHONENUMBER { get; set; }
    
        /// <summary>
        /// 身份证限制数量
        /// </summary>
        
        [Description("身份证限制数量")]
        public decimal SELLRULE_ICNONUMBER { get; set; }
    
        /// <summary>
        /// 手机限制单位类型（订单、人数）
        /// </summary>
        
        [Description("手机限制单位类型（订单、人数）")]
        public string SELLRULE_PHONETYPE { get; set; }
    
        /// <summary>
        /// 身份证限制单位类型（订单、人数）
        /// </summary>
        
        [Description("身份证限制单位类型（订单、人数）")]
        public string SELLRULE_ICNOTYPE { get; set; }
    
        /// <summary>
        /// 提前预定天数（天）
        /// </summary>
        
        [Description("提前预定天数（天）")]
        public decimal SELLRULE_DAYS { get; set; }
    
        /// <summary>
        /// 提前预定时间(分钟)
        /// </summary>
        
        [Description("提前预定时间(分钟)")]
        public decimal SELLRULE_DATE { get; set; }
    
        /// <summary>
        /// 不支付自动取消时间(分钟)
        /// </summary>
        
        [Description("不支付自动取消时间(分钟)")]
        public decimal SELLRULE_AUTOTIME { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string SELLRULE_MEMO { get; set; }
    
        /// <summary>
        /// 排序
        /// </summary>
        
        [Description("排序")]
        public decimal SELLRULE_SORT { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal SELLRULE_CREID { get; set; }
    
        /// <summary>
        /// 创建人姓名
        /// </summary>
        
        [Description("创建人姓名")]
        public string SELLRULE_CRENAME { get; set; }
    
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
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime SELLRULE_CREDATE { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal SELLRULE_UPID { get; set; }
    
        /// <summary>
        /// 修改人名称
        /// </summary>
        
        [Description("修改人名称")]
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
