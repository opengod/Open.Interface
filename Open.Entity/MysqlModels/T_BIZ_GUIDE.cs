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
    /// T_BIZ_GUIDE 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_GUIDE")]
    public class T_BIZ_GUIDE
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal GUIDE_ID { get; set; }
    
        /// <summary>
        /// 信息来源类型
        /// </summary>
        
        [Description("信息来源类型")]
        public string GUIDE_MSGFROMTYPE { get; set; }
    
        /// <summary>
        /// 信息来源
        /// </summary>
        
        [Description("信息来源")]
        public string GUIDE_MSGFROMCODEVALUE { get; set; }
    
        /// <summary>
        /// 身份证号码
        /// </summary>
        
        [Description("身份证号码")]
        public string GUIDE_IDCARD { get; set; }
    
        /// <summary>
        /// 真实姓名
        /// </summary>
        
        [Description("真实姓名")]
        public string GUIDE_REALNAME { get; set; }
    
        /// <summary>
        /// 性别
        /// </summary>
        
        [Description("性别")]
        public string GUIDE_SEX { get; set; }
    
        /// <summary>
        /// 资格证号
        /// </summary>
        
        [Description("资格证号")]
        public string GUIDE_CERTIFICATENO { get; set; }
    
        /// <summary>
        /// 语种
        /// </summary>
        
        [Description("语种")]
        public string GUIDE_LANGUAGE { get; set; }
    
        /// <summary>
        /// 导游等级
        /// </summary>
        
        [Description("导游等级")]
        public string GUIDE_LEVELCODEVALUE { get; set; }
    
        /// <summary>
        /// 毕业院校
        /// </summary>
        
        [Description("毕业院校")]
        public string GUIDE_SCHOOL { get; set; }
    
        /// <summary>
        /// 导游头像
        /// </summary>
        
        [Description("导游头像")]
        public string GUIDE_IMAGEPATH { get; set; }
    
        /// <summary>
        /// 出生日期
        /// </summary>
        
        [Description("出生日期")]
        public string GUIDE_BIRTHDATE { get; set; }
    
        /// <summary>
        /// 民族
        /// </summary>
        
        [Description("民族")]
        public string GUIDE_NATION { get; set; }
    
        /// <summary>
        /// 学历
        /// </summary>
        
        [Description("学历")]
        public string GUIDE_EDUCTIONCODEVALUE { get; set; }
    
        /// <summary>
        /// 家庭住址
        /// </summary>
        
        [Description("家庭住址")]
        public string GUIDE_HOMEADDRESS { get; set; }
    
        /// <summary>
        /// 移动电话
        /// </summary>
        
        [Description("移动电话")]
        public string GUIDE_MOBILE { get; set; }
    
        /// <summary>
        /// QQ号码
        /// </summary>
        
        [Description("QQ号码")]
        public string GUIDE_QQ { get; set; }
    
        /// <summary>
        /// 微信号
        /// </summary>
        
        [Description("微信号")]
        public string GUIDE_WEIXIN { get; set; }
    
        /// <summary>
        /// 电子邮件
        /// </summary>
        
        [Description("电子邮件")]
        public string GUIDE_EMAIL { get; set; }
    
        /// <summary>
        /// 导游证编号
        /// </summary>
        
        [Description("导游证编号")]
        public string GUIDE_GUIDENO { get; set; }
    
        /// <summary>
        /// 服务旅行社
        /// </summary>
        
        [Description("服务旅行社")]
        public string GUIDE_TRAVELCOMPANY { get; set; }
    
        /// <summary>
        /// 发证机关
        /// </summary>
        
        [Description("发证机关")]
        public string GUIDE_CERTORG { get; set; }
    
        /// <summary>
        /// 发证日期
        /// </summary>
        
        [Description("发证日期")]
        public string GUIDE_CERTDATE { get; set; }
    
        /// <summary>
        /// 最后年审日期
        /// </summary>
        
        [Description("最后年审日期")]
        public string GUIDE_LASTYEARAUDIT { get; set; }
    
        /// <summary>
        /// 服务开始时间
        /// </summary>
        
        [Description("服务开始时间")]
        public DateTime GUIDE_SERVICESTAR { get; set; }
    
        /// <summary>
        /// 服务结束时间
        /// </summary>
        
        [Description("服务结束时间")]
        public DateTime GUIDE_SERVICEEND { get; set; }
    
        /// <summary>
        /// 服务内容
        /// </summary>
        
        [Description("服务内容")]
        public string GUIDE_SERVICECONTENT { get; set; }
    
        /// <summary>
        /// 个人简介
        /// </summary>
        
        [Description("个人简介")]
        public string GUIDE_SIGN { get; set; }
    
        /// <summary>
        /// 预约须知
        /// </summary>
        
        [Description("预约须知")]
        public string GUIDE_NOTIC { get; set; }
    
        /// <summary>
        /// 详细介绍
        /// </summary>
        
        [Description("详细介绍")]
        public string GUIDE_MEMO { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal GUIDE_CREID { get; set; }
    
        /// <summary>
        /// 创建人姓名
        /// </summary>
        
        [Description("创建人姓名")]
        public string GUIDE_CRENAME { get; set; }
    
        /// <summary>
        /// 创建人所在机构ID
        /// </summary>
        
        [Description("创建人所在机构ID")]
        public decimal GUIDE_CREORGID { get; set; }
    
        /// <summary>
        /// 创建人所在机构名称
        /// </summary>
        
        [Description("创建人所在机构名称")]
        public string GUIDE_CREORGNAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime GUIDE_CREDATE { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal GUIDE_UPID { get; set; }
    
        /// <summary>
        /// 修改人名称
        /// </summary>
        
        [Description("修改人名称")]
        public string GUIDE_UPNAME { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime GUIDE_UPDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string GUIDE_ISDEL { get; set; }
    }
}
