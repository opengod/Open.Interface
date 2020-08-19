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
    /// T_BIZ_COMPLAINANSWER 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_COMPLAINANSWER")]
    public class T_BIZ_COMPLAINANSWER
    {
    
        /// <summary>
        /// 常见问题解答表主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("常见问题解答表主键")]
        public decimal ANSWER_ID { get; set; }
    
        /// <summary>
        /// 题目编号
        /// </summary>
        
        [Description("题目编号")]
        public string ANSWER_NO { get; set; }
    
        /// <summary>
        /// 题目内容
        /// </summary>
        
        [Description("题目内容")]
        public string ANSWER_INFO { get; set; }
    
        /// <summary>
        /// 答案
        /// </summary>
        
        [Description("答案")]
        public string ANSWER_ANSWER { get; set; }
    
        /// <summary>
        /// 所属类别
        /// </summary>
        
        [Description("所属类别")]
        public string ANSWER_CATEGORY { get; set; }
    
        /// <summary>
        /// 排序
        /// </summary>
        
        [Description("排序")]
        public decimal ANSWER_SORT { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal ANSWER_CREID { get; set; }
    
        /// <summary>
        /// 创建人姓名
        /// </summary>
        
        [Description("创建人姓名")]
        public string ANSWER_CRENAME { get; set; }
    
        /// <summary>
        /// 创建人所在机构ID
        /// </summary>
        
        [Description("创建人所在机构ID")]
        public decimal ANSWER_CREORGID { get; set; }
    
        /// <summary>
        /// 创建人所在机构名称
        /// </summary>
        
        [Description("创建人所在机构名称")]
        public string ANSWER_CREORGNAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime ANSWER_CREDATE { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal ANSWER_UPID { get; set; }
    
        /// <summary>
        /// 修改人名称
        /// </summary>
        
        [Description("修改人名称")]
        public string ANSWER_UPNAME { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime ANSWER_UPDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string ANSWER_ISDEL { get; set; }
    }
}
