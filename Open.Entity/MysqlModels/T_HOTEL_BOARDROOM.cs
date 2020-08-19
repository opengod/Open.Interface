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
    /// T_HOTEL_BOARDROOM 
    /// </summary>    
   [Serializable]
   [SugarTable("T_HOTEL_BOARDROOM")]
    public class T_HOTEL_BOARDROOM
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal BOARDROOM_ID { get; set; }
    
        /// <summary>
        /// 酒店ID
        /// </summary>
        
        [Description("酒店ID")]
        public decimal BOARDROOM_HOTELID { get; set; }
    
        /// <summary>
        /// 酒店名称
        /// </summary>
        
        [Description("酒店名称")]
        public string BOARDROOM_HOTELNAME { get; set; }
    
        /// <summary>
        /// 会议室名称
        /// </summary>
        
        [Description("会议室名称")]
        public string BOARDROOM_NAME { get; set; }
    
        /// <summary>
        /// 会议室产品编号
        /// </summary>
        
        [Description("会议室产品编号")]
        public string BOARDROOM_CODE { get; set; }
    
        /// <summary>
        /// 售卖规则ID
        /// </summary>
        
        [Description("售卖规则ID")]
        public decimal BOARDROOM_SELLRULE { get; set; }
    
        /// <summary>
        /// 退订规则ID
        /// </summary>
        
        [Description("退订规则ID")]
        public decimal BOARDROOM_RTTRULE { get; set; }
    
        /// <summary>
        /// 售价
        /// </summary>
        
        [Description("售价")]
        public decimal BOARDROOM_SELLPRICE { get; set; }
    
        /// <summary>
        /// 票面价格
        /// </summary>
        
        [Description("票面价格")]
        public decimal BOARDROOM_MARKETPRICE { get; set; }
    
        /// <summary>
        /// 结算价格
        /// </summary>
        
        [Description("结算价格")]
        public decimal BOARDROOM_SETTLEPRICE { get; set; }
    
        /// <summary>
        /// 可容纳最大人数
        /// </summary>
        
        [Description("可容纳最大人数")]
        public decimal BOARDROOM_MAXPEOPLE { get; set; }
    
        /// <summary>
        /// 可容纳最小人数
        /// </summary>
        
        [Description("可容纳最小人数")]
        public decimal BOARDROOM_MINPEOPLE { get; set; }
    
        /// <summary>
        /// 布局（可多选）
        /// </summary>
        
        [Description("布局（可多选）")]
        public string BOARDROOM_LAYOUT { get; set; }
    
        /// <summary>
        /// 排序
        /// </summary>
        
        [Description("排序")]
        public decimal BOARDROOM_SORT { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal BOARDROOM_CREID { get; set; }
    
        /// <summary>
        /// 创建人姓名
        /// </summary>
        
        [Description("创建人姓名")]
        public string BOARDROOM_CRENAME { get; set; }
    
        /// <summary>
        /// 创建人所在机构ID
        /// </summary>
        
        [Description("创建人所在机构ID")]
        public decimal BOARDROOM_CREORGID { get; set; }
    
        /// <summary>
        /// 创建人所在机构名称
        /// </summary>
        
        [Description("创建人所在机构名称")]
        public string BOARDROOM_CREORGNAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime BOARDROOM_CREDATE { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal BOARDROOM_UPID { get; set; }
    
        /// <summary>
        /// 修改人姓名
        /// </summary>
        
        [Description("修改人姓名")]
        public string BOARDROOM_UPNAME { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime BOARDROOM_UPDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string BOARDROOM_ISDEL { get; set; }
    }
}
