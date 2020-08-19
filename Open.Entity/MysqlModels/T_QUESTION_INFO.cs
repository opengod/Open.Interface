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
    /// T_QUESTION_INFO 
    /// </summary>    
   [Serializable]
   [SugarTable("T_QUESTION_INFO")]
    public class T_QUESTION_INFO
    {
    
        /// <summary>
        /// 题目信息表主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("题目信息表主键")]
        public decimal QUESINFO_ID { get; set; }
    
        /// <summary>
        /// 题目编号
        /// </summary>
        
        [Description("题目编号")]
        public string QUESINFO_NO { get; set; }
    
        /// <summary>
        /// 内容
        /// </summary>
        
        [Description("内容")]
        public string QUESINFO_INFO { get; set; }
    
        /// <summary>
        /// A选项
        /// </summary>
        
        [Description("A选项")]
        public string QUESINFO_A { get; set; }
    
        /// <summary>
        /// B选项
        /// </summary>
        
        [Description("B选项")]
        public string QUESINFO_B { get; set; }
    
        /// <summary>
        /// C选项
        /// </summary>
        
        [Description("C选项")]
        public string QUESINFO_C { get; set; }
    
        /// <summary>
        /// D选项
        /// </summary>
        
        [Description("D选项")]
        public string QUESINFO_D { get; set; }
    
        /// <summary>
        /// 正确答案
        /// </summary>
        
        [Description("正确答案")]
        public string QUESINFO_ANSWER { get; set; }
    
        /// <summary>
        /// 分值
        /// </summary>
        
        [Description("分值")]
        public decimal QUESINFO_SCORE { get; set; }
    
        /// <summary>
        /// 所属日期
        /// </summary>
        
        [Description("所属日期")]
        public string QUESINFO_DATE { get; set; }
    
        /// <summary>
        /// 所属类别
        /// </summary>
        
        [Description("所属类别")]
        public string QUESINFO_CATEGORY { get; set; }
    
        /// <summary>
        /// 排序
        /// </summary>
        
        [Description("排序")]
        public decimal QUESINFO_SORT { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal QUESINFO_CREID { get; set; }
    
        /// <summary>
        /// 创建人姓名
        /// </summary>
        
        [Description("创建人姓名")]
        public string QUESINFO_CRENAME { get; set; }
    
        /// <summary>
        /// 创建人所在机构ID
        /// </summary>
        
        [Description("创建人所在机构ID")]
        public decimal QUESINFO_CREORGID { get; set; }
    
        /// <summary>
        /// 创建人所在机构名称
        /// </summary>
        
        [Description("创建人所在机构名称")]
        public string QUESINFO_CREORGNAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime QUESINFO_CREDATE { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal QUESINFO_UPID { get; set; }
    
        /// <summary>
        /// 修改人名称
        /// </summary>
        
        [Description("修改人名称")]
        public string QUESINFO_UPNAME { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime QUESINFO_UPDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string QUESINFO_ISDEL { get; set; }
    }
}
