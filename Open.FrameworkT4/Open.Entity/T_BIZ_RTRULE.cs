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
    /// T_BIZ_RTRULE 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_RTRULE")]
    public class T_BIZ_RTRULE
    {
    
        /// <summary>
        /// 退票规则ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("退票规则ID")]
        public decimal RTRULE_ID { get; set; }
    
        /// <summary>
        /// 产品包ID
        /// </summary>
        
        [Description("产品包ID")]
        public decimal PACKAGE_ID { get; set; }
    
        /// <summary>
        /// 产品ID
        /// </summary>
        
        [Description("产品ID")]
        public decimal RTRULE_PRODUCTID { get; set; }
    
        /// <summary>
        /// 是否可退1是可退，0是不可退
        /// </summary>
        
        [Description("是否可退1是可退，0是不可退")]
        public decimal RTRULE_RTFLAG { get; set; }
    
        /// <summary>
        /// 游玩之前多少天不允许退
        /// </summary>
        
        [Description("游玩之前多少天不允许退")]
        public decimal RTRULE_BDATE { get; set; }
    
        /// <summary>
        /// 游玩之后多少天不允许退
        /// </summary>
        
        [Description("游玩之后多少天不允许退")]
        public decimal RTRULE_ADATE { get; set; }
    
        /// <summary>
        /// 过期是否可退
        /// </summary>
        
        [Description("过期是否可退")]
        public decimal RTRULE_EXPFLAG { get; set; }
    
        /// <summary>
        /// 过期几天后自动完结
        /// </summary>
        
        [Description("过期几天后自动完结")]
        public decimal RTRULE_EXPCLOSE { get; set; }
    
        /// <summary>
        /// 退票是否需要审核0不需要审核
        /// </summary>
        
        [Description("退票是否需要审核0不需要审核")]
        public decimal RTRULE_ISAUDIT { get; set; }
    
        /// <summary>
        /// 退票类别ID(百分比，固定值)
        /// </summary>
        
        [Description("退票类别ID(百分比，固定值)")]
        public decimal RTRULE_TYPEID { get; set; }
    
        /// <summary>
        /// 手续费
        /// </summary>
        
        [Description("手续费")]
        public decimal RTRULE_FEE { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string RTRULE_REMARK { get; set; }
    
        /// <summary>
        /// 产品名称
        /// </summary>
        
        [Description("产品名称")]
        public string PDT_NAME { get; set; }
    
        /// <summary>
        /// 产品包名称
        /// </summary>
        
        [Description("产品包名称")]
        public string PAG_NAME { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal RTRULE_CREATEID { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal RTRULE_EDITID { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime RTRULE_CEDATE { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime RTRULE_ETDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除F：T
        /// </summary>
        
        [Description("是否逻辑删除F：T")]
        public string ISLOGIDEL { get; set; }
    
        /// <summary>
        /// 删除人ID
        /// </summary>
        
        [Description("删除人ID")]
        public decimal RTRULE_DELID { get; set; }
    
        /// <summary>
        /// 删除时间
        /// </summary>
        
        [Description("删除时间")]
        public DateTime RTRULE_DELDATE { get; set; }
    
        /// <summary>
        /// 创建企业ID
        /// </summary>
        
        [Description("创建企业ID")]
        public decimal RETURN_COMPANYCID { get; set; }
    
        /// <summary>
        /// 创建企业名称
        /// </summary>
        
        [Description("创建企业名称")]
        public string RETURN_COMPANYNAME { get; set; }
    }
}
