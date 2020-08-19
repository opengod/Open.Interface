//-----------------------------------------------------------------------
// <Copyright>
// * copyright © 2020 open All Rights Reserved
// * version : 4.0.30319.42000
// * author  : open
// * history : Created by open 2020-08-19 11:17:17 
// </Copyright>
//-----------------------------------------------------------------------
using System;
using SqlSugar;
using System.ComponentModel;

namespace Open.Entity.Oracle
{
    /// <summary>
    /// T_BIZ_PDT_CTL 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_PDT_CTL")]
    public class T_BIZ_PDT_CTL
    {
    
        /// <summary>
        /// 产品控制表ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("产品控制表ID")]
        public decimal PDT_CTL_ID { get; set; }
    
        /// <summary>
        /// 产品ID
        /// </summary>
        
        [Description("产品ID")]
        public decimal PDT_CTL_TICKETID { get; set; }
    
        /// <summary>
        /// 门票开始日期
        /// </summary>
        
        [Description("门票开始日期")]
        public DateTime PDT_CTL_STARTDAY { get; set; }
    
        /// <summary>
        /// 门票结束日期
        /// </summary>
        
        [Description("门票结束日期")]
        public DateTime PDT_CTL_ENDDAY { get; set; }
    
        /// <summary>
        /// 门票开始时间
        /// </summary>
        
        [Description("门票开始时间")]
        public string PDT_CTL_STARTTIME { get; set; }
    
        /// <summary>
        /// 门票结束时间
        /// </summary>
        
        [Description("门票结束时间")]
        public string PDT_CTL_ENDTIME { get; set; }
    
        /// <summary>
        /// 控制方法0是根据时间控制1是根据售卖时间2是根据检票时间
        /// </summary>
        
        [Description("控制方法0是根据时间控制1是根据售卖时间2是根据检票时间")]
        public decimal PDT_CTL_STYLE { get; set; }
    
        /// <summary>
        /// 售票时间后几天有效
        /// </summary>
        
        [Description("售票时间后几天有效")]
        public decimal PDT_CTL_SALEDAY { get; set; }
    
        /// <summary>
        /// 售票时间后有效次数
        /// </summary>
        
        [Description("售票时间后有效次数")]
        public decimal PDT_CTL_SALECOUNT { get; set; }
    
        /// <summary>
        /// 检票时间后几天有效
        /// </summary>
        
        [Description("检票时间后几天有效")]
        public decimal PDT_CTL_CHECKDAY { get; set; }
    
        /// <summary>
        /// 检票时间后有效次数
        /// </summary>
        
        [Description("检票时间后有效次数")]
        public decimal PDT_CTL_CHECKCOUNT { get; set; }
    
        /// <summary>
        /// 星期一是否有效0是有效1是无效
        /// </summary>
        
        [Description("星期一是否有效0是有效1是无效")]
        public decimal PDT_CTL_MONDAY { get; set; }
    
        /// <summary>
        /// 星期二是否有效0是有效1是无效
        /// </summary>
        
        [Description("星期二是否有效0是有效1是无效")]
        public decimal PDT_CTL_TUESDAY { get; set; }
    
        /// <summary>
        /// 星期三是否有效0是有效1是无效
        /// </summary>
        
        [Description("星期三是否有效0是有效1是无效")]
        public decimal PDT_CTL_WEDNESDAY { get; set; }
    
        /// <summary>
        /// 星期四是否有效0是有效1是无效
        /// </summary>
        
        [Description("星期四是否有效0是有效1是无效")]
        public decimal PDT_CTL_THURSDAY { get; set; }
    
        /// <summary>
        /// 星期五是否有效0是有效1是无效
        /// </summary>
        
        [Description("星期五是否有效0是有效1是无效")]
        public decimal PDT_CTL_FRIDAY { get; set; }
    
        /// <summary>
        /// 星期六是否有效0是有效1是无效
        /// </summary>
        
        [Description("星期六是否有效0是有效1是无效")]
        public decimal PDT_CTL_SATURDAY { get; set; }
    
        /// <summary>
        /// 星期日是否有效0是有效1是无效
        /// </summary>
        
        [Description("星期日是否有效0是有效1是无效")]
        public decimal PDT_CTL_SUNDAY { get; set; }
    
        /// <summary>
        /// 景区ID
        /// </summary>
        
        [Description("景区ID")]
        public decimal PDT_CTL_PARKID { get; set; }
    
        /// <summary>
        /// 逻辑删除
        /// </summary>
        
        [Description("逻辑删除")]
        public string ISLOGIDEL { get; set; }
    
        /// <summary>
        /// 删除人ID
        /// </summary>
        
        [Description("删除人ID")]
        public decimal PDT_CTL_DELID { get; set; }
    
        /// <summary>
        /// 删除人姓名
        /// </summary>
        
        [Description("删除人姓名")]
        public string PDT_CTL_DELNAME { get; set; }
    
        /// <summary>
        /// 删除日期
        /// </summary>
        
        [Description("删除日期")]
        public DateTime PDT_CTL_DELDATE { get; set; }
    
        /// <summary>
        /// 创建企业ID
        /// </summary>
        
        [Description("创建企业ID")]
        public decimal PDT_CTL_COMPID { get; set; }
    
        /// <summary>
        /// 创建企业名称
        /// </summary>
        
        [Description("创建企业名称")]
        public string PDT_CTL_COMPNA { get; set; }
    }
}
