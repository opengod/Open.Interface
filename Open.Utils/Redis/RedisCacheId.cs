using System;
using System.Collections.Generic;
using System.Text;

namespace Open.Utils
{
    public static class RedisCacheId
    {
        #region 3号库 附件上传（文件分片数据存储）
        /// <summary>
        /// 附件
        /// </summary>
        public static long attachement { get { return 3; } }
        /// <summary>
        /// excel导入
        /// </summary>
        public static long excel { get { return 3; } }
        #endregion
    }
}
