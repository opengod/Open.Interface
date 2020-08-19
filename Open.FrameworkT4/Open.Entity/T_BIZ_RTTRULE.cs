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
    /// T_BIZ_RTTRULE 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_RTTRULE")]
    public class T_BIZ_RTTRULE
    {
    
        /// <summary>
        /// 退订规则主键ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("退订规则主键ID")]
        public decimal RTTRULE_ID { get; set; }
    
        /// <summary>
        /// 退订规则名称
        /// </summary>
        
        [Description("退订规则名称")]
        public string RTTRULE_NAME { get; set; }
    
        /// <summary>
        /// 供应商ID
        /// </summary>
        
        [Description("供应商ID")]
        public decimal RTTRULE_SUPID { get; set; }
    
        /// <summary>
        /// 供应商编码
        /// </summary>
        
        [Description("供应商编码")]
        public string RTTRULE_SUPCODE { get; set; }
    
        /// <summary>
        /// 供应商名称
        /// </summary>
        
        [Description("供应商名称")]
        public string RTTRULE_SUPNAME { get; set; }
    
        /// <summary>
        /// 产品类型（P景区，PT门票，PP套餐，H酒店，HR房间，HB会议室，L线路，C评论，T投诉，R餐饮，RP餐饮套餐，E休闲娱乐，EP娱乐套餐，B商店，BP商店商品）
        /// </summary>
        
        [Description("产品类型（P景区，PT门票，PP套餐，H酒店，HR房间，HB会议室，L线路，C评论，T投诉，R餐饮，RP餐饮套餐，E休闲娱乐，EP娱乐套餐，B商店，BP商店商品）")]
        public string RTTRULE_PRODUCTTYPE { get; set; }
    
        /// <summary>
        /// 是否可退
        /// </summary>
        
        [Description("是否可退")]
        public string RTTRULE_FLAG { get; set; }
    
        /// <summary>
        /// 是否随时退
        /// </summary>
        
        [Description("是否随时退")]
        public string RTTRULE_ALLFLAG { get; set; }
    
        /// <summary>
        /// 游玩日期前是否可退
        /// </summary>
        
        [Description("游玩日期前是否可退")]
        public string RTTRULE_BEFFLAG { get; set; }
    
        /// <summary>
        /// 游玩日期前退票截止时间
        /// </summary>
        
        [Description("游玩日期前退票截止时间")]
        public DateTime RTTRULE_FEFRTTDATE { get; set; }
    
        /// <summary>
        /// 当天是否可退
        /// </summary>
        
        [Description("当天是否可退")]
        public string RTTRULE_TODAYFLAG { get; set; }
    
        /// <summary>
        /// 过期是否可退
        /// </summary>
        
        [Description("过期是否可退")]
        public string RTTRULE_EXPFLAG { get; set; }
    
        /// <summary>
        /// 过期几天可退
        /// </summary>
        
        [Description("过期几天可退")]
        public decimal RTTRULE_EXPDAYS { get; set; }
    
        /// <summary>
        /// 过期几天自动完结
        /// </summary>
        
        [Description("过期几天自动完结")]
        public decimal RTTRULE_EXPCLOSE { get; set; }
    
        /// <summary>
        /// 是否需要审核
        /// </summary>
        
        [Description("是否需要审核")]
        public string RTTRULE_ISCHECK { get; set; }
    
        /// <summary>
        /// 退订类别(P百分比，F手续费)
        /// </summary>
        
        [Description("退订类别(P百分比，F手续费)")]
        public string RTTRULE_TYPE { get; set; }
    
        /// <summary>
        /// 退订手续费
        /// </summary>
        
        [Description("退订手续费")]
        public decimal RTTRULE_PRICE { get; set; }
    
        /// <summary>
        /// 退订百分比
        /// </summary>
        
        [Description("退订百分比")]
        public decimal RTTRULE_PERCENT { get; set; }
    
        /// <summary>
        /// 游玩日期前以内
        /// </summary>
        
        [Description("游玩日期前以内")]
        public DateTime RTTRULE_BEFDATE { get; set; }
    
        /// <summary>
        /// 游玩日期前以内扣费金额
        /// </summary>
        
        [Description("游玩日期前以内扣费金额")]
        public decimal RTTRULE_BEFDATEPRICE { get; set; }
    
        /// <summary>
        /// 验证时间
        /// </summary>
        
        [Description("验证时间")]
        public string RTTRULE_CHECKTIME { get; set; }
    
        /// <summary>
        /// 退票提前多少分钟
        /// </summary>
        
        [Description("退票提前多少分钟")]
        public decimal RTTRULE_BEFCHETIME { get; set; }
    
        /// <summary>
        /// 退票费用二位数组
        /// </summary>
        
        [Description("退票费用二位数组")]
        public string RTTRULE_RTTCOST { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string RTTRULE_MEMO { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal RTTRULE_CREID { get; set; }
    
        /// <summary>
        /// 创建人姓名
        /// </summary>
        
        [Description("创建人姓名")]
        public string RTTRULE_CRENAME { get; set; }
    
        /// <summary>
        /// 创建人所在机构ID
        /// </summary>
        
        [Description("创建人所在机构ID")]
        public decimal RTTRULE_CREORGID { get; set; }
    
        /// <summary>
        /// 创建人所在机构名称
        /// </summary>
        
        [Description("创建人所在机构名称")]
        public string RTTRULE_CREORGNAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime RTTRULE_CREDATE { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal RTTRULE_UPID { get; set; }
    
        /// <summary>
        /// 修改人名称
        /// </summary>
        
        [Description("修改人名称")]
        public string RTTRULE_UPNAME { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime RTTRULE_UPDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string RTTRULE_ISDEL { get; set; }
    }
}
