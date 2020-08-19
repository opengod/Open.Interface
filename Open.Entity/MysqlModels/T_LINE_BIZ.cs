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
    /// T_LINE_BIZ 
    /// </summary>    
   [Serializable]
   [SugarTable("T_LINE_BIZ")]
    public class T_LINE_BIZ
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal LINE_ID { get; set; }
    
        /// <summary>
        /// 旅行社ID
        /// </summary>
        
        [Description("旅行社ID")]
        public decimal LINE_TRAVELID { get; set; }
    
        /// <summary>
        /// 旅行社名称
        /// </summary>
        
        [Description("旅行社名称")]
        public string LINE_TRAVELNAME { get; set; }
    
        /// <summary>
        /// 供应商ID
        /// </summary>
        
        [Description("供应商ID")]
        public decimal LINE_SUPID { get; set; }
    
        /// <summary>
        /// 供应商编码
        /// </summary>
        
        [Description("供应商编码")]
        public string LINE_SUPCODE { get; set; }
    
        /// <summary>
        /// 供应商名称
        /// </summary>
        
        [Description("供应商名称")]
        public string LINE_SUPNAME { get; set; }
    
        /// <summary>
        /// 供应商线路ID
        /// </summary>
        
        [Description("供应商线路ID")]
        public string LINE_SUPLINEID { get; set; }
    
        /// <summary>
        /// 支付方式1：在线支付，2：只展示不支付
        /// </summary>
        
        [Description("支付方式1：在线支付，2：只展示不支付")]
        public string LINE_PAYTYPE { get; set; }
    
        /// <summary>
        /// 出发城市地区
        /// </summary>
        
        [Description("出发城市地区")]
        public string LINE_STARTPLACE { get; set; }
    
        /// <summary>
        /// 目的地城市地区
        /// </summary>
        
        [Description("目的地城市地区")]
        public string LINE_ENDPLACE { get; set; }
    
        /// <summary>
        /// 集合地点
        /// </summary>
        
        [Description("集合地点")]
        public string LINE_STATION { get; set; }
    
        /// <summary>
        /// 团号模型
        /// </summary>
        
        [Description("团号模型")]
        public string LINE_MODEL { get; set; }
    
        /// <summary>
        /// 线路编码
        /// </summary>
        
        [Description("线路编码")]
        public string LINE_CODE { get; set; }
    
        /// <summary>
        /// 线路名称
        /// </summary>
        
        [Description("线路名称")]
        public string LINE_NAME { get; set; }
    
        /// <summary>
        /// 线路评分
        /// </summary>
        
        [Description("线路评分")]
        public string LINE_SCORE { get; set; }
    
        /// <summary>
        /// 线路二级分类
        /// </summary>
        
        [Description("线路二级分类")]
        public string LINE_TAG { get; set; }
    
        /// <summary>
        /// 线路标签
        /// </summary>
        
        [Description("线路标签")]
        public string LINE_FLAG { get; set; }
    
        /// <summary>
        /// 推荐特色
        /// </summary>
        
        [Description("推荐特色")]
        public string LINE_RECOMMENDED { get; set; }
    
        /// <summary>
        /// 线路介绍
        /// </summary>
        
        [Description("线路介绍")]
        public string LINE_INFO { get; set; }
    
        /// <summary>
        /// 行程安排
        /// </summary>
        
        [Description("行程安排")]
        public string LINE_PLAN { get; set; }
    
        /// <summary>
        /// 预订须知
        /// </summary>
        
        [Description("预订须知")]
        public string LINE_BUYNOTE { get; set; }
    
        /// <summary>
        /// 费用包含
        /// </summary>
        
        [Description("费用包含")]
        public string LINE_COSTIN { get; set; }
    
        /// <summary>
        /// 费用不含
        /// </summary>
        
        [Description("费用不含")]
        public string LINE_COSTOFF { get; set; }
    
        /// <summary>
        /// 地图交通
        /// </summary>
        
        [Description("地图交通")]
        public string LINE_MAP { get; set; }
    
        /// <summary>
        /// 是否推荐
        /// </summary>
        
        [Description("是否推荐")]
        public string LINE_ISHOT { get; set; }
    
        /// <summary>
        /// 行程天数
        /// </summary>
        
        [Description("行程天数")]
        public string LINE_DAY { get; set; }
    
        /// <summary>
        /// 售卖价
        /// </summary>
        
        [Description("售卖价")]
        public decimal LINE_INPRICE { get; set; }
    
        /// <summary>
        /// 结算价
        /// </summary>
        
        [Description("结算价")]
        public decimal LINE_PRICE { get; set; }
    
        /// <summary>
        /// 有效开始时间
        /// </summary>
        
        [Description("有效开始时间")]
        public DateTime LINE_STARTTIME { get; set; }
    
        /// <summary>
        /// 有效结束时间
        /// </summary>
        
        [Description("有效结束时间")]
        public DateTime LINE_ENDTIME { get; set; }
    
        /// <summary>
        /// 是否包团
        /// </summary>
        
        [Description("是否包团")]
        public string LINE_ISTEAM { get; set; }
    
        /// <summary>
        /// 包团人数
        /// </summary>
        
        [Description("包团人数")]
        public decimal LINE_TEAMPEOPLE { get; set; }
    
        /// <summary>
        /// 景区个数
        /// </summary>
        
        [Description("景区个数")]
        public decimal LINE_PARKNUM { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string LINE_MEMO { get; set; }
    
        /// <summary>
        /// 排序
        /// </summary>
        
        [Description("排序")]
        public decimal LINE_SORT { get; set; }
    
        /// <summary>
        /// 售卖规则ID
        /// </summary>
        
        [Description("售卖规则ID")]
        public decimal LINE_SELLRULEID { get; set; }
    
        /// <summary>
        /// 售卖规则名称
        /// </summary>
        
        [Description("售卖规则名称")]
        public string LINE_SELLRULENAME { get; set; }
    
        /// <summary>
        /// 退订规则ID
        /// </summary>
        
        [Description("退订规则ID")]
        public decimal LINE_RTTRULEID { get; set; }
    
        /// <summary>
        /// 退订规则名称
        /// </summary>
        
        [Description("退订规则名称")]
        public string LINE_RTTRULENAME { get; set; }
    
        /// <summary>
        /// 违约条款退改规则
        /// </summary>
        
        [Description("违约条款退改规则")]
        public string LINE_RETRRULE { get; set; }
    
        /// <summary>
        /// 客服人员或负责人电话
        /// </summary>
        
        [Description("客服人员或负责人电话")]
        public string LINE_CUSTOMERPHNOE { get; set; }
    
        /// <summary>
        /// 预定限制
        /// </summary>
        
        [Description("预定限制")]
        public string LINE_RESERVELIMIT { get; set; }
    
        /// <summary>
        /// 产品说明
        /// </summary>
        
        [Description("产品说明")]
        public string LINE_PRODUCTINFO { get; set; }
    
        /// <summary>
        /// 开票说明
        /// </summary>
        
        [Description("开票说明")]
        public string LINE_TICKETEXPLAIN { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal LINE_CREID { get; set; }
    
        /// <summary>
        /// 创建人姓名
        /// </summary>
        
        [Description("创建人姓名")]
        public string LINE_CRENAME { get; set; }
    
        /// <summary>
        /// 创建人所在机构ID
        /// </summary>
        
        [Description("创建人所在机构ID")]
        public decimal LINE_CREORGID { get; set; }
    
        /// <summary>
        /// 创建人所在机构名称
        /// </summary>
        
        [Description("创建人所在机构名称")]
        public string LINE_CREORGNAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime LINE_CREDATE { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal LINE_UPID { get; set; }
    
        /// <summary>
        /// 修改人名称
        /// </summary>
        
        [Description("修改人名称")]
        public string LINE_UPNAME { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime LINE_UPDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string LINE_ISDEL { get; set; }
    }
}
