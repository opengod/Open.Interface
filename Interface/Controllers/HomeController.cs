using Interface.Models;
using Interface.Services;
using Microsoft.AspNetCore.Mvc;
using Open.Entity.Mysql;
using Open.Entity.Oracle;
using Open.Utils;
using Open.Utils.Excel;
using SqlSugar;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interface.Controllers
{
    /// <summary>
    /// 主页
    /// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        #region 构造函数
        private readonly Logs log = new Logs();
        private readonly Order oOrder = new Order();
        private readonly ExcelHelper oExcelHelper = new ExcelHelper();
        private readonly SqlSugarClient db_mysql = new SqlSugarClientInit().Init("MySqlConnection", "MySql");
        private readonly SqlSugarClient db_oracle = new SqlSugarClientInit().Init("OracleConnection", "Oracle");
        #endregion

        #region 示例
        #region 增删改查
        /// <summary>
        /// 增删改查
        /// </summary>
        /// <param name="oRequestParam"></param>
        /// <returns></returns>
        //[TypeFilter(typeof(LogActionFilter))]
        [HttpPost]
        public async Task<ReponseData<object>> AllDBwork(RequestParam<HomeModel> oRequestParam)
        {
            //新增
            CONSOLE_USER oCONSOLE_USER = new CONSOLE_USER
            {
                USER_ID = 1,
                USER_NAME = "123456"
            };
            db_oracle.Insertable(oCONSOLE_USER).ExecuteCommand();
            //批量新增
            List<CONSOLE_USER> _CONSOLE_USER = new List<CONSOLE_USER>()
             {
                   new CONSOLE_USER
                   {
                       USER_ID = 2,
                       USER_NAME = "123456"
                   },
                   new CONSOLE_USER
                   {
                       USER_ID = 3,
                       USER_NAME = "123456"
                   },
                   new CONSOLE_USER
                   {
                       USER_ID = 4,
                       USER_NAME = "123456"
                   }
            };
            db_oracle.Insertable(_CONSOLE_USER).ExecuteCommand();
            //获取第一条
            var oOrder = db_oracle.Queryable<CONSOLE_USER>().Where(p => p.USER_ID == 1).First();
            //获取list
            var oOrderList = db_oracle.Queryable<CONSOLE_USER>().Where(p => p.USER_ID > 1).ToList();
            //获取list 单表简单排序分页
            var totalCount = 0;
            var oOrderList2 = db_oracle.Queryable<CONSOLE_USER>().Where(p => p.USER_ID > 1).OrderBy(p => p.USER_ID, OrderByType.Desc).ToPageList(1, 1, ref totalCount);
            //修改
            oCONSOLE_USER.USER_NAME = "开放哥哥";
            db_oracle.Updateable(oCONSOLE_USER).ExecuteCommand();
            //批量修改
            foreach (var o in oOrderList)
            {
                o.USER_NAME = "哇";
            }
            db_oracle.Updateable(oOrderList).ExecuteCommand();
            //删除
            db_oracle.Deleteable<CONSOLE_USER>().Where(p => p.USER_ID == 1).ExecuteCommand();
            //批量删除
            db_oracle.Deleteable(oOrderList).ExecuteCommand();
            //多表复杂查询
            var _FindMuchList1 = await Task.Run(() => db_mysql.Queryable<T_B2C_MEMBER, T_TICKET_BOOKVISITOR>((member, book) => new object[] {
                      JoinType.Left, member.MEMBER_ID ==book.VISITOR_MEMBERID})
               .Where((member, book) => member.MEMBER_ISDEL == "F" && member.MEMBER_ID == 19)
               .OrderBy((member, book) => member.MEMBER_ID)
               .Select((member, book) => new
               {
                   ID = member.MEMBER_ID,
                   Name = member.MEMBER_NAME,
                   Tel = member.MEMBER_MOBILE,
                   Num = book.VISITOR_NUM
               }).Take(10).ToList());
            //多表group复杂查询
            var _FindMuchList2 = await Task.Run(() => db_mysql.Queryable<T_B2C_MEMBER, T_TICKET_BOOKVISITOR>((member, book) => new object[] {
                      JoinType.Left, member.MEMBER_ID ==book.VISITOR_MEMBERID})
               .Where((member, book) => member.MEMBER_ISDEL == "F" && member.MEMBER_ID == 19)
               .GroupBy((member, book) => member.MEMBER_ID)
               .OrderBy((member, book) => member.MEMBER_ID)
               .Select((member, book) => new
               {
                   nun = SqlFunc.AggregateCount(book.VISITOR_NUM),
                   id = member.MEMBER_ID,
                   name = member.MEMBER_NAME
               }).Take(10).ToList());
            //多表复杂查询 JoinType 一对多 多对多的联表查询 会返回笛卡尔积  即left有可能会返回超过左边记录的条数 需要进行去重及细化查询条件
            var _FindMuchList3 = db_mysql.Queryable<T_B2C_MEMBER, T_TICKET_BOOKVISITOR, T_BIZ_VISITOR>((member, book, visitor) => new object[] {
                      JoinType.Left, member.MEMBER_ID ==book.VISITOR_MEMBERID,
                      JoinType.Left, book.VISITOR_ID ==visitor.VISITOR_BOOKVISITORID,
                     })
               .Where((member, book, visitor) => member.MEMBER_ISDEL == "F" && member.MEMBER_ID == 19)
               .OrderBy((member, book, visitor) => member.MEMBER_ID)
               .Select((member, book, visitor) => new
               {
                   ID = member.MEMBER_ID,
                   Name = member.MEMBER_NAME,
                   Tel = member.MEMBER_MOBILE,
                   Num = book.VISITOR_NUM,
                   Icno = visitor.VISITOR_ICNO
               }).Take(10).ToList();
            //多表复杂查询 返回AB完整对象
            var _FindMuchList4 = await Task.Run(() => db_mysql.Queryable<T_B2C_MEMBER, T_TICKET_BOOKVISITOR>((member, book) => new object[] {
                      JoinType.Left, member.MEMBER_ID ==book.VISITOR_MEMBERID
                     })
               .Where((member, book) => member.MEMBER_ISDEL == "F" && member.MEMBER_ID == 19)
               .OrderBy((member, book) => member.MEMBER_ID)
               .Select((member, book) => new
               { member, book }).Take(10).ToList());
            return ReponseData<object>.data("AllDBwork", "1000", _FindMuchList4);
        }
        #endregion

        #region 获取自定义实体报表
        /// <summary>
        /// 获取数据表联查自定义实体报表
        /// </summary>
        /// <returns></returns>
        //  [TypeFilter(typeof(LogActionFilter))]
        [HttpPost]
        public async Task<IActionResult> GetCustomReportExcel(RequestParam<HomeModel> oRequestParam)
        {
            //多表复杂查询 JoinType 一对多 多对多的联表查询 会返回笛卡尔积  即left有可能会返回超过左边记录的条数 需要进行去重及细化查询条件
            var _FindMuchList3 = db_mysql.Queryable<T_B2C_MEMBER, T_TICKET_BOOKVISITOR, T_BIZ_VISITOR>((member, book, visitor) => new object[] {
                      JoinType.Left, member.MEMBER_ID ==book.VISITOR_MEMBERID,
                      JoinType.Left, book.VISITOR_ID ==visitor.VISITOR_BOOKVISITORID,
                     })
               .Where((member, book, visitor) => member.MEMBER_ISDEL == "F" && member.MEMBER_ID == 19)
               .OrderBy((member, book, visitor) => member.MEMBER_ID)
               .Select((member, book, visitor) => new HomeModel
               {
                   ID = member.MEMBER_ID,
                   Name = member.MEMBER_NAME,
                   Tel = member.MEMBER_MOBILE,
                   Num = book.VISITOR_NUM,
                   Icno = visitor.VISITOR_ICNO
               }).Take(10).ToList();
            return await Task.Run(() => oExcelHelper.ExcelDownload(_FindMuchList3, "这是一个excle文件"));
        }

        /// <summary>
        /// 获取数据表报表
        /// </summary>
        /// <returns></returns>
        //  [TypeFilter(typeof(LogActionFilter))]
        [HttpGet]
        public IActionResult GetDBReportExcel()
        {
            //获取list
            var oOrderList = db_oracle.Queryable<CONSOLE_USER>().Where(p => p.USER_ID > 1).ToList();
            return oExcelHelper.ExcelDownload(oOrderList, "这是一个excle文件");
        }

        /// <summary>
        /// 获取自定义实体报表
        /// </summary>
        /// <returns></returns>
        //  [TypeFilter(typeof(LogActionFilter))]
        [HttpPost]
        public async Task<IActionResult> GetReportExcel(RequestParam<HomeModel> oRequestParam)
        {
            var oHomeModel = new List<HomeModel>()
            {
                new HomeModel
                {
                    ID = 123,
                    Name = "哇塞",
                    Num = 1314
                }
            };
            return await Task.Run(() => oExcelHelper.ExcelDownload(oHomeModel, "这是一个excle文件"));
        }
        #endregion
        #endregion
    }
}