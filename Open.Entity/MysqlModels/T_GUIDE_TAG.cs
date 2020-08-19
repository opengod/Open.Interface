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
    /// T_GUIDE_TAG 
    /// </summary>    
   [Serializable]
   [SugarTable("T_GUIDE_TAG")]
    public class T_GUIDE_TAG
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal GUIDETAG_ID { get; set; }
    
        /// <summary>
        /// 旅行社ID
        /// </summary>
        
        [Description("旅行社ID")]
        public decimal GUIDETAG_TAID { get; set; }
    
        /// <summary>
        /// 旅行社名称
        /// </summary>
        
        [Description("旅行社名称")]
        public string GUIDETAG_TANAME { get; set; }
    
        /// <summary>
        /// 导游主键
        /// </summary>
        
        [Description("导游主键")]
        public decimal GUIDETAG_GUIDEID { get; set; }
    
        /// <summary>
        /// 入职日期
        /// </summary>
        
        [Description("入职日期")]
        public DateTime GUIDETAG_JOINDATE { get; set; }
    
        /// <summary>
        /// 离职日期
        /// </summary>
        
        [Description("离职日期")]
        public DateTime GUIDETAG_LEAVEDATE { get; set; }
    
        /// <summary>
        /// 职位状态（0在职、1离职）
        /// </summary>
        
        [Description("职位状态（0在职、1离职）")]
        public string GUIDETAG_STATUS { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string GUIDETAG_MEMO { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal GUIDETAG_CREID { get; set; }
    
        /// <summary>
        /// 创建人姓名
        /// </summary>
        
        [Description("创建人姓名")]
        public string GUIDETAG_CRENAME { get; set; }
    
        /// <summary>
        /// 创建人所在机构ID
        /// </summary>
        
        [Description("创建人所在机构ID")]
        public decimal GUIDETAG_CREORGID { get; set; }
    
        /// <summary>
        /// 创建人所在机构名称
        /// </summary>
        
        [Description("创建人所在机构名称")]
        public string GUIDETAG_CREORGNAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime GUIDETAG_CREDATE { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal GUIDETAG_UPID { get; set; }
    
        /// <summary>
        /// 修改人名称
        /// </summary>
        
        [Description("修改人名称")]
        public string GUIDETAG_UPNAME { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime GUIDETAG_UPDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string GUIDETAG_ISDEL { get; set; }
    }
}
