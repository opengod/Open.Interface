using SqlSugar;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Open.Utils
{
    public static class ExtList
    {
        /// <summary>
        /// 获取表里某页的数据
        /// </summary>
        /// <param name="data">表数据</param>
        /// <param name="pageIndex">当前页</param>
        /// <param name="pageSize">分页大小</param>
        /// <param name="allPage">返回总页数</param>
        /// <returns>返回当页表数据</returns>
        public static List<T> GetPage<T>(this List<T> data, int pageIndex, int pageSize, out int allPage)
        {
            allPage = 1;
            return null;
        }
        /// <summary>
        /// IList转成List<T>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static List<T> IListToList<T>(IList list)
        {
            T[] array = new T[list.Count];
            list.CopyTo(array, 0);
            return new List<T>(array);
        }

        /// <summary>
        /// 分页
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="pageIndex">当前页</param>
        /// <param name="pageSize">页大小</param>
        /// <returns></returns>
        public static PageResult<T> Paging<T>(this ISugarQueryable<T> source, int pageIndex, int pageSize)
        {
            if (pageIndex <= 0)
                throw new ArgumentException("Index of current page can not less than 0 !", "pageIndex");
            if (pageSize <= 1)
                throw new ArgumentException("Size of page can not less than 1 !", "pageSize");
            var pagedQuery = source.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            return new PageResult<T>
            {
                rows = pagedQuery.ToList(),
                records = source.Count(),
                page = pageIndex,
                pagesize = pageSize
            };
        }

        /// <summary>
        /// 分页
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="pageIndex">当前页</param>
        /// <param name="pageSize">页大小</param>
        /// <returns></returns>
        public static async Task<PageResult<T>> PagingAsync<T>(this ISugarQueryable<T> source, int pageIndex, int pageSize)
        {
            if (pageIndex <= 0)
                throw new ArgumentException("Index of current page can not less than 0 !", "pageIndex");
            if (pageSize <= 1)
                throw new ArgumentException("Size of page can not less than 1 !", "pageSize");
            var pagedQuery = source.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            return new PageResult<T>
            {
                rows = await pagedQuery.ToListAsync(),
                records = await source.CountAsync(),
                page = pageIndex,
                pagesize = pageSize
            };
        }
    }
}
