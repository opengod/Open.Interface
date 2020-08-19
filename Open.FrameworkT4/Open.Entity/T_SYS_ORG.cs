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
    /// T_SYS_ORG 
    /// </summary>    
   [Serializable]
   [SugarTable("T_SYS_ORG")]
    public class T_SYS_ORG
    {
    
        /// <summary>
        /// 主键ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键ID")]
        public decimal ORG_ID { get; set; }
    
        /// <summary>
        /// 父机构ID
        /// </summary>
        
        [Description("父机构ID")]
        public decimal ORG_PID { get; set; }
    
        /// <summary>
        /// 机构名称
        /// </summary>
        
        [Description("机构名称")]
        public string ORG_NAME { get; set; }
    
        /// <summary>
        /// 机构编码
        /// </summary>
        
        [Description("机构编码")]
        public string ORG_CODE { get; set; }
    
        /// <summary>
        /// 机构类型 1：OTA，4：景区，5：特产购物，6：旅行社，7：酒店，8：云旅，9：餐饮，16：休闲娱乐
        /// </summary>
        
        [Description("机构类型 1：OTA，4：景区，5：特产购物，6：旅行社，7：酒店，8：云旅，9：餐饮，16：休闲娱乐")]
        public string ORG_TYPE { get; set; }
    
        /// <summary>
        /// 所属区域
        /// </summary>
        
        [Description("所属区域")]
        public string ORG_AREA { get; set; }
    
        /// <summary>
        /// 伙伴号
        /// </summary>
        
        [Description("伙伴号")]
        public string ORG_MERCHANTCODE { get; set; }
    
        /// <summary>
        /// 密钥
        /// </summary>
        
        [Description("密钥")]
        public string ORG_KEY { get; set; }
    
        /// <summary>
        /// 消费通知地址
        /// </summary>
        
        [Description("消费通知地址")]
        public string ORG_CONSUMEURL { get; set; }
    
        /// <summary>
        /// 退款通知地址
        /// </summary>
        
        [Description("退款通知地址")]
        public string ORG_REFUNDURL { get; set; }
    
        /// <summary>
        /// 供应商类别
        /// </summary>
        
        [Description("供应商类别")]
        public string ORG_SUPTYPE { get; set; }
    
        /// <summary>
        /// 供应商ID
        /// </summary>
        
        [Description("供应商ID")]
        public decimal ORG_SUPID { get; set; }
    
        /// <summary>
        /// 供应商编码
        /// </summary>
        
        [Description("供应商编码")]
        public string ORG_SUPCODE { get; set; }
    
        /// <summary>
        /// 供应商名称
        /// </summary>
        
        [Description("供应商名称")]
        public string ORG_SUPNAME { get; set; }
    
        /// <summary>
        /// 供应商接口地址
        /// </summary>
        
        [Description("供应商接口地址")]
        public string ORG_SUPURL { get; set; }
    
        /// <summary>
        /// 供应商账号
        /// </summary>
        
        [Description("供应商账号")]
        public string ORG_SUPACCOUNT { get; set; }
    
        /// <summary>
        /// 供应商秘钥
        /// </summary>
        
        [Description("供应商秘钥")]
        public string ORG_SUPKEY { get; set; }
    
        /// <summary>
        /// 是否使用银联分账功能
        /// </summary>
        
        [Description("是否使用银联分账功能")]
        public string ORG_ISSEPARATE { get; set; }
    
        /// <summary>
        /// 银联支付子账户商户号
        /// </summary>
        
        [Description("银联支付子账户商户号")]
        public string ORG_UNIONCODE { get; set; }
    
        /// <summary>
        /// 机构备注
        /// </summary>
        
        [Description("机构备注")]
        public string ORG_MEMO { get; set; }
    
        /// <summary>
        /// 是否部门
        /// </summary>
        
        [Description("是否部门")]
        public string ORG_ISDEPARTMENT { get; set; }
    
        /// <summary>
        /// 是否停用
        /// </summary>
        
        [Description("是否停用")]
        public string ORG_ISENABLE { get; set; }
    
        /// <summary>
        /// 联系人
        /// </summary>
        
        [Description("联系人")]
        public string ORG_LINKPERSON { get; set; }
    
        /// <summary>
        /// 联系人电话
        /// </summary>
        
        [Description("联系人电话")]
        public string ORG_LINKTEL { get; set; }
    
        /// <summary>
        /// 诚信评分
        /// </summary>
        
        [Description("诚信评分")]
        public decimal ORG_CREDIT { get; set; }
    
        /// <summary>
        /// 排序
        /// </summary>
        
        [Description("排序")]
        public decimal ORG_SORT { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal ORG_CREID { get; set; }
    
        /// <summary>
        /// 创建人姓名
        /// </summary>
        
        [Description("创建人姓名")]
        public string ORG_CRENAME { get; set; }
    
        /// <summary>
        /// 创建人所在机构ID
        /// </summary>
        
        [Description("创建人所在机构ID")]
        public decimal ORG_CREORGID { get; set; }
    
        /// <summary>
        /// 创建人所在机构名称
        /// </summary>
        
        [Description("创建人所在机构名称")]
        public string ORG_CREORGNAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime ORG_CREDATE { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal ORG_UPID { get; set; }
    
        /// <summary>
        /// 修改人名称
        /// </summary>
        
        [Description("修改人名称")]
        public string ORG_UPNAME { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime ORG_UPDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string ORG_ISDEL { get; set; }
    }
}
