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
    /// T_RPT_NUMDISTRIBUTION 
    /// </summary>    
   [Serializable]
   [SugarTable("T_RPT_NUMDISTRIBUTION")]
    public class T_RPT_NUMDISTRIBUTION
    {
    
        /// <summary>
        /// id
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("id")]
        public decimal NUMDISTRIBUTION_ID { get; set; }
    
        /// <summary>
        /// 区域id
        /// </summary>
        
        [Description("区域id")]
        public string NUMDISTRIBUTION_AREAID { get; set; }
    
        /// <summary>
        /// 场次id
        /// </summary>
        
        [Description("场次id")]
        public string NUMDISTRIBUTION_SCREENINGSID { get; set; }
    
        /// <summary>
        /// 剧目id
        /// </summary>
        
        [Description("剧目id")]
        public string NUMDISTRIBUTION_REPERTORYID { get; set; }
    
        /// <summary>
        /// 大厅id
        /// </summary>
        
        [Description("大厅id")]
        public string NUMDISTRIBUTION_HALLID { get; set; }
    
        /// <summary>
        /// 线下比例
        /// </summary>
        
        [Description("线下比例")]
        public decimal NUMDISTRIBUTION_UNPROPORTION { get; set; }
    
        /// <summary>
        /// 线下总数量
        /// </summary>
        
        [Description("线下总数量")]
        public decimal NUMDISTRIBUTION_UNSUM { get; set; }
    
        /// <summary>
        /// 线下已售
        /// </summary>
        
        [Description("线下已售")]
        public decimal NUMDISTRIBUTION_UNSALE { get; set; }
    
        /// <summary>
        /// 线上已售
        /// </summary>
        
        [Description("线上已售")]
        public decimal NUMDISTRIBUTION_LINESALE { get; set; }
    
        /// <summary>
        /// 线上总数量
        /// </summary>
        
        [Description("线上总数量")]
        public decimal NUMDISTRIBUTION_LINESUM { get; set; }
    
        /// <summary>
        /// 是否已同步 F否 T是
        /// </summary>
        
        [Description("是否已同步 F否 T是")]
        public string NUMDISTRIBUTION_ISFLAG { get; set; }
    
        /// <summary>
        /// 最后修改日期
        /// </summary>
        
        [Description("最后修改日期")]
        public DateTime NUMDISTRIBUTION_LUDATE { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime NUMDISTRIBUTION_CDATE { get; set; }
    
        /// <summary>
        /// 企业id
        /// </summary>
        
        [Description("企业id")]
        public decimal NUMDISTRIBUTION_ORGID { get; set; }
    }
}
