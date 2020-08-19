using System;
using System.Collections.Generic;
using System.Text;

namespace Open.Utils.Extend
{
    public static class ExtRandomNum
    {

        /// <summary>
        /// 生成随机串，随机串包含字母或数字
        /// </summary>
        /// <returns></returns>
        public static string GenerateNonceStr()
        {
            return Guid.NewGuid().ToString().Replace("-", "");
        }

        /// <summary>
        /// 获取随机数
        /// </summary>
        /// <param name="min">随机数范围下界</param>
        /// <param name="number">随机数范围上界</param>
        /// <returns></returns>
        public static int GetRandomRaffle(int min = 0, int number = 100)
        {
            var ran = new Random(GetRandomSeed());
            int ranNumber = ran.Next(min, number);  //随机数
            return ranNumber;
        }

        static int GetRandomSeed()
        {
            byte[] bytes = new byte[4];
            var rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            rng.GetBytes(bytes);
            return BitConverter.ToInt32(bytes, 0);
        }
    }
}
