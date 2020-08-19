using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using MySql.Data.MySqlClient;
using Spire.Doc;
using Spire.Xls;

namespace Open.Utils.Helper
{
    public class FileHelper
    {
        // 获取连接字符串
        static string ConnectString = Appsettings.app(new string[] { "ConnectionStrings", "MySqlConnection" });

        /// <summary>
        /// 备份数据库
        /// </summary>
        /// <param name="cmdText">指定准备备份的文件名 以***.sql为标准</param>
        /// <returns></returns>
        public static bool BackupDB(string cmdText)
        {
            bool isBack = false;
            try
            {
                MySqlConnection myconn = new MySqlConnection(ConnectString);
                if (myconn.State == ConnectionState.Closed)
                {
                    myconn.Open();
                }
                try
                {
                    if (string.IsNullOrEmpty(cmdText))
                    {
                        return isBack;
                    }
                    using (MySqlCommand cmmd = new MySqlCommand())
                    {
                        using (MySqlBackup backCmd = new MySqlBackup(cmmd))
                        {
                            cmmd.Connection = myconn;
                            cmmd.CommandTimeout = 60;
                            backCmd.ExportInfo.MaxSqlLength = 1024;//指定备份文件的大小
                            backCmd.ExportToFile(cmdText);
                            isBack = true;
                        }
                    }
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    if (myconn.State == ConnectionState.Open)
                    {
                        myconn.Close();
                        myconn.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return isBack;
        }

        /// <summary>
        /// 还原数据库
        /// </summary>
        /// <param name="strPath">指定还原文件***.sql的绝对路径</param>
        /// <param name="dbName">还原到指定数据库</param>
        /// <returns></returns>
        public static bool RestoreDB(string strPath, string dbName)
        {
            bool isImport = false;
            try
            {
                MySqlConnection myconn = new MySqlConnection(ConnectString);
                if (myconn.State == ConnectionState.Closed)
                {
                    myconn.Open();
                }
                try
                {
                    if (string.IsNullOrEmpty(strPath))
                    {
                        return isImport;
                    }
                    using (MySqlCommand cmmd = new MySqlCommand())
                    {
                        using (MySqlBackup backCmd = new MySqlBackup(cmmd))
                        {
                            cmmd.Connection = myconn;
                            cmmd.CommandTimeout = 3600;
                            backCmd.ImportInfo.TargetDatabase = dbName;//前提条件 当前 myconn 中的用户有建库等系列权限
                            backCmd.ImportInfo.DatabaseDefaultCharSet = "utf8";
                            backCmd.ImportFromFile(strPath);
                            isImport = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                }
                finally
                {
                    if (myconn.State == ConnectionState.Open)
                    {
                        myconn.Close();
                        myconn.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return isImport;
        }

        public static bool FileExists(string FileName)
        {
            string destFileName = FileName;
            if (File.Exists(destFileName))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void DownLoad(string filepath, string fileName)
        {
            string destFileName = filepath;
            if (File.Exists(destFileName))
            {
                FileInfo fi = new FileInfo(destFileName);
                Web.Response.Body.Close();
                Web.Response.Headers["Content-Type"] = "application/x-bittorrent";
                Web.Response.Headers["Content-Disposition"] = "attachment; filename=" + Web.UrlEncode(fileName, System.Text.Encoding.UTF8);
                FileStream t = new FileStream(filepath, FileMode.Open);
                byte[] bytes = new byte[(int)t.Length];
                Web.Response.Headers.ContentLength = t.Length;
                t.Read(bytes, 0, (int)t.Length);
                Web.Response.Body.Write(bytes, 0, bytes.Length);
                Web.Response.Body.Flush();
                t.Close();
            }
        }

        /// <summary>
        /// Base64转文件
        /// </summary>
        /// <param name="strbase64"></param>
        /// <param name="filepath"></param>
        public static void Base64StringToFile(string strbase64, string filepath)
        {
            try
            {
                strbase64 = strbase64.Replace(' ', '+');
                MemoryStream stream = new MemoryStream(Convert.FromBase64String(strbase64));
                FileStream fs = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.Write);
                byte[] b = stream.ToArray();
                fs.Write(b, 0, b.Length);
                fs.Close();

            }
            catch (Exception ex)
            {
                throw ExceptionEx.ThrowBusinessException(ex);
            }
        }

        #region 删除文件
        /// <summary>
        /// 删除文件
        /// </summary>
        /// <param name="file">要删除的文件路径和名称</param>
        public static void DeleteFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }
        #endregion



        #region 删除文件夹底下的所有文件
        /// <summary>
        /// 删除文件
        /// </summary>
        /// <param name="file">要删除的文件路径和名称</param>
        public static void DeleteFilesAndFolders(string filePath)
        {
            foreach (FileInfo file in (new DirectoryInfo(filePath)).GetFiles())
            {
                WipeFile(file.ToString(), 10);
            }



        }
        #endregion


        public static void WipeFile(string filename, int timesToWrite)
        {
            try
            {
                if (File.Exists(filename))
                {
                    //设置文件的属性为正常，这是为了防止文件是只读
                    File.SetAttributes(filename, FileAttributes.Normal);
                    //计算扇区数目
                    double sectors = Math.Ceiling(new FileInfo(filename).Length / 512.0);
                    // 创建一个同样大小的虚拟缓存
                    byte[] dummyBuffer = new byte[512];
                    // 创建一个加密随机数目生成器
                    RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
                    // 打开这个文件的FileStream
                    FileStream inputStream = new FileStream(filename, FileMode.Open, FileAccess.Write, FileShare.ReadWrite);
                    for (int currentPass = 0; currentPass < timesToWrite; currentPass++)
                    {
                        // 文件流位置
                        inputStream.Position = 0;
                        //循环所有的扇区
                        for (int sectorsWritten = 0; sectorsWritten < sectors; sectorsWritten++)
                        {
                            //把垃圾数据填充到流中
                            rng.GetBytes(dummyBuffer);
                            // 写入文件流中
                            inputStream.Write(dummyBuffer, 0, dummyBuffer.Length);
                        }
                    }
                    // 清空文件
                    inputStream.SetLength(0);
                    // 关闭文件流
                    inputStream.Close();
                    // 清空原始日期需要
                    DateTime dt = new DateTime(2037, 1, 1, 0, 0, 0);
                    File.SetCreationTime(filename, dt);
                    File.SetLastAccessTime(filename, dt);
                    File.SetLastWriteTime(filename, dt);
                    // 删除文件
                    File.Delete(filename);
                }
            }
            catch (Exception)
            {
            }
        }


        #region 获取一个文件的长度
        /// <summary>
        /// 获取一个文件的长度,单位为Byte
        /// </summary>
        /// <param name="filePath">文件的绝对路径</param>        
        public static long GetFileSize(string filePath)
        {
            //创建一个文件对象
            FileInfo fi = new FileInfo(filePath);
            //获取文件的大小
            return fi.Length;
        }
        #endregion

        #region 获取文件大小并以B，KB，GB，TB
        /// <summary>
        /// 计算文件大小函数(保留两位小数),Size为字节大小
        /// </summary>
        /// <param name="size">初始文件大小</param>
        /// <returns></returns>
        public static string ToFileSize(long size)
        {
            string m_strSize = "";
            long FactSize = 0;
            FactSize = size;
            if (FactSize < 1024.00)
                m_strSize = FactSize.ToString("F2") + " 字节";
            else if (FactSize >= 1024.00 && FactSize < 1048576)
                m_strSize = (FactSize / 1024.00).ToString("F2") + " KB";
            else if (FactSize >= 1048576 && FactSize < 1073741824)
                m_strSize = (FactSize / 1024.00 / 1024.00).ToString("F2") + " MB";
            else if (FactSize >= 1073741824)
                m_strSize = (FactSize / 1024.00 / 1024.00 / 1024.00).ToString("F2") + " GB";
            return m_strSize;
        }
        #endregion

        /// <summary>
        /// 获取EXCEL数据
        /// <summary>
        /// <returns></returns>
        public static void GetExcelData(string path)
        {
            try
            {
                Workbook workbook = new Workbook();
                workbook.LoadFromFile(path);
                workbook.SaveToFile(path.Substring(0, path.LastIndexOf(".")) + ".pdf", Spire.Xls.FileFormat.PDF);
            }
            catch (Exception ex)
            {
                if (ex is ExceptionEx)
                {
                    throw;
                }
                else
                {
                    throw ExceptionEx.ThrowBusinessException(ex);
                }
            }
        }

        /// <summary>
        /// 获取Word数据
        /// <summary>
        /// <returns></returns>
        public static void GetWordData(string path)
        {
            try
            {
                Document document = new Document();
                document.LoadFromFile(path);
                document.SaveToFile(path.Substring(0, path.LastIndexOf(".")) + ".pdf", Spire.Doc.FileFormat.PDF);
            }
            catch (Exception ex)
            {
                if (ex is ExceptionEx)
                {
                    throw;
                }
                else
                {
                    throw ExceptionEx.ThrowBusinessException(ex);
                }
            }
        }
    }
}
