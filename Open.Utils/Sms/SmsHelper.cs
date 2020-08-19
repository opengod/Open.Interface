﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace Open.Utils.Sms
{
    /// <summary>
    /// 阿里短信发送
    /// </summary>
    public class SmsHelper
    {
        //private const string endurl = "dysmsapi.aliyuncs.com";
        //private const string AccessKeyId = "LTAIfxKLt3qBUtLl";
        //private const string AccessKeySecret = "L1AKiSvdR6KSp2gTn2e4Y2QXpIdNf7";
        //private const string SignName = "开元盛达";

        /// <summary>
        /// 短信验证码
        /// </summary>
        /// <param name="mobile"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        public static string SendSms(string mobile,string templateCode,string TemplateParam, SmsSettingModel SettingModel)
        {
            string nowDate = DateTime.Now.ToUniversalTime().ToString("yyyy-MM-dd'T'HH:mm:ss'Z'");//GTM时间
            Dictionary<string, string> keyValues = new Dictionary<string, string>();//声明一个字典
            //1.系统参数
            keyValues.Add("SignatureMethod", "HMAC-SHA1");
            keyValues.Add("SignatureNonce", Guid.NewGuid().ToString());
            keyValues.Add("AccessKeyId", SettingModel.AccessKeyId);
            keyValues.Add("SignatureVersion", "1.0");
            keyValues.Add("Timestamp", nowDate);
            keyValues.Add("Format", "Json");//可换成xml

            //2.业务api参数
            keyValues.Add("Action", "SendSms");
            keyValues.Add("Version", "2017-05-25");
            keyValues.Add("RegionId", "cn-hangzhou");
            keyValues.Add("PhoneNumbers", mobile);
            keyValues.Add("SignName", SettingModel.SignName);
            // keyValues.Add("TemplateParam", "{\"code\":\"" + code + "\"}");
            keyValues.Add("TemplateParam", TemplateParam);
            keyValues.Add("TemplateCode", templateCode);
            keyValues.Add("OutId", "123");

            //3.去除签名关键字key
            if (keyValues.ContainsKey("Signature"))
            {
                keyValues.Remove("Signature");
            }

            //4.参数key排序
            Dictionary<string, string> ascDic = keyValues.OrderBy(o => o.Key).ToDictionary(o => o.Key, p => p.Value.ToString());
            //5.构造待签名的字符串
            StringBuilder builder = new StringBuilder();
            foreach (var item in ascDic)
            {
                if (item.Key == "SignName")
                {
                }
                else
                {
                    builder.Append("&").Append(specialUrlEncode(item.Key)).Append("=").Append(specialUrlEncode(item.Value));
                }
                if (item.Key == "RegionId")
                {
                    builder.Append("&").Append(specialUrlEncode("SignName")).Append("=").Append(specialUrlEncode(keyValues["SignName"]));
                }
            }
            string sorteQueryString = builder.ToString().Substring(1);

            StringBuilder stringToSign = new StringBuilder();
            stringToSign.Append("GET").Append("&");
            stringToSign.Append(specialUrlEncode("/")).Append("&");
            stringToSign.Append(specialUrlEncode(sorteQueryString));

            string Sign = MySign(SettingModel.AccessKeySecret + "&", stringToSign.ToString());
            //6.签名最后也要做特殊URL编码
            string signture = specialUrlEncode(Sign);

            //最终打印出合法GET请求的URL
            string url = string.Format("http://{0}/?Signature={1}{2}", SettingModel.endurl, signture, builder);
            string result = GetHtmlFormUrl(url);
            return result;
        }


        /// <summary>
        /// 短信接口C#调用方法
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        private static string GetHtmlFormUrl(string url)
        {
            string strRet = null;
            if (url == null || url.Trim().ToString() == "")
            {
                return strRet;
            }
            string targeturl = url.Trim().ToString();
            try
            {
                HttpWebRequest hr = (HttpWebRequest)WebRequest.Create(targeturl);
                hr.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1)";
                hr.Method = "GET";
                hr.Timeout = 30 * 60 * 1000;
                WebResponse hs = hr.GetResponse();
                Stream sr = hs.GetResponseStream();
                StreamReader ser = new StreamReader(sr, Encoding.UTF8);

                strRet = MessageHandle(ser.ReadToEnd());
            }
            catch (Exception ex)
            {
                strRet = "短信发送失败！" + ex.Message;
            }
            return strRet;
        }

        /// <summary>
        /// 验证手机号码是否合法
        /// </summary>
        /// <param name="mobile">电话号码</param>
        /// <returns></returns>
        public static bool IsMobile(string mobile)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(mobile, @"^1[3|4|5|7|8][0-9]\d{8}$");
        }

        /// <summary>
        /// URL编码
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private static string specialUrlEncode(string temp)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < temp.Length; i++)
            {
                string t = temp[i].ToString();
                string k = HttpUtility.UrlEncode(t, Encoding.UTF8);
                if (t == k)
                {
                    stringBuilder.Append(t);
                }
                else
                {
                    stringBuilder.Append(k.ToUpper());
                }
            }
            return stringBuilder.ToString().Replace("+", "%20").Replace("*", "%2A").Replace("%7E", "~");
        }

        /// <summary>
        /// HMACSHA1签名
        /// </summary>
        /// <param name="accessSecret"></param>
        /// <param name="stringToSign"></param>
        /// <returns></returns>
        private static string MySign(string accessSecret, string stringToSign)
        {
            try
            {
                var hmacsha1 = new HMACSHA1(Encoding.UTF8.GetBytes(accessSecret));
                var dataBuffer = Encoding.UTF8.GetBytes(stringToSign);
                var hashBytes = hmacsha1.ComputeHash(dataBuffer);
                string stringbyte = BitConverter.ToString(hashBytes, 0).Replace("-", string.Empty).ToLower();
                byte[] bytes = strToToHexByte(stringbyte);
                return Convert.ToBase64String(bytes);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        /// <summary>
        /// 字符串转16进制字节数组
        /// </summary>
        /// <param name="hexString"></param>
        /// <returns></returns>
        private static byte[] strToToHexByte(string hexString)
        {
            hexString = hexString.Replace(" ", "");
            if ((hexString.Length % 2) != 0)
                hexString += " ";
            byte[] returnBytes = new byte[hexString.Length / 2];
            for (int i = 0; i < returnBytes.Length; i++)
                returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
            return returnBytes;
        }

        /// <summary>
        /// 消息处理机制
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private static string MessageHandle(string str)
        {
            MessageModel message = JsonConvert.DeserializeObject<MessageModel>(str);
            string result = "";
            switch (message.Code)
            {
                case "OK":
                    result = "短信发送成功！";
                    break;
                case "isp.RAM_PERMISSION_DENY":
                    result = "RAM权限DENY";
                    break;
                case "isv.OUT_OF_SERVICE":
                    result = "业务停机";
                    break;
                case "isv.PRODUCT_UN_SUBSCRIPT":
                    result = "未开通云通信产品的阿里云客户";
                    break;
                case "isv.PRODUCT_UNSUBSCRIBE":
                    result = "产品未开通";
                    break;
                case "isv.ACCOUNT_NOT_EXISTS":
                    result = "账户不存在";
                    break;
                case "isv.ACCOUNT_ABNORMAL":
                    result = "账户异常    ";
                    break;
                case "isv.SMS_TEMPLATE_ILLEGAL":
                    result = "短信模板不合法";
                    break;
                case "isv.SMS_SIGNATURE_ILLEGAL":
                    result = "短信签名不合法";
                    break;
                case "isv.INVALID_PARAMETERS":
                    result = "参数异常";
                    break;
                case "isv.MOBILE_NUMBER_ILLEGAL":
                    result = "非法手机号";
                    break;
                case "isv.MOBILE_COUNT_OVER_LIMIT":
                    result = "手机号码数量超过限制";
                    break;
                case "isv.TEMPLATE_MISSING_PARAMETERS":
                    result = "模板缺少变量";
                    break;
                case "isv.BUSINESS_LIMIT_CONTROL":
                    result = "业务限流";
                    break;
                case "isv.INVALID_JSON_PARAM":
                    result = "JSON参数不合法，只接受字符串值";
                    break;
                case "isv.PARAM_LENGTH_LIMIT":
                    result = "参数超出长度限制";
                    break;
                case "isv.PARAM_NOT_SUPPORT_URL":
                    result = "不支持URL";
                    break;
                case "isv.AMOUNT_NOT_ENOUGH":
                    result = "账户余额不足";
                    break;
                case "isv.TEMPLATE_PARAMS_ILLEGAL":
                    result = "模板变量里包含非法关键字";
                    break;
            }
            return result;
        }

    }

    internal class MessageModel
    {
        public string RequestId { get; set; }
        public string Code { get; set; }
        public string Message { get; set; }
    }
}
