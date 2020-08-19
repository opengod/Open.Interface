using System;

namespace Open.Utils
{
    public class DateTimeDiff
    {
        /// <summary>
        /// 计算日期间隔
        /// </summary>
        /// <param name="startDate">开始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <param name="drf">决定返回值形式的枚举</param>
        /// <returns>年月日的int数组，具体数组长度与枚举参数drf有关</returns>
        public static int[] DiffTimes(DateTime startDate, DateTime endDate, DiffResultFormat drf)
        {
            try
            {
                #region 数据初始化
                DateTime max;
                DateTime min;
                if (startDate > endDate)
                {
                    max = startDate;
                    min = endDate;
                }
                else
                {
                    max = endDate;
                    min = startDate;
                }
                int tempYear = max.Year;
                int tempMonth = max.Month;
                if (max.Month < min.Month)
                {
                    tempYear--;
                    tempMonth = tempMonth + 12;
                }
                int year = tempYear - min.Year;
                int month = (year == 0 && tempMonth - min.Month == 0) ? 1 : tempMonth - min.Month;
                #endregion

                #region 按条件计算
                switch (drf)
                {
                    case DiffResultFormat.yy:
                        return new int[] { year, 0, 0, 0, 0 };
                    case DiffResultFormat.hh:
                        return new int[] { year, year * 2 + month, 0, 0, 0 };
                    case DiffResultFormat.qq:
                        return new int[] { year, year * 2 + month, year * 4 + month, 0, 0 };
                    case DiffResultFormat.mm:
                        return new int[] { year, year * 2 + month, year * 4 + month, year * 12 + month, 0 };
                    case DiffResultFormat.dd:
                        TimeSpan ts = max - min;
                        return new int[] { 0, 0, 0, 0, ts.Days };
                    default:
                        throw new Exception("字符串参数不正确!");
                }
                #endregion
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 两个日期间隔的天数
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        public static int DiffTimesDay(DateTime startDate, DateTime endDate)
        {
            TimeSpan sp = endDate.Subtract(startDate);
            int days = sp.Days;
            return days;
        }
    }

    /// 关于返回值形式的枚举
    /// </summary>
    public enum DiffResultFormat
    {
        /// <summary>
        /// 年数
        /// </summary>
        yy,

        /// <summary>
        /// 半年
        /// </summary>
        hh,

        /// <summary>
        /// 季度
        /// </summary>
        qq,

        /// <summary>
        /// 月数
        /// </summary>
        mm,

        /// <summary>
        /// 天数
        /// </summary>
        dd,
    }
}
