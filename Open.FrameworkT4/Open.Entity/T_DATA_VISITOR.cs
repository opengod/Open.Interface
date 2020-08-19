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
    /// T_DATA_VISITOR 
    /// </summary>    
   [Serializable]
   [SugarTable("T_DATA_VISITOR")]
    public class T_DATA_VISITOR
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("主键")]
        public decimal VISITOR_ID { get; set; }
    
        /// <summary>
        /// 游客编号
        /// </summary>
        
        [Description("游客编号")]
        public decimal VISITOR_NO { get; set; }
    
        /// <summary>
        /// 游客姓名
        /// </summary>
        
        [Description("游客姓名")]
        public string VISITOR_NAME { get; set; }
    
        /// <summary>
        /// 游客电话
        /// </summary>
        
        [Description("游客电话")]
        public string VISITOR_TEL { get; set; }
    
        /// <summary>
        /// 游客性别(M：男，W：女）
        /// </summary>
        
        [Description("游客性别(M：男，W：女）")]
        public string VISITOR_SEX { get; set; }
    
        /// <summary>
        /// 游客年龄
        /// </summary>
        
        [Description("游客年龄")]
        public int VISITOR_AGE { get; set; }
    
        /// <summary>
        /// 所属省份
        /// </summary>
        
        [Description("所属省份")]
        public string VISITOR_PROVINCE { get; set; }
    
        /// <summary>
        /// 所属城市
        /// </summary>
        
        [Description("所属城市")]
        public string VISITOR_CITY { get; set; }
    
        /// <summary>
        /// 来泉开始日期
        /// </summary>
        
        [Description("来泉开始日期")]
        public DateTime VISITOR_STARDATE { get; set; }
    
        /// <summary>
        /// 来泉结束日期
        /// </summary>
        
        [Description("来泉结束日期")]
        public DateTime VISITOR_ENDDATE { get; set; }
    
        /// <summary>
        /// 入园日期
        /// </summary>
        
        [Description("入园日期")]
        public DateTime VISITOR_ENTRYDATE { get; set; }
    
        /// <summary>
        /// 出行方式（A：飞机，B：大巴，C：汽车，D：动车，T：火车）
        /// </summary>
        
        [Description("出行方式（A：飞机，B：大巴，C：汽车，D：动车，T：火车）")]
        public string VISITOR_TRAVELWAY { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Description("创建时间")]
        public DateTime VISITOR_CREDATE { get; set; }
    
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        
        [Description("是否逻辑删除")]
        public string VISITOR_ISDEL { get; set; }
    }
}
