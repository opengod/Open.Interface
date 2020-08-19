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
    /// T_BIZ_COMMENT 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_COMMENT")]
    public class T_BIZ_COMMENT
    {
    
        /// <summary>
        /// 评论主键ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("评论主键ID")]
        public decimal COMMENT_ID { get; set; }
    
        /// <summary>
        /// 用户ID
        /// </summary>
        
        [Description("用户ID")]
        public decimal COMMENT_MEMBERID { get; set; }
    
        /// <summary>
        /// 部门ID
        /// </summary>
        
        [Description("部门ID")]
        public decimal COMMENT_ORGID { get; set; }
    
        /// <summary>
        /// 产品ID
        /// </summary>
        
        [Description("产品ID")]
        public decimal COMMENT_PRODUCTID { get; set; }
    
        /// <summary>
        /// 用户姓名
        /// </summary>
        
        [Description("用户姓名")]
        public string COMMENT_MEMBERNAME { get; set; }
    
        /// <summary>
        /// 用户表单ID
        /// </summary>
        
        [Description("用户表单ID")]
        public string COMMENT_FORMID { get; set; }
    
        /// <summary>
        /// 部门名称
        /// </summary>
        
        [Description("部门名称")]
        public string COMMENT_ORGNAME { get; set; }
    
        /// <summary>
        /// 产品名称
        /// </summary>
        
        [Description("产品名称")]
        public string COMMENT_PRODUCTNAME { get; set; }
    
        /// <summary>
        /// 订单编号
        /// </summary>
        
        [Description("订单编号")]
        public string COMMENT_ORDERNO { get; set; }
    
        /// <summary>
        /// 评论类型（P景区，PT门票，PP套餐，H酒店，HR房间，HB会议室，L线路，C评论，T投诉，R餐饮，RP餐饮套餐，E休闲娱乐，EP娱乐套餐，B商店，BP商店商品，资讯Z，G导游，TC旅游通卡）
        /// </summary>
        
        [Description("评论类型（P景区，PT门票，PP套餐，H酒店，HR房间，HB会议室，L线路，C评论，T投诉，R餐饮，RP餐饮套餐，E休闲娱乐，EP娱乐套餐，B商店，BP商店商品，资讯Z，G导游，TC旅游通卡）")]
        public string COMMENT_TYPE { get; set; }
    
        /// <summary>
        /// 评分
        /// </summary>
        
        [Description("评分")]
        public decimal COMMENT_SCORE { get; set; }
    
        /// <summary>
        /// 评论内容
        /// </summary>
        
        [Description("评论内容")]
        public string COMMENT_CONTENT { get; set; }
    
        /// <summary>
        /// 商家回复
        /// </summary>
        
        [Description("商家回复")]
        public string COMMENT_REPLY { get; set; }
    
        /// <summary>
        /// 点赞数量
        /// </summary>
        
        [Description("点赞数量")]
        public decimal COMMENT_PRAISE { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime COMMENT_CRETIME { get; set; }
    
        /// <summary>
        /// 回复时间
        /// </summary>
        
        [Description("回复时间")]
        public DateTime COMMENT_REPLYTIME { get; set; }
    
        /// <summary>
        /// 是否已发送模板消息（F 未发送 T 已发送）
        /// </summary>
        
        [Description("是否已发送模板消息（F 未发送 T 已发送）")]
        public string COMMENT_ISSENDTEMPLATE { get; set; }
    
        /// <summary>
        /// 是否删除
        /// </summary>
        
        [Description("是否删除")]
        public string COMMENT_ISDEL { get; set; }
    
        /// <summary>
        /// 是否通过审核
        /// </summary>
        
        [Description("是否通过审核")]
        public string COMMENT_ISCHECK { get; set; }
    
        /// <summary>
        /// 审核人ID
        /// </summary>
        
        [Description("审核人ID")]
        public string COMMENT_CHECKID { get; set; }
    
        /// <summary>
        /// 审核人姓名
        /// </summary>
        
        [Description("审核人姓名")]
        public string COMMENT_CHECKNAME { get; set; }
    
        /// <summary>
        /// 审核时间
        /// </summary>
        
        [Description("审核时间")]
        public DateTime COMMENT_CHECKDATE { get; set; }
    
        /// <summary>
        /// 排序
        /// </summary>
        
        [Description("排序")]
        public decimal COMMENT_SORT { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string COMMENT_MEMO { get; set; }
    }
}
