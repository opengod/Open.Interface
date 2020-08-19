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
    /// T_BIZ_DEVICE 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_DEVICE")]
    public class T_BIZ_DEVICE
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal DEVICE_ID { get; set; }
    
        /// <summary>
        /// 部门ID：景区酒店商户ID
        /// </summary>
        
        [Description("部门ID：景区酒店商户ID")]
        public decimal DEVICE_ORGID { get; set; }
    
        /// <summary>
        /// 部门名称
        /// </summary>
        
        [Description("部门名称")]
        public string DEVICE_ORGNAME { get; set; }
    
        /// <summary>
        /// 设备分类:1云闸机，2酒店终端，3餐饮、商户终端
        /// </summary>
        
        [Description("设备分类:1云闸机，2酒店终端，3餐饮、商户终端")]
        public string DEVICE_CLASS { get; set; }
    
        /// <summary>
        /// 设备类型编码类型
        /// </summary>
        
        [Description("设备类型编码类型")]
        public string DEVICE_CODETYPE { get; set; }
    
        /// <summary>
        /// 设备类型编码值
        /// </summary>
        
        [Description("设备类型编码值")]
        public string DEVICE_CODEVALUE { get; set; }
    
        /// <summary>
        /// 设备编号
        /// </summary>
        
        [Description("设备编号")]
        public string DEVICE_CODE { get; set; }
    
        /// <summary>
        /// 设备机器码
        /// </summary>
        
        [Description("设备机器码")]
        public string DEVICE_MACHINECODE { get; set; }
    
        /// <summary>
        /// 设备名称
        /// </summary>
        
        [Description("设备名称")]
        public string DEVICE_NAME { get; set; }
    
        /// <summary>
        /// 链接地址
        /// </summary>
        
        [Description("链接地址")]
        public string DEVICE_URL { get; set; }
    
        /// <summary>
        /// 登录账号
        /// </summary>
        
        [Description("登录账号")]
        public string DEVICE_LOGINCODE { get; set; }
    
        /// <summary>
        /// 登录密码
        /// </summary>
        
        [Description("登录密码")]
        public string DEVICE_LOGINPWD { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string DEVICE_MEMO { get; set; }
    
        /// <summary>
        /// 排序
        /// </summary>
        
        [Description("排序")]
        public decimal DEVICE_SORT { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal DEVICE_CREID { get; set; }
    
        /// <summary>
        /// 创建人姓名
        /// </summary>
        
        [Description("创建人姓名")]
        public string DEVICE_CRENAME { get; set; }
    
        /// <summary>
        /// 创建人所在机构ID
        /// </summary>
        
        [Description("创建人所在机构ID")]
        public decimal DEVICE_CREORGID { get; set; }
    
        /// <summary>
        /// 创建人所在机构名称
        /// </summary>
        
        [Description("创建人所在机构名称")]
        public string DEVICE_CREORGNAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime DEVICE_CREDATE { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal DEVICE_UPID { get; set; }
    
        /// <summary>
        /// 修改人名称
        /// </summary>
        
        [Description("修改人名称")]
        public string DEVICE_UPNAME { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime DEVICE_UPDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string DEVICE_ISDEL { get; set; }
    }
}
