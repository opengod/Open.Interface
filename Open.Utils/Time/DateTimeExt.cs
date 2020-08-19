using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Open.Utils
{
    /// <summary>
    /// 时间扩展操作类
    /// </summary>
    public static class DateTimeExt
    {
        /// <summary>
        /// 当前时间是否周末
        /// </summary>
        /// <param name="dateTime">时间点</param>
        /// <returns></returns>
        public static bool IsWeekend(this DateTime dateTime)
        {
            DayOfWeek[] weeks = { DayOfWeek.Saturday, DayOfWeek.Sunday };
            return weeks.Contains(dateTime.DayOfWeek);
        }

        /// <summary>
        /// 当前时间是否工作日
        /// </summary>
        /// <param name="dateTime">时间点</param>
        /// <returns></returns>
        public static bool IsWeekday(this DateTime dateTime)
        {
            DayOfWeek[] weeks = { DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday, DayOfWeek.Thursday, DayOfWeek.Friday };
            return weeks.Contains(dateTime.DayOfWeek);
        }

        /// <summary>
        /// 获取时间相对唯一字符串
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="milsec">是否使用毫秒</param>
        /// <returns></returns>
        public static string ToUniqueString(this DateTime dateTime, bool milsec = false)
        {
            int sedonds = dateTime.Hour * 3600 + dateTime.Minute * 60 + dateTime.Second;
            string value = string.Format("{0}{1}{2}", dateTime.ToString("yy"), dateTime.DayOfYear, sedonds);
            return milsec ? value + dateTime.ToString("fff") : value;
        }

        /// <summary>
        /// 将时间转换为JS时间格式(Date.getTime())
        /// </summary>
        public static string ToJsGetTime(this DateTime dateTime)
        {
            DateTime utc = dateTime.ToUniversalTime();
            return ((long)utc.Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds).ToString();
        }

        /// <summary>  
        /// 根据时间范围获取每年每月每周的分组  
        /// </summary>  
        /// <param name="strStartDate">起始时间</param>  
        /// <param name="strEndDate">结束时间</param>  
        /// <returns>返回每周起始结束键值对</returns>  
        public static Dictionary<DateTime, DateTime> GetGroupWeekByDateRange(DateTime dtStartDate, DateTime dtEndDate)
        {
            var dict = new Dictionary<DateTime, DateTime>();
            // 同年  
            if (dtStartDate.Year == dtEndDate.Year)
            {
                GetGroupWeekByYear(dict, dtStartDate, dtEndDate);
            }
            // 不同年      
            else
            {
                int MonthDay = DateTime.DaysInMonth(dtStartDate.Year, dtStartDate.Month);

                int delayDay = dtStartDate.Day;

                GetAmountDateList(3, 1, dtStartDate, dtEndDate, 2, 1, delayDay, 2);

                //CW_F_CalDateTable_CLR(3, 1, dtStartDate, dtEndDate, 2, 0, 0, 2);

                int WhileCount = dtEndDate.Year - dtStartDate.Year;
                // 某年一共有多少天  
                int YearDay = DateTime.IsLeapYear(dtStartDate.Year) ? 366 : 365;
                DateTime dtTempStartDate = dtStartDate;
                DateTime dtTempEndDate = dtTempStartDate.AddDays(YearDay - dtTempStartDate.DayOfYear);
                // 根据时间范围获取每月每周的分组  
                GetGroupWeekByYear(dict, dtTempStartDate, dtTempEndDate);
                for (int i = 1; i <= WhileCount; i++)
                {
                    var last = dict[dict.Keys.Last<DateTime>()];
                    // 某年某月一共有多少天  
                    YearDay = DateTime.IsLeapYear(dtTempStartDate.Year + 1) ? 366 : 365;
                    dtTempStartDate = last.AddDays(1);
                    dtTempEndDate = dtTempStartDate.AddDays(YearDay - dtTempStartDate.DayOfYear);
                    // 根据时间范围获取每月每周的分组  
                    GetGroupWeekByYear(dict, dtTempStartDate, dtTempEndDate);
                }
            }
            return dict;
        }

        /// <summary>
        /// 根据时间范围(年)获取每月分组  
        /// </summary>
        /// <param name="dict"></param>
        /// <param name="dtStartDate"></param>
        /// <param name="dtEndDate"></param>
        public static void GetGroupWeekByYear(Dictionary<DateTime, DateTime> dict, DateTime dtStartDate, DateTime dtEndDate)
        {
            // 不同月  
            if ((dtEndDate.Month - dtStartDate.Month) >= 1)
            {
                int WhileCount = dtEndDate.Month - dtStartDate.Month;
                int MonthDay = DateTime.DaysInMonth(dtStartDate.Year, dtStartDate.Month);
                DateTime dtTempStartDate = dtStartDate;
                DateTime dtTempEndDate = dtTempStartDate.AddDays(MonthDay - 1);
                dict.Add(dtTempStartDate, dtTempEndDate);
                for (int i = 1; i <= WhileCount; i++)
                {
                    // 某年某月一共有多少天  
                    MonthDay = DateTime.DaysInMonth(dtTempStartDate.Year, dtTempStartDate.Month + 1);
                    dtTempStartDate = dtTempEndDate.AddDays(1);
                    dtTempEndDate = dtTempStartDate.AddDays(MonthDay - 1);
                    dict.Add(dtTempStartDate, dtTempEndDate);
                }
            }
            // 同月  
            else
            {
                dict.Add(dtStartDate, dtEndDate);
            }
        }

        // 如果有应收日，那就以合同的应收日为准，否刚就为应收日期就为自然月最后一天
        /// <summary>
        /// 计算应收日期及所属期
        /// CybleBeginDate:周期实际的起始日
        /// CybleEndDate:周期实际的结束日。
        /// CW_F_CalDateTable_CLR(3,1,'2013-01-15','2014-05-14',2,0,0,2)
        /// </summary>
        /// <param name="UnitType">周期单位</param>
        /// <param name="Cycle">周期</param>
        /// <param name="BeginDate">起始日期</param>
        /// <param name="EndDate">截止日期</param>
        /// <param name="ExesType">应收类别,1代表提前,2代表延后,4代表本期,</param>
        /// <param name="ExesMonth">指定月份,0代表本期</param>
        /// <param name="AccDate">指定应收天数,0代表每期最后一天</param>
        /// <returns></returns>
        public static IEnumerable GetAmountDateList(int UnitType, int Cycle, DateTime BeginDate, DateTime EndDate, int ExesType, int ExesMonth, int AccDate, int iEnumPeroiod)
        {
            var Peroid = (enumPeroiod)iEnumPeroiod;
            var AccountDate = DateTime.MinValue;
            var rowList = new List<DateTime[]>();
            var dtBegin = BeginDate;
            var dtEnd = DateTime.MinValue;
            var dtCybleBeginDate = new DateTime(dtBegin.Year, dtBegin.Month, 1);
            var dtCycleEndDate = EndDate;
            switch (UnitType)
            {
                #region 年
                case 1:
                    while (dtBegin <= EndDate)
                    {
                        if (Peroid == enumPeroiod.NotSplit)
                        {
                            dtEnd = EndDate;
                        }
                        else
                        {
                            if (dtEnd == DateTime.MinValue)
                            {
                                // 按自然月，则首期,加上周期减1（有可能是每2年或每3年）
                                dtEnd = new DateTime(dtBegin.Year, 12, 31).AddYears(Cycle - 1);
                            }
                            else
                            {
                                dtEnd = new DateTime(dtEnd.Year, 12, 31).AddYears(Cycle);
                            }
                        }
                        dtCycleEndDate = dtEnd;
                        // 例：2011-12-31，变2012-1-1，再减1年（设Cycle为1）
                        dtCybleBeginDate = dtEnd.AddDays(1).AddYears(-Cycle);
                        if (dtEnd > EndDate)
                            dtEnd = EndDate;
                        AccountDate = CalAccountDate(dtBegin, dtEnd, ExesType, ExesMonth, AccDate);
                        rowList.Add(new DateTime[] { dtBegin, AccountDate, dtCybleBeginDate, dtCycleEndDate, dtEnd });
                        if (Peroid != enumPeroiod.AllPeroid)
                            break;
                        dtBegin = AccountDate.AddDays(1);
                    }
                    break;
                #endregion

                #region 季
                case 2:
                    while (dtBegin <= EndDate)
                    {
                        if (Peroid == enumPeroiod.NotSplit)
                        {
                            dtEnd = EndDate;
                        }
                        else
                        {
                            if (dtEnd == DateTime.MinValue)
                                dtEnd = new DateTime(dtBegin.Year, dtBegin.Month, 1).AddMonths((Cycle - 1) * 3);
                            else
                                dtEnd = new DateTime(dtEnd.Year, dtEnd.Month, 1).AddMonths(Cycle * 3);

                            switch (dtEnd.Month)
                            {
                                case 1:
                                case 2:
                                case 3:
                                    dtEnd = new DateTime(dtEnd.Year, 3, 31);
                                    break;
                                case 4:
                                case 5:
                                case 6:
                                    dtEnd = new DateTime(dtEnd.Year, 6, 30);
                                    break;
                                case 7:
                                case 8:
                                case 9:
                                    dtEnd = new DateTime(dtEnd.Year, 9, 30);
                                    break;
                                case 10:
                                case 11:
                                case 12:
                                    dtEnd = new DateTime(dtEnd.Year, 12, 31);
                                    break;
                            }
                        }
                        dtCycleEndDate = dtEnd;
                        dtCybleBeginDate = dtEnd.AddDays(1).AddMonths(-(Cycle * 3));//倒退到起始日。例：结束日期是2011-3-31，则先变为2011-4-1,再减一季（3个月），则变为2011-1-1
                        if (dtEnd > EndDate)
                            dtEnd = EndDate;
                        AccountDate = CalAccountDate(dtBegin, dtEnd, ExesType, ExesMonth, AccDate);
                        rowList.Add(new DateTime[] { dtBegin, AccountDate, dtCybleBeginDate, dtCycleEndDate, dtEnd });
                        if (Peroid != enumPeroiod.AllPeroid) break;
                        dtBegin = AccountDate.AddDays(1);
                    }
                    break;
                #endregion

                #region 月
                case 3:
                    while (dtBegin <= EndDate)
                    {
                        if (Peroid == enumPeroiod.NotSplit)
                        {
                            dtEnd = EndDate;
                        }
                        else
                        {
                            if (dtEnd == DateTime.MinValue)
                            {
                                dtEnd = new DateTime(dtBegin.Year, dtBegin.Month, 1).AddMonths(Cycle).AddDays(-1);
                            }
                            else
                            {
                                // 每次都是上一周期所在月的最后一天，所以取当月，加上周期Cycle加1，得到后月（设Cycle=1)第1天，再减1
                                dtEnd = new DateTime(dtEnd.Year, dtEnd.Month, 1).AddMonths(Cycle + 1).AddDays(-1);
                            }
                        }
                        dtCycleEndDate = dtEnd;
                        dtCybleBeginDate = new DateTime(dtCycleEndDate.Year, dtCycleEndDate.Month, 1);
                        if (dtEnd > EndDate)
                            dtEnd = EndDate;
                        AccountDate = CalAccountDate(dtBegin, dtEnd, ExesType, ExesMonth, AccDate);

                        rowList.Add(new DateTime[] { dtBegin, AccountDate, dtCybleBeginDate, dtCycleEndDate, dtEnd });
                        if (Peroid != enumPeroiod.AllPeroid) break;
                        dtBegin = AccountDate.AddDays(1);
                    }
                    break;
                #endregion

                #region 周
                case 4:
                    while (dtBegin <= EndDate)
                    {
                        if (Peroid == enumPeroiod.NotSplit)
                        {
                            dtEnd = EndDate;
                        }
                        else
                        {
                            dtEnd = dtBegin.AddDays(Cycle * 7);
                        }
                        dtCycleEndDate = dtEnd.AddDays(-1);
                        dtCybleBeginDate = dtCycleEndDate.AddDays(-7 * Cycle);
                        if (dtEnd > EndDate)
                            dtEnd = EndDate;
                        else
                            dtEnd = dtEnd.AddDays(-1);
                        AccountDate = CalAccountDate(dtBegin, dtEnd, ExesType, ExesMonth, AccDate);
                        rowList.Add(new DateTime[] { dtBegin, AccountDate, dtCybleBeginDate, dtCycleEndDate, dtEnd });
                        if (Peroid != enumPeroiod.AllPeroid) break;
                        dtBegin = dtEnd.AddDays(1);
                    }
                    break;
                #endregion

                #region 日
                case 5:
                    while (dtBegin <= EndDate)
                    {
                        dtEnd = dtBegin.AddDays(Cycle);
                        if (dtEnd > EndDate)
                            dtEnd = EndDate;
                        else
                            dtEnd = dtEnd.AddDays(-1);
                        dtCycleEndDate = dtBegin;
                        dtCybleBeginDate = dtBegin;

                        AccountDate = CalAccountDate(dtBegin, dtEnd, ExesType, ExesMonth, AccDate);
                        rowList.Add(new DateTime[] { dtBegin, dtEnd, AccountDate, dtCybleBeginDate, dtCycleEndDate });
                        if (Peroid != enumPeroiod.AllPeroid) break;
                        // 
                        dtBegin = AccountDate.AddDays(1);
                    }
                    break;
                #endregion

                #region 其他
                case 6:
                    {
                        dtEnd = EndDate;
                        dtCycleEndDate = dtEnd;
                        dtCybleBeginDate = dtBegin;
                        AccountDate = CalAccountDate(dtBegin, dtEnd, ExesType, ExesMonth, AccDate);
                        rowList.Add(new DateTime[] { BeginDate, EndDate, AccountDate, dtCybleBeginDate, dtCycleEndDate });
                        if (Peroid != enumPeroiod.AllPeroid) break;
                    }
                    break;
                    #endregion
            }
            return rowList as IEnumerable;
        }

        private static DateTime CalAccountDate(DateTime dtBegin, DateTime dtEnd, int DelayType, int DelayMonth, int DelayDay)
        {
            var dtAccount = dtEnd;
            switch (DelayType)
            {
                // 提前N个月
                case 1:                 
                    dtAccount = new DateTime(dtBegin.Year, dtBegin.Month, 1);
                    dtAccount = dtAccount.AddMonths(-DelayMonth);
                    break;
                // 延后
                case 2:
                    dtAccount = new DateTime(dtEnd.Year, dtEnd.Month, 1);
                    dtAccount = dtAccount.AddMonths(DelayMonth);
                    break;
                // 指定月份       
                case 3:                                 
                    if (DelayMonth < 1 || DelayMonth > 12)
                        dtAccount = new DateTime(dtEnd.Year, dtEnd.Month, 1);
                    else
                        dtAccount = new DateTime(dtEnd.Year, DelayMonth, 1);
                    break;
                // 本期
                case 4:
                default:
                    dtAccount = new DateTime(dtEnd.Year, dtEnd.Month, 1);
                    break;
            }
            DateTime dtMonthLast = new DateTime(dtAccount.Year, dtAccount.Month, 1).AddMonths(1).AddDays(-1);
            // 应收所在月份的天数。
            int MonthDays = dtMonthLast.Day;
            if (DelayDay <= 0 || DelayDay > MonthDays)
            {
                dtAccount = dtMonthLast;
            }
            else
            {
                dtAccount = new DateTime(dtAccount.Year, dtAccount.Month, DelayDay - 1);
            }
            return dtAccount;
        }
    }


    public enum enumPeroiod
    {
        NotSplit = 0, //不分隔，起始与截止整个是一周期。
        First = 1, //只取第一期            
        AllPeroid = 2 //取所有周期
    }
}
