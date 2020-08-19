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
    /// T_HOTEL_GUARANTEE 
    /// </summary>    
   [Serializable]
   [SugarTable("T_HOTEL_GUARANTEE")]
    public class T_HOTEL_GUARANTEE
    {
    
        /// <summary>
        /// 主键ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键ID")]
        public decimal GUARANTEE_ID { get; set; }
    
        /// <summary>
        /// 是否担保房
        /// </summary>
        
        [Description("是否担保房")]
        public string GUARANTEE_ISOPEN { get; set; }
    
        /// <summary>
        /// 最晚到店时间
        /// </summary>
        
        [Description("最晚到店时间")]
        public DateTime GUARANTEE_TIME { get; set; }
    
        /// <summary>
        /// 担保金额类别(P百分比，F金额)
        /// </summary>
        
        [Description("担保金额类别(P百分比，F金额)")]
        public string GUARANTEE_PRICETYPE { get; set; }
    
        /// <summary>
        /// 金额
        /// </summary>
        
        [Description("金额")]
        public decimal GUARANTEE_PRICE { get; set; }
    
        /// <summary>
        /// 担保百分比
        /// </summary>
        
        [Description("担保百分比")]
        public decimal GUARANTEE_PERCENT { get; set; }
    
        /// <summary>
        /// 担保描述
        /// </summary>
        
        [Description("担保描述")]
        public string GUARANTEE_DESCRIBE { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string GUARANTEE_MEMO { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal GUARANTEE_CREID { get; set; }
    
        /// <summary>
        /// 创建人姓名
        /// </summary>
        
        [Description("创建人姓名")]
        public string GUARANTEE_CRENAME { get; set; }
    
        /// <summary>
        /// 创建人所在机构ID
        /// </summary>
        
        [Description("创建人所在机构ID")]
        public decimal GUARANTEE_CREORGID { get; set; }
    
        /// <summary>
        /// 创建人所在机构名称
        /// </summary>
        
        [Description("创建人所在机构名称")]
        public string GUARANTEE_CREORGNAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime GUARANTEE_CREDATE { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal GUARANTEE_UPID { get; set; }
    
        /// <summary>
        /// 修改人名称
        /// </summary>
        
        [Description("修改人名称")]
        public string GUARANTEE_UPNAME { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime GUARANTEE_UPDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string GUARANTEE_ISDEL { get; set; }
    }
}
