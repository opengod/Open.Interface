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
    /// T_BIZ_COMMENTLIKE 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_COMMENTLIKE")]
    public class T_BIZ_COMMENTLIKE
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal LIKE_ID { get; set; }
    
        /// <summary>
        /// 用户ID
        /// </summary>
        
        [Description("用户ID")]
        public decimal LIKE_MEMBERID { get; set; }
    
        /// <summary>
        /// 部门ID
        /// </summary>
        
        [Description("部门ID")]
        public decimal LIKE_ORGID { get; set; }
    
        /// <summary>
        /// 产品ID
        /// </summary>
        
        [Description("产品ID")]
        public decimal LIKE_PRODUCTID { get; set; }
    
        /// <summary>
        /// 点赞类型（P景点，L线路，E餐饮，EP餐饮套餐，H酒店，F休闲娱乐，B商品，Z资讯，C评论）
        /// </summary>
        
        [Description("点赞类型（P景点，L线路，E餐饮，EP餐饮套餐，H酒店，F休闲娱乐，B商品，Z资讯，C评论）")]
        public string LIKE_TYPE { get; set; }
    
        /// <summary>
        /// 订单编号
        /// </summary>
        
        [Description("订单编号")]
        public string LIKE_ORDERNO { get; set; }
    }
}
