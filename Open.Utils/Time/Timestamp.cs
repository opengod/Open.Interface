using System;


namespace Open.Utils
{
    /// <summary>
    /// 时间戳-时间格式转换
    /// </summary>
    public static class DateTimeExtension
    {
        /// <summary>
        /// 获取时间戳 13位毫秒级
        /// </summary>
        /// <param name="dt">时间</param>
        /// <returns></returns>
        public static long ToTimestamp(DateTime time)
        {
            DateTime start = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            long t = (time.Ticks - start.ToLocalTime().Ticks) / 10000;   //除10000调整为13位      
            return t;
        }

        /// <summary>
        /// 时间戳转换成时间,失败返回NULL则说明转换失败(如时间戳无效)13位毫秒级
        /// </summary>
        /// <param name="timestamp">时间戳</param>
        /// <returns></returns>
        public static DateTime? ToDateTime(long time)
        {
            try
            {
                DateTime start = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                DateTime date = start.AddMilliseconds(time).ToLocalTime();
                return date;
            }
            catch
            {
                return null;
            }
        }
    }
}
