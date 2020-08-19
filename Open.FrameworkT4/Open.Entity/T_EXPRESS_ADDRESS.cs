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
    /// T_EXPRESS_ADDRESS 
    /// </summary>    
   [Serializable]
   [SugarTable("T_EXPRESS_ADDRESS")]
    public class T_EXPRESS_ADDRESS
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal ADDRESS_ID { get; set; }
    
        /// <summary>
        /// 用户表ID
        /// </summary>
        
        [Description("用户表ID")]
        public decimal ADDRESS_MEMBERID { get; set; }
    
        /// <summary>
        /// 姓名
        /// </summary>
        
        [Description("姓名")]
        public string ADDRESS_NAME { get; set; }
    
        /// <summary>
        /// 电话
        /// </summary>
        
        [Description("电话")]
        public string ADDRESS_PHONE { get; set; }
    
        /// <summary>
        /// 省
        /// </summary>
        
        [Description("省")]
        public string ADDRESS_PROVINCE { get; set; }
    
        /// <summary>
        /// 市
        /// </summary>
        
        [Description("市")]
        public string ADDRESS_CITY { get; set; }
    
        /// <summary>
        /// 区
        /// </summary>
        
        [Description("区")]
        public string ADDRESS_AREA { get; set; }
    
        /// <summary>
        /// 详细地址
        /// </summary>
        
        [Description("详细地址")]
        public string ADDRESS_DETAIL { get; set; }
    
        /// <summary>
        /// 所有地址。逗号隔开
        /// </summary>
        
        [Description("所有地址。逗号隔开")]
        public string ADDRESS_ALL { get; set; }
    
        /// <summary>
        /// 是否删除
        /// </summary>
        
        [Description("是否删除")]
        public string ADDRESS_ISDEL { get; set; }
    
        /// <summary>
        /// 排序
        /// </summary>
        
        [Description("排序")]
        public decimal ADDRESS_SORT { get; set; }
    
        /// <summary>
        /// 是否默认
        /// </summary>
        
        [Description("是否默认")]
        public string ADDRESS_ISMAIN { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime ADDRESS_CREDATE { get; set; }
    }
}
