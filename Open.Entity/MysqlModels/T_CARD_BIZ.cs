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
    /// T_CARD_BIZ 
    /// </summary>    
   [Serializable]
   [SugarTable("T_CARD_BIZ")]
    public class T_CARD_BIZ
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal CARD_ID { get; set; }
    
        /// <summary>
        /// 旅游通卡编码
        /// </summary>
        
        [Description("旅游通卡编码")]
        public string CARD_CODE { get; set; }
    
        /// <summary>
        /// 名称
        /// </summary>
        
        [Description("名称")]
        public string CARD_NAME { get; set; }
    
        /// <summary>
        /// 支付方式1：在线支付，2：只展示不支付
        /// </summary>
        
        [Description("支付方式1：在线支付，2：只展示不支付")]
        public string CARD_PAYTYPE { get; set; }
    
        /// <summary>
        /// 使用规则
        /// </summary>
        
        [Description("使用规则")]
        public string CARD_RULE { get; set; }
    
        /// <summary>
        /// 通卡介绍
        /// </summary>
        
        [Description("通卡介绍")]
        public string CARD_INFO { get; set; }
    
        /// <summary>
        /// 购买须知
        /// </summary>
        
        [Description("购买须知")]
        public string CARD_BUYNOTE { get; set; }
    
        /// <summary>
        /// 是否推荐
        /// </summary>
        
        [Description("是否推荐")]
        public string CARD_ISHOT { get; set; }
    
        /// <summary>
        /// 有效期限：半年、一年、两年
        /// </summary>
        
        [Description("有效期限：半年、一年、两年")]
        public string CARD_VALIDDATE { get; set; }
    
        /// <summary>
        /// 市场价
        /// </summary>
        
        [Description("市场价")]
        public decimal CARD_MARKETPRICE { get; set; }
    
        /// <summary>
        /// 售卖价
        /// </summary>
        
        [Description("售卖价")]
        public decimal CARD_INPRICE { get; set; }
    
        /// <summary>
        /// 结算价
        /// </summary>
        
        [Description("结算价")]
        public decimal CARD_PRICE { get; set; }
    
        /// <summary>
        /// 景区个数
        /// </summary>
        
        [Description("景区个数")]
        public decimal CARD_PARKNUM { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string CARD_MEMO { get; set; }
    
        /// <summary>
        /// 排序
        /// </summary>
        
        [Description("排序")]
        public decimal CARD_SORT { get; set; }
    
        /// <summary>
        /// 客服人员或负责人电话
        /// </summary>
        
        [Description("客服人员或负责人电话")]
        public string CARD_CUSTOMERPHNOE { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal CARD_CREID { get; set; }
    
        /// <summary>
        /// 创建人姓名
        /// </summary>
        
        [Description("创建人姓名")]
        public string CARD_CRENAME { get; set; }
    
        /// <summary>
        /// 创建人所在机构ID
        /// </summary>
        
        [Description("创建人所在机构ID")]
        public decimal CARD_CREORGID { get; set; }
    
        /// <summary>
        /// 创建人所在机构名称
        /// </summary>
        
        [Description("创建人所在机构名称")]
        public string CARD_CREORGNAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime CARD_CREDATE { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal CARD_UPID { get; set; }
    
        /// <summary>
        /// 修改人名称
        /// </summary>
        
        [Description("修改人名称")]
        public string CARD_UPNAME { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime CARD_UPDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string CARD_ISDEL { get; set; }
    }
}
