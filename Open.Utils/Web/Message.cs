using System;
using System.Collections.Generic;
using System.Text;

namespace Open.Utils
{
    public class Message
    {
        /// <summary>
        /// 获取代码对应详细描述
        /// </summary>
        /// <param name="Code"></param>
        /// <returns></returns>
        public static string ReturnCodeMessage(string Code)
        {
            switch (Code)
            {
                #region 执行成功
                case "1000": return "成功";
                #endregion

                #region 人员登录
                case "L1001": return "账户被系统锁定,请联系管理员";
                case "L1002": return "账户不存在，请重新输入";
                case "L1003": return "密码不正确，请重新输入";
                case "L1004": return "两次输入的新密码不一致";
                case "L1005": return "无法获取到用户信息";
                case "L1006": return "您输入的旧密码错误，请重新输入";
                case "L1007": return "账户被系统锁定";
                #endregion

                #region 人员密码
                case "P1001": return "密码不正确，请重新输入";
                case "P1002": return "新密码不能为空";
                case "P1003": return "确认新密码不能为空";
                case "P1004": return "两次输入的新密码不一致";
                case "P1005": return "无法获取到用户信息";
                case "P1006": return "您输入的旧密码错误，请重新输入";
                #endregion

                #region 创建订单业务错误
                case "12001": return "产品不存在，不可预订";
                case "12004": return "产品已下线，不可预订";

                case "20001": return "创建订单异常，取票人身份证号码不合法";
                case "20002": return "创建订单异常，选购产品数量<0";
                case "20003": return "创建订单异常，选购产品数量不是整数";
                case "20004": return "创建订单异常，选购产品不存在";
                case "20005": return "创建订单异常，取票人邮箱格式不合法";
                case "20006": return "创建订单异常，取票人手机号码异常";
                case "20007": return "创建订单异常，取票人姓名异常";
                case "20008": return "创建订单异常，价格排期ID解密失败";
                case "20009": return "创建订单异常，根据价格ID获取产品排期失败";
                case "20010": return "创建订单异常，出行日期为空";
                case "20011": return "创建订单异常，您选择的出行日期格式不合法";
                case "20012": return "创建订单异常，根据产品ID获取团购信息失败";
                case "20013": return "创建订单异常，团购信息状态异常";
                case "20014": return "创建订单异常，购买产品的数量和游客人数不符";
                case "20015": return "创建订单异常，游客信息为空";
                case "20017": return "创建订单异常，游客身份证信息输入有误";
                case "20018": return "创建订单异常，价格排期ID不是正常数字";
                case "20019": return "创建订单异常，账户不存在";
                case "20020": return "创建订单异常，该用户当天的订单量超过了限制";
                case "20021": return "创建订单异常，票数超过了该产品可购买的票数范围";
                case "20022": return "创建订单异常，库存不足";
                case "20023": return "创建订单异常，该产品已经下架";
                case "20024": return "创建订单异常，选择的价格排期已经下架";
                case "20025": return "您选的产品价格已发生变化";
                case "20026": return "创建订单异常，超过了购买限制";
                case "20027": return "创建订单异常，用户未登陆";
                case "20028": return "创建订单异常，优惠劵异常";
                case "20029": return "创建订单异常，创建产品快照失败";
                case "20030": return "创建订单异常，创建订单的返现信息失败";
                case "20031": return "创建订单异常，超出产品同一手机号购买限制";
                case "20032": return "供应商未签订协议";
                case "20033": return "协议当日票不可售";
                case "20034": return "供应商未建立产品价格政策协议";
                case "20035": return "账户余额不足";
                case "20036": return "产品不存在，请核实产品编码";
                case "20037": return "创建订单异常，预订日期异常";
                case "20038": return "创建订单异常，调取微信统一下单接口失败";

                case "30001": return "创建订单异常";
                case "30002": return "创建订单异常，订单号异常";

                case "30003": return "没有可确认的订单";
                case "30004": return "申请改签异常，改签日期可售票价与订单单价不一致";

                #endregion

                #region 同步订单业务错误， 13000~13999.
                case "13001": return "订单不存在";
                case "13003": return "订单不存在电子门票信息";
                case "13004": return "订单存在，但不属于该用户";
                case "13005": return "该订单无法修改";
                case "13007": return "订单产品价格信息异常";
                case "13009": return "订单状态不正确，不能重新发送入园凭证";
                #endregion

                #region 电子票业务错误
                case "14001": return "电子票生成失败";
                case "14002": return "订单消费失败， 电子票不存在";
                case "14003": return "订单消费失败， 电子票已消费";
                case "14004": return "订单消费失败， 电子票已作废(订单已取消或已退款)";
                case "14005": return "订单电子票查询失败";
                case "14006": return "电子票有误";
                case "14007": return "电子票最多重复发送5次";
                case "14008": return "订单消费失败， 电子票已过期";
                case "14009": return "订单消费失败，订单还未到有效使用日期";
                case "14010": return "订单消费失败，订单已超过有效使用日期";
                case "14011": return "消费码重发间隔为1分钟，请1分钟后重试";
                case "14012": return "重发凭证失败，原因为订单未支付或订单状态不正确";
                case "14013": return "重发凭证失败，供应商不支持对非联系人手机号下发凭证";
                #endregion

                #region 退款业务错误
                case "15001": return "抱歉，该订单可退金额不足，无法进行退款";
                case "15002": return "退款失败，系统出错";
                case "15003": return "退款失败，供应商已拒绝退款";
                case "15005": return "退款失败，该订单已全部退款";
                case "15006": return "退款失败，手续费超过限制";
                case "15007": return "退款失败，退款张数大于最大退款张数";
                case "15008": return "退款失败，只有预付成功的订单允许退款";
                case "15009": return "退款失败，使用了代金券的订单不可以进行部分退款";
                case "15010": return "退款失败，订单已全部消费";
                case "15011": return "退款失败，供应商不支持退款操作";
                case "15012": return "申请退款异常，财务账户异常";
                case "15013": return "申请退款异常，订单数量异常";
                case "15014": return "申请退款异常，退款数量异常";

                case "15015": return "申请退款异常，未建立退票规则，无法退票";
                case "15016": return "申请退款异常，退款数量异常";
                case "15017": return "退款失败，不在可退款日期范围内";
                case "15018": return "退款失败，过期不可退";
                case "15019": return "退款失败，当天不可退";
                case "15020": return "申请退款需要审核";
                case "15000": return "申请退款异常，无可退票订单信息";

                case "16001": return "取消订单失败，订单已支付";
                case "16002": return "取消订单失败，订单已消费或已退款";
                #endregion

                #region 查询业务错误
                case "17001": return "景区编码为空";
                case "17002": return "查询景区财务账户不存在";
                case "17003": return "未建立退票规则";
                #endregion

                #region 景区接口业务错误
                case "18001": return "订单列表为空";
                case "18002": return "核销失败，可使用票数为零";
                case "18003": return "核销失败，当天无此订单信息";
                case "18004": return "核销失败，检票数量异常";
                case "18007": return "订单已全部核销";
                case "18006": return "预定时间限制，不能提前入园";
                #endregion

                #region 商家核销错误
                case "21001": return "登录失败，用户名错误/没有此用户";
                case "21002": return "登录失败，密码错误";
                case "21010": return "查询订单失败，没有此查询条件订单";
                case "21011": return "核销失败，核销数量超过订单总数量";
                case "21012": return "核销失败，没有此订单";
                #endregion

                #region 企业入园人数上报错误
                case "22001": return "上报失败，缺少必填参数";
                #endregion

                #region 系统错误
                case "90001": return "报文解析异常，请检查报文结构";
                case "90002": return "签证验证不通过";
                case "90003": return "无效IP访问";
                case "90004": return "系统处理异常";
                case "90005": return "交互Json解析错误";
                case "90006": return "合作者标识不存在";
                case "90007": return "web服务调用错误";
                case "90008": return "IP校验失败";
                case "90009": return "不支持该接口";
                case "90010": return "参数错误";
                case "99999": return "接口出错";
                #endregion

                default: return "error";
            }
        }

        public static JsonMsgResult ReturnMsg(string Code, object Data, bool Success = false)
        {
            return new JsonMsgResult(Code, ReturnCodeMessage(Code), Data, Success);
        }

        public static ReponseData ReturnMessage(string Code, object Data)
        {
            return new ReponseData(Code, ReturnCodeMessage(Code), Data);
        }

        public static ReponseData ReturnMessage(string Method, string Code, object Data)
        {
            return new ReponseData(Method, Code, ReturnCodeMessage(Code), Data);
        }
    }
}
