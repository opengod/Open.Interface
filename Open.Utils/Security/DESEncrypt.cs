using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Open.Utils
{
    public static class DESEncrypt
    {
        private const string KeyStr = "mzerokey_2019";

        private static byte[] DESKeys = new byte[8] { 18, 52, 86, 120, 144, 171, 205, 239 };

        #region ========加密========
        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="Text"></param>
        /// <returns></returns>
        public static string Encrypt(string Text)
        {
            return Encrypt(Text, KeyStr);
        }

        /// <summary> 
        /// 加密数据 
        /// </summary> 
        /// <param name="Text"></param> 
        /// <param name="sKey"></param> 
        /// <returns></returns> 
        public static string Encrypt(string Text, string sKey)
        {
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            byte[] inputByteArray;
            inputByteArray = Encoding.Default.GetBytes(Text);
            des.Key = ASCIIEncoding.ASCII.GetBytes(MD5(sKey).Substring(0, 8));
            des.IV = ASCIIEncoding.ASCII.GetBytes(MD5(sKey).Substring(0, 8));
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            StringBuilder ret = new StringBuilder();
            foreach (byte b in ms.ToArray())
            {
                ret.AppendFormat("{0:X2}", b);
            }
            return ret.ToString();
        }
        #endregion

        #region ========解密========
        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="Text"></param>
        /// <returns></returns>
        public static string Decrypt(string Text)
        {
            if (!string.IsNullOrEmpty(Text))
            {
                return Decrypt(Text, KeyStr);
            }
            else
            {
                return "";
            }
        }
        /// <summary> 
        /// 解密数据 
        /// </summary> 
        /// <param name="Text"></param> 
        /// <param name="sKey"></param> 
        /// <returns></returns> 
        public static string Decrypt(string Text, string sKey)
        {
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            int len;
            len = Text.Length / 2;
            byte[] inputByteArray = new byte[len];
            int x, i;
            for (x = 0; x < len; x++)
            {
                i = Convert.ToInt32(Text.Substring(x * 2, 2), 16);
                inputByteArray[x] = (byte)i;
            }
            des.Key = ASCIIEncoding.ASCII.GetBytes(MD5(sKey).Substring(0, 8));
            des.IV = ASCIIEncoding.ASCII.GetBytes(MD5(sKey).Substring(0, 8));
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            return Encoding.Default.GetString(ms.ToArray());
        }

        #endregion

        private static string EncryptString(string datastr, string keystr)
        {
            DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
            byte[] bytes = Encoding.ASCII.GetBytes(keystr);
            byte[] bytes2 = Encoding.Unicode.GetBytes(datastr);
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, dESCryptoServiceProvider.CreateEncryptor(bytes, bytes), CryptoStreamMode.Write);
            cryptoStream.Write(bytes2, 0, bytes2.Length);
            cryptoStream.FlushFinalBlock();
            return Convert.ToBase64String(memoryStream.ToArray());
        }

        public static string EncryptString(string datastr)
        {
            return EncryptString(datastr, KeyStr);
        }

        private static string DecryptString(string datastr, string keystr)
        {
            byte[] array = Convert.FromBase64String(datastr);
            DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
            byte[] bytes = Encoding.ASCII.GetBytes(keystr);
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, dESCryptoServiceProvider.CreateDecryptor(bytes, bytes), CryptoStreamMode.Write);
            cryptoStream.Write(array, 0, array.Length);
            cryptoStream.FlushFinalBlock();
            return Encoding.Unicode.GetString(memoryStream.ToArray());
        }

        public static string DecryptString(string datastr)
        {
            return DecryptString(datastr, KeyStr);
        }

        public static string DESEncode(this string encryptString, string encryptKey)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(encryptKey.Substring(0, 8));
            byte[] dESKeys = DESKeys;
            byte[] bytes2 = Encoding.UTF8.GetBytes(encryptString);
            DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, dESCryptoServiceProvider.CreateEncryptor(bytes, dESKeys), CryptoStreamMode.Write);
            cryptoStream.Write(bytes2, 0, bytes2.Length);
            cryptoStream.FlushFinalBlock();
            return Convert.ToBase64String(memoryStream.ToArray());
        }

        public static string DESDecode(this string decryptString, string decryptKey)
        {
            try
            {
                byte[] bytes = Encoding.UTF8.GetBytes(decryptKey);
                byte[] dESKeys = DESKeys;
                byte[] array = Convert.FromBase64String(decryptString);
                DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
                MemoryStream memoryStream = new MemoryStream();
                CryptoStream cryptoStream = new CryptoStream(memoryStream, dESCryptoServiceProvider.CreateDecryptor(bytes, dESKeys), CryptoStreamMode.Write);
                cryptoStream.Write(array, 0, array.Length);
                cryptoStream.FlushFinalBlock();
                return Encoding.UTF8.GetString(memoryStream.ToArray());
            }
            catch
            {
                return string.Empty;
            }
        }

        public static string Base64Encode(this string encryptString)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(encryptString);
            return Convert.ToBase64String(bytes);
        }

        public static string Base64Decode(this string decryptString)
        {
            byte[] bytes = Convert.FromBase64String(decryptString);
            return Encoding.UTF8.GetString(bytes);
        }

        public static string MD5(this string str)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(str.Trim());
            MD5 mD = new MD5CryptoServiceProvider();
            byte[] value = mD.ComputeHash(bytes);
            return BitConverter.ToString(value).Replace("-", "").ToLower();
        }

        public static string EncodeSignature(string msg, string MerchantKey)
        {
            return Base64Encode(DESEncode(MD5(msg), MerchantKey));
        }

        public static string DecodeInfo(string msg, string MerchantKey)
        {
            return DESDecode(Base64Decode(msg), MerchantKey);
        }
    }
}
