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
    /// T_B2C_ACTIVITE 
    /// </summary>    
   [Serializable]
   [SugarTable("T_B2C_ACTIVITE")]
    public class T_B2C_ACTIVITE
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal ACTIVITE_ID { get; set; }
    
        /// <summary>
        /// 发布日期
        /// </summary>
        
        [Description("发布日期")]
        public DateTime ACTIVITE_PUBLISHDATE { get; set; }
    
        /// <summary>
        /// 活动标题
        /// </summary>
        
        [Description("活动标题")]
        public string ACTIVITE_TITLE { get; set; }
    
        /// <summary>
        /// 活动介绍
        /// </summary>
        
        [Description("活动介绍")]
        public string ACTIVITE_CONTENT { get; set; }
    
        /// <summary>
        /// 活动首页展示图片
        /// </summary>
        
        [Description("活动首页展示图片")]
        public string ACTIVITE_HOMEPICPATH { get; set; }
    
        /// <summary>
        /// 活动地点
        /// </summary>
        
        [Description("活动地点")]
        public string ACTIVITE_ADDRESS { get; set; }
    
        /// <summary>
        /// 是否首页轮播：F否，T是
        /// </summary>
        
        [Description("是否首页轮播：F否，T是")]
        public string ACTIVITE_PICSHOWHOME { get; set; }
    
        /// <summary>
        /// 报名链接
        /// </summary>
        
        [Description("报名链接")]
        public string ACTIVITE_REGLINK { get; set; }
    
        /// <summary>
        /// 购票链接
        /// </summary>
        
        [Description("购票链接")]
        public string ACTIVITE_BUYLINK { get; set; }
    
        /// <summary>
        /// 是否报名：F不报名，T报名
        /// </summary>
        
        [Description("是否报名：F不报名，T报名")]
        public string ACTIVITE_ISATTEND { get; set; }
    
        /// <summary>
        /// 是否审核：F未审核，T审核
        /// </summary>
        
        [Description("是否审核：F未审核，T审核")]
        public string ACTIVITE_ISAUDIT { get; set; }
    
        /// <summary>
        /// 是否需要填写身份证
        /// </summary>
        
        [Description("是否需要填写身份证")]
        public string ACTIVITE_ISIC { get; set; }
    
        /// <summary>
        /// 点赞数量
        /// </summary>
        
        [Description("点赞数量")]
        public decimal ACTIVITE_PRAISE { get; set; }
    
        /// <summary>
        /// 审核人ID
        /// </summary>
        
        [Description("审核人ID")]
        public decimal ACTIVITE_AUDITID { get; set; }
    
        /// <summary>
        /// 报名开始时间
        /// </summary>
        
        [Description("报名开始时间")]
        public DateTime ACTIVITE_ATTENDSTAR { get; set; }
    
        /// <summary>
        /// 报名结束时间
        /// </summary>
        
        [Description("报名结束时间")]
        public DateTime ACTIVITE_ATTENDEND { get; set; }
    
        /// <summary>
        /// 活动开始时间
        /// </summary>
        
        [Description("活动开始时间")]
        public DateTime ACTIVITE_STAR { get; set; }
    
        /// <summary>
        /// 活动结束时间
        /// </summary>
        
        [Description("活动结束时间")]
        public DateTime ACTIVITE_END { get; set; }
    
        /// <summary>
        /// 审核人
        /// </summary>
        
        [Description("审核人")]
        public string ACTIVITE_AUDITNAME { get; set; }
    
        /// <summary>
        /// 审核日期
        /// </summary>
        
        [Description("审核日期")]
        public DateTime ACTIVITE_AUDITDATE { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal ACTIVITE_CREID { get; set; }
    
        /// <summary>
        /// 创建人姓名
        /// </summary>
        
        [Description("创建人姓名")]
        public string ACTIVITE_CRENAME { get; set; }
    
        /// <summary>
        /// 创建人所在机构ID
        /// </summary>
        
        [Description("创建人所在机构ID")]
        public decimal ACTIVITE_CREORGID { get; set; }
    
        /// <summary>
        /// 创建人所在机构名称
        /// </summary>
        
        [Description("创建人所在机构名称")]
        public string ACTIVITE_CREORGNAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime ACTIVITE_CREDATE { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal ACTIVITE_UPID { get; set; }
    
        /// <summary>
        /// 修改人名称
        /// </summary>
        
        [Description("修改人名称")]
        public string ACTIVITE_UPNAME { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime ACTIVITE_UPDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string ACTIVITE_ISDEL { get; set; }
    }
}
