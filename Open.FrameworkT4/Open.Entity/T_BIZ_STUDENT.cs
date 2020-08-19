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
    /// T_BIZ_STUDENT 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_STUDENT")]
    public class T_BIZ_STUDENT
    {
    
        /// <summary>
        /// 高校新生信息表主键ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("高校新生信息表主键ID")]
        public decimal STUDENT_ID { get; set; }
    
        /// <summary>
        /// 姓名
        /// </summary>
        
        [Description("姓名")]
        public string STUDENT_NAME { get; set; }
    
        /// <summary>
        /// 手机号
        /// </summary>
        
        [Description("手机号")]
        public string STUDENT_PHONE { get; set; }
    
        /// <summary>
        /// 身份证号
        /// </summary>
        
        [Description("身份证号")]
        public string STUDENT_ICNO { get; set; }
    
        /// <summary>
        /// 学校名称
        /// </summary>
        
        [Description("学校名称")]
        public string STUDENT_SCHOOL { get; set; }
    
        /// <summary>
        /// 专业
        /// </summary>
        
        [Description("专业")]
        public string STUDENT_SPECIALTY { get; set; }
    
        /// <summary>
        /// 学号
        /// </summary>
        
        [Description("学号")]
        public string STUDENT_SNO { get; set; }
    
        /// <summary>
        /// 是否删除
        /// </summary>
        
        [Description("是否删除")]
        public string STUDENT_ISDEL { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal STUDENT_CREID { get; set; }
    
        /// <summary>
        /// 创建人姓名
        /// </summary>
        
        [Description("创建人姓名")]
        public string STUDENT_CRENAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime STUDENT_CREDATE { get; set; }
    
        /// <summary>
        /// 入职通知书编号
        /// </summary>
        
        [Description("入职通知书编号")]
        public string STUDENT_NO { get; set; }
    
        /// <summary>
        /// 年限(届)
        /// </summary>
        
        [Description("年限(届)")]
        public string STUDENT_PERIOD { get; set; }
    }
}
