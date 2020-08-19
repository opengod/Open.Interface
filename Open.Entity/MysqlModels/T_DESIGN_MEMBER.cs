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
    /// T_DESIGN_MEMBER 
    /// </summary>    
   [Serializable]
   [SugarTable("T_DESIGN_MEMBER")]
    public class T_DESIGN_MEMBER
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal MENBER_ID { get; set; }
    
        /// <summary>
        /// 所属团队ID
        /// </summary>
        
        [Description("所属团队ID")]
        public decimal MENBER_TEAMID { get; set; }
    
        /// <summary>
        /// 姓名
        /// </summary>
        
        [Description("姓名")]
        public string MENBER_NAME { get; set; }
    
        /// <summary>
        /// 院系
        /// </summary>
        
        [Description("院系")]
        public string MENBER_DEPARTMENT { get; set; }
    
        /// <summary>
        /// 年级
        /// </summary>
        
        [Description("年级")]
        public string MENBER_GRADE { get; set; }
    
        /// <summary>
        /// 电话号码
        /// </summary>
        
        [Description("电话号码")]
        public string MENBER_MOBILE { get; set; }
    
        /// <summary>
        /// 微信号
        /// </summary>
        
        [Description("微信号")]
        public string MENBER_WECHAT { get; set; }
    
        /// <summary>
        /// 是否队长，T：是，F：不是
        /// </summary>
        
        [Description("是否队长，T：是，F：不是")]
        public string MENBER_ISMAIN { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime MENBER_CREDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string MENBER_ISDEL { get; set; }
    }
}
