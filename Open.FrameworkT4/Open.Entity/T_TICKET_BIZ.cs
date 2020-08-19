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
    /// T_TICKET_BIZ 
    /// </summary>    
   [Serializable]
   [SugarTable("T_TICKET_BIZ")]
    public class T_TICKET_BIZ
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal TICKET_ID { get; set; }
    
        /// <summary>
        /// 中文名称
        /// </summary>
        
        [Description("中文名称")]
        public string TICKET_CNAME { get; set; }
    
        /// <summary>
        /// 英文名称
        /// </summary>
        
        [Description("英文名称")]
        public string TICKET_ENAME { get; set; }
    
        /// <summary>
        /// 打印中文名称
        /// </summary>
        
        [Description("打印中文名称")]
        public string TICKET_DISCNAME { get; set; }
    
        /// <summary>
        /// 打印英文名称
        /// </summary>
        
        [Description("打印英文名称")]
        public string TICKET_DISENAME { get; set; }
    
        /// <summary>
        /// 售卖规则ID
        /// </summary>
        
        [Description("售卖规则ID")]
        public decimal TICKET_SELLRULEID { get; set; }
    
        /// <summary>
        /// 退订规则ID
        /// </summary>
        
        [Description("退订规则ID")]
        public decimal TICKET_RTTRULEID { get; set; }
    
        /// <summary>
        /// 供应商ID
        /// </summary>
        
        [Description("供应商ID")]
        public decimal TICKET_SUPID { get; set; }
    
        /// <summary>
        /// 供应商编码
        /// </summary>
        
        [Description("供应商编码")]
        public string TICKET_SUPCODE { get; set; }
    
        /// <summary>
        /// 供应商名称
        /// </summary>
        
        [Description("供应商名称")]
        public string TICKET_SUPNAME { get; set; }
    
        /// <summary>
        /// 供应商景区ID
        /// </summary>
        
        [Description("供应商景区ID")]
        public string TICKET_SUPPARKID { get; set; }
    
        /// <summary>
        /// 供应商景区编号
        /// </summary>
        
        [Description("供应商景区编号")]
        public string TICKET_SUPPARKCODE { get; set; }
    
        /// <summary>
        /// 供应商产品ID
        /// </summary>
        
        [Description("供应商产品ID")]
        public string TICKET_SUPPROID { get; set; }
    
        /// <summary>
        /// 供应商产品门票ID
        /// </summary>
        
        [Description("供应商产品门票ID")]
        public string TICKET_SUPPROTICKETID { get; set; }
    
        /// <summary>
        /// 所属景区ID
        /// </summary>
        
        [Description("所属景区ID")]
        public decimal TICKET_PARKID { get; set; }
    
        /// <summary>
        /// 所属景区名称
        /// </summary>
        
        [Description("所属景区名称")]
        public string TICKET_PARKNAME { get; set; }
    
        /// <summary>
        /// 线上门票编码
        /// </summary>
        
        [Description("线上门票编码")]
        public string TICKET_CODE { get; set; }
    
        /// <summary>
        /// 线下门票编码
        /// </summary>
        
        [Description("线下门票编码")]
        public string TICKET_OFFCODE { get; set; }
    
        /// <summary>
        /// 有效天数
        /// </summary>
        
        [Description("有效天数")]
        public decimal TICKET_DAYS { get; set; }
    
        /// <summary>
        /// 有效人数
        /// </summary>
        
        [Description("有效人数")]
        public decimal TICKET_PERSONS { get; set; }
    
        /// <summary>
        /// 是否启用
        /// </summary>
        
        [Description("是否启用")]
        public string TICKET_ISENABLE { get; set; }
    
        /// <summary>
        /// 所属组别
        /// </summary>
        
        [Description("所属组别")]
        public string TICKET_GROUP { get; set; }
    
        /// <summary>
        /// 票面价格
        /// </summary>
        
        [Description("票面价格")]
        public decimal TICKET_MARKETPRICE { get; set; }
    
        /// <summary>
        /// 售卖价
        /// </summary>
        
        [Description("售卖价")]
        public decimal TICKET_SELLPRICE { get; set; }
    
        /// <summary>
        /// 景区结算价格
        /// </summary>
        
        [Description("景区结算价格")]
        public decimal TICKET_SETTLEPRICE { get; set; }
    
        /// <summary>
        /// 是否期票
        /// </summary>
        
        [Description("是否期票")]
        public string TICKET_ISPERIOD { get; set; }
    
        /// <summary>
        /// 是否是联票
        /// </summary>
        
        [Description("是否是联票")]
        public string TICKET_ISCUPON { get; set; }
    
        /// <summary>
        /// 是否延迟入园
        /// </summary>
        
        [Description("是否延迟入园")]
        public string TICKET_ISDELAY { get; set; }
    
        /// <summary>
        /// 延迟入园时间单位分钟
        /// </summary>
        
        [Description("延迟入园时间单位分钟")]
        public decimal TICKET_DELAYTIME { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string TICKET_MEMO { get; set; }
    
        /// <summary>
        /// 排序
        /// </summary>
        
        [Description("排序")]
        public decimal TICKET_SORT { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal TICKET_CREID { get; set; }
    
        /// <summary>
        /// 创建人姓名
        /// </summary>
        
        [Description("创建人姓名")]
        public string TICKET_CRENAME { get; set; }
    
        /// <summary>
        /// 创建人所在机构ID
        /// </summary>
        
        [Description("创建人所在机构ID")]
        public decimal TICKET_CREORGID { get; set; }
    
        /// <summary>
        /// 创建人所在机构名称
        /// </summary>
        
        [Description("创建人所在机构名称")]
        public string TICKET_CREORGNAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime TICKET_CREDATE { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal TICKET_UPID { get; set; }
    
        /// <summary>
        /// 修改人名称
        /// </summary>
        
        [Description("修改人名称")]
        public string TICKET_UPNAME { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime TICKET_UPDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string TICKET_ISDEL { get; set; }
    }
}
