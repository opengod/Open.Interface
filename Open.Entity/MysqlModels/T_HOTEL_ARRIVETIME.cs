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
    /// T_HOTEL_ARRIVETIME 
    /// </summary>    
   [Serializable]
   [SugarTable("T_HOTEL_ARRIVETIME")]
    public class T_HOTEL_ARRIVETIME
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal ARRIVE_ID { get; set; }
    
        /// <summary>
        /// 名称
        /// </summary>
        
        [Description("名称")]
        public string ARRIVE_NAME { get; set; }
    
        /// <summary>
        /// 到店时间
        /// </summary>
        
        [Description("到店时间")]
        public DateTime ARRIVE_DATE { get; set; }
    
        /// <summary>
        /// 是否需要担保
        /// </summary>
        
        [Description("是否需要担保")]
        public string ARRIVE_ISGUARANTEE { get; set; }
    
        /// <summary>
        /// 排序
        /// </summary>
        
        [Description("排序")]
        public decimal ARRIVE_SORT { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal ARRIVE_CREID { get; set; }
    
        /// <summary>
        /// 创建人姓名
        /// </summary>
        
        [Description("创建人姓名")]
        public string ARRIVE_CRENAME { get; set; }
    
        /// <summary>
        /// 创建人所在机构ID
        /// </summary>
        
        [Description("创建人所在机构ID")]
        public decimal ARRIVE_CREORGID { get; set; }
    
        /// <summary>
        /// 创建人所在机构名称
        /// </summary>
        
        [Description("创建人所在机构名称")]
        public string ARRIVE_CREORGNAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime ARRIVE_CREDATE { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal ARRIVE_UPID { get; set; }
    
        /// <summary>
        /// 修改人姓名
        /// </summary>
        
        [Description("修改人姓名")]
        public string ARRIVE_UPNAME { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime ARRIVE_UPDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string ARRIVE_ISDEL { get; set; }
    }
}
