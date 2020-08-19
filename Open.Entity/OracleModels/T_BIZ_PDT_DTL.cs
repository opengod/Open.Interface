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
    /// T_BIZ_PDT_DTL 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_PDT_DTL")]
    public class T_BIZ_PDT_DTL
    {
    
        /// <summary>
        /// 套票明细表ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("套票明细表ID")]
        public decimal PDT_DTL_ID { get; set; }
    
        /// <summary>
        /// 套票产品ID
        /// </summary>
        
        [Description("套票产品ID")]
        public decimal PDT_DTL_PDTID { get; set; }
    
        /// <summary>
        /// 套票建筑名称
        /// </summary>
        
        [Description("套票建筑名称")]
        public string PDT_DTL_NAME { get; set; }
    
        /// <summary>
        /// 套票下明细产品ID
        /// </summary>
        
        [Description("套票下明细产品ID")]
        public decimal PDT_DTL_PDT2ID { get; set; }
    
        /// <summary>
        /// 套票下明细产品名称
        /// </summary>
        
        [Description("套票下明细产品名称")]
        public string PDT_DTL_PDT2NM { get; set; }
    
        /// <summary>
        /// 套票下明细产品编码
        /// </summary>
        
        [Description("套票下明细产品编码")]
        public string PDT_DTL_PDT2CODE { get; set; }
    
        /// <summary>
        /// 产品数量
        /// </summary>
        
        [Description("产品数量")]
        public decimal PDT_DTL_NUM { get; set; }
    
        /// <summary>
        /// 与主产品使用间隔天数
        /// </summary>
        
        [Description("与主产品使用间隔天数")]
        public decimal PDT_DTL_DTCOUNT { get; set; }
    
        /// <summary>
        /// 景区ID
        /// </summary>
        
        [Description("景区ID")]
        public decimal PDT_DTL_PACKID { get; set; }
    
        /// <summary>
        /// 企业ID
        /// </summary>
        
        [Description("企业ID")]
        public decimal PDT_DTL_ORGID { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal PDT_DTL_CUID { get; set; }
    
        /// <summary>
        /// 创建人姓名
        /// </summary>
        
        [Description("创建人姓名")]
        public string PDT_DTL_CNAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime PDT_DTL_CDATE { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal PDT_DTL_EUID { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime PDT_DTL_EDATE { get; set; }
    
        /// <summary>
        /// 修改人姓名
        /// </summary>
        
        [Description("修改人姓名")]
        public string PDT_DTL_ENAME { get; set; }
    
        /// <summary>
        /// 逻辑删除
        /// </summary>
        
        [Description("逻辑删除")]
        public string ISLOGIDEL { get; set; }
    
        /// <summary>
        /// 删除人ID
        /// </summary>
        
        [Description("删除人ID")]
        public decimal DTL_DELID { get; set; }
    
        /// <summary>
        /// 删除人
        /// </summary>
        
        [Description("删除人")]
        public string DTL_DELNAME { get; set; }
    
        /// <summary>
        /// 删除日期
        /// </summary>
        
        [Description("删除日期")]
        public DateTime DTL_DATE { get; set; }
    
        /// <summary>
        /// 创建企业ID
        /// </summary>
        
        [Description("创建企业ID")]
        public decimal PDT_DTL_COMPANYCID { get; set; }
    
        /// <summary>
        /// 创建企业名称
        /// </summary>
        
        [Description("创建企业名称")]
        public string PDT_DTL_COMPANYNAME { get; set; }
    }
}
