using System;

namespace Open.Utils
{
    public class OperatorModel
    {
        public decimal UserId { get; set; }
        public string UserCode { get; set; }
        public string UserName { get; set; }
        public string UserPwd { get; set; }
        public string CompanyId { get; set; }
        public string CompanyParentId { get; set; }
        public string DepartmentId { get; set; }
        public string RoleId { get; set; }
        /// <summary>
        /// 登录IP地址
        /// </summary>
        public string LoginIPAddress { get; set; }
        /// <summary>
        /// 登录地址
        /// </summary>
        public string LoginIPAddressName { get; set; }
        /// <summary>
        /// 登录Token值
        /// </summary>
        public string LoginToken { get; set; }
        /// <summary>
        /// 登录时间
        /// </summary>
        public DateTime LoginTime { get; set; }
        /// <summary>
        /// 是否系统管理员
        /// </summary>
        public bool IsSystem { get; set; }
        /// <summary>
        /// 记住登录
        /// </summary>
        public bool IsRemeberMe { get; set; }
    }
}
