using System;
using System.Collections.Generic;
using System.Text;

namespace Open.Utils
{
    /// <summary>
    /// 自动编号 规则分类枚举
    /// </summary>
    public enum CodeRuleEnum
    {
        /// <summary>
        /// 交易单号
        /// </summary>
        TransOrderCode = 10000
    }

    /// <summary>
    /// 缴费状态 分类枚举
    /// </summary>
    public enum AmountStateEnum
    {
        /// <summary>
        /// 已缴费
        /// </summary>
        Paid = 1,
        /// <summary>
        /// 已缴费
        /// </summary>
        NoPaid = 2
    }

    /// <summary>
    /// 收款方式 分类枚举
    /// </summary>
    public enum AmountTypeEnum
    {
        /// <summary>
        /// 已缴费
        /// </summary>
        Cash = 1,
        /// <summary>
        /// 已缴费
        /// </summary>
        Transfer = 2,
        /// <summary>
        /// 支付宝
        /// </summary>
        AliPay = 3,
        /// <summary>
        /// 微信
        /// </summary>
        WeChatPay = 4,
        /// <summary>
        /// 认缴
        /// </summary>
        SubcribePay = 5
    }
}
