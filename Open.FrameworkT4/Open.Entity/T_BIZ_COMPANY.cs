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
    /// T_BIZ_COMPANY 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_COMPANY")]
    public class T_BIZ_COMPANY
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal COMPANY_ID { get; set; }
    
        /// <summary>
        /// 信息来源类型
        /// </summary>
        
        [Description("信息来源类型")]
        public string COMPANY_MSGFROMTYPE { get; set; }
    
        /// <summary>
        /// 信息来源
        /// </summary>
        
        [Description("信息来源")]
        public string COMPANY_MSGFROMCODEVALUE { get; set; }
    
        /// <summary>
        /// 类型（1景区景点，2酒店，3餐饮，4旅行社，5商户）
        /// </summary>
        
        [Description("类型（1景区景点，2酒店，3餐饮，4旅行社，5商户）")]
        public string COMPANY_CLASS { get; set; }
    
        /// <summary>
        /// 全称
        /// </summary>
        
        [Description("全称")]
        public string COMPANY_NAME { get; set; }
    
        /// <summary>
        /// 简称
        /// </summary>
        
        [Description("简称")]
        public string COMPANY_NICKNAME { get; set; }
    
        /// <summary>
        /// 地址
        /// </summary>
        
        [Description("地址")]
        public string COMPANY_ADDRESS { get; set; }
    
        /// <summary>
        /// 联系人
        /// </summary>
        
        [Description("联系人")]
        public string COMPANY_CONTRACT { get; set; }
    
        /// <summary>
        /// 营业执照号
        /// </summary>
        
        [Description("营业执照号")]
        public string COMPANY_BUSINESS { get; set; }
    
        /// <summary>
        /// 客服电话
        /// </summary>
        
        [Description("客服电话")]
        public string COMPANY_TEL { get; set; }
    
        /// <summary>
        /// 排序
        /// </summary>
        
        [Description("排序")]
        public decimal COMPANY_SORT { get; set; }
    
        /// <summary>
        /// 企业简介
        /// </summary>
        
        [Description("企业简介")]
        public string COMPANY_DESCRIPTION { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string COMPANY_MEMO { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal COMPANY_CREID { get; set; }
    
        /// <summary>
        /// 创建人姓名
        /// </summary>
        
        [Description("创建人姓名")]
        public string COMPANY_CRENAME { get; set; }
    
        /// <summary>
        /// 创建人所在机构ID
        /// </summary>
        
        [Description("创建人所在机构ID")]
        public decimal COMPANY_CREORGID { get; set; }
    
        /// <summary>
        /// 创建人所在机构名称
        /// </summary>
        
        [Description("创建人所在机构名称")]
        public string COMPANY_CREORGNAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime COMPANY_CREDATE { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal COMPANY_UPID { get; set; }
    
        /// <summary>
        /// 修改人名称
        /// </summary>
        
        [Description("修改人名称")]
        public string COMPANY_UPNAME { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime COMPANY_UPDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string COMPANY_ISDEL { get; set; }
    }
}
