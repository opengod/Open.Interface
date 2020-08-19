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
    /// T_BIZ_COUPONPRO 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_COUPONPRO")]
    public class T_BIZ_COUPONPRO
    {
    
        /// <summary>
        /// 优惠券产品表主键ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("优惠券产品表主键ID")]
        public decimal COUPONPRO_ID { get; set; }
    
        /// <summary>
        /// 编码
        /// </summary>
        
        [Description("编码")]
        public string COUPONPRO_CODE { get; set; }
    
        /// <summary>
        /// 名称
        /// </summary>
        
        [Description("名称")]
        public string COUPONPRO_NAME { get; set; }
    
        /// <summary>
        /// 对应字典表活动类型
        /// </summary>
        
        [Description("对应字典表活动类型")]
        public string COUPONPRO_TYPE { get; set; }
    
        /// <summary>
        /// 优惠金额/折扣
        /// </summary>
        
        [Description("优惠金额/折扣")]
        public decimal COUPONPRO_DISPRICE { get; set; }
    
        /// <summary>
        /// 是否启用
        /// </summary>
        
        [Description("是否启用")]
        public string COUPONPRO_ISENABLE { get; set; }
    
        /// <summary>
        /// 有效开始时间
        /// </summary>
        
        [Description("有效开始时间")]
        public DateTime COUPONPRO_DATES { get; set; }
    
        /// <summary>
        /// 有效结束时间
        /// </summary>
        
        [Description("有效结束时间")]
        public DateTime COUPONPRO_DATEE { get; set; }
    
        /// <summary>
        /// 对应字典表活动类型（P景点，L线路，R餐饮，H酒店，E休闲娱乐，B商品，C旅游通卡，T通用券）
        /// </summary>
        
        [Description("对应字典表活动类型（P景点，L线路，R餐饮，H酒店，E休闲娱乐，B商品，C旅游通卡，T通用券）")]
        public string COUPONPRO_ORGTYPE { get; set; }
    
        /// <summary>
        /// 优惠券所属景区ID
        /// </summary>
        
        [Description("优惠券所属景区ID")]
        public decimal COUPONPRO_ORG { get; set; }
    
        /// <summary>
        /// 所属产品id（门票、房间、旅游卡等）
        /// </summary>
        
        [Description("所属产品id（门票、房间、旅游卡等）")]
        public decimal COUPONPRO_PRODUCTID { get; set; }
    
        /// <summary>
        /// 所属产品名称（门票、房间、旅游卡等）
        /// </summary>
        
        [Description("所属产品名称（门票、房间、旅游卡等）")]
        public string COUPONPRO_PRODUCTNAME { get; set; }
    
        /// <summary>
        /// 是否参加此次高校优惠活动 T:是 F：否
        /// </summary>
        
        [Description("是否参加此次高校优惠活动 T:是 F：否")]
        public string COUPONPRO_ISENTER { get; set; }
    
        /// <summary>
        /// 打折还是满减  D：打折  M：满减
        /// </summary>
        
        [Description("打折还是满减  D：打折  M：满减")]
        public string COUPONPRO_ISDISCOUNT { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string COUPONPRO_MEMO { get; set; }
    
        /// <summary>
        /// 排序
        /// </summary>
        
        [Description("排序")]
        public decimal COUPONPRO_SORT { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal COUPONPRO_CREID { get; set; }
    
        /// <summary>
        /// 创建人姓名
        /// </summary>
        
        [Description("创建人姓名")]
        public string COUPONPRO_CRENAME { get; set; }
    
        /// <summary>
        /// 创建人所在机构ID
        /// </summary>
        
        [Description("创建人所在机构ID")]
        public decimal COUPONPRO_CREORGID { get; set; }
    
        /// <summary>
        /// 创建人所在机构名称
        /// </summary>
        
        [Description("创建人所在机构名称")]
        public string COUPONPRO_CREORGNAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime COUPONPRO_CREDATE { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal COUPONPRO_UPID { get; set; }
    
        /// <summary>
        /// 修改人名称
        /// </summary>
        
        [Description("修改人名称")]
        public string COUPONPRO_UPNAME { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime COUPONPRO_UPDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string COUPONPRO_ISDEL { get; set; }
    }
}
