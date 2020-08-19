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
    /// T_HOTEL_RTTRULE 
    /// </summary>    
   [Serializable]
   [SugarTable("T_HOTEL_RTTRULE")]
    public class T_HOTEL_RTTRULE
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
        /// 产品类型(HR房间，HB会议室)
        /// </summary>
        
        [Description("产品类型(HR房间，HB会议室)")]
        public string RTTRULE_PRODUCTTYPE { get; set; }
    
        /// <summary>
        /// 退订类型（F免费取消，P收费取消，N不可取消）
        /// </summary>
        
        [Description("退订类型（F免费取消，P收费取消，N不可取消）")]
        public string RTTRULE_TYPE { get; set; }
    
        /// <summary>
        /// 最晚取消时间
        /// </summary>
        
        [Description("最晚取消时间")]
        public DateTime RTTRULE_TIME { get; set; }
    
        /// <summary>
        /// 是否需要审核
        /// </summary>
        
        [Description("是否需要审核")]
        public string RTTRULE_ISCHECK { get; set; }
    
        /// <summary>
        /// 收取费用类别(P百分比，F手续费)
        /// </summary>
        
        [Description("收取费用类别(P百分比，F手续费)")]
        public string RTTRULE_PRICETYPE { get; set; }
    
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
        /// 描述
        /// </summary>
        
        [Description("描述")]
        public string RTTRULE_DESCRIBE { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string RTTRULE_MEMO { get; set; }
    
        /// <summary>
        /// 是否由日历表新增
        /// </summary>
        
        [Description("是否由日历表新增")]
        public string RTTRULE_ISCALADD { get; set; }
    
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
