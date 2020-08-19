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
    /// T_TICKET_PERIOD 
    /// </summary>    
   [Serializable]
   [SugarTable("T_TICKET_PERIOD")]
    public class T_TICKET_PERIOD
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal PERIOD_ID { get; set; }
    
        /// <summary>
        /// 门票ID
        /// </summary>
        
        [Description("门票ID")]
        public decimal PERIOD_PRODUCTID { get; set; }
    
        /// <summary>
        /// 门票名称
        /// </summary>
        
        [Description("门票名称")]
        public string PERIOD_PRODUCTNAME { get; set; }
    
        /// <summary>
        /// 景区ID
        /// </summary>
        
        [Description("景区ID")]
        public decimal PERIOD_PARKID { get; set; }
    
        /// <summary>
        /// 景区名称
        /// </summary>
        
        [Description("景区名称")]
        public string PERIOD_PARKNAME { get; set; }
    
        /// <summary>
        /// 有效期开始
        /// </summary>
        
        [Description("有效期开始")]
        public DateTime PERIOD_DATES { get; set; }
    
        /// <summary>
        /// 有效期结束
        /// </summary>
        
        [Description("有效期结束")]
        public DateTime PERIOD_DATEE { get; set; }
    
        /// <summary>
        /// 星期几有效
        /// </summary>
        
        [Description("星期几有效")]
        public string PERIOD_VALALIDWEEK { get; set; }
    
        /// <summary>
        /// 不可使用日期
        /// </summary>
        
        [Description("不可使用日期")]
        public string PERIOD_INVALIDDATE { get; set; }
    
        /// <summary>
        /// 上架日期默认取有效期
        /// </summary>
        
        [Description("上架日期默认取有效期")]
        public DateTime PERIOD_SALEDATES { get; set; }
    
        /// <summary>
        /// 下架日期默认取有效期
        /// </summary>
        
        [Description("下架日期默认取有效期")]
        public DateTime PERIOD_SALEDATEE { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal PERIOD_CREID { get; set; }
    
        /// <summary>
        /// 创建人姓名
        /// </summary>
        
        [Description("创建人姓名")]
        public string PERIOD_CRENAME { get; set; }
    
        /// <summary>
        /// 创建人所在机构ID
        /// </summary>
        
        [Description("创建人所在机构ID")]
        public decimal PERIOD_CREORGID { get; set; }
    
        /// <summary>
        /// 创建人所在机构名称
        /// </summary>
        
        [Description("创建人所在机构名称")]
        public string PERIOD_CREORGNAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime PERIOD_CREDATE { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal PERIOD_UPID { get; set; }
    
        /// <summary>
        /// 修改人名称
        /// </summary>
        
        [Description("修改人名称")]
        public string PERIOD_UPNAME { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime PERIOD_UPDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string PERIOD_ISDEL { get; set; }
    }
}
