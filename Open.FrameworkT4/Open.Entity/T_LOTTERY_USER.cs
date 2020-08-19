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
    /// T_LOTTERY_USER 
    /// </summary>    
   [Serializable]
   [SugarTable("T_LOTTERY_USER")]
    public class T_LOTTERY_USER
    {
    
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("")]
        public decimal LOTTERYUSER_ID { get; set; }
    
        /// <summary>
        /// 所属活动规则表id
        /// </summary>
        
        [Description("所属活动规则表id")]
        public decimal LOTTERYUSER_RULEID { get; set; }
    
        /// <summary>
        /// 参与用户ID
        /// </summary>
        
        [Description("参与用户ID")]
        public decimal LOTTERYUSER_USERID { get; set; }
    
        /// <summary>
        /// 参与用户昵称
        /// </summary>
        
        [Description("参与用户昵称")]
        public string LOTTERYUSER_USERNAME { get; set; }
    
        /// <summary>
        /// 抽奖状态（未抽奖、已抽奖）
        /// </summary>
        
        [Description("抽奖状态（未抽奖、已抽奖）")]
        public int LOTTERYUSER_PLAYSTATE { get; set; }
    
        /// <summary>
        /// 中奖状态（未中奖、已中奖、已领奖）
        /// </summary>
        
        [Description("中奖状态（未中奖、已中奖、已领奖）")]
        public int LOTTERYUSER_BINGOSTATE { get; set; }
    
        /// <summary>
        /// 中奖奖项ID
        /// </summary>
        
        [Description("中奖奖项ID")]
        public decimal LOTTERYUSER_BINGOAWARDSID { get; set; }
    
        /// <summary>
        /// 中奖奖项名称
        /// </summary>
        
        [Description("中奖奖项名称")]
        public string LOTTERYUSER_BINGOAWARDSNAME { get; set; }
    
        /// <summary>
        /// 排序
        /// </summary>
        
        [Description("排序")]
        public decimal LOTTERYUSER_SORT { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime LOTTERYUSER_CREDATE { get; set; }
    
        /// <summary>
        /// 是否已发送优惠券：F：未发放，T已发放
        /// </summary>
        
        [Description("是否已发送优惠券：F：未发放，T已发放")]
        public string LOTTERYUSER_ISSEND { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string LOTTERYUSER_ISDEL { get; set; }
    }
}
