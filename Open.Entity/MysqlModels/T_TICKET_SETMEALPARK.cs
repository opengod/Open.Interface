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
    /// T_TICKET_SETMEALPARK 
    /// </summary>    
   [Serializable]
   [SugarTable("T_TICKET_SETMEALPARK")]
    public class T_TICKET_SETMEALPARK
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal SETMEALPARK_ID { get; set; }
    
        /// <summary>
        /// 套餐ID
        /// </summary>
        
        [Description("套餐ID")]
        public decimal SETMEALPARK_SETMEALID { get; set; }
    
        /// <summary>
        /// 套餐编码
        /// </summary>
        
        [Description("套餐编码")]
        public string SETMEALPARK_SETMEALCODE { get; set; }
    
        /// <summary>
        /// 景区ID
        /// </summary>
        
        [Description("景区ID")]
        public decimal SETMEALPARK_PARKID { get; set; }
    
        /// <summary>
        /// 景区名称
        /// </summary>
        
        [Description("景区名称")]
        public string SETMEALPARK_PARKNAME { get; set; }
    
        /// <summary>
        /// 门票ID
        /// </summary>
        
        [Description("门票ID")]
        public decimal SETMEALPARK_TICKETID { get; set; }
    
        /// <summary>
        /// 门票名称
        /// </summary>
        
        [Description("门票名称")]
        public string SETMEALPARK_TICKETNAME { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string SETMEALPARK_MEMO { get; set; }
    
        /// <summary>
        /// 排序
        /// </summary>
        
        [Description("排序")]
        public decimal SETMEALPARK_SORT { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal SETMEALPARK_CREID { get; set; }
    
        /// <summary>
        /// 创建人姓名
        /// </summary>
        
        [Description("创建人姓名")]
        public string SETMEALPARK_CRENAME { get; set; }
    
        /// <summary>
        /// 创建人所在机构ID
        /// </summary>
        
        [Description("创建人所在机构ID")]
        public decimal SETMEALPARK_CREORGID { get; set; }
    
        /// <summary>
        /// 创建人所在机构名称
        /// </summary>
        
        [Description("创建人所在机构名称")]
        public string SETMEALPARK_CREORGNAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime SETMEALPARK_CREDATE { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal SETMEALPARK_UPID { get; set; }
    
        /// <summary>
        /// 修改人名称
        /// </summary>
        
        [Description("修改人名称")]
        public string SETMEALPARK_UPNAME { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime SETMEALPARK_UPDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string SETMEALPARK_ISDEL { get; set; }
    
        /// <summary>
        /// 套餐结算价
        /// </summary>
        
        [Description("套餐结算价")]
        public decimal SETMEALPARK_TOTALPRICE { get; set; }
    
        /// <summary>
        /// 景区结算价
        /// </summary>
        
        [Description("景区结算价")]
        public decimal SETMEALPARK_PRICE { get; set; }
    
        /// <summary>
        /// 所占比例(根据此比例分别计算景区结算价)
        /// </summary>
        
        [Description("所占比例(根据此比例分别计算景区结算价)")]
        public decimal SETMEALPARK_PERCENT { get; set; }
    }
}
