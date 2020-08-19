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
    /// T_B2C_TRAVELINFO 
    /// </summary>    
   [Serializable]
   [SugarTable("T_B2C_TRAVELINFO")]
    public class T_B2C_TRAVELINFO
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal TRAVELINFO_ID { get; set; }
    
        /// <summary>
        /// 标题
        /// </summary>
        
        [Description("标题")]
        public string TRAVELINFO_TITLE { get; set; }
    
        /// <summary>
        /// 发布日期
        /// </summary>
        
        [Description("发布日期")]
        public DateTime TRAVELINFO_PUBLISHDATE { get; set; }
    
        /// <summary>
        /// 发布人（手输）
        /// </summary>
        
        [Description("发布人（手输）")]
        public string TRAVELINFO_PUBLISHMAN { get; set; }
    
        /// <summary>
        /// 关键字
        /// </summary>
        
        [Description("关键字")]
        public string TRAVELINFO_KEYWORD { get; set; }
    
        /// <summary>
        /// 内容
        /// </summary>
        
        [Description("内容")]
        public string TRAVELINFO_CONTENT { get; set; }
    
        /// <summary>
        /// 信息类型（Z资讯，S攻略，A文创艺术）
        /// </summary>
        
        [Description("信息类型（Z资讯，S攻略，A文创艺术）")]
        public string TRAVELINFO_TYPE { get; set; }
    
        /// <summary>
        /// 首页展示图片
        /// </summary>
        
        [Description("首页展示图片")]
        public string TRAVELINFO_HOMEPICPATH { get; set; }
    
        /// <summary>
        /// 是否首页轮播：F否，T是
        /// </summary>
        
        [Description("是否首页轮播：F否，T是")]
        public string TRAVELINFO_PICSHOWHOME { get; set; }
    
        /// <summary>
        /// 是否审核：F未审核，T审核
        /// </summary>
        
        [Description("是否审核：F未审核，T审核")]
        public string TRAVELINFO_ISAUDIT { get; set; }
    
        /// <summary>
        /// 审核人ID
        /// </summary>
        
        [Description("审核人ID")]
        public decimal TRAVELINFO_AUDITID { get; set; }
    
        /// <summary>
        /// 审核人
        /// </summary>
        
        [Description("审核人")]
        public string TRAVELINFO_AUDITNAME { get; set; }
    
        /// <summary>
        /// 审核日期
        /// </summary>
        
        [Description("审核日期")]
        public DateTime TRAVELINFO_AUDITDATE { get; set; }
    
        /// <summary>
        /// 点赞数量
        /// </summary>
        
        [Description("点赞数量")]
        public decimal TRAVELINFO_PRAISE { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal TRAVELINFO_CREID { get; set; }
    
        /// <summary>
        /// 创建人姓名
        /// </summary>
        
        [Description("创建人姓名")]
        public string TRAVELINFO_CRENAME { get; set; }
    
        /// <summary>
        /// 创建人所在机构ID
        /// </summary>
        
        [Description("创建人所在机构ID")]
        public decimal TRAVELINFO_CREORGID { get; set; }
    
        /// <summary>
        /// 创建人所在机构名称
        /// </summary>
        
        [Description("创建人所在机构名称")]
        public string TRAVELINFO_CREORGNAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime TRAVELINFO_CREDATE { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal TRAVELINFO_UPID { get; set; }
    
        /// <summary>
        /// 修改人名称
        /// </summary>
        
        [Description("修改人名称")]
        public string TRAVELINFO_UPNAME { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime TRAVELINFO_UPDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string TRAVELINFO_ISDEL { get; set; }
    }
}
