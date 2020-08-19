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
    /// T_QUESTION_RESULT 
    /// </summary>    
   [Serializable]
   [SugarTable("T_QUESTION_RESULT")]
    public class T_QUESTION_RESULT
    {
    
        /// <summary>
        /// 答题结果表主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("答题结果表主键")]
        public decimal QUESRESULT_ID { get; set; }
    
        /// <summary>
        /// 答题结果编号
        /// </summary>
        
        [Description("答题结果编号")]
        public string QUESRESULT_NO { get; set; }
    
        /// <summary>
        /// 用户ID
        /// </summary>
        
        [Description("用户ID")]
        public decimal QUESRESULT_USERID { get; set; }
    
        /// <summary>
        /// 用户昵称
        /// </summary>
        
        [Description("用户昵称")]
        public string QUESRESULT_CNAME { get; set; }
    
        /// <summary>
        /// 题目ID
        /// </summary>
        
        [Description("题目ID")]
        public decimal QUESRESULT_QUESID { get; set; }
    
        /// <summary>
        /// 题目编号
        /// </summary>
        
        [Description("题目编号")]
        public string QUESRESULT_QUESNO { get; set; }
    
        /// <summary>
        /// 题目日期
        /// </summary>
        
        [Description("题目日期")]
        public string QUESRESULT_QUESDATE { get; set; }
    
        /// <summary>
        /// 用户选择（A，B，C，D）
        /// </summary>
        
        [Description("用户选择（A，B，C，D）")]
        public string QUESRESULT_SELECT { get; set; }
    
        /// <summary>
        /// 答题结果
        /// </summary>
        
        [Description("答题结果")]
        public decimal QUESRESULT_RESULT { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        
        [Description("")]
        public string QUESRESULT_SUGGEST { get; set; }
    
        /// <summary>
        /// 排序
        /// </summary>
        
        [Description("排序")]
        public decimal QUESRESULT_SORT { get; set; }
    
        /// <summary>
        /// 答题时间
        /// </summary>
        
        [Description("答题时间")]
        public DateTime QUESRESULT_CREDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string QUESRESULT_ISDEL { get; set; }
    }
}
