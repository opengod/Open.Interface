using System;
using System.Collections.Generic;
using System.Text;

namespace Open.Utils.Ueditor
{
    public class UeditorUploadResult
    {
        public UeditorUploadState State { get; set; }
        public string Url { get; set; }
        public string OriginFileName { get; set; }
        public string ErrorMessage { get; set; }
    }

    public enum UeditorUploadState
    {
        Success = 0,
        SizeLimitExceed = -1,
        TypeNotAllow = -2,
        FileAccessError = -3,
        NetworkError = -4,
        Unknown = 1,
    }
}
