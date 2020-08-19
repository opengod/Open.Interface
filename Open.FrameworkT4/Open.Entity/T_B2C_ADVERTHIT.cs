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
    /// T_B2C_ADVERTHIT 
    /// </summary>    
   [Serializable]
   [SugarTable("T_B2C_ADVERTHIT")]
    public class T_B2C_ADVERTHIT
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal ADVERTHIT_ID { get; set; }
    
        /// <summary>
        /// 广告ID
        /// </summary>
        
        [Description("广告ID")]
        public decimal ADVERTHIT_ADVERTID { get; set; }
    
        /// <summary>
        /// 广告标题
        /// </summary>
        
        [Description("广告标题")]
        public string ADVERTHIT_ADVERTTITLE { get; set; }
    
        /// <summary>
        /// 会员ID
        /// </summary>
        
        [Description("会员ID")]
        public decimal ADVERTHIT_MEMBERID { get; set; }
    
        /// <summary>
        /// 会员姓名
        /// </summary>
        
        [Description("会员姓名")]
        public string ADVERTHIT_MEMBERNAME { get; set; }
    
        /// <summary>
        /// 产品类型
        /// </summary>
        
        [Description("产品类型")]
        public string ADVERTHIT_PROTYPE { get; set; }
    
        /// <summary>
        /// 产品名称
        /// </summary>
        
        [Description("产品名称")]
        public string ADVERTHIT_PRONAME { get; set; }
    
        /// <summary>
        /// 产品ID
        /// </summary>
        
        [Description("产品ID")]
        public decimal ADVERTHIT_PROID { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal ADVERTHIT_CREID { get; set; }
    
        /// <summary>
        /// 创建人姓名
        /// </summary>
        
        [Description("创建人姓名")]
        public string ADVERTHIT_CRENAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime ADVERTHIT_CREDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string ADVERTHIT_ISDEL { get; set; }
    }
}
