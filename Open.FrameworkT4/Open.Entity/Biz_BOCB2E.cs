//-----------------------------------------------------------------------
// <Copyright>
// * copyright © 2018-2019 QZYL Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : MZERO
// * history : Created by T4 2019-08-22 08:43:48 
// </Copyright>
//-----------------------------------------------------------------------
using System;

namespace QZYL.Entity
{
    /// <summary>
    /// Biz_BOCB2E 
    /// </summary>    
    [Serializable]
    public class Biz_BOCB2E
    {
    
        /// <summary>
        /// 主键
        /// </summary>
        public string B_ID { get; set; }
    
        /// <summary>
        /// 企业前置机
        /// </summary>
        public string B_Termid { get; set; }
    
        /// <summary>
        /// 客户端产生的报文编号
        /// </summary>
        public string B_Trnid { get; set; }
    
        /// <summary>
        /// 企业在中行网银系统的客户编码
        /// </summary>
        public string B_Custid { get; set; }
    
        /// <summary>
        /// 企业操作员代码
        /// </summary>
        public string B_Cusopr { get; set; }
    
        /// <summary>
        /// 交易代码
        /// </summary>
        public string B_Trncod { get; set; }
    
        /// <summary>
        /// 交易验证标识，签到时生成，签退时注销
        /// </summary>
        public string B_Token { get; set; }
    
        /// <summary>
        /// 交易流水号  主动推送中产生的网银交易流水号
        /// </summary>
        public string B_Obssmsgid { get; set; }
    
        /// <summary>
        /// 业务类型 01:余额信息,02:额度信息,03:余额变动信息, 04:账户对账信息,05:账户变动信息,06：银行承兑开立,07：银行承兑申请退回, 08：国结授信业务, 09：转让结果,10：融资结果,11：付款结果,12：电签协议结果通知,13、经销商融资申请结果通知,14、经销商融资还款申请结果通知,15、经销商融资申请结果夜间批量通知,16、经销商融资申请还款结果夜间批量通知
        /// </summary>
        public string B_TrnType { get; set; }
    
        /// <summary>
        /// 通知次数
        /// </summary>
        public string B_PushNum { get; set; }
    
        /// <summary>
        /// 开户行机构号
        /// </summary>
        public string B_IbkNum { get; set; }
    
        /// <summary>
        /// 开户行名称
        /// </summary>
        public string B_BkName { get; set; }
    
        /// <summary>
        /// 账号
        /// </summary>
        public string B_Actacn { get; set; }
    
        /// <summary>
        /// 账号名称
        /// </summary>
        public string B_ActName { get; set; }
    
        /// <summary>
        /// 对方开户银行号
        /// </summary>
        public string B_TransiBkn { get; set; }
    
        /// <summary>
        /// 对方开户行名称
        /// </summary>
        public string B_TransBank { get; set; }
    
        /// <summary>
        /// 对方账号
        /// </summary>
        public string B_TransSact { get; set; }
    
        /// <summary>
        /// 对方名称
        /// </summary>
        public string B_TransName { get; set; }
    
        /// <summary>
        /// 被代理行号
        /// </summary>
        public string B_MactiBkn { get; set; }
    
        /// <summary>
        /// 被代理账号
        /// </summary>
        public string B_MacTacn { get; set; }
    
        /// <summary>
        /// 被代理账号
        /// </summary>
        public string B_MactName { get; set; }
    
        /// <summary>
        /// 被代理账户开户行名
        /// </summary>
        public string B_MactBank { get; set; }
    
        /// <summary>
        /// 汇款行业务编号
        /// </summary>
        public string B_OutRef { get; set; }
    
        /// <summary>
        /// 收款行业务编号
        /// </summary>
        public string B_Tobref { get; set; }
    
        /// <summary>
        /// 交易日期
        /// </summary>
        public DateTime B_TxnDate { get; set; }
    
        /// <summary>
        /// 交易时间
        /// </summary>
        public DateTime B_TxnTime { get; set; }
    
        /// <summary>
        /// 起息日
        /// </summary>
        public DateTime B_ValDat { get; set; }
    
        /// <summary>
        /// 交易流水号 
        /// </summary>
        public string B_VchNum { get; set; }
    
        /// <summary>
        /// 记录标识号
        /// </summary>
        public string B_TransID { get; set; }
    
        /// <summary>
        /// 业务类型
        /// </summary>
        public string B_BusType { get; set; }
    
