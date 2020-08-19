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
    /// T_TICKET_BOOKCAL 
    /// </summary>    
   [Serializable]
   [SugarTable("T_TICKET_BOOKCAL")]
    public class T_TICKET_BOOKCAL
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal BOOKCAL_ID { get; set; }
    
        /// <summary>
        /// 景区机构ID
        /// </summary>
        
        [Description("景区机构ID")]
        public decimal BOOKCAL_PARKID { get; set; }
    
        /// <summary>
        /// 景区名称名称
        /// </summary>
        
        [Description("景区名称名称")]
        public string BOOKCAL_PARKNAME { get; set; }
    
        /// <summary>
        /// 日期
        /// </summary>
        
        [Description("日期")]
        public DateTime BOOKCAL_DATE { get; set; }
    
        /// <summary>
        /// 星期
        /// </summary>
        
        [Description("星期")]
        public string BOOKCAL_WEEKDAY { get; set; }
    
        /// <summary>
        /// 时段开始时间
        /// </summary>
        
        [Description("时段开始时间")]
        public DateTime BOOKCAL_STARTIME { get; set; }
    
        /// <summary>
        /// 时段结束时间
        /// </summary>
        
        [Description("时段结束时间")]
        public DateTime BOOKCAL_ENDTIME { get; set; }
    
        /// <summary>
        /// 可预约人数
        /// </summary>
        
        [Description("可预约人数")]
        public decimal BOOKCAL_TOTALNUM { get; set; }
    
        /// <summary>
        /// 已预约人数（后台不可编辑）
        /// </summary>
        
        [Description("已预约人数（后台不可编辑）")]
        public decimal BOOKCAL_BOOKNUM { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string BOOKCAL_MEMO { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal BOOKCAL_CREID { get; set; }
    
        /// <summary>
        /// 创建人姓名
        /// </summary>
        
        [Description("创建人姓名")]
        public string BOOKCAL_CRENAME { get; set; }
    
        /// <summary>
        /// 创建人所在机构ID
        /// </summary>
        
        [Description("创建人所在机构ID")]
        public decimal BOOKCAL_CREORGID { get; set; }
    
        /// <summary>
        /// 创建人所在机构名称
        /// </summary>
        
        [Description("创建人所在机构名称")]
        public string BOOKCAL_CREORGNAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime BOOKCAL_CREDATE { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal BOOKCAL_UPID { get; set; }
    
        /// <summary>
        /// 修改人名称
        /// </summary>
        
        [Description("修改人名称")]
        public string BOOKCAL_UPNAME { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime BOOKCAL_UPDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string BOOKCAL_ISDEL { get; set; }
    }
}
