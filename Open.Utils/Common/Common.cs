using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace Open.Utils
{
    /// <summary>
    /// 常用公共类
    /// </summary>
    public class Common
    {
        #region Stopwatch计时器
        /// <summary>
        /// 计时器开始
        /// </summary>
        /// <returns></returns>
        public static Stopwatch TimerStart(Stopwatch watch)
        {
            watch.Reset();
            watch.Start();
            return watch;
        }
        /// <summary>
        /// 计时器结束
        /// </summary>
        /// <param name="watch"></param>
        /// <returns></returns>
        public static string TimerEnd(Stopwatch watch)
        {
            watch.Stop();
            double costtime = watch.ElapsedMilliseconds;
            return costtime.ToString();
        }
        #endregion

        #region 删除数组中的重复项
        /// <summary>
        /// 删除数组中的重复项
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string[] RemoveDup(string[] values)
        {
            List<string> list = new List<string>();
            for (int i = 0; i < values.Length; i++)//遍历数组成员
            {
                if (!list.Contains(values[i]))
                {
                    list.Add(values[i]);
                };
            }
            return list.ToArray();
        }
        #endregion

        #region 生成随机字符串
        ///<summary>
        ///生成随机字符串 
        ///</summary>
        public static string GetRandomString(int length)
        {
            byte[] b = new byte[4];
            new System.Security.Cryptography.RNGCryptoServiceProvider().GetBytes(b);
            Random r = new Random(BitConverter.ToInt32(b, 0));
            string s = null; 
            string str = "0123456789";
            str += "abcdefghijklmnopqrstuvwxyz"; 
            str += "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; 
            for (int i = 0; i < length; i++)
            {
                s += str.Substring(r.Next(0, str.Length - 1), 1);
            }
            return s;
        }
        #endregion

        #region 自动生成编号
        /// <summary>
        /// 表示全局唯一标识符 (GUID)。
        /// </summary>
        /// <returns></returns>
        public static string GuId()
        {
            return Guid.NewGuid().ToString();
        }
        /// <summary>
        /// 自动生成编号  201008251145409865
        /// </summary>
        /// <returns></returns>
        public static string CreateNo()
        {
            Random random = new Random();
            string strRandom = random.Next(1000, 10000).ToString(); //生成编号 
            string code = DateTime.Now.ToString("yyyyMMddHHmmss") + strRandom;//形如
            return code;
        }
        #endregion

        #region 生成0-9随机数
        /// <summary>
        /// 生成0-9随机数
        /// </summary>
        /// <param name="codeNum">生成长度</param>
        /// <returns></returns>
        public static string RndNum(int codeNum)
        {
            StringBuilder sb = new StringBuilder(codeNum);
            Random rand = new Random();
            for (int i = 1; i < codeNum + 1; i++)
            {
                int t = rand.Next(9);
                sb.AppendFormat("{0}", t);
            }
            return sb.ToString();

        }
        #endregion

        #region 删除最后一个字符之后的字符
        /// <summary>
        /// 删除最后结尾的一个逗号
        /// </summary>
        public static string DelLastComma(string str)
        {
            return str.Substring(0, str.LastIndexOf(","));
        }
        /// <summary>
        /// 删除最后结尾的指定字符后的字符
        /// </summary>
        public static string DelLastChar(string str, string strchar)
        {
            return str.Substring(0, str.LastIndexOf(strchar));
        }
        /// <summary>
        /// 删除最后结尾的长度
        /// </summary>
        /// <param name="str"></param>
        /// <param name="Length"></param>
        /// <returns></returns>
        public static string DelLastLength(string str, int Length)
        {
            if (string.IsNullOrEmpty(str))
                return "";
            str = str.Substring(0, str.Length - Length);
            return str;
        }
        #endregion

        /// <summary>
        /// 验证是否合法的手机号码
        /// </summary>
        public static bool IsMobile(string mobile)
        {
            return Regex.IsMatch(mobile, @"^(13|14|15|16|18|19|17)\d{9}$");
        }
        /// <summary>
        /// 验证是否合法的电话号码或手机号码 
        /// </summary>
        public static bool IsPhoneNo(string phoneNo)
        {
            return Regex.IsMatch(phoneNo, "^(0\\d{2,3}-?\\d{7,8}(-\\d{3,5}){0,1})|(((13[0-9])|(15([0-3]|[5-9]))|(18[0-9])|(17[0-9])|(14[0-9]))\\d{8})$");
        }


        /// <summary>
        /// 验证是否合法的身份证号码
        /// </summary>
        public static bool CheckIDCard(string id)
        {
            if (id.Length == 18)
            {
                bool check = CheckIDCard18(id);
                return check;
            }

            if (id.Length == 15)
            {
                bool check = CheckIDCard15(id);
                return check;
            }

            return false;
        }
        /// <summary>
        /// 18位身份证验证
        /// </summary>
        private static bool CheckIDCard18(string id)
        {
            long n = 0;
            if (long.TryParse(id.Remove(17), out n) == false || n < Math.Pow(10, 16) || long.TryParse(id.Replace('x', '0').Replace('X', '0'), out n) == false)
            {
                return false;//数字验证
            }
            string address = "11x22x35x44x53x12x23x36x45x54x13x31x37x46x61x14x32x41x50x62x15x33x42x51x63x21x34x43x52x64x65x71x81x82x91";
            if (address.IndexOf(id.Remove(2)) == -1)
            {
                return false;//省份验证
            }
            string birth = id.Substring(6, 8).Insert(6, "-").Insert(4, "-");
            DateTime time = new DateTime();
            if (DateTime.TryParse(birth, out time) == false)
            {
                return false;//生日验证
            }
            string[] arrVarifyCode = ("1,0,x,9,8,7,6,5,4,3,2").Split(',');
            string[] Wi = ("7,9,10,5,8,4,2,1,6,3,7,9,10,5,8,4,2").Split(',');
            char[] Ai = id.Remove(17).ToCharArray();
            int sum = 0;
            for (int i = 0; i < 17; i++)
            {
                sum += int.Parse(Wi[i]) * int.Parse(Ai[i].ToString());
            }
            int y = -1;
            Math.DivRem(sum, 11, out y);
            if (arrVarifyCode[y] != id.Substring(17, 1).ToLower())
            {
                return false;//校验码验证
            }
            return true;//符合GB11643-1999标准
        }
        /// <summary>
        /// 15位身份证验证
        /// </summary>
        private static bool CheckIDCard15(string id)
        {
            long n = 0;
            if (long.TryParse(id, out n) == false || n < Math.Pow(10, 14))
            {
                return false;//数字验证
            }
            string address = "11x22x35x44x53x12x23x36x45x54x13x31x37x46x61x14x32x41x50x62x15x33x42x51x63x21x34x43x52x64x65x71x81x82x91";
            if (address.IndexOf(id.Remove(2)) == -1)
            {
                return false;//省份验证
            }
            string birth = id.Substring(6, 6).Insert(4, "-").Insert(2, "-");
            DateTime time = new DateTime();
            if (DateTime.TryParse(birth, out time) == false)
            {
                return false;//生日验证
            }
            return true;//符合15位身份证标准
        }
        /// <summary>
        /// 获取类型
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        public static Type GetType<T>()
        {
            return GetType(typeof(T));
        }

        /// <summary>
        /// 获取类型
        /// </summary>
        /// <param name="type">类型</param>
        public static Type GetType(Type type)
        {
            return Nullable.GetUnderlyingType(type) ?? type;
        }

        /// <summary>
        /// 换行符
        /// </summary>
        public static string Line => Environment.NewLine;

        /// <summary>
        /// 获取物理路径
        /// </summary>
        /// <param name="relativePath">相对路径</param>
        public static string GetPhysicalPath(string relativePath)
        {
            if (string.IsNullOrWhiteSpace(relativePath))
            {
                return string.Empty;
            }
            var rootPath = Open.Utils.Helper.Web.RootPath;
            if (string.IsNullOrWhiteSpace(rootPath))
            {
                return Path.GetFullPath(relativePath);
            }
            return $"{ Open.Utils.Helper.Web.RootPath}\\{relativePath.Replace("/", "\\").TrimStart('\\')}";
        }

        /// <summary>
        /// 获取wwwroot路径
        /// </summary>
        /// <param name="relativePath">相对路径</param>
        public static string GetWebRootPath(string relativePath)
        {
            if (string.IsNullOrWhiteSpace(relativePath))
            {
                return string.Empty;
            }
            var rootPath = Open.Utils.Helper.Web.WebRootPath;
            if (string.IsNullOrWhiteSpace(rootPath))
            {
                return Path.GetFullPath(relativePath);
            }
            return $"{ Open.Utils.Helper.Web.WebRootPath}\\{relativePath.Replace("/", "\\").TrimStart('\\')}";
        }


        public static DataTable ToDataTable<T>(IEnumerable<T> collection)
        {
            var props = typeof(T).GetProperties();
            var dt = new DataTable();
            dt.Columns.AddRange(props.Select(p => new DataColumn(p.Name, p.PropertyType)).ToArray());
            if (collection.Count() > 0)
            {
                for (int i = 0; i < collection.Count(); i++)
                {
                    ArrayList tempList = new ArrayList();
                    foreach (PropertyInfo pi in props)
                    {
                        object obj = pi.GetValue(collection.ElementAt(i), null);
                        tempList.Add(obj);
                    }
                    object[] array = tempList.ToArray();
                    dt.LoadDataRow(array, true);
                }
            }
            return dt;
        }

        //判断字符是否浮点型
        public static bool IsNumeric(string s)
        {
            bool bReturn = true;
            double result;
            try
            {
                result = double.Parse(s);
            }
            catch
            {
                result = 0;
                bReturn = false;
            }
            return bReturn;
        }


        //判断字符是否整形
        public static bool IsInt(string s)
        {
            bool bReturn = true;
            double result;
            try
            {
                result = int.Parse(s);
            }
            catch
            {
                result = 0;
                bReturn = false;
            }
            return bReturn;
        }
        //判断是否日期格式
        public static bool IsDate(string strDate)
        {
            try
            {
                DateTime.Parse(strDate);  //不是字符串时会出现异常
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// 半角转全角
        /// --->中文不分全角半角，全角与半角是针对字符的。全角空格为12288，半角空格为32；其他字符半角(33-126)与全角(65281-65374)的对应关系是：均相差65248
        /// </summary>
        public static string ToSBC(string input)
        {
            char[] c = input.ToCharArray();
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == 32)
                {
                    c[i] = (char)12288;
                    continue;
                }
                if (c[i] < 127)
                    c[i] = (char)(c[i] + 65248);
            }
            return new string(c);
        }
        /// <summary>
        /// 全角转半角
        /// --->中文不分全角半角，全角与半角是针对字符的。全角空格为12288，半角空格为32；其他字符半角(33-126)与全角(65281-65374)的对应关系是：均相差65248
        /// </summary>
        public static string ToDBC(string input)
        {
            char[] c = input.ToCharArray();
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == 12288)
                {
                    c[i] = (char)32;
                    continue;
                }
                if (c[i] > 65280 && c[i] < 65375)
                    c[i] = (char)(c[i] - 65248);
            }
            return new string(c);
        }

        /// <summary>
        /// Unix时间戳格式转为DateTime时间格式
        /// </summary>
        /// <param name="timeStamp"></param>
        /// <returns></returns>
        [Obsolete]
        public static DateTime StampToDateTime(string timeStamp)
        {
            DateTime dtStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            long lTime;
            if (timeStamp.Length.Equals(10))//判断是10位
                lTime = long.Parse(timeStamp + "0000000");
            else
                lTime = long.Parse(timeStamp + "0000");//13位
            TimeSpan toNow = new TimeSpan(lTime);
            return dtStart.Add(toNow);
        }

        /// <summary>  
        ///  DateTime时间格式转换为Unix时间戳格式 13位
        /// </summary>  
        /// <param name="time">时间</param>  
        /// <returns>long</returns>  
        [Obsolete]
        public static long ConvertDateTimeToInt(DateTime time)
        {
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1, 0, 0, 0, 0));
            long t = (time.Ticks - startTime.Ticks) / 10000;   //除10000调整为13位      
            return t;
        }
    }
}
