using System;

namespace Open.Utils
{
    public class JsonMsgResult
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        public bool Success { get; set; } = true;
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
        public string Responder { get; set; } = "QZYL";
        /// <summary>
        /// 响应时间
        /// </summary>
        public string ReponseTime { get; set; } = DateTime.Now.ToLocalTime().ToString();
        /// <summary>
        /// 响应数据
        /// </summary>
        public object Data { get; set; }
        public JsonMsgResult()
        {
            this.Success = false;
            this.Method = "";
            this.Code = "";
            this.Message = "";
            this.Data = null;
        }
        public JsonMsgResult(string Code, string Message, object Data, bool Success = false)
        {
            this.Success = Success;
            this.Code = Code;
            this.Message = Message;
            this.Data = Data;
        }
        public JsonMsgResult(string Method, string Code, string Message, object Data)
        {
            this.Method = Method;
            this.Code = Code;
            this.Message = Message;
            this.Data = Data;
        }
        public JsonMsgResult(string Method, string Code, string Message, string Responder, string ReponseTime, object Data)
        {
            this.Method = Method;
            this.Code = Code;
            this.Message = Message;
            this.Responder = Responder;
            this.ReponseTime = ReponseTime;
            this.Data = Data;
        }
    }
}
