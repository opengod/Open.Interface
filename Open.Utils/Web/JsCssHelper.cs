﻿using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace Open.Utils.Web
{
    public class JsCssHelper
    {
        #region Js 文件操作
        /// <summary>
        /// 读取js文件内容并压缩
        /// </summary>
        /// <param name="filePathlist"></param>
        /// <returns></returns>
        public static string ReadJSFile(string[] filePathlist)
        {
            StringBuilder jsStr = new StringBuilder();
            try
            {
                string rootPath = Assembly.GetExecutingAssembly().CodeBase.Replace("/bin/Learun.Util.DLL", "").Replace("file:///", "");
                foreach (var filePath in filePathlist)
                {
                    string path = rootPath + filePath;
                    if (Open.Utils.Helper.FileHelper.FileExists(path))
                    {
                        string content = File.ReadAllText(path, Encoding.UTF8);
                        jsStr.Append(content);
                    }
                }
                return jsStr.ToString();
            }
            catch (Exception)
            {
                return "";
            }
        }
        #endregion

        #region Css 文件操作
        /// <summary>
        /// 读取css 文件内容并压缩
        /// </summary>
        /// <param name="filePathlist"></param>
        /// <returns></returns>
        public static string ReadCssFile(string[] filePathlist)
        {
            StringBuilder cssStr = new StringBuilder();
            try
            {
                string rootPath = Assembly.GetExecutingAssembly().CodeBase.Replace("/bin/Learun.Util.DLL", "").Replace("file:///", "");
                foreach (var filePath in filePathlist)
                {
                    string path = rootPath + filePath;
                    if (Open.Utils.Helper.FileHelper.FileExists(path))
                    {
                        string content = File.ReadAllText(path, Encoding.UTF8);
                        cssStr.Append(content);
                    }
                }
                return cssStr.ToString();
            }
            catch (Exception)
            {
                return cssStr.ToString();
            }
        }
        #endregion

        #region 读取文件
        /// <summary>
        /// 读取对应文件
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static string Read(string filePath)
        {
            StringBuilder str = new StringBuilder();
            try
            {
                string rootPath = Assembly.GetExecutingAssembly().CodeBase.Replace("/bin/Learun.Util.DLL", "").Replace("file:///", "");
                string path = rootPath + filePath;
                if (Open.Utils.Helper.FileHelper.FileExists(path))
                {
                    string content = File.ReadAllText(path, Encoding.UTF8);
                    str.Append(content);
                }
                return str.ToString();
            }
            catch (Exception)
            {
                return "";
            }
        }
        /// <summary>
        /// 读取js文件
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static string ReadJS(string filePath)
        {
            StringBuilder str = new StringBuilder();
            try
            {
                string rootPath = Assembly.GetExecutingAssembly().CodeBase.Replace("/bin/Learun.Util.DLL", "").Replace("file:///", "");
                string path = rootPath + filePath;
                if (Open.Utils.Helper.FileHelper.FileExists(path))
                {
                    string content = File.ReadAllText(path, Encoding.UTF8);
                    str.Append(content);
                }
                return str.ToString();
            }
            catch (Exception)
            {
                return "";
            }
        }
        /// <summary>
        /// 读取css文件
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static string ReadCss(string filePath)
        {
            StringBuilder str = new StringBuilder();
            try
            {
                string rootPath = Assembly.GetExecutingAssembly().CodeBase.Replace("/bin/Learun.Util.DLL", "").Replace("file:///", "");
                string path = rootPath + filePath;
                if (Open.Utils.Helper.FileHelper.FileExists(path))
                {
                    string content = File.ReadAllText(path, Encoding.UTF8);
                    str.Append(content);
                }
                return str.ToString();
            }
            catch (Exception)
            {
                return "";
            }
        }
        #endregion
    }
}
