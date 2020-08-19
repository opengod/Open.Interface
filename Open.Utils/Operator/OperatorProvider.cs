using System;

namespace Open.Utils
{
    public class OperatorProvider
    {
        public static OperatorProvider Provider
        {
            get { return new OperatorProvider(); }
        }

        private string LoginUserKey = "loginuserkey_2019";

        private string LoginProvider = Appsettings.app(new string[] { "AppSettings", "LoginProvider" });

        public OperatorModel GetCurrent()
        {
            var operatorModel = new OperatorModel();
            if (LoginProvider == "Cookie")
            {
                operatorModel = DESEncrypt.Decrypt(WebHelper.GetCookie(LoginUserKey).ToString()).ToObject<OperatorModel>();
            }
            else
            {
                operatorModel = DESEncrypt.Decrypt(WebHelper.GetSession(LoginUserKey).ToString()).ToObject<OperatorModel>();
            }
            return operatorModel;
        }

        /// <summary>
        /// 判断登录状态
        /// </summary>
        /// <param name="token">登录票据</param>
        /// <param name="loginMark">登录设备标识</param>
        /// <returns>-1未登录,1登录成功,0登录过期</returns>
        public OperatorResult IsOnLine()
        {
            // -1未登录  1登录成功 0登录过期
            var operatorResult = new OperatorResult() { stateCode = 1 };
            try
            {
                var oOperatorModel = Provider.GetCurrent();
                if (oOperatorModel == null)
                {
                    operatorResult.stateCode = -1;
                    return operatorResult;
                }
                TimeSpan timeSpan = DateTime.Now - oOperatorModel.LoginTime;
                //if (oOperatorModel.IsRemeberMe)
                //{
                //    // 登录操作超过7天移除
                //    if (timeSpan.TotalDays > 7)
                //    {
                //        operatorResult.stateCode = 0;
                //        Provider.RemoveCurrent();
                //    }
                //}
                //else
                //{
                // 登录操作超过15小时移除
                if (timeSpan.TotalHours > 15)
                {
                    operatorResult.stateCode = 0;
                    Provider.RemoveCurrent();
                }
                //}
                return operatorResult;
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                operatorResult.stateCode = -1;
                return operatorResult;
            }
        }

        public void AddCurrent(OperatorModel operatorModel)
        {
            if (LoginProvider == "Cookie")
            {
                //if (operatorModel.IsRemeberMe)
                //{
                //    WebHelper.WriteCookie(LoginUserKey, DESEncrypt.Encrypt(operatorModel.ToJson()), 10080);
                //}
                //else
                //{
                    WebHelper.WriteCookie(LoginUserKey, DESEncrypt.Encrypt(operatorModel.ToJson()));
                //}
            }
            else
            {
                WebHelper.WriteSession(LoginUserKey, DESEncrypt.Encrypt(operatorModel.ToJson()));
            }
        }

        public void RemoveCurrent()
        {
            if (LoginProvider == "Cookie")
            {
                WebHelper.RemoveCookie(LoginUserKey.Trim());
            }
            else
            {
                WebHelper.RemoveSession(LoginUserKey.Trim());
            }
        }
    }
}
