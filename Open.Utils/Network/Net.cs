﻿using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;

namespace Open.Utils
{
    /// <summary>
    /// 网络操作
    /// </summary>
    public class Net
    {
        #region Ip(获取Ip)
        /// <summary>
        /// 获取Ip
        /// </summary>
        //public static string Ip
        //{
        //    get
        //    {
        //        var result = string.Empty;
        //        if (HttpContextWeb.Current != null)
        //            result = GetWebClientIp();
        //        if (result.IsEmpty())
        //            result = GetLanIp();
        //        return result;
        //    }
        //}

        /// <summary>
        /// 获得IP地址
        /// </summary>
        /// <returns>字符串数组</returns>
        public static string GetIp()
        {
            HttpContextAccessor _context = new HttpContextAccessor();
            var ip = _context.HttpContext.Request.Headers["X-Forwarded-For"].ToString();
            if (string.IsNullOrEmpty(ip))
            {
                ip = _context.HttpContext.Connection.RemoteIpAddress.ToString();
            }
            return ip;
        }

        /// <summary>
        /// 获取Web客户端的Ip
        /// </summary>
        //private static string GetWebClientIp()
        //{
        //    var ip = GetWebRemoteIp();
        //    foreach (var hostAddress in Dns.GetHostAddresses(ip))
        //    {
        //        if (hostAddress.AddressFamily == AddressFamily.InterNetwork)
        //            return hostAddress.ToString();
        //    }
        //    return string.Empty;
        //}

        /// <summary>
        /// 获取Web远程Ip
        /// </summary>
        //private static string GetWebRemoteIp()
        //{
        //    var ip = HttpContextWeb.Current.Request.Headers["X-Forwarded-For"];
        //    if (string.IsNullOrEmpty(ip))
        //    {
        //        ip = HttpContextWeb.Current.Connection.RemoteIpAddress.ToString();
        //    }
        //    return ip;
        //}

        /// <summary>
        /// 获取局域网IP
        /// </summary>
        //private static string GetLanIp()
        //{
        //    foreach (var hostAddress in Dns.GetHostAddresses(Dns.GetHostName()))
        //    {
        //        if (hostAddress.AddressFamily == AddressFamily.InterNetwork)
        //            return hostAddress.ToString();
        //    }
        //    return string.Empty;
        //}

        #endregion

        #region Host(获取主机名)

        /// <summary>
        /// 获取主机名
        /// </summary>
        //public static string Host
        //{
        //    get
        //    {
        //        return HttpContextWeb.Current == null ? Dns.GetHostName() : GetWebClientHostName();
        //    }
        //}

        /// <summary>
        /// 获取Web客户端主机名
        /// </summary>
        //private static string GetWebClientHostName()
        //{
        //    if (string.IsNullOrWhiteSpace(HttpContextWeb.Current.Connection.LocalIpAddress.MapToIPv4().ObjToString()))
        //        return string.Empty;
        //    var ip = GetWebRemoteIp();
        //    var result = Dns.GetHostEntry(IPAddress.Parse(ip)).HostName;
        //    if (result == "localhost.localdomain")
        //        result = Dns.GetHostName();
        //    return result;
        //}

        #endregion

        #region 获取mac地址
        /// <summary>
        /// 返回描述本地计算机上的网络接口的对象(网络接口也称为网络适配器)。
        /// </summary>
        /// <returns></returns>
        public static NetworkInterface[] NetCardInfo()
        {
            return NetworkInterface.GetAllNetworkInterfaces();
        }
        ///<summary>
        /// 通过NetworkInterface读取网卡Mac
        ///</summary>
        ///<returns></returns>
        public static List<string> GetMacByNetworkInterface()
        {
            List<string> macs = new List<string>();
            NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface ni in interfaces)
            {
                macs.Add(ni.GetPhysicalAddress().ToString());
            }
            return macs;
        }
        #endregion

        #region Ip城市(获取Ip城市)
        /// <summary>
        /// 获取IP地址信息
        /// </summary>
        /// <param name="ip"></param>
        /// <returns></returns>
        public static string GetLocation(string ip)
        {
            string res = "";
            try
            {
                string url = "http://apis.juhe.cn/ip/ip2addr?ip=" + ip + "&dtype=json&key=b39857e36bee7a305d55cdb113a9d725";
                res = HttpMethods.HttpGet(url);
                var resjson = res.ToObject<objex>();
                res = resjson.result.area + " " + resjson.result.location;
            }
            catch
            {
                res = "";
            }
            if (!string.IsNullOrEmpty(res))
            {
                return res;
            }
            try
            {
                string url = "https://sp0.baidu.com/8aQDcjqpAAV3otqbppnN2DJv/api.php?query=" + ip + "&resource_id=6006&ie=utf8&oe=gbk&format=json";
                res = HttpMethods.HttpGet(url, Encoding.GetEncoding("GBK"));
                var resjson = res.ToObject<obj>();
                res = resjson.data[0].location;
            }
            catch
            {
                res = "";
            }
            return res;
        }
        /// <summary>
        /// 百度接口
        /// </summary>
        public class obj
        {
            public List<dataone> data { get; set; }
        }
        public class dataone
        {
            public string location { get; set; }
        }
        /// <summary>
        /// 聚合数据
        /// </summary>
        public class objex
        {
            public string resultcode { get; set; }
            public dataoneex result { get; set; }
            public string reason { get; set; }
            public string error_code { get; set; }
        }
        public class dataoneex
        {
            public string area { get; set; }
            public string location { get; set; }
        }
        #endregion
    }
}