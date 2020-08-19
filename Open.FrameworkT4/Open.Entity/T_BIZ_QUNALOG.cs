//-----------------------------------------------------------------------
// <Copyright>
// * copyright © 2020 open All Rights Reserved
// * version : 4.0.30319.42000
// * author  : open
// * history : Created by open 2020-08-19 11:17:17 
// </Copyright>
//-----------------------------------------------------------------------
using System;
using SqlSugar;
using System.ComponentModel;

namespace Open.Entity.Oracle
{
    /// <summary>
    /// T_BIZ_QUNALOG 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_QUNALOG")]
    public class T_BIZ_QUNALOG
    {
    
        /// <summary>
        /// a
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("a")]
        public decimal ID { get; set; }
    
        /// <summary>
        /// 请求数据
        /// </summary>
        
        [Description("请求数据")]
        public string TRANSFERDATA { get; set; }
    
        /// <summary>
        /// response请求 request请求beforBack请求前 endBack请求后
        /// </summary>
        
        [Description("response请求 request请求beforBack请求前 endBack请求后")]
        public string SENDMETHOD { get; set; }
    
        /// <summary>
        /// 添加时间
        /// </summary>
        
        [Description("添加时间")]
        public DateTime ADDTIME { get; set; }
    
        /// <summary>
        /// 错误条件
        /// </summary>
        
        [Description("错误条件")]
        public string CONDITION { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string METHODNAME { get; set; }
    }
}
