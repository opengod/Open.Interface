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
    /// T_EXPRESS_TEMPLATE 
    /// </summary>    
   [Serializable]
   [SugarTable("T_EXPRESS_TEMPLATE")]
    public class T_EXPRESS_TEMPLATE
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public long TEMPLATE_ID { get; set; }
    
        /// <summary>
        /// 名称
        /// </summary>
        
        [Description("名称")]
        public string TEMPLATE_NAME { get; set; }
    
        /// <summary>
        /// 0-自定义模板;1-卖家承担运费;
        /// </summary>
        
        [Description("0-自定义模板;1-卖家承担运费;")]
        public int TEMPLATE_TYPE { get; set; }
    
        /// <summary>
        /// 计价方式：0-按件数;1-按重量;2-按体积;
        /// </summary>
        
        [Description("计价方式：0-按件数;1-按重量;2-按体积;")]
        public int TEMPLATE_METHOD { get; set; }
    
        /// <summary>
        /// 店铺ID
        /// </summary>
        
        [Description("店铺ID")]
        public long TEMPLATE_SHOPID { get; set; }
    
        /// <summary>
        /// 发货时间
        /// </summary>
        
        [Description("发货时间")]
        public string TEMPLATE_SENDTIME { get; set; }
    
        /// <summary>
        /// 创建人
        /// </summary>
        
        [Description("创建人")]
        public int TEMPLATE_CREATOR { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime TEMPLATE_CREATETIME { get; set; }
    
        /// <summary>
        /// 修改人
        /// </summary>
        
        [Description("修改人")]
        public int TEMPLATE_UPDATOR { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime TEMPLATE_UPDATETIME { get; set; }
    
        /// <summary>
        /// 删除人
        /// </summary>
        
        [Description("删除人")]
        public int TEMPLATE_DELETOR { get; set; }
    
        /// <summary>
        /// 删除时间
        /// </summary>
        
        [Description("删除时间")]
        public DateTime TEMPLATE_DELETETIME { get; set; }
    
        /// <summary>
        /// 逻辑删除：0-正常;1-删除;
        /// </summary>
        
        [Description("逻辑删除：0-正常;1-删除;")]
        public int TEMPLATE_ISDEL { get; set; }
    }
}
