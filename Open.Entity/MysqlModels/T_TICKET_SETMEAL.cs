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
    /// T_TICKET_SETMEAL 
    /// </summary>    
   [Serializable]
   [SugarTable("T_TICKET_SETMEAL")]
    public class T_TICKET_SETMEAL
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal SETMEAL_ID { get; set; }
    
        /// <summary>
        /// 套餐名称
        /// </summary>
        
        [Description("套餐名称")]
        public string SETMEAL_NAME { get; set; }
    
        /// <summary>
        /// 套餐编码
        /// </summary>
        
        [Description("套餐编码")]
        public string SETMEAL_CODE { get; set; }
    
        /// <summary>
        /// 套餐介绍
        /// </summary>
        
        [Description("套餐介绍")]
        public string SETMEAL_INFO { get; set; }
    
        /// <summary>
        /// 有效开始时间
        /// </summary>
        
        [Description("有效开始时间")]
        public DateTime SETMEAL_STARTTIME { get; set; }
    
        /// <summary>
        /// 有效结束时间
        /// </summary>
        
        [Description("有效结束时间")]
        public DateTime SETMEAL_ENDTIME { get; set; }
    
        /// <summary>
        /// 售卖价格
        /// </summary>
        
        [Description("售卖价格")]
        public decimal SETMEAL_SELLPRICE { get; set; }
    
        /// <summary>
        /// 结算价格
        /// </summary>
        
        [Description("结算价格")]
        public decimal SETMEAL_PRICE { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string SETMEAL_MEMO { get; set; }
    
        /// <summary>
        /// 排序
        /// </summary>
        
        [Description("排序")]
        public decimal SETMEAL_SORT { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal SETMEAL_CREID { get; set; }
    
        /// <summary>
        /// 创建人姓名
        /// </summary>
        
        [Description("创建人姓名")]
        public string SETMEAL_CRENAME { get; set; }
    
        /// <summary>
        /// 创建人所在机构ID
        /// </summary>
        
        [Description("创建人所在机构ID")]
        public decimal SETMEAL_CREORGID { get; set; }
    
        /// <summary>
        /// 创建人所在机构名称
        /// </summary>
        
        [Description("创建人所在机构名称")]
        public string SETMEAL_CREORGNAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime SETMEAL_CREDATE { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal SETMEAL_UPID { get; set; }
    
        /// <summary>
        /// 修改人名称
        /// </summary>
        
        [Description("修改人名称")]
        public string SETMEAL_UPNAME { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime SETMEAL_UPDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string SETMEAL_ISDEL { get; set; }
    }
}
