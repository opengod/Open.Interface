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
    /// T_TRAVEL_STRATEGYDETAIL 
    /// </summary>    
   [Serializable]
   [SugarTable("T_TRAVEL_STRATEGYDETAIL")]
    public class T_TRAVEL_STRATEGYDETAIL
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal DETAIL_ID { get; set; }
    
        /// <summary>
        /// 攻略编码
        /// </summary>
        
        [Description("攻略编码")]
        public string STRATEGY_CODE { get; set; }
    
        /// <summary>
        /// 站点名称
        /// </summary>
        
        [Description("站点名称")]
        public string DETAIL_NAME { get; set; }
    
        /// <summary>
        /// 所属天数
        /// </summary>
        
        [Description("所属天数")]
        public string DETAIL_DAY { get; set; }
    
        /// <summary>
        /// 附近景点
        /// </summary>
        
        [Description("附近景点")]
        public string DETAIL_SPOTS { get; set; }
    
        /// <summary>
        /// 附近美食
        /// </summary>
        
        [Description("附近美食")]
        public string DETAIL_FOOD { get; set; }
    
        /// <summary>
        /// 经度
        /// </summary>
        
        [Description("经度")]
        public decimal DETAIL_LONGTUDE { get; set; }
    
        /// <summary>
        /// 纬度
        /// </summary>
        
        [Description("纬度")]
        public decimal DETAIL_LATITUDE { get; set; }
    
        /// <summary>
        /// 站点详情
        /// </summary>
        
        [Description("站点详情")]
        public string DETAIL_DESCRIBE { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string DETAIL_MEMO { get; set; }
    
        /// <summary>
        /// 排序
        /// </summary>
        
        [Description("排序")]
        public decimal DETAIL_SORT { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal DETAIL_CREID { get; set; }
    
        /// <summary>
        /// 创建人姓名
        /// </summary>
        
        [Description("创建人姓名")]
        public string DETAIL_CRENAME { get; set; }
    
        /// <summary>
        /// 创建人所在机构ID
        /// </summary>
        
        [Description("创建人所在机构ID")]
        public decimal DETAIL_CREORGID { get; set; }
    
        /// <summary>
        /// 创建人所在机构名称
        /// </summary>
        
        [Description("创建人所在机构名称")]
        public string DETAIL_CREORGNAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime DETAIL_CREDATE { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal DETAIL_UPID { get; set; }
    
        /// <summary>
        /// 修改人姓名
        /// </summary>
        
        [Description("修改人姓名")]
        public string DETAIL_UPNAME { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime DETAIL_UPDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string DETAIL_ISDEL { get; set; }
    }
}
