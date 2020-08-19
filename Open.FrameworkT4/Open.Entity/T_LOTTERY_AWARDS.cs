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
    /// T_LOTTERY_AWARDS 
    /// </summary>    
   [Serializable]
   [SugarTable("T_LOTTERY_AWARDS")]
    public class T_LOTTERY_AWARDS
    {
    
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("")]
        public decimal LOTTERYAWARDS_ID { get; set; }
    
        /// <summary>
        /// 活动规则表id
        /// </summary>
        
        [Description("活动规则表id")]
        public decimal LOTTERYAWARDS_RULEID { get; set; }
    
        /// <summary>
        /// 奖项名称
        /// </summary>
        
        [Description("奖项名称")]
        public string LOTTERYAWARDS_NAME { get; set; }
    
        /// <summary>
        /// 可中奖人数
        /// </summary>
        
        [Description("可中奖人数")]
        public decimal LOTTERYAWARDS_NUMBER { get; set; }
    
        /// <summary>
        /// 中奖概率
        /// </summary>
        
        [Description("中奖概率")]
        public decimal LOTTERYAWARDS_PROBABILITY { get; set; }
    
        /// <summary>
        /// 已中奖人数
        /// </summary>
        
        [Description("已中奖人数")]
        public decimal LOTTERYAWARDS_BINGONUMBER { get; set; }
    
        /// <summary>
        /// 奖品名称
        /// </summary>
        
        [Description("奖品名称")]
        public string LOTTERYAWARDS_PRIZENAME { get; set; }
    
        /// <summary>
        /// 排序
        /// </summary>
        
        [Description("排序")]
        public decimal LOTTERYAWARDS_SORT { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime LOTTERYAWARDS_CREDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string LOTTERYAWARDS_ISDEL { get; set; }
    }
}
