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
    /// T_DESIGN_TEAM 
    /// </summary>    
   [Serializable]
   [SugarTable("T_DESIGN_TEAM")]
    public class T_DESIGN_TEAM
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal TEAM_ID { get; set; }
    
        /// <summary>
        /// 创建用户id
        /// </summary>
        
        [Description("创建用户id")]
        public decimal TEAM_MEMBERID { get; set; }
    
        /// <summary>
        /// 团队名称
        /// </summary>
        
        [Description("团队名称")]
        public string TEAM_NAME { get; set; }
    
        /// <summary>
        /// 学校
        /// </summary>
        
        [Description("学校")]
        public string TEAM_SCHOOL { get; set; }
    
        /// <summary>
        /// 负责人
        /// </summary>
        
        [Description("负责人")]
        public string TEAM_LEADER { get; set; }
    
        /// <summary>
        /// 邮箱
        /// </summary>
        
        [Description("邮箱")]
        public string TEAM_EMAIL { get; set; }
    
        /// <summary>
        /// 指导老师
        /// </summary>
        
        [Description("指导老师")]
        public string TEAM_TEACHER { get; set; }
    
        /// <summary>
        /// 合照
        /// </summary>
        
        [Description("合照")]
        public string TEAM_PHOTO { get; set; }
    
        /// <summary>
        /// 团队宣言
        /// </summary>
        
        [Description("团队宣言")]
        public string TEAM_DECLARATION { get; set; }
    
        /// <summary>
        /// 实时票数
        /// </summary>
        
        [Description("实时票数")]
        public decimal TEAM_VOTES { get; set; }
    
        /// <summary>
        /// 是否进入决赛。T：进入，F未进入。新增默认F
        /// </summary>
        
        [Description("是否进入决赛。T：进入，F未进入。新增默认F")]
        public string TEAM_ISFINALS { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime TEAM_CREDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string TEAM_ISDEL { get; set; }
    }
}
