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
    /// T_LINE_PRO 
    /// </summary>    
   [Serializable]
   [SugarTable("T_LINE_PRO")]
    public class T_LINE_PRO
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal LINEPRO_ID { get; set; }
    
        /// <summary>
        /// 供应商类别
        /// </summary>
        
        [Description("供应商类别")]
        public string LINEPRO_SUPTYPE { get; set; }
    
        /// <summary>
        /// 供应商线路ID
        /// </summary>
        
        [Description("供应商线路ID")]
        public string LINEPRO_SUPLINEID { get; set; }
    
        /// <summary>
        /// 供应商线路编号
        /// </summary>
        
        [Description("供应商线路编号")]
        public string LINEPRO_SUPPARKCODE { get; set; }
    
        /// <summary>
        /// 供应商线路产品ID
        /// </summary>
        
        [Description("供应商线路产品ID")]
        public string LINEPRO_SUPPROID { get; set; }
    
        /// <summary>
        /// 供应商线路产品门票ID
        /// </summary>
        
        [Description("供应商线路产品门票ID")]
        public string LINEPRO_SUPPROTICKETID { get; set; }
    
        /// <summary>
        /// 产品编码
        /// </summary>
        
        [Description("产品编码")]
        public string LINEPRO_CODE { get; set; }
    
        /// <summary>
        /// 产品名称
        /// </summary>
        
        [Description("产品名称")]
        public string LINEPRO_NAME { get; set; }
    
        /// <summary>
        /// 预订须知
        /// </summary>
        
        [Description("预订须知")]
        public string LINEPRO_BUYNOTE { get; set; }
    
        /// <summary>
        /// 售卖价
        /// </summary>
        
        [Description("售卖价")]
        public decimal LINEPRO_INPRICE { get; set; }
    
        /// <summary>
        /// 结算价
        /// </summary>
        
        [Description("结算价")]
        public decimal LINEPR_OPRICE { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string LINEPRO_MEMO { get; set; }
    
        /// <summary>
        /// 排序
        /// </summary>
        
        [Description("排序")]
        public decimal LINEPRO_SORT { get; set; }
    
        /// <summary>
        /// 售卖规则ID
        /// </summary>
        
        [Description("售卖规则ID")]
        public decimal LINEPRO_SELLRULEID { get; set; }
    
        /// <summary>
        /// 售卖规则名称
        /// </summary>
        
        [Description("售卖规则名称")]
        public string LINEPRO_SELLRULENAME { get; set; }
    
        /// <summary>
        /// 退订规则ID
        /// </summary>
        
        [Description("退订规则ID")]
        public decimal LINEPRO_RTTRULEID { get; set; }
    
        /// <summary>
        /// 退订规则名称
        /// </summary>
        
        [Description("退订规则名称")]
        public string LINEPRO_RTTRULENAME { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal LINEPRO_CREID { get; set; }
    
        /// <summary>
        /// 创建人姓名
        /// </summary>
        
        [Description("创建人姓名")]
        public string LINEPRO_CRENAME { get; set; }
    
        /// <summary>
        /// 创建人所在机构ID
        /// </summary>
        
        [Description("创建人所在机构ID")]
        public decimal LINEPRO_CREORGID { get; set; }
    
        /// <summary>
        /// 创建人所在机构名称
        /// </summary>
        
        [Description("创建人所在机构名称")]
        public string LINEPRO_CREORGNAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime LINEPRO_CREDATE { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal LINEPRO_UPID { get; set; }
    
        /// <summary>
        /// 修改人名称
        /// </summary>
        
        [Description("修改人名称")]
        public string LINEPRO_UPNAME { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime LINEPRO_UPDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string LINEPRO_ISDEL { get; set; }
    }
}
