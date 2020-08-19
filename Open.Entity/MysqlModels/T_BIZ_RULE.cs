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
    /// T_BIZ_RULE 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_RULE")]
    public class T_BIZ_RULE
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal RULE_ID { get; set; }
    
        /// <summary>
        /// 活动类型：type：1 大转盘 ，2：设计大赛投票
        /// </summary>
        
        [Description("活动类型：type：1 大转盘 ，2：设计大赛投票")]
        public string RULE_TYPE { get; set; }
    
        /// <summary>
        /// 规则类别  存储字典表
        /// </summary>
        
        [Description("规则类别  存储字典表")]
        public string RULE_NAME { get; set; }
    
        /// <summary>
        /// 规则信息
        /// </summary>
        
        [Description("规则信息")]
        public string RULE_REMARK { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        
        [Description("")]
        public decimal RULE_CREID { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        
        [Description("")]
        public string RULE_CRENAME { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        
        [Description("")]
        public decimal RULE_CREORGID { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        
        [Description("")]
        public string RULE_CREORGNAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime RULE_CREDATE { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        
        [Description("")]
        public decimal RULE_UPID { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        
        [Description("")]
        public string RULE_UPNAME { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        
        [Description("")]
        public DateTime RULE_UPDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string RULE_ISDEL { get; set; }
    }
}
