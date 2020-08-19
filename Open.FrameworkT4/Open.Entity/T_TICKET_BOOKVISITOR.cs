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
    /// T_TICKET_BOOKVISITOR 
    /// </summary>    
   [Serializable]
   [SugarTable("T_TICKET_BOOKVISITOR")]
    public class T_TICKET_BOOKVISITOR
    {
    
        /// <summary>
        /// 游客主键ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("游客主键ID")]
        public decimal VISITOR_ID { get; set; }
    
        /// <summary>
        /// 订单号
        /// </summary>
        
        [Description("订单号")]
        public string VISITOR_ORDERNO { get; set; }
    
        /// <summary>
        /// 景区机构ID
        /// </summary>
        
        [Description("景区机构ID")]
        public decimal VISITOR_PARKID { get; set; }
    
        /// <summary>
        /// 景区名称
        /// </summary>
        
        [Description("景区名称")]
        public string VISITOR_PARKNAME { get; set; }
    
        /// <summary>
        /// 用户表ID
        /// </summary>
        
        [Description("用户表ID")]
        public decimal VISITOR_MEMBERID { get; set; }
    
        /// <summary>
        /// 景区时段预约表id
        /// </summary>
        
        [Description("景区时段预约表id")]
        public decimal VISITOR_BOOKCAL { get; set; }
    
        /// <summary>
        /// 活动id
        /// </summary>
        
        [Description("活动id")]
        public int VISITOR_ACTIVITEID { get; set; }
    
        /// <summary>
        /// 活动名称
        /// </summary>
        
        [Description("活动名称")]
        public string VISITOR_ACTIVITENAME { get; set; }
    
        /// <summary>
        /// 团队名称
        /// </summary>
        
        [Description("团队名称")]
        public string VISITOR_TEAMNAME { get; set; }
    
        /// <summary>
        /// 预约入园日期
        /// </summary>
        
        [Description("预约入园日期")]
        public DateTime VISITOR_DATE { get; set; }
    
        /// <summary>
        /// 预约入园开始时间
        /// </summary>
        
        [Description("预约入园开始时间")]
        public DateTime VISITOR_STARTIME { get; set; }
    
        /// <summary>
        /// 预约入园结束时间
        /// </summary>
        
        [Description("预约入园结束时间")]
        public DateTime VISITOR_ENDTIME { get; set; }
    
        /// <summary>
        /// 核销编码
        /// </summary>
        
        [Description("核销编码")]
        public string VISITOR_CODE { get; set; }
    
        /// <summary>
        /// 预约人数
        /// </summary>
        
        [Description("预约人数")]
        public int VISITOR_NUM { get; set; }
    
        /// <summary>
        /// 预约状态。F：待入园，T：已入园，O：部分入园，N：创建成功，P：创建取消，S：预约成功，A：预约取消，R：退款成功，B：待审核，C：审核不通过，D：审核通过，E：已出园
        /// </summary>
        
        [Description("预约状态。F：待入园，T：已入园，O：部分入园，N：创建成功，P：创建取消，S：预约成功，A：预约取消，R：退款成功，B：待审核，C：审核不通过，D：审核通过，E：已出园")]
        public string VISITOR_STATUS { get; set; }
    
        /// <summary>
        /// 预约类型。S：散客，T：团队，J：讲解员，H：活动，X：学校团队
        /// </summary>
        
        [Description("预约类型。S：散客，T：团队，J：讲解员，H：活动，X：学校团队")]
        public string VISITOR_TYPE { get; set; }
    
        /// <summary>
        /// 检票人数
        /// </summary>
        
        [Description("检票人数")]
        public int VISITOR_CHECKNUM { get; set; }
    
        /// <summary>
        /// 核销时间
        /// </summary>
        
        [Description("核销时间")]
        public DateTime VISITOR_CHECKDATE { get; set; }
    
        /// <summary>
        /// 出园人数
        /// </summary>
        
        [Description("出园人数")]
        public int VISITOR_OUTNUM { get; set; }
    
        /// <summary>
        /// 出园时间
        /// </summary>
        
        [Description("出园时间")]
        public DateTime VISITOR_OUTDATE { get; set; }
    
        /// <summary>
        /// 年龄类型。成年：adult，儿童：child
        /// </summary>
        
        [Description("年龄类型。成年：adult，儿童：child")]
        public string VISITOR_AGETYPE { get; set; }
    
        /// <summary>
        /// 游客姓名，默认首位为预约人(下单人)
        /// </summary>
        
        [Description("游客姓名，默认首位为预约人(下单人)")]
        public string VISITOR_NAME { get; set; }
    
        /// <summary>
        /// 游客手机号
        /// </summary>
        
        [Description("游客手机号")]
        public string VISITOR_TEL { get; set; }
    
        /// <summary>
        /// 游客身份证号
        /// </summary>
        
        [Description("游客身份证号")]
        public string VISITOR_ICNO { get; set; }
    
        /// <summary>
        /// 证件类型，身份证0、港澳居民来往内地通行证1、台湾居民来往大陆通行证2、护照3
        /// </summary>
        
        [Description("证件类型，身份证0、港澳居民来往内地通行证1、台湾居民来往大陆通行证2、护照3")]
        public string VISITOR_CARDTYPE { get; set; }
    
        /// <summary>
        /// 游客体温
        /// </summary>
        
        [Description("游客体温")]
        public string VISITOR_TEMPERATURE { get; set; }
    
        /// <summary>
        /// 游客性别，男，女
        /// </summary>
        
        [Description("游客性别，男，女")]
        public string VISITOR_SEX { get; set; }
    
        /// <summary>
        /// 游客邮箱
        /// </summary>
        
        [Description("游客邮箱")]
        public string VISITOR_EMAIL { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string VISITOR_MEMO { get; set; }
    
        /// <summary>
        /// 审核人id
        /// </summary>
        
        [Description("审核人id")]
        public decimal VISITOR_AUDITID { get; set; }
    
        /// <summary>
        /// 审核人姓名
        /// </summary>
        
        [Description("审核人姓名")]
        public string VISITOR_AUDITNAME { get; set; }
    
        /// <summary>
        /// 审核时间
        /// </summary>
        
        [Description("审核时间")]
        public DateTime VISITOR_AUDITDATE { get; set; }
    
        /// <summary>
        /// 是否黑名单 F否T是U已解封
        /// </summary>
        
        [Description("是否黑名单 F否T是U已解封")]
        public string VISITOR_ISBLACKLIST { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string VISITOR_ISDEL { get; set; }
    }
}
