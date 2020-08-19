using NLog;
using System;

namespace Open.Utils
{
    public class LogHelper : ILogHelper
    {
        public static Logger logger = LogManager.GetCurrentClassLogger();

        public void Debug(object source, string message)
        {
            throw new NotImplementedException();
        }

        public void Debug(object source, string message, params object[] ps)
        {
            throw new NotImplementedException();
        }

        public void Debug(Type source, string message)
        {
            throw new NotImplementedException();
        }

        public void Debug(object source, object message, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void Debug(Type source, object message, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void Error(string Method, string message)
        {
            var errorMsg = string.Format("【Method】：{0} \r\n【详细信息】：{1} ",
                            new object[] { Method, message });
            logger.Error(errorMsg);
        }

        public void Error(object source, Exception ex)
        {
            //return string.Format("【自定义错误】：{0} \r\n【异常类型】：{1} \r\n【异常信息】：{2} \r\n【堆栈调用】：{3}", new object[] { throwMsg,
            //    ex.GetType().Name, ex.Message, ex.StackTrace });
            var errorMsg = string.Format("【异常信息】：{0} \r\n【异常类型】：{1} \r\n【堆栈调用】：{2}", ex.GetType().Name, ex.Message, ex.StackTrace);
            logger.Error(errorMsg);
        }

        public void Error(Type source, object message)
        {
            throw new NotImplementedException();
        }

        public void Error(object source, object message, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void Error(Type source, object message, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void Fatal(object source, object message)
        {
            throw new NotImplementedException();
        }

        public void Fatal(Type source, object message)
        {
            throw new NotImplementedException();
        }

        public void Fatal(object source, object message, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void Fatal(Type source, object message, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void Info(object source, object message)
        {
            string errorMsg = string.Format("【操作信息】：{0} \r\n", new object[] { source });
            logger.Info(errorMsg);
        }

        public void Info(Type source, object message)
        {
            throw new NotImplementedException();
        }

        public void Info(object source, object message, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void Info(Type source, object message, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void Warn(object source, object message)
        {
            throw new NotImplementedException();
        }

        public void Warn(Type source, object message)
        {
            throw new NotImplementedException();
        }

        public void Warn(object source, object message, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void Warn(Type source, object message, Exception exception)
        {
            throw new NotImplementedException();
        }
    }
}
