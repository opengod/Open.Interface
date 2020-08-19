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
    /// T_BIZ_VISITOR 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_VISITOR")]
    public class T_BIZ_VISITOR
    {
    
        /// <summary>
        /// 游客主键ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("游客主键ID")]
        public decimal VISITOR_ID { get; set; }
    
        /// <summary>
        /// 预约表ID
        /// </summary>
        
        [Description("预约表ID")]
        public decimal VISITOR_BOOKVISITORID { get; set; }
    
        /// <summary>
        /// 来源订单类型
        /// </summary>
        
        [Description("来源订单类型")]
        public string VISITOR_ORDERTYPE { get; set; }
    
        /// <summary>
        /// 来源订单号
        /// </summary>
        
        [Description("来源订单号")]
        public string VISITOR_ORDERNO { get; set; }
    
        /// <summary>
        /// 年龄类型。成年：adult，儿童：child
        /// </summary>
        
        [Description("年龄类型。成年：adult，儿童：child")]
        public string VISITOR_AGETYPE { get; set; }
    
        /// <summary>
        /// 游客姓名
        /// </summary>
        
        [Description("游客姓名")]
        public string VISITOR_NAME { get; set; }
    
        /// <summary>
        /// 游客性别
        /// </summary>
        
        [Description("游客性别")]
        public string VISITOR_SEX { get; set; }
    
        /// <summary>
        /// 生日
        /// </summary>
        
        [Description("生日")]
        public DateTime VISITOR_BIRTHDAY { get; set; }
    
        /// <summary>
        /// 游客手机号
        /// </summary>
        
        [Description("游客手机号")]
        public string VISITOR_TEL { get; set; }
    
        /// <summary>
        /// 游客证件号
        /// </summary>
        
        [Description("游客证件号")]
        public string VISITOR_ICNO { get; set; }
    
        /// <summary>
        /// 证件类型，身份证0、港澳居民来往内地通行证1、台湾居民来往大陆通行证2、护照3
        /// </summary>
        
        [Description("证件类型，身份证0、港澳居民来往内地通行证1、台湾居民来往大陆通行证2、护照3")]
        public string VISITOR_CARDTYPE { get; set; }
    
        /// <summary>
        /// 地区
        /// </summary>
        
        [Description("地区")]
        public string VISITOR_AREA { get; set; }
    
        /// <summary>
        /// 省份
        /// </summary>
        
        [Description("省份")]
        public string VISITOR_PROVINCE { get; set; }
    
        /// <summary>
        /// 市
        /// </summary>
        
        [Description("市")]
        public string VISITOR_CITY { get; set; }
    
        /// <summary>
        /// 区县
        /// </summary>
        
        [Description("区县")]
        public string VISITOR_COUNTY { get; set; }
    
        /// <summary>
        /// 归属地
        /// </summary>
        
        [Description("归属地")]
        public string VISITOR_BELONG { get; set; }
    
        /// <summary>
        /// 优待票类型。儿童 children，老人 old，教师teacher,学生student
        /// </summary>
        
        [Description("优待票类型。儿童 children，老人 old，教师teacher,学生student")]
        public string VISITOR_PREFERENTIAL { get; set; }
    
        /// <summary>
        /// 证件号（教室资格证/学生证）
        /// </summary>
        
        [Description("证件号（教室资格证/学生证）")]
        public string VISITOR_CERTIFICATE { get; set; }
    
        /// <summary>
        /// 是否新型冠状病毒感染的肺炎确诊病例接触史，T：是，F：否
        /// </summary>
        
        [Description("是否新型冠状病毒感染的肺炎确诊病例接触史，T：是，F：否")]
        public string VISITOR_ISPNEUMONIA { get; set; }
    
        /// <summary>
        /// 近期（一个月内）是否出入过湖北省，T：是，F：否
        /// </summary>
        
        [Description("近期（一个月内）是否出入过湖北省，T：是，F：否")]
        public string VISITOR_ISHUBEI { get; set; }
    
        /// <summary>
        /// 症状类型。发热fever，咳嗽cough，咽喉疼痛throat，头痛headache，流鼻涕runny，无症状healthy，其他other
        /// </summary>
        
        [Description("症状类型。发热fever，咳嗽cough，咽喉疼痛throat，头痛headache，流鼻涕runny，无症状healthy，其他other")]
        public string VISITOR_CONDITION { get; set; }
    
        /// <summary>
        /// 是否去医院就诊，T：是，F：否
        /// </summary>
        
        [Description("是否去医院就诊，T：是，F：否")]
        public string VISITOR_ISHOSPITAL { get; set; }
    
        /// <summary>
        /// 当前温度
        /// </summary>
        
        [Description("当前温度")]
        public string VISITOR_TEMPERATURE { get; set; }
    
        /// <summary>
        /// 游客邮箱
        /// </summary>
        
        [Description("游客邮箱")]
        public string VISITOR_EMAIL { get; set; }
    
        /// <summary>
        /// 是否加入黑名单
        /// </summary>
        
        [Description("是否加入黑名单")]
        public string VISITOR_ISBLACKLIST { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string VISITOR_MEMO { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string VISITOR_ISDEL { get; set; }
    }
}
