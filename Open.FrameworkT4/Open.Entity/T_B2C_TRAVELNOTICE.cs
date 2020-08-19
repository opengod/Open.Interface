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
    /// T_B2C_TRAVELNOTICE 
    /// </summary>    
   [Serializable]
   [SugarTable("T_B2C_TRAVELNOTICE")]
    public class T_B2C_TRAVELNOTICE
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal TRAVELNOTICE_ID { get; set; }
    
        /// <summary>
        /// 公告类型（1酒店、2景区、3商家）
        /// </summary>
        
        [Description("公告类型（1酒店、2景区、3商家）")]
        public string TRAVELNOTICE_CLASS { get; set; }
    
        /// <summary>
        /// 部门ID
        /// </summary>
        
        [Description("部门ID")]
        public decimal TRAVELNOTICE_ORGID { get; set; }
    
        /// <summary>
        /// 部门名称
        /// </summary>
        
        [Description("部门名称")]
        public string TRAVELNOTICE_ORGNAME { get; set; }
    
        /// <summary>
        /// 公告标题
        /// </summary>
        
        [Description("公告标题")]
        public string TRAVELNOTICE_TITLE { get; set; }
    
        /// <summary>
        /// 发布日期
        /// </summary>
        
        [Description("发布日期")]
        public DateTime TRAVELNOTICE_PUBLISHDATE { get; set; }
    
        /// <summary>
        /// 公告内容
        /// </summary>
        
        [Description("公告内容")]
        public string TRAVELNOTICE_CONTENT { get; set; }
    
        /// <summary>
        /// 是否审核：F未审核，T审核,在同一个部门对一条公告审核则其他公告置为未审核
        /// </summary>
        
        [Description("是否审核：F未审核，T审核,在同一个部门对一条公告审核则其他公告置为未审核")]
        public string TRAVELNOTICE_ISAUDIT { get; set; }
    
        /// <summary>
        /// 审核人ID
        /// </summary>
        
        [Description("审核人ID")]
        public decimal TRAVELNOTICE_AUDITID { get; set; }
    
        /// <summary>
        /// 审核人
        /// </summary>
        
        [Description("审核人")]
        public string TRAVELNOTICE_AUDITNAME { get; set; }
    
        /// <summary>
        /// 审核日期
        /// </summary>
        
        [Description("审核日期")]
        public DateTime TRAVELNOTICE_AUDITDATE { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal TRAVELNOTICE_CREID { get; set; }
    
        /// <summary>
        /// 创建人姓名
        /// </summary>
        
        [Description("创建人姓名")]
        public string TRAVELNOTICE_CRENAME { get; set; }
    
        /// <summary>
        /// 创建人所在机构ID
        /// </summary>
        
        [Description("创建人所在机构ID")]
        public decimal TRAVELNOTICE_CREORGID { get; set; }
    
        /// <summary>
        /// 创建人所在机构名称
        /// </summary>
        
        [Description("创建人所在机构名称")]
        public string TRAVELNOTICE_CREORGNAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime TRAVELNOTICE_CREDATE { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal TRAVELNOTICE_UPID { get; set; }
    
        /// <summary>
        /// 修改人名称
        /// </summary>
        
        [Description("修改人名称")]
        public string TRAVELNOTICE_UPNAME { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime TRAVELNOTICE_UPDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string TRAVELNOTICE_ISDEL { get; set; }
    }
}
