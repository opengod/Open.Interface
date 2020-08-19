using System;

namespace Open.Utils
{
    /// <summary>
    /// 请求参数
    /// </summary>
    public class RequestParam
    {
        /// <summary>
        /// 请求数据,默认采用Base64编码
        /// </summary>
        public string Data { get; set; }
        /// <summary>
        /// 加密数据MD5(MerchantKey+data)
        /// </summary>
        public string Signed { get; set; }
    }

    /// <summary>
    /// 请求数据
    /// </summary>
    public class RequestData
    {
        /// <summary>
        /// 合作伙伴号（对外接口）/用户openid（C端接口）
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
        /// 请求时间
        /// </summary>
        public string RequestTime { get; set; }
        /// <summary>
        /// 请求数据
        /// </summary>
        public dynamic Data { get; set; }
    }

    /// <summary>
    /// 响应消息体
    /// </summary>
    public class ReponseData
    {
        private string _code;
        private string _message;
        private string _method;
        private string _responder;
        private string _responsetime;
        private object _data;

        public ReponseData()
        {
            this._method = "";
            this._code = "";
            this._message = "";
            this._data = null;
        }

        public ReponseData(string Code, string Message, object Data)
        {
            this._code = Code;
            this._message = Message;
            this._data = Data;
        }

        public ReponseData(string Method, string Code, string Message, object Data)
        {
            this._method = Method;
            this._code = Code;
            this._message = Message;
            this._data = Data;
        }
        public ReponseData(string Method, string Code, string Message, string Responder, string ReponseTime, object Data)
        {
            this._method = Method;
            this._code = Code;
            this._message = Message;
            this._responder = Responder;
            this._responsetime = ReponseTime;
            this._data = Data;
        }
        /// <summary>
        /// 消息编码
        /// </summary>
        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }
        /// <summary>
        /// 消息正文
        /// </summary>
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }
        /// <summary>
        /// 响应方法
        /// </summary>
        public string Method
        {
            get { return _method; }
            set { _method = value; }
        }
        /// <summary>
        /// 响应人
        /// </summary>
        public string Responder
        {
            get { return string.IsNullOrEmpty(_responder) ? "QZYL" : _responder; }
            set { _responder = value; }
        }
        /// <summary>
        /// 响应时间
        /// </summary>
        public string ReponseTime
        {
            get { return string.IsNullOrEmpty(_responsetime) ? DateTime.Now.ToLocalTime().ToString() : _responsetime; }
            set { _responsetime = value; }
        }
        /// <summary>
        /// 响应数据
        /// </summary>
        public dynamic Data
        {
            get { return _data; }
            set { _data = value; }
        }
    }
}
