using System.Linq;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;
using SqlSugar;
using Open.Entity;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Open.Utils
{
    /// <summary>
    /// 通用接口过滤器，请求校验，操作日志处理
    /// </summary>
    public class LogHandler : ILogHandler
    {
        private readonly Logs log = new Logs();
        /// <summary>
        /// 通用接口过滤器，请求校验，操作日志处理
        /// </summary>
        /// <param name="context">请求</param>
        /// <param name="next">响应</param>
        /// <returns></returns>
        public async Task LogAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var apipath = context.ActionDescriptor.AttributeRouteInfo.Template;
            var _path = apipath.Split('/');
            try
            {
                var sw = new Stopwatch();
                sw.Start();
                //操作参数
                var args = JsonConvert.SerializeObject(context.ActionArguments.Values.First());
                //记录请求日志
                await Task.Run(() => log.WriteLog(_path[1], _path[2], "请求参数：" + args));
                RequestParam_API oRequestParam_API = JsonConvert.DeserializeObject<RequestParam_API>(args);
                // 请求参数验证
                if (oRequestParam_API == null || oRequestParam_API.RequestData == null || oRequestParam_API.Signed == null)
                {
                    context.Result = new ObjectResult(ReponseData_API.data(_path[2], "90010", null));
                    await Task.Run(() => log.WriteLog(_path[1], _path[2], "返回参数：" + JsonConvert.SerializeObject(context.Result)));
                    return;
                }
                // 请求方法名验证
                if (oRequestParam_API.RequestData.Method != _path[2])
                {
                    context.Result = new ObjectResult(ReponseData_API.data(_path[2], "90013", null));
                    await Task.Run(() => log.WriteLog(_path[1], _path[2], "返回参数：" + JsonConvert.SerializeObject(context.Result)));
                    return;
                }
                // 秘钥验证
                var MenchantKey = Appsettings.app(new string[] { "API", "MenchantKey" });
                var sign = DESEncrypt.MD5(MenchantKey + oRequestParam_API.RequestData.AgencyCode + oRequestParam_API.RequestData.Method + oRequestParam_API.RequestData.Requestor + oRequestParam_API.RequestData.RequestTime);
                if (!sign.Equals(oRequestParam_API.Signed))
                {
                    context.Result = new ObjectResult(ReponseData_API.data(_path[2], "90002", null));
                    await Task.Run(() => log.WriteLog(_path[1], _path[2], "返回参数：" + JsonConvert.SerializeObject(context.Result)));
                    return;
                }
                // 时间戳验证
                var reqDate = DateTimeExtension.ToDateTime(oRequestParam_API.RequestData.RequestTime);
                if (reqDate == null)
                {
                    context.Result = new ObjectResult(ReponseData_API.data(_path[2], "90011", null));
                    await Task.Run(() => log.WriteLog(_path[1], _path[2], "返回参数：" + JsonConvert.SerializeObject(context.Result)));
                    return;
                }
                TimeSpan min = DateTime.Now - (reqDate ?? DateTime.Now);
                if (min.Minutes > 5 || min.Minutes < -5)
                {
                    context.Result = new ObjectResult(ReponseData_API.data(_path[2], "90012", null));
                    await Task.Run(() => log.WriteLog(_path[1], _path[2], "返回参数：" + JsonConvert.SerializeObject(context.Result)));
                    return;
                }
                //返回结果
                dynamic actionResult = (await next()).Result;
                sw.Stop();
                string ua = context.HttpContext.Request.Headers["User-Agent"];
                var client = UAParser.Parser.GetDefault().Parse(ua);
                var device = client.Device.Family;
                device = device.ToLower() == "other" ? "" : device;
                //var input = new T_SYS_LOG
                //{
                //    ApiMethod = context.HttpContext.Request.Method.ToLower(),
                //    ApiPath = apipath,
                //    ElapsedMilliseconds = sw.ElapsedMilliseconds,
                //    Device = device,
                //    Browser = client.UA.Family,
                //    Os = client.OS.Family,
                //    BrowserInfo = ua,
                //    IP = IPHelper.GetIP(context?.HttpContext?.Request),
                //    CreatedTime = DateTime.Now
                //};
                //判断是否返回实体结果
                var isObectResult = SerializeLibrary.ContainProperty(actionResult, "Value");
                if (isObectResult)
                {
                    //操作结果
                    var res = JsonConvert.DeserializeObject<ReponseData>(JsonConvert.SerializeObject(actionResult?.Value));
                    await Task.Run(() => log.WriteLog(_path[1], _path[2], "返回参数：" + JsonConvert.SerializeObject(actionResult?.Value)));
                    //input.Status = res?.Code == "1000" ? true : false;
                    //input.Msg = res?.Message;
                    //input.ApiLabel = _apiHelper.GetApis().FirstOrDefault(a => a.Path == input.ApiPath)?.Label;
                }
                //原生sqlsugar
                //var ConnectionString = Appsettings.app(new string[] { "ConnectionStrings", "MySqlConnection" });
                //SqlSugarClient db = new SqlSugarClient(new ConnectionConfig()
                //{
                //    DbType = DbType.MySql,
                //    ConnectionString = ConnectionString,
                //    InitKeyType = InitKeyType.Attribute,
                //    IsAutoCloseConnection = true
                //});
                //db.Insertable(input).ExecuteCommand();
            }
            catch (Exception ex)
            {
                context.Result = new ObjectResult(ReponseData_API.data(_path[2], "90001", null));
                await Task.Run(() => log.WriteLog(_path[1], _path[2], "返回参数：" + JsonConvert.SerializeObject(context.Result) + ex.Message + "\r\n" + ex.StackTrace + "\r\n" + ex.Source));
                return;
            }
        }
    }
}
