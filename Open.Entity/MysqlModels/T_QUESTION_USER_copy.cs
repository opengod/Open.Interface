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
    /// T_QUESTION_USER_copy 
    /// </summary>    
   [Serializable]
   [SugarTable("T_QUESTION_USER_copy")]
    public class T_QUESTION_USER_copy
    {
    
        /// <summary>
        /// 答题结果表主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("答题结果表主键")]
        public decimal QUESUSER_ID { get; set; }
    
        /// <summary>
        /// 用户ID
        /// </summary>
        
        [Description("用户ID")]
        public decimal QUESUSER_USERID { get; set; }
    
        /// <summary>
        /// 姓名
        /// </summary>
        
        [Description("姓名")]
        public string QUESUSER_NAME { get; set; }
    
        /// <summary>
        /// 用户昵称
        /// </summary>
        
        [Description("用户昵称")]
        public string QUESUSER_CNAME { get; set; }
    
        /// <summary>
        /// 电话
        /// </summary>
        
        [Description("电话")]
        public string QUESUSER_MOBILE { get; set; }
    
        /// <summary>
        /// 地址
        /// </summary>
        
        [Description("地址")]
        public string QUESUSER_ADDRESS { get; set; }
    
        /// <summary>
        /// 剩余答题次数
        /// </summary>
        
        [Description("剩余答题次数")]
        public decimal QUESUSER_NUMBER { get; set; }
    
        /// <summary>
        /// 当前日期
        /// </summary>
        
        [Description("当前日期")]
        public DateTime QUESUSER_CURRENTDATE { get; set; }
    
        /// <summary>
        /// 答题总积分
        /// </summary>
        
        [Description("答题总积分")]
        public decimal QUESUSER_SCORE { get; set; }
    
        /// <summary>
        /// 答题时间
        /// </summary>
        
        [Description("答题时间")]
        public DateTime QUESUSER_ANSWERDATE { get; set; }
    
        /// <summary>
        /// 转发次数
        /// </summary>
        
        [Description("转发次数")]
        public decimal QUESUSER_FORWARDTIMES { get; set; }
    
        /// <summary>
        /// 开始答题时间
        /// </summary>
        
        [Description("开始答题时间")]
        public DateTime QUESUSER_STAR { get; set; }
    
        /// <summary>
        /// 结束开始答题时间
        /// </summary>
        
        [Description("结束开始答题时间")]
        public DateTime QUESUSER_END { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime QUESUSER_CREDATE { get; set; }
    
        /// <summary>
        /// 排序
        /// </summary>
        
        [Description("排序")]
        public decimal QUESUSER_SORT { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string QUESUSER_ISDEL { get; set; }
    }
}
