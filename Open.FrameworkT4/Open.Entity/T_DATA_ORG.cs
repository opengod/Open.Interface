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
    /// T_DATA_ORG 
    /// </summary>    
   [Serializable]
   [SugarTable("T_DATA_ORG")]
    public class T_DATA_ORG
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal ORG_ID { get; set; }
    
        /// <summary>
        /// 编号
        /// </summary>
        
        [Description("编号")]
        public string ORG_NO { get; set; }
    
        /// <summary>
        /// 机构名称
        /// </summary>
        
        [Description("机构名称")]
        public string ORG_NAME { get; set; }
    
        /// <summary>
        /// 机构类型(H:酒店，P：景区)
        /// </summary>
        
        [Description("机构类型(H:酒店，P：景区)")]
        public string ORG_TYPE { get; set; }
    
        /// <summary>
        /// 机构等级
        /// </summary>
        
        [Description("机构等级")]
        public string ORG_GRADE { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime ORG_CREDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string ORG_ISDEL { get; set; }
    }
}
