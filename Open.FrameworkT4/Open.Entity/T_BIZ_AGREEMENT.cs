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
    /// T_BIZ_AGREEMENT 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_AGREEMENT")]
    public class T_BIZ_AGREEMENT
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal AGREE_ID { get; set; }
    
        /// <summary>
        /// 合同名称
        /// </summary>
        
        [Description("合同名称")]
        public string AGREE_NAME { get; set; }
    
        /// <summary>
        /// 产品类型 P景点，L线路，R餐饮，H酒店，E休闲娱乐，B商品
        /// </summary>
        
        [Description("产品类型 P景点，L线路，R餐饮，H酒店，E休闲娱乐，B商品")]
        public string AGREE_TYPE { get; set; }
    
        /// <summary>
        /// 合同内容
        /// </summary>
        
        [Description("合同内容")]
        public string AGREE_CONTENT { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string AGREE_MEMO { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal AGREE_CREID { get; set; }
    
        /// <summary>
        /// 创建人姓名
        /// </summary>
        
        [Description("创建人姓名")]
        public string AGREE_CRENAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime AGREE_CREDATE { get; set; }
    
        /// <summary>
        /// 是否删除
        /// </summary>
        
        [Description("是否删除")]
        public string AGREE_ISDEL { get; set; }
    }
}
