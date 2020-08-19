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
    /// T_BIZ_MTBASEDATA 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_MTBASEDATA")]
    public class T_BIZ_MTBASEDATA
    {
    
        /// <summary>
        /// ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("ID")]
        public decimal DATAID { get; set; }
    
        /// <summary>
        /// 景点ID
        /// </summary>
        
        [Description("景点ID")]
        public decimal PARKID { get; set; }
    
        /// <summary>
        /// 景区名称
        /// </summary>
        
        [Description("景区名称")]
        public string PARKNAME { get; set; }
    
        /// <summary>
        /// 城市
        /// </summary>
        
        [Description("城市")]
        public string CITY { get; set; }
    
        /// <summary>
        /// 地址
        /// </summary>
        
        [Description("地址")]
        public string ADDRESS { get; set; }
    
        /// <summary>
        /// 电话
        /// </summary>
        
        [Description("电话")]
        public string PHONE { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string DESCRIPTION { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string IMGLIST { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string IMGTEXT { get; set; }
    
        /// <summary>
        /// 景区地理经度
        /// </summary>
        
        [Description("景区地理经度")]
        public string LONGITUDE { get; set; }
    
        /// <summary>
        /// 景区地理纬度
        /// </summary>
        
        [Description("景区地理纬度")]
        public string LATITUDE { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal AHEADHOUR { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string CHARGEINCLUDENOTE { get; set; }
    
        /// <summary>
        /// 退款说明
        /// </summary>
        
        [Description("退款说明")]
        public string REFUNDNOTE { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string USENOTE { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string IMPORTANTNOTE { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string IMAGETEXTNOTE { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal CANREFUND { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string COMMISSIONRATIO { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string REFUNDRATIO { get; set; }
    
        /// <summary>
        /// 产品ID
        /// </summary>
        
        [Description("产品ID")]
        public decimal PRODUCTID { get; set; }
    
        /// <summary>
        /// 票面价格
        /// </summary>
        
        [Description("票面价格")]
        public decimal MARKETPRICE { get; set; }
    
        /// <summary>
        /// 美团售卖价
        /// </summary>
        
        [Description("美团售卖价")]
        public decimal SELLPRICE { get; set; }
    
        /// <summary>
        /// 用户名
        /// </summary>
        
        [Description("用户名")]
        public string CLIENT { get; set; }
    
        /// <summary>
        /// 密钥
        /// </summary>
        
        [Description("密钥")]
        public string SECRET { get; set; }
    
        /// <summary>
        /// 合作方ID
        /// </summary>
        
        [Description("合作方ID")]
        public string PARTNERID { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string PLATFORMSEND { get; set; }
    
        /// <summary>
        /// 入园地址
        /// </summary>
        
        [Description("入园地址")]
        public string GETINADDRESSES { get; set; }
    
        /// <summary>
        /// 是否需要换票 0:不需要 1:需要
        /// </summary>
        
        [Description("是否需要换票 0:不需要 1:需要")]
        public decimal NEEDTICKET { get; set; }
    
        /// <summary>
        /// 其他注意事项	必须是纯文本，不能有格式代码
        /// </summary>
        
        [Description("其他注意事项	必须是纯文本，不能有格式代码")]
        public string OTHERNOTE { get; set; }
    
        /// <summary>
        /// 景区当日开始入园时间	单位分钟,从凌晨开始计算时间
        /// </summary>
        
        [Description("景区当日开始入园时间	单位分钟,从凌晨开始计算时间")]
        public decimal VOUCHERTIMEBEGIN { get; set; }
    
        /// <summary>
        /// 景区当日停止入园时间	单位分钟，从凌晨开始计算时间
        /// </summary>
        
        [Description("景区当日停止入园时间	单位分钟，从凌晨开始计算时间")]
        public decimal VOUCHERTIMEEND { get; set; }
    
        /// <summary>
        /// 提前预约类型 1	任意时刻都可下单2	入园前多少分钟可以下单，相对于入园截止时间计算提前A分钟预定，则aheadMinutes=A。如17点截止入园，提前150分钟预定，则aheadMinutes=150。即14:30之前可预定3	截止到(从预定日期晚上24点往前计算)A天B点C分 则aheadMinutes = A x 24 x 60 +(24 x 60 - B x 60 - C)，如预定1.19号游玩，1.18号16点34止预定，则A＝1，B＝16，C＝34
        /// </summary>
        [Description("提前预约类型 1	任意时刻都可下单2	入园前多少分钟可以下单，相对于入园截止时间计算提前A分钟预定，则aheadMinutes=A。如17点截止入园，提前150分钟预定，则aheadMinutes=150。即14:30之前可预定3	截止到(从预定日期晚上24点往前计算)A天B点C分 则aheadMinutes = A x 24 x 60 +(24 x 60 - B x 60 - C)，如预定1.19号游玩，1.18号16点34止预定，则A＝1，B＝16，C＝34")]
        public decimal AHEADHOURSTYPE { get; set; }
    
        /// <summary>
        /// 提前预约分钟数
        /// </summary>
        
        [Description("提前预约分钟数")]
        public decimal AHEADMINUTES { get; set; }
    
        /// <summary>
        /// 产品标题
        /// </summary>
        
        [Description("产品标题")]
        public string TITLE { get; set; }
    
        /// <summary>
        /// 产品副标题
        /// </summary>
        
        [Description("产品副标题")]
        public string SUBTITLE { get; set; }
    
        /// <summary>
        /// 费用包含补充说明
        /// </summary>
        
        [Description("费用包含补充说明")]
        public string INCLUDE { get; set; }
    
        /// <summary>
        /// 身份证几天内
        /// </summary>
        
        [Description("身份证几天内")]
        public decimal IDLIMITDAYS { get; set; }
    
        /// <summary>
        /// 每身份证idLimitDays天内最多可购买数量
        /// </summary>
        
        [Description("每身份证idLimitDays天内最多可购买数量")]
        public decimal IDLIMITCOUNTM { get; set; }
    
        /// <summary>
        /// 每手机号几天内
        /// </summary>
        
        [Description("每手机号几天内")]
        public decimal PHONELIMITDAYS { get; set; }
    
        /// <summary>
        /// 每手机号phoneLimitDays天内最多可购买数量
        /// </summary>
        
        [Description("每手机号phoneLimitDays天内最多可购买数量")]
        public decimal PHONELIMITCOUNT { get; set; }
    
        /// <summary>
        /// 费用不包含
        /// </summary>
        
        [Description("费用不包含")]
        public string EXCLUDE { get; set; }
    
        /// <summary>
        /// 每多少个人共用一个游客信息
        /// </summary>
        
        [Description("每多少个人共用一个游客信息")]
        public decimal VISITORINFOGROUPSIZE { get; set; }
    
        /// <summary>
        /// 取票地址
        /// </summary>
        
        [Description("取票地址")]
        public string TICKETGETADDRESS { get; set; }
    
        /// <summary>
        /// 服务电话
        /// </summary>
        
        [Description("服务电话")]
        public string SERVICEPHONE { get; set; }
    
        /// <summary>
        /// 服务开始小时
        /// </summary>
        
        [Description("服务开始小时")]
        public string STARTHOUR { get; set; }
    
        /// <summary>
        /// 服务开始分钟
        /// </summary>
        
        [Description("服务开始分钟")]
        public string STARTMIN { get; set; }
    
        /// <summary>
        /// 服务结束小时
        /// </summary>
        
        [Description("服务结束小时")]
        public string ENDHOUR { get; set; }
    
        /// <summary>
        /// 服务结束分钟
        /// </summary>
        
        [Description("服务结束分钟")]
        public string ENDMIN { get; set; }
    
        /// <summary>
        /// 通知类型 0是新上架 1是已通知
        /// </summary>
        
        [Description("通知类型 0是新上架 1是已通知")]
        public string ISNOTICE { get; set; }
    }
}
