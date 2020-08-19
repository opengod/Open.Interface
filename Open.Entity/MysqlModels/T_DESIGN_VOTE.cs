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
    /// T_DESIGN_VOTE 
    /// </summary>    
   [Serializable]
   [SugarTable("T_DESIGN_VOTE")]
    public class T_DESIGN_VOTE
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal VOTE_ID { get; set; }
    
        /// <summary>
        /// 用户ID
        /// </summary>
        
        [Description("用户ID")]
        public decimal VOTE_MEMBERID { get; set; }
    
        /// <summary>
        /// 团队ID
        /// </summary>
        
        [Description("团队ID")]
        public decimal VOTE_TEAMID { get; set; }
    
        /// <summary>
        /// 投票类型（D：线路设计大赛）
        /// </summary>
        
        [Description("投票类型（D：线路设计大赛）")]
        public string VOTE_TYPE { get; set; }
    
        /// <summary>
        /// 投票时间
        /// </summary>
        
        [Description("投票时间")]
        public DateTime VOTE_CREDATE { get; set; }
    }
}
