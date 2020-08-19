using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Open.Utils;
using Swashbuckle.AspNetCore.Swagger;
using static Open.Utils.Swagger.CustomApiVersion;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Microsoft.AspNetCore.Cors.Infrastructure;

namespace Interface
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        private const string ApiName = "Open.Interface";
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddControllers().AddNewtonsoftJson(options =>
            {
                // 忽略循环引用
                options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                // 不使用驼峰，接口返回json不做驼峰校验，返回真实格式
                options.SerializerSettings.ContractResolver = new DefaultContractResolver();
                // 设置时间格式
                options.SerializerSettings.DateFormatString = "yyyy.MM-dd HH:mm:ss";
                // 如字段为null值，该字段不会返回到前端
                options.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
            });
            services.AddMvc().AddJsonOptions(options => options.JsonSerializerOptions.PropertyNamingPolicy = null);//swagger文档，JSON首字母小写解决
            #region Swagger
            services.AddSwaggerGen(c =>
            {
                //遍历出全部的版本，做文档信息展示
                typeof(ApiVersions).GetEnumNames().ToList().ForEach(version =>
                {
                    c.SwaggerDoc(version, new OpenApiInfo
                    {
                        // {ApiName} 定义成全局变量，方便修改
                        Version = version,
                        Title = $"{ApiName} 接口文档",
                        Description = $"{ApiName}" + version
                    });
                });
                var basePath = Path.GetDirectoryName(typeof(Program).Assembly.Location);
                var xmlPath = Path.Combine(basePath, "Interface.xml");
                // 默认的第二个参数是false，true显示controller的注释
                c.IncludeXmlComments(xmlPath, true);
            });
            #endregion
            #region 操作日志
            services.AddSingleton<ILogHandler, LogHandler>();
            //全局注册过滤器
            //services.AddControllers(options =>
            //{
            //    options.Filters.Add<LogActionFilter>();
            //}); 
            #endregion
            #region 跨域
            services.AddCors(options => options.AddPolicy("CorsPolicy",
                       builder =>
                       {
                           builder.AllowAnyMethod()
                               .SetIsOriginAllowed(_ => true)
                               .AllowAnyHeader()
                               .AllowCredentials();
                       }));
            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            #region 跨域
            app.UseCors("CorsPolicy");
            #endregion
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

           // app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.UseStaticFiles();
            #region Swagger
            //启用中间件服务生成Swagger作为JSON终结点
            app.UseSwagger();
            //启用中间件服务对swagger-ui，指定Swagger JSON终结点
            app.UseSwaggerUI(c =>
            {
                // 根据版本名称倒序 遍历展示
                typeof(ApiVersions).GetEnumNames().OrderByDescending(e => e).ToList().ForEach(version =>
                {
                    c.SwaggerEndpoint($"/swagger/{version}/swagger.json", $"{ApiName} {version}");
                });
            });
            #endregion

            #region Logs
            MyServiceProvider.ServiceProvider = app.ApplicationServices;
            #endregion
        }
    }
}
