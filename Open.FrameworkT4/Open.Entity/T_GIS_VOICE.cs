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
    /// T_GIS_VOICE 
    /// </summary>    
   [Serializable]
   [SugarTable("T_GIS_VOICE")]
    public class T_GIS_VOICE
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal VOICEGIS_ID { get; set; }
    
        /// <summary>
        /// 语音名称
        /// </summary>
        
        [Description("语音名称")]
        public string VOICEGIS_NAME { get; set; }
    
        /// <summary>
        /// 经维度类型
        /// </summary>
        
        [Description("经维度类型")]
        public string VOICEGIS_TUDETYPE { get; set; }
    
        /// <summary>
        /// 语音经度
        /// </summary>
        
        [Description("语音经度")]
        public decimal VOICEGIS_LONGITUDE { get; set; }
    
        /// <summary>
        /// 语音维度
        /// </summary>
        
        [Description("语音维度")]
        public decimal VOICEGIS_LATITUDE { get; set; }
    
        /// <summary>
        /// 语音录入人
        /// </summary>
        
        [Description("语音录入人")]
        public string VOICEGIS_MAN { get; set; }
    
        /// <summary>
        /// 语音故障联系电话
        /// </summary>
        
        [Description("语音故障联系电话")]
        public string VOICEGIS_PHONE { get; set; }
    
        /// <summary>
        /// 语音文字说明
        /// </summary>
        
        [Description("语音文字说明")]
        public string VOICEGIS_INTRODUCTION { get; set; }
    
        /// <summary>
        /// 音频文件路径
        /// </summary>
        
        [Description("音频文件路径")]
        public string VOICEGIS_URL { get; set; }
    
        /// <summary>
        /// 景区ID
        /// </summary>
        
        [Description("景区ID")]
        public decimal VOICEGIS_PARKID { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        
        [Description("备注")]
        public string VOICEGIS_MEMO { get; set; }
    
        /// <summary>
        /// 排序
        /// </summary>
        
        [Description("排序")]
        public decimal VOICEGIS_SORT { get; set; }
    
        /// <summary>
        /// 创建人ID
        /// </summary>
        
        [Description("创建人ID")]
        public decimal VOICEGIS_CREID { get; set; }
    
        /// <summary>
        /// 创建人姓名
        /// </summary>
        
        [Description("创建人姓名")]
        public string VOICEGIS_CRENAME { get; set; }
    
        /// <summary>
        /// 创建人所在机构ID
        /// </summary>
        
        [Description("创建人所在机构ID")]
        public decimal VOICEGIS_CREORGID { get; set; }
    
        /// <summary>
        /// 创建人所在机构名称
        /// </summary>
        
        [Description("创建人所在机构名称")]
        public string VOICEGIS_CREORGNAME { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime VOICEGIS_CREDATE { get; set; }
    
        /// <summary>
        /// 修改人ID
        /// </summary>
        
        [Description("修改人ID")]
        public decimal VOICEGIS_UPID { get; set; }
    
        /// <summary>
        /// 修改人名称
        /// </summary>
        
        [Description("修改人名称")]
        public string VOICEGIS_UPNAME { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        
        [Description("修改时间")]
        public DateTime VOICEGIS_UPDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string VOICEGIS_ISDEL { get; set; }
    }
}
