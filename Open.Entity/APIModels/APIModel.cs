using System;
using System.Collections.Generic;
using System.Text;

namespace Open.Entity
{
    /// <summary>
    /// 通用请求参数
    /// </summary>
    public class RequestParam_API
    {
        /// <summary>
        /// 请求数据
        /// </summary>
        public RequestData_API RequestData { get; set; }
        /// <summary>
        /// 加密数据MD5(MerchantKey+data)
        /// </summary>
        public string Signed { get; set; }
    }

    /// <summary>
    /// 通用请求数据
    /// </summary>
    public class RequestData_API
    {
        /// <summary>
        /// 会员手机号
        /// </summary>
        public string AgencyCode { get; set; }
        /// <summary>
        /// 请求方法
        /// </summary>
        public string Method { get; set; }
        /// <summary>
        /// 请求人
        /// </summary>
        public string Requestor { get; set; }
        /// <summary>
        /// 请求时间戳 5min有效
        /// </summary>
        public long RequestTime { get; set; }
        /// <summary>
        /// 请求数据
        /// </summary>
        public dynamic Data { get; set; }
    }
    /// <summary>
    /// 通用响应消息体
    /// </summary>
    public class ReponseData_API
    {
        /// <summary>
        /// 消息编码
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 消息正文
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// 响应方法
        /// </summary>
        public string Method { get; set; }
        /// <summary>
        /// 响应人
        /// </summary>
        public string Responder
        {
            get { return "InTel"; }
            set { }
        }
        /// <summary>
        /// 响应时间
        /// </summary>
        public string ReponseTime
        {
            get { return DateTime.Now.ToLocalTime().ToString(); }
            set { }
        }
        /// <summary>
        /// 响应数据
        /// </summary>
        public dynamic Data { get; set; }

        /// <summary>
        /// 返回内容重定义
        /// </summary>
        public static ReponseData_API data(string Method, string Code, dynamic Data)
        {
            return new ReponseData_API() { Method = Method, Code = Code, Message = Messages_API.ReturnCodeMessage(Code), Data = Data };
        }
    }

    /// <summary>
    /// 获取消息代码对应详细描述
    /// </summary>
    /// <returns></returns>
    public class Messages_API
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

                #region 用户相关
                case "10001": return "密码错误，请重新输入";
                case "10002": return "旧密码错误，请重新输入";
                case "10003": return "用户有效租赁时间已过，请联系系统管理员充值";
                case "10004": return "用户未启用，请联系系统管理员启用";
                #endregion

                #region 通话相关
                case "20001": return "用户绑定中间号失败";
                case "20002": return "用户绑定中间号失败，当前平台不可用";
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
                case "90010": return "请求参数缺失或为空";
                case "90011": return "时间戳格式错误，请传入13位时间戳";
                case "90012": return "请求时间戳已过期";
                case "90013": return "请求方法不合法";
                case "99999": return "接口出错";
                #endregion

                default: return "error";
            }
        }
    }
}
