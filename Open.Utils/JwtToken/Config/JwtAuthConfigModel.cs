using System;

namespace Open.Utils
{
    public class JwtAuthConfigModel : BaseConfigModel
    {
        public string JWTSecretKey { get; set; }
        public string JWTIssuer { get; set; }
        public string JWTAudience { get; set; }
        /// <summary>
        /// web应用过期12小时
        /// </summary>
        public double WebExp { get; set; }

        /// <summary>
        /// APP应用过期12小时
        /// </summary>
        public double AppExp { get; set; }

        /// <summary>
        /// 小程序应用过期12小时
        /// </summary>
        public double MiniProgramExp { get; set; }

        /// <summary>
        /// 其他应用过期12小时
        /// </summary>
        public double OtherExp { get; set; }

        public JwtAuthConfigModel()
        {
            try
            {
                JWTSecretKey = Appsettings.app(new string[] { "JwtAuth", "SecurityKey" });
                JWTIssuer = Appsettings.app(new string[] { "JwtAuth", "Issuer" });
                JWTAudience = Appsettings.app(new string[] { "JwtAuth", "Audience" });
                WebExp = double.Parse(Appsettings.app(new string[] { "JwtAuth", "WebExp" }));
                AppExp = double.Parse(Appsettings.app(new string[] { "JwtAuth", "AppExp" }));
                MiniProgramExp = double.Parse(Appsettings.app(new string[] { "JwtAuth", "MiniProgramExp" }));
                OtherExp = double.Parse(Appsettings.app(new string[] { "JwtAuth", "OtherExp" }));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}