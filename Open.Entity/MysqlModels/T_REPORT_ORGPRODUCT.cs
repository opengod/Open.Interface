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
    /// T_REPORT_ORGPRODUCT 
    /// </summary>    
   [Serializable]
   [SugarTable("T_REPORT_ORGPRODUCT")]
    public class T_REPORT_ORGPRODUCT
    {
    
        /// <summary>
        /// 报表_企业产品信息表主键ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("报表_企业产品信息表主键ID")]
        public decimal ORGPRO_ID { get; set; }
    
        /// <summary>
        /// 产品编码
        /// </summary>
        
        [Description("产品编码")]
        public string ORGPRO_CODE { get; set; }
    
        /// <summary>
        /// 产品名称
        /// </summary>
        
        [Description("产品名称")]
        public string ORGPRO_NAME { get; set; }
    
        /// <summary>
        /// 产品类型（P景区，PT门票，PP套餐，H酒店，HR房间，HB会议室，L线路，C评论，T投诉，R餐饮，RP餐饮套餐，E休闲娱乐，EP娱乐套餐，B商店，BP商店商品）
        /// </summary>
        
        [Description("产品类型（P景区，PT门票，PP套餐，H酒店，HR房间，HB会议室，L线路，C评论，T投诉，R餐饮，RP餐饮套餐，E休闲娱乐，EP娱乐套餐，B商店，BP商店商品）")]
        public string ORGPRO_TYPE { get; set; }
    
        /// <summary>
        /// 产品类别（O老人，M成人，C儿童，S单人间，D双人间，T三人间，F四人间，P套房）
        /// </summary>
        
        [Description("产品类别（O老人，M成人，C儿童，S单人间，D双人间，T三人间，F四人间，P套房）")]
        public string ORGPRO_CATEGORY { get; set; }
    
        /// <summary>
        /// 日期
        /// </summary>
        
        [Description("日期")]
        public DateTime ORGPRO_DATE { get; set; }
    
        /// <summary>
        /// 价格
        /// </summary>
        
        [Description("价格")]
        public decimal ORGPRO_PRICE { get; set; }
    
        /// <summary>
        /// 状态（T上架，F下架）
        /// </summary>
        
        [Description("状态（T上架，F下架）")]
        public string ORGPRO_STATUS { get; set; }
    
        /// <summary>
        /// 说明
        /// </summary>
        
        [Description("说明")]
        public string ORGPRO_INFO { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string ORGPRO_MEMO { get; set; }
    
        /// <summary>
        /// 排序
        /// </summary>
        
        [Description("排序")]
        public decimal ORGPRO_SORT { get; set; }
    
        /// <summary>
        /// 所属机构
        /// </summary>
        
        [Description("所属机构")]
        public decimal ORGPRO_ORGID { get; set; }
    
        /// <summary>
        /// 所属机构名称
        /// </summary>
        
        [Description("所属机构名称")]
        public string ORGPRO_ORGNAME { get; set; }
    
        /// <summary>
        /// 所属机构类型（P景区，H酒店，L线路，C评论，T投诉，R餐饮，E休闲娱乐，B商店）
        /// </summary>
        
        [Description("所属机构类型（P景区，H酒店，L线路，C评论，T投诉，R餐饮，E休闲娱乐，B商店）")]
        public string ORGPRO_ORGTYPE { get; set; }
    
        /// <summary>
        /// 创建人姓名
        /// </summary>
        
        [Description("创建人姓名")]
        public string ORGPRO_CREATE { get; set; }
    
        /// <summary>
        /// 创建人
        /// </summary>
        
        [Description("创建人")]
        public decimal ORGPRO_CREATEBY { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime ORGPRO_CREATEDATE { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal ORGPRO_UPPEOPLEID { get; set; }
    
        /// <summary>
        /// 修改人名称
        /// </summary>
        
        [Description("修改人名称")]
        public string ORGPRO_UPPEOPLENAME { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime ORGPRO_UPDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string ORGPRO_DEL { get; set; }
    }
}
