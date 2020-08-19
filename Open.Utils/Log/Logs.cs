using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Open.Utils
{
    #region 日志
    /// <summary>
    /// 日志相关
    /// </summary>
    public class Logs
    {
        private string nyear = DateTime.Now.ToString("yyyy");
        private string nmoth = DateTime.Now.ToString("yyyy-MM");
        private string ntime = DateTime.Now.ToString("yyyy-MM-dd");
        private string _DefaultLogPath;
        private int? _fileSize;
        private int? _delDays;

        /// <summary>
        /// 日志开始
        /// </summary>
        /// <returns></returns>
        public string DefaultLogPath
        {
            get => MyServiceProvider.ServiceProvider.GetRequiredService<IHostingEnvironment>().WebRootPath + (string.IsNullOrEmpty(_DefaultLogPath) ? @"\LogInfo" + "\\" + nyear + "\\" + nmoth : _DefaultLogPath);
            set { _DefaultLogPath = value; }
        }
        /// <summary>
        /// 文件路径
        /// </summary>
        /// <returns></returns>
        public int FileSize
        {
            get
            {
                return _fileSize == null ? 2 : _fileSize.Value;
            }
            set { _fileSize = value; }
        }
        /// <summary>
        /// 日期删除
        /// </summary>
        /// <returns></returns>
        public int DelDays
        {
            get
            {
                return _delDays == null ? 10 : _delDays.Value;
            }
            set { _delDays = value; }
        }
        /// <summary>
        /// 文件路径判断
        /// </summary>
        /// <returns></returns>
        public void IsDirectory(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                filePath = DefaultLogPath;
            }
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }
        }
        /// <summary>
        /// 文件路径
        /// </summary>
        /// <returns></returns>
        public string isLogFile(string filePath, string fileName)
        {
            filePath = GetFilePath(filePath, fileName);
            if (!File.Exists(filePath))
            {
                FileStream fs = new FileStream(filePath, FileMode.CreateNew);
                fs.Close();
                fs.Dispose();
            }
            return filePath;
        }
        /// <summary>
        /// 文件路径
        /// </summary>
        /// <returns></returns>
        public string GetFilePath(string filePath, string fileName)
        {
            if (fileName.PadRight(3) != ".txt")
                fileName += ".txt";
            if (filePath.PadRight(2) == "\\")
            {
                filePath += fileName;
            }
            else
            {
                filePath += "\\" + fileName;
            }
            return filePath;
        }
        /// <summary>
        /// 日志内容
        /// </summary>
        /// <returns></returns>
        public void WriteLog(string fileContent)
        {
            WriteLog("", "", fileContent);
        }


        //public void WriteLog(string fileName, string fileContent)
        //{
        //    WriteLog("", DateTime.Now.ToString("yyyy-MM-dd") + fileName, fileContent);
        //}
        /// <summary>
        /// 日志开始
        /// </summary>
        /// <param name="filePath">日志文件路径</param>
        ///  <param name="fileName">日志文件名称</param>
        ///   <param name="fileContent">日志内容</param>
        /// <returns></returns>
        public void WriteLog(string filePath, string fileName, string fileContent)
        {
            //读写锁，当资源处于写入模式时，其他线程写入需要等待本次写入结束之后才能继续写入
            ReaderWriterLockSlim LogWriteLock = new ReaderWriterLockSlim();
            fileName = DateTime.Now.ToString("yyyy-MM-dd") + fileName;
            filePath = filePath == null ? DefaultLogPath + "\\" + DateTime.Now.ToString("yyyy-MM-dd") : DefaultLogPath + "\\" + DateTime.Now.ToString("yyyy-MM-dd") + "\\" + filePath;
            IsDirectory(filePath);
            //filePath += "\\" + DateTime.Now.ToString("yyyy-MM-dd");
            //IsDirectory(filePath);
            if (string.IsNullOrEmpty(fileName.Trim()))
            {
                fileName = DateTime.Now.ToString("yyyy-MM-dd");
            }
            string[] strFilesArry = Directory.GetFiles(filePath, fileName + "》*.txt");
            if (strFilesArry.Length == 0)
            {
                filePath = isLogFile(filePath, fileName + "》0");
            }
            else
            {
                int fileMax = 0;
                bool isTrue = false;
                foreach (string str in strFilesArry)
                {
                    string fileStr = str.Trim();
                    int indexnum = fileStr.LastIndexOf("》");
                    if (fileStr.LastIndexOf("》") >= 0)
                    {
                        fileStr = fileStr.Substring(fileStr.LastIndexOf("》") + 1);
                        fileStr = fileStr.Split('.')[0].Trim();
                        int fileNum = Convert.ToInt32(fileStr);
                        if (fileNum >= fileMax)
                            fileMax = fileNum;
                        isTrue = true;
                    }
                }
                string filePathStr = GetFilePath(filePath, fileName + "》" + fileMax.ToString());
                if (!isTrue)
                    filePathStr = GetFilePath(filePath, fileName + "》0");
                FileInfo fileInfo = new FileInfo(filePathStr);
                if (fileInfo.Length > 1024 * 1024 * this.FileSize)
                {
                    fileName += "》" + (fileMax + 1).ToString();
                    filePath = isLogFile(filePath, fileName);
                }
                else
                {
                    isLogFile(filePath, fileName + "》0");
                    filePath = filePathStr;

                }
            }

            StringBuilder rContent = new StringBuilder();
            rContent.Append("\r\n");
            rContent.Append("\r\n");
            rContent.Append("\r\n");
            rContent.Append("====================【开始】====================");
            rContent.Append("\r\n");
            rContent.Append("记录时间：" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + "\r\n");
            rContent.Append(fileContent + "\r\n");
            rContent.Append("====================【结束】====================");
            try
            {
                FileStream nfs = new FileStream(filePath, FileMode.Append);
                StreamWriter sw = new StreamWriter(nfs, Encoding.UTF8);
                sw.Write(rContent);
                sw.Close();
                sw.Dispose();
                nfs.Close();
                nfs.Dispose();
                //退出写入模式，释放资源占用
                LogWriteLock.EnterWriteLock();
            }
            catch
            {
            }
            finally
            {
                //退出写入模式，释放资源占用
                LogWriteLock.ExitWriteLock();
                DelLog();
            }
        }
        /// <summary>
        /// 删除日志
        /// </summary>
        /// <returns></returns>
        public void DelLog()
        {
            ntime = DateTime.Now.AddDays(this.DelDays).ToString("yyyy-MM-dd");
            string filePath = DefaultLogPath + "\\" + nyear + "\\" + nmoth + "\\" + ntime;
            if (Directory.Exists(filePath))
            {
                Directory.Delete(filePath, true);
            }
        }
    }

    public static class MyServiceProvider
    {
        public static IServiceProvider ServiceProvider {get; set;}
    }
    #endregion
}