        /// <summary>
        /// 业务类型描述
        /// </summary>
        public string B_TrantpDir { get; set; }
    
        /// <summary>
        /// 借贷标识  D：借 C：贷
        /// </summary>
        public string B_Direction { get; set; }
    
        /// <summary>
        /// 交易金额
        /// </summary>
        public string B_Txnamt { get; set; }
    
        /// <summary>
        /// 交易币种
        /// </summary>
        public string B_Trncur { get; set; }
    
        /// <summary>
        /// 凭证类型
        /// </summary>
        public string B_Vouchtp { get; set; }
    
        /// <summary>
        /// 凭证类型的中文描述
        /// </summary>
        public string B_VouchType { get; set; }
    
        /// <summary>
        /// 凭证号码
        /// </summary>
        public string B_VouchNum { get; set; }
    
        /// <summary>
        /// 摘要
        /// </summary>
        public string B_AcsRef { get; set; }
    
        /// <summary>
        /// 用途
        /// </summary>
        public string B_UseInfo { get; set; }
    
        /// <summary>
        /// 交易附言
        /// </summary>
        public string B_FurInfo { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        public string B_Remark { get; set; }
    
        /// <summary>
        /// 交易后余额
        /// </summary>
        public string B_Acctbal { get; set; }
    
        /// <summary>
        /// 可用余额
        /// </summary>
        public string B_Avlbal { get; set; }
    
        /// <summary>
        /// 冻结金额
        /// </summary>
        public string B_Frzamt { get; set; }
    
        /// <summary>
        /// 透支额度
        /// </summary>
        public string B_OverDramt { get; set; }
    
        /// <summary>
        /// 可用透支额度
        /// </summary>
        public string B_Avloverdramt { get; set; }
    
        /// <summary>
        /// 客户业务编号
        /// </summary>
        public string B_Insid { get; set; }
    
        /// <summary>
        /// 网银编号
        /// </summary>
        public string B_Obssid { get; set; }
    
        /// <summary>
        /// 汇款日期
        /// </summary>
        public DateTime B_Trfdat { get; set; }
    
        /// <summary>
        /// 汇率
        /// </summary>
        public decimal B_Fxrate { get; set; }
    
        /// <summary>
        /// 冲正标识 0：正常 1：冲正
        /// </summary>
        public string B_ReversalCode { get; set; }
    
        /// <summary>
        /// BANCS客户号
        /// </summary>
        public string B_Cusid { get; set; }
    
        /// <summary>
        /// 客户名称
        /// </summary>
        public string B_CusName { get; set; }
    
        /// <summary>
        /// 序号 (定期一本通序号)
        /// </summary>
        public string B_SeqNo { get; set; }
    
        /// <summary>
        /// 册号 (定期一本通册号)
        /// </summary>
        public string B_Volno { get; set; }
    
        /// <summary>
        /// 预留项1
        /// </summary>
        public string B_Reserve1 { get; set; }
    
        /// <summary>
        /// 预留项2
        /// </summary>
        public string B_Reserve2 { get; set; }
    
        /// <summary>
        /// 预留项3
        /// </summary>
        public string B_Reserve3 { get; set; }
    
        /// <summary>
        /// 数据状态   0:未处理 1:已核销 2:转认缴 3:不处理(不是租户转进来的资金流数据不需要处理)
        /// </summary>
        public string B_DataStatus { get; set; }
    
        /// <summary>
        /// 核销的交易明细ID
        /// </summary>
        public string B_BillItemsID { get; set; }
    
        /// <summary>
        /// 创建人
        /// </summary>
        public string B_CreateUserID { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime B_CreateTime { get; set; }
    
        /// <summary>
        /// 最后修改人
        /// </summary>
        public string B_LastModifyUserId { get; set; }
    
        /// <summary>
        /// 最后修改时间
        /// </summary>
        public DateTime B_LastModifyTime { get; set; }
    
        /// <summary>
        /// 删除标志
        /// </summary>
        public bool B_DeleteMark { get; set; }
    
        /// <summary>
        /// 删除人
        /// </summary>
        public string B_DeleteUserID { get; set; }
    
        /// <summary>
        /// 删除时间
        /// </summary>
        public DateTime B_DeleteTime { get; set; }
    
        /// <summary>
        /// 关联的认缴信息
        /// </summary>
        public string B_SubcribeID { get; set; }
    }
}
