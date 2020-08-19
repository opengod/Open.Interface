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
    /// T_B2C_ADVERT 
    /// </summary>    
   [Serializable]
   [SugarTable("T_B2C_ADVERT")]
    public class T_B2C_ADVERT
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal ADVERT_ID { get; set; }
    
        /// <summary>
        /// 广告名称
        /// </summary>
        
        [Description("广告名称")]
        public string ADVERT_TITLE { get; set; }
    
        /// <summary>
        /// 展示位置(首页顶部IT、首页底部IB、旅游线路L、景区景点P、酒店住宿H、最新资讯Z、推荐线路M、休闲娱乐E、餐饮美食R、特产首页顶部BT、特产首页顶部BB、特产店铺B)
        /// </summary>
        
        [Description("展示位置(首页顶部IT、首页底部IB、旅游线路L、景区景点P、酒店住宿H、最新资讯Z、推荐线路M、休闲娱乐E、餐饮美食R、特产首页顶部BT、特产首页顶部BB、特产店铺B)")]
        public string ADVERT_SHOWTYPE { get; set; }
    
        /// <summary>
        /// 展示图片
        /// </summary>
        
        [Description("展示图片")]
        public string ADVERT_IMAGEPATH { get; set; }
    
        /// <summary>
        /// 产品类型(旅游线路L、景区景点P、酒店住宿H、最新资讯Z、推荐线路M、休闲娱乐E、餐饮美食R、B特产店铺)
        /// </summary>
        
        [Description("产品类型(旅游线路L、景区景点P、酒店住宿H、最新资讯Z、推荐线路M、休闲娱乐E、餐饮美食R、B特产店铺)")]
        public string ADVERT_PROTYPE { get; set; }
    
        /// <summary>
        /// 产品名称
        /// </summary>
        
        [Description("产品名称")]
        public string ADVERT_PRONAME { get; set; }
    
        /// <summary>
        /// 产品ID
        /// </summary>
        
        [Description("产品ID")]
        public decimal ADVERT_PROID { get; set; }
    
        /// <summary>
        /// 点击数量
        /// </summary>
        
        [Description("点击数量")]
        public decimal ADVERT_HITTOTAL { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string ADVERT_MEMO { get; set; }
    
        /// <summary>
        /// 是否审核：F未审核，T审核
        /// </summary>
        
        [Description("是否审核：F未审核，T审核")]
        public string ADVERT_ISAUDIT { get; set; }
    
        /// <summary>
        /// 审核人ID
        /// </summary>
        
        [Description("审核人ID")]
        public decimal ADVERT_AUDITID { get; set; }
    
        /// <summary>
        /// 审核人
        /// </summary>
        
        [Description("审核人")]
        public string ADVERT_AUDITNAME { get; set; }
    
        /// <summary>
        /// 审核日期
        /// </summary>
        
        [Description("审核日期")]
        public DateTime ADVERT_AUDITDATE { get; set; }
    
        /// <summary>
        /// 排序
        /// </summary>
        
        [Description("排序")]
        public decimal ADVERT_SORT { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal ADVERT_CREID { get; set; }
    
        /// <summary>
        /// 创建人姓名
        /// </summary>
        
        [Description("创建人姓名")]
        public string ADVERT_CRENAME { get; set; }
    
        /// <summary>
        /// 创建人所在机构ID
        /// </summary>
        
        [Description("创建人所在机构ID")]
        public decimal ADVERT_CREORGID { get; set; }
    
        /// <summary>
        /// 创建人所在机构名称
        /// </summary>
        
        [Description("创建人所在机构名称")]
        public string ADVERT_CREORGNAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime ADVERT_CREDATE { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal ADVERT_UPID { get; set; }
    
        /// <summary>
        /// 修改人名称
        /// </summary>
        
        [Description("修改人名称")]
        public string ADVERT_UPNAME { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime ADVERT_UPDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string ADVERT_ISDEL { get; set; }
    }
}
