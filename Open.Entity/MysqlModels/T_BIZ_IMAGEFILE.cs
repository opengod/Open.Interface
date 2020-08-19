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
    /// T_BIZ_IMAGEFILE 
    /// </summary>    
   [Serializable]
   [SugarTable("T_BIZ_IMAGEFILE")]
    public class T_BIZ_IMAGEFILE
    {
    
        /// <summary>
        /// 图片表主键ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("图片表主键ID")]
        public decimal IMAGEFILE_ID { get; set; }
    
        /// <summary>
        /// 产品类型（P景区，PT门票，PP套餐，H酒店，HR房间，HB会议室，L线路，C评论，T投诉，R餐饮，RP餐饮套餐，E休闲娱乐，EP娱乐套餐，B商店，BP商店商品，G导游，TC旅游通卡，BV景区预约）
        /// </summary>
        
        [Description("产品类型（P景区，PT门票，PP套餐，H酒店，HR房间，HB会议室，L线路，C评论，T投诉，R餐饮，RP餐饮套餐，E休闲娱乐，EP娱乐套餐，B商店，BP商店商品，G导游，TC旅游通卡，BV景区预约）")]
        public string IMAGEFILE_TYPE { get; set; }
    
        /// <summary>
        /// 产品ID
        /// </summary>
        
        [Description("产品ID")]
        public decimal IMAGEFILE_PROID { get; set; }
    
        /// <summary>
        /// 产品名称
        /// </summary>
        
        [Description("产品名称")]
        public string IMAGEFILE_PRONAME { get; set; }
    
        /// <summary>
        /// 图片路径地址
        /// </summary>
        
        [Description("图片路径地址")]
        public string IMAGEFILE_PATH { get; set; }
    
        /// <summary>
        /// 图片跳转链接
        /// </summary>
        
        [Description("图片跳转链接")]
        public string IMAGEFILE_URL { get; set; }
    
        /// <summary>
        /// 文件ID
        /// </summary>
        
        [Description("文件ID")]
        public decimal IMAGEFILE_FILEID { get; set; }
    
        /// <summary>
        /// 层级(一级)
        /// </summary>
        
        [Description("层级(一级)")]
        public string IMAGEFILE_LEVEL { get; set; }
    
        /// <summary>
        /// 是否主图
        /// </summary>
        
        [Description("是否主图")]
        public string IMAGEFILE_ISMAIN { get; set; }
    
        /// <summary>
        /// 上传人所在机构
        /// </summary>
        
        [Description("上传人所在机构")]
        public decimal IMAGEFILE_ORGID { get; set; }
    
        /// <summary>
        /// 上传人所在机构名称
        /// </summary>
        
        [Description("上传人所在机构名称")]
        public string IMAGEFILE_ORGNAME { get; set; }
    
        /// <summary>
        /// 上传人姓名
        /// </summary>
        
        [Description("上传人姓名")]
        public string IMAGEFILE_CREATE { get; set; }
    
        /// <summary>
        /// 上传人
        /// </summary>
        
        [Description("上传人")]
        public decimal IMAGEFILE_CREATEBY { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime IMAGEFILE_CREATEDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string IMAGEFILE_ISDEL { get; set; }
    }
}
