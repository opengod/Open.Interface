using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace Open.Utils.Helper
{
    public static class GZip
    {
        /// <summary>  
        /// 压缩数据  
        /// </summary>  
        /// <param name="data"></param>  
        /// <returns></returns>  
        public static byte[] Compress(byte[] data)
        {
            MemoryStream ms = new MemoryStream();
            GZipStream zipStream = new GZipStream(ms, CompressionMode.Compress);
            zipStream.Write(data, 0, data.Length);//将数据压缩并写到基础流中  
            zipStream.Close();
            return ms.ToArray();
        }

        /// <summary> 
        /// 解压数据  
        /// </summary>  
        /// <param name="data"></param>  
        /// <returns></returns>  
        public static byte[] Decompress(byte[] data)
        {
            MemoryStream srcMs = new MemoryStream(data);
            GZipStream zipStream = new GZipStream(srcMs, CompressionMode.Decompress);
            MemoryStream ms = new MemoryStream();
            byte[] bytes = new byte[40960];
            int n;
            while ((n = zipStream.Read(bytes, 0, bytes.Length)) > 0)
            {
                ms.Write(bytes, 0, n);
            }
            zipStream.Close();
            return ms.ToArray();
        }
    }
}
