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
    /// T_REPORT_ORGCHECK 
    /// </summary>    
   [Serializable]
   [SugarTable("T_REPORT_ORGCHECK")]
    public class T_REPORT_ORGCHECK
    {
    
        /// <summary>
        /// 报表_企业入园信息表主键ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("报表_企业入园信息表主键ID")]
        public decimal CHECKINFO_ID { get; set; }
    
        /// <summary>
        /// 入园时间
        /// </summary>
        
        [Description("入园时间")]
        public DateTime CHECKINFO_DATE { get; set; }
    
        /// <summary>
        /// 入园数量
        /// </summary>
        
        [Description("入园数量")]
        public decimal CHECKINFO_COUNT { get; set; }
    
        /// <summary>
        /// 用户姓名
        /// </summary>
        
        [Description("用户姓名")]
        public string CHECKINFO_NAME { get; set; }
    
        /// <summary>
        /// 手机号码
        /// </summary>
        
        [Description("手机号码")]
        public string CHECKINFO_TEL { get; set; }
    
        /// <summary>
        /// 身份证号码
        /// </summary>
        
        [Description("身份证号码")]
        public string CHECKINFO_ICNO { get; set; }
    
        /// <summary>
        /// 产品编码
        /// </summary>
        
        [Description("产品编码")]
        public string CHECKINFO_PROCODE { get; set; }
    
        /// <summary>
        /// 产品名称
        /// </summary>
        
        [Description("产品名称")]
        public string CHECKINFO_PRONAME { get; set; }
    
        /// <summary>
        /// 产品类型（P景区，PT门票，PP套餐，H酒店，HR房间，HB会议室，L线路，C评论，T投诉，R餐饮，RP餐饮套餐，E休闲娱乐，EP娱乐套餐，B商店，BP商店商品）
        /// </summary>
        
        [Description("产品类型（P景区，PT门票，PP套餐，H酒店，HR房间，HB会议室，L线路，C评论，T投诉，R餐饮，RP餐饮套餐，E休闲娱乐，EP娱乐套餐，B商店，BP商店商品）")]
        public string CHECKINFO_PROTYPE { get; set; }
    
        /// <summary>
        /// 产品类别（O老人，M成人，C儿童；S单人间，D双人间，T三人间，F四人间，P套房；爸妈游，亲子游，蜜月游，户外活动；小吃快餐，自助餐，闽菜；KTV，足疗按摩，酒吧；特色美食，特色礼品）
        /// </summary>
        
        [Description("产品类别（O老人，M成人，C儿童；S单人间，D双人间，T三人间，F四人间，P套房；爸妈游，亲子游，蜜月游，户外活动；小吃快餐，自助餐，闽菜；KTV，足疗按摩，酒吧；特色美食，特色礼品）")]
        public string CHECKINFO_CATEGORY { get; set; }
    
        /// <summary>
        /// 销售渠道
        /// </summary>
        
        [Description("销售渠道")]
        public string CHECKINFO_CHANNEL { get; set; }
    
        /// <summary>
        /// 企业所属区域
        /// </summary>
        
        [Description("企业所属区域")]
        public string CHECKINFO_ORGAREA { get; set; }
    
        /// <summary>
        /// 说明
        /// </summary>
        
        [Description("说明")]
        public string CHECKINFO_INFO { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string CHECKINFO_MEMO { get; set; }
    
        /// <summary>
        /// 排序
        /// </summary>
        
        [Description("排序")]
        public decimal CHECKINFO_SORT { get; set; }
    
        /// <summary>
        /// 所属机构
        /// </summary>
        
        [Description("所属机构")]
        public decimal CHECKINFO_ORGID { get; set; }
    
        /// <summary>
        /// 所属机构名称
        /// </summary>
        
        [Description("所属机构名称")]
        public string CHECKINFO_ORGNAME { get; set; }
    
        /// <summary>
        /// 所属机构类型（P景区，H酒店，L线路，C评论，T投诉，R餐饮，E休闲娱乐，B商店）
        /// </summary>
        
        [Description("所属机构类型（P景区，H酒店，L线路，C评论，T投诉，R餐饮，E休闲娱乐，B商店）")]
        public string CHECKINFO_ORGTYPE { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal CHECKINFO_CREID { get; set; }
    
        /// <summary>
        /// 创建人姓名
        /// </summary>
        
        [Description("创建人姓名")]
        public string CHECKINFO_CRENAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime CHECKINFO_CREDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string CHECKINFO_ISDEL { get; set; }
    }
}
