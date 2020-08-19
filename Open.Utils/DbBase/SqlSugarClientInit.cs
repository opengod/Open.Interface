using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Open.Utils
{
    /// <summary>
    /// SqlSugarClient DB 用于原生写法，分库分表
    /// </summary>
    public class SqlSugarClientInit
    {
        /// <summary>
        /// SqlSugarClient DB 用于原生写法，分库分表
        /// </summary>
        /// <param name="ConnectionString">Appsettings.json中ConnectionString连接字符串</param>
        /// <param name="dbType">数据库类型，MySql、Oracle、SqlServer、Sqlite、PostgreSQL</param>
        /// <returns>SqlSugarClient</returns>
        public SqlSugarClient Init(string ConnectionString, string dbType)
        {
            Logs log = new Logs();
            var enumDbType = DbType.MySql;
            switch (dbType)
            {
                case "MySql":
                    enumDbType = DbType.MySql;
                    break;
                case "Oracle":
                    enumDbType = DbType.Oracle;
                    break;
                case "SqlServer":
                    enumDbType = DbType.SqlServer;
                    break;
                case "Sqlite":
                    enumDbType = DbType.Sqlite;
                    break;
                case "PostgreSQL":
                    enumDbType = DbType.PostgreSQL;
                    break;
                default:
                    break;
            }
            var oConnectionString = Appsettings.app(new string[] { "ConnectionStrings", ConnectionString });
            SqlSugarClient db = new SqlSugarClient(new ConnectionConfig()
            {
                DbType = enumDbType,
                ConnectionString = oConnectionString,
                InitKeyType = InitKeyType.Attribute,
                IsAutoCloseConnection = true
            });
            #region 记录事件
            //db.Aop.OnLogExecuting = (sql, pars) => //SQL执行前事件
            //{

            //};
            //db.Aop.OnLogExecuted = (sql, pars) => //SQL执行完事件
            //{
            //    log.WriteLog("SqlSugarClient", "OnLogExecuted", sql);
            //    log.WriteLog("SqlSugarClient", "OnLogExecuted", string.Join(",", pars?.Select(it => it.ParameterName + ":" + it.Value)));
            //};
            //db.Aop.OnError = (exp) =>//执行SQL 错误事件
            //{
            //    log.WriteLog("SqlSugarClient", "OnError", exp.Sql);
            //    log.WriteLog("SqlSugarClient", "OnError", exp.Parametres.ToJson());
            //    log.WriteLog("SqlSugarClient", "OnError", exp.Message);
            //    //exp.sql exp.parameters 可以拿到参数和错误Sql             
            //};
            //db.Aop.OnExecutingChangeSql = (sql, pars) => //SQL执行前 可以修改SQL
            //{
            //    return new KeyValuePair<string, SugarParameter[]>(sql, pars);
            //};
            ////执行时间
            //var t = db.Ado.SqlExecutionTime; 
            #endregion
            return db;
        }
    }
}
