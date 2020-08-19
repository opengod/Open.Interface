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
    /// T_DATA_MSGTEMPAPPLY 
    /// </summary>    
   [Serializable]
   [SugarTable("T_DATA_MSGTEMPAPPLY")]
    public class T_DATA_MSGTEMPAPPLY
    {
    
        /// <summary>
        /// a
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)] 
        [Description("a")]
        public decimal MSGTEMPAPPLY_ID { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal MSGTEMPAPPLY_MSGID { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public decimal MSGTEMPAPPLY_PRODUCTID { get; set; }
    
        /// <summary>
        /// 门票：P,酒店：H,餐饮：C,线路：T
        /// </summary>
        
        [Description("门票：P,酒店：H,餐饮：C,线路：T")]
        public string MSGTEMPAPPLY_TYPE { get; set; }
    
        /// <summary>
        /// a
        /// </summary>
        
        [Description("a")]
        public string HASLINK { get; set; }
    }
}
