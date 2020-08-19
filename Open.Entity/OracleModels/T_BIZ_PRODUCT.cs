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
    /// T_BIZ_PRODUCT 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_PRODUCT")]
    public class T_BIZ_PRODUCT
    {
    
        /// <summary>
        /// 产品ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("产品ID")]
        public decimal PRODUCT_ID { get; set; }
    
        /// <summary>
        /// 景区ID
        /// </summary>
        
        [Description("景区ID")]
        public decimal PRODUCT_PARKID { get; set; }
    
        /// <summary>
        /// 景点名称
        /// </summary>
        
        [Description("景点名称")]
        public string PRODUCT_PARKNAME { get; set; }
    
        /// <summary>
        /// 产品编码
        /// </summary>
        
        [Description("产品编码")]
        public string PRODUCT_CODE { get; set; }
    
        /// <summary>
        /// 中文名称
        /// </summary>
        
        [Description("中文名称")]
        public string PRODUCT_CNNAME { get; set; }
    
        /// <summary>
        /// 英文名称
        /// </summary>
        
        [Description("英文名称")]
        public string PRODUCT_ENNAME { get; set; }
    
        /// <summary>
        /// 打印备注中文
        /// </summary>
        
        [Description("打印备注中文")]
        public string PRODUCT_PRTCN { get; set; }
    
        /// <summary>
        /// 打印备注英文
        /// </summary>
        
        [Description("打印备注英文")]
        public string PRODUCT_PRTEN { get; set; }
    
        /// <summary>
        /// 线上售卖价
        /// </summary>
        
        [Description("线上售卖价")]
        public decimal PRODUCT_BSPRICE { get; set; }
    
        /// <summary>
        /// 票面单价
        /// </summary>
        
        [Description("票面单价")]
        public decimal PRODUCT_PRICE { get; set; }
    
        /// <summary>
        /// 折扣状态
        /// </summary>
        
        [Description("折扣状态")]
        public decimal PRODUCT_DISTSTATUS { get; set; }
    
        /// <summary>
        /// 分销价格，原折扣金额
        /// </summary>
        
        [Description("分销价格，原折扣金额")]
        public decimal PRODUCT_DISTOUNT { get; set; }
    
        /// <summary>
        /// 折扣率
        /// </summary>
        
        [Description("折扣率")]
        public decimal PRODUCT_DISTTRATE { get; set; }
    
        /// <summary>
        /// 产品上架日期
        /// </summary>
        
        [Description("产品上架日期")]
        public DateTime PRODUCT_UPDAY { get; set; }
    
        /// <summary>
        /// 产品下架日期
        /// </summary>
        
        [Description("产品下架日期")]
        public DateTime PRODUCT_DNDAY { get; set; }
    
        /// <summary>
        /// 产品上架时间
        /// </summary>
        
        [Description("产品上架时间")]
        public string PRODUCT_UPTIME { get; set; }
    
        /// <summary>
        /// 产品下架时间
        /// </summary>
        
        [Description("产品下架时间")]
        public string PRODUCT_DNTIME { get; set; }
    
        /// <summary>
        /// 提前几天可售
        /// </summary>
        
        [Description("提前几天可售")]
        public decimal PRODUCT_FEWDAY { get; set; }
    
        /// <summary>
        /// 是否可退1是可退，0是不可退
        /// </summary>
        
        [Description("是否可退1是可退，0是不可退")]
        public decimal PRODUCT_BACKFLAG { get; set; }
    
        /// <summary>
        /// 退票费用状态0是退票没费用1是固定值2是退票率
        /// </summary>
        
        [Description("退票费用状态0是退票没费用1是固定值2是退票率")]
        public decimal PRODUCT_BACKSTATUS { get; set; }
    
        /// <summary>
        /// 退票费用
        /// </summary>
        
        [Description("退票费用")]
        public decimal PRODUCT_BACKFESS { get; set; }
    
        /// <summary>
        /// 退款费率
        /// </summary>
        
        [Description("退款费率")]
        public decimal PRODUCT_BACKRATE { get; set; }
    
        /// <summary>
        /// 过期可退
        /// </summary>
        
        [Description("过期可退")]
        public decimal PRODUCT_EXPFALG { get; set; }
    
        /// <summary>
        /// 过期可退天数
        /// </summary>
        
        [Description("过期可退天数")]
        public decimal PRODUCT_EXPDAY { get; set; }
    
        /// <summary>
        /// 门票人数
        /// </summary>
        
        [Description("门票人数")]
        public decimal PRODUCT_PCOUNT { get; set; }
    
        /// <summary>
        /// 门票状态(0:正常1暂停2作废)
        /// </summary>
        
        [Description("门票状态(0:正常1暂停2作废)")]
        public decimal PRODUCT_STATUS { get; set; }
    
        /// <summary>
        /// 是否同步至线下（0:未同步，1：已同步）
        /// </summary>
        
        [Description("是否同步至线下（0:未同步，1：已同步）")]
        public decimal PRODUCT_ISFLAG { get; set; }
    
        /// <summary>
        /// 线下编码
        /// </summary>
        
        [Description("线下编码")]
        public string PRODUCT_OFFLCODE { get; set; }
    
        /// <summary>
        /// 限定开始年龄
        /// </summary>
        
        [Description("限定开始年龄")]
        public decimal PRODUCT_AGEST { get; set; }
    
        /// <summary>
        /// 限定结束年龄
        /// </summary>
        
        [Description("限定结束年龄")]
        public decimal PRODUCT_AGEED { get; set; }
    
        /// <summary>
        /// 是否需要预约，原限定男女
        /// </summary>
        
        [Description("是否需要预约，原限定男女")]
        public decimal PRODUCT_SEX { get; set; }
    
        /// <summary>
        /// 是否限定区域售卖0是不限定1是限定
        /// </summary>
        
        [Description("是否限定区域售卖0是不限定1是限定")]
        public decimal PRODUCT_LMTAREA { get; set; }
    
        /// <summary>
        /// 产品组别ID
        /// </summary>
        
        [Description("产品组别ID")]
        public decimal PRODUCT_GRPID { get; set; }
    
        /// <summary>
        /// 门票类型ID
        /// </summary>
        
        [Description("门票类型ID")]
        public decimal PRODUCT_TYPEID { get; set; }
    
        /// <summary>
        /// 退票是否需要审核0不需审核1需要审核
        /// </summary>
        
        [Description("退票是否需要审核0不需审核1需要审核")]
        public decimal PRODUCT_AUDIT { get; set; }
    
        /// <summary>
        /// 退票审核状态（0：未审核，1：已审核）
        /// </summary>
        
        [Description("退票审核状态（0：未审核，1：已审核）")]
        public decimal PRODUCT_AUDITSATUS { get; set; }
    
        /// <summary>
        /// 逻辑删除
        /// </summary>
        
        [Description("逻辑删除")]
        public string PRODUCT_ISLOGIDEL { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime PRODUCT_CREATEDATE { get; set; }
    
        /// <summary>
        /// 创建人
        /// </summary>
        
        [Description("创建人")]
        public decimal PRODUCT_CREATEID { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime PRODUCT_EDITDATE { get; set; }
    
        /// <summary>
        /// 修改人
        /// </summary>
        
        [Description("修改人")]
        public decimal PRODUCT_EDTID { get; set; }
    
        /// <summary>
        /// 删除人ID
        /// </summary>
        
        [Description("删除人ID")]
        public decimal PRODUCT_DELID { get; set; }
    
        /// <summary>
        /// 删除人姓名
        /// </summary>
        
        [Description("删除人姓名")]
        public string PRODUCT_DELNAME { get; set; }
    
        /// <summary>
        /// 删除时间
        /// </summary>
        
        [Description("删除时间")]
        public DateTime PRODUCT_DELDATE { get; set; }
    
        /// <summary>
        /// 企业名称
        /// </summary>
        
        [Description("企业名称")]
        public string PRODUCT_COMPANYNA { get; set; }
    
        /// <summary>
        /// 企业ID
        /// </summary>
        
        [Description("企业ID")]
        public decimal PRODUCT_COMPANYID { get; set; }
    
        /// <summary>
        /// 创建企业ID
        /// </summary>
        
        [Description("创建企业ID")]
        public decimal PRODUCT_COMPCID { get; set; }
    
        /// <summary>
        /// 创建企业名称
        /// </summary>
        
        [Description("创建企业名称")]
        public string PRODUCT_COMPCNA { get; set; }
    
        /// <summary>
        /// 是否是剧场票(2：一般票；1：剧场票)
        /// </summary>
        
        [Description("是否是剧场票(2：一般票；1：剧场票)")]
        public string PRODUCT_ISTHEATRE { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal PRODUCT_OFFPLACEID { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal PRODUCT_ISB2C { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string PRODUCT_ISTIME { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal PRODUCT_HOUR { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal PRODUCT_MINUTE { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal PRODUCT_SECOND { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string PRODUCT_ISCOUPON { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal PRODUCT_PERIOD { get; set; }
    
        /// <summary>
        /// 结算价
        /// </summary>
        
        [Description("结算价")]
        public decimal PRODUCT_SETTLEPRICE { get; set; }
    }
}
