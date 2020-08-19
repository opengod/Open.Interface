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
    /// T_TICKET_BOOKACTIVITE 
    /// </summary>    
   [Serializable]
   [SugarTable("T_TICKET_BOOKACTIVITE")]
    public class T_TICKET_BOOKACTIVITE
    {
    
        /// <summary>
        /// 预约活动表ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("预约活动表ID")]
        public int ACTIVITE_ID { get; set; }
    
        /// <summary>
        /// 所属机构ID
        /// </summary>
        
        [Description("所属机构ID")]
        public decimal ACTIVITE_ORGID { get; set; }
    
        /// <summary>
        /// 所属机构名称
        /// </summary>
        
        [Description("所属机构名称")]
        public string ACTIVITE_ORGNAME { get; set; }
    
        /// <summary>
        /// 活动名称
        /// </summary>
        
        [Description("活动名称")]
        public string ACTIVITE_NAME { get; set; }
    
        /// <summary>
        /// 活动地点
        /// </summary>
        
        [Description("活动地点")]
        public string ACTIVITE_PLACE { get; set; }
    
        /// <summary>
        /// 活动开始时间
        /// </summary>
        
        [Description("活动开始时间")]
        public DateTime ACTIVITE_STARTDATE { get; set; }
    
        /// <summary>
        /// 活动结束时间
        /// </summary>
        
        [Description("活动结束时间")]
        public DateTime ACTIVITE_ENDDATE { get; set; }
    
        /// <summary>
        /// 活动总人数
        /// </summary>
        
        [Description("活动总人数")]
        public int ACTIVITE_PEOPLENUM { get; set; }
    
        /// <summary>
        /// 已预约人数
        /// </summary>
        
        [Description("已预约人数")]
        public int ACTIVITE_BOOKNUM { get; set; }
    
        /// <summary>
        /// 活动介绍
        /// </summary>
        
        [Description("活动介绍")]
        public string ACTIVITE_INFO { get; set; }
    
        /// <summary>
        /// 图片
        /// </summary>
        
        [Description("图片")]
        public string ACTIVITE_IMAGE { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string ACTIVITE_DEMO { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal ACTIVITE_CREID { get; set; }
    
        /// <summary>
        /// 创建人名称
        /// </summary>
        
        [Description("创建人名称")]
        public string ACTIVITE_CRENAME { get; set; }
    
        /// <summary>
        /// 创建人所属机构ID
        /// </summary>
        
        [Description("创建人所属机构ID")]
        public decimal ACTIVITE_CREORGID { get; set; }
    
        /// <summary>
        /// 创建人所属机构名称
        /// </summary>
        
        [Description("创建人所属机构名称")]
        public string ACTIVITE_CREORGNAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime ACTIVITE_CREDATE { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal ACTIVITE_UPID { get; set; }
    
        /// <summary>
        /// 修改人名称
        /// </summary>
        
        [Description("修改人名称")]
        public string ACTIVITE_UPNAME { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime ACTIVITE_UPDATE { get; set; }
    
        /// <summary>
        /// 是否删除
        /// </summary>
        
        [Description("是否删除")]
        public string ACTIVITE_ISDEL { get; set; }
    }
}
