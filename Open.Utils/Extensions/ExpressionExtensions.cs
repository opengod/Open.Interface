using Open.Utils.Helper;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Open.Utils
{
    /// <summary>
    /// 表达式树的扩展
    /// </summary>
    public class ExpressionExtensions
    {
        /// <summary>
        /// 构建表达式树
        /// 调用：GenerateExpression(new string[]{"username"},new object[]{"zzl"},new string[]{"="});
        /// </summary>
        /// <typeparam name="T">表类型</typeparam>
        /// <param name="keys">字段名</param>
        /// <param name="values">字段值</param>
        /// <param name="operation">操作符</param>
        /// <returns></returns>
        public static Expression<Func<T, bool>> GenerateExpression<T>(List<FieldValueParam> listParam)
        {
            Expression<Func<T, bool>> expression_return = t => true;
            try
            {
                if (listParam.Count > 0)
                {
                    foreach (var item in listParam)
                    {
                        switch (item.operation)
                        {
                            // 等于
                            case "=":
                                expression_return = expression_return.And(Lambda.Equal<T>(item.name, item.value));
                                break;
                            // 大于
                            case ">":
                                expression_return = expression_return.And(Lambda.Greater<T>(item.name, item.value));
                                break;
                            // 大于等于
                            case ">=":
                                expression_return = expression_return.And(Lambda.GreaterEqual<T>(item.name, item.value));
                                break;
                            // 小于
                            case "<":
                                expression_return = expression_return.And(Lambda.Less<T>(item.name, item.value));
                                break;
                            // 小于等于
                            case "<=":
                                expression_return = expression_return.And(Lambda.LessEqual<T>(item.name, item.value));
                                break;
                            // 包含
                            case "%":
                                expression_return = expression_return.And(Lambda.Contains<T>(item.name, item.value));
                                break;
                            // 包含于
                            case "in":
                                string[] arrStr = item.value.ToString().Split(',');
                                Expression<Func<T, bool>> or_return = t => false;
                                if (arrStr.Length > 0)
                                {
                                    foreach (var arr in arrStr)
                                    {
                                        or_return = or_return.Or(Lambda.Contains<T>(item.name, arr));
                                    }
                                }
                                expression_return = expression_return.And(or_return);
                                break;
                            // 不等于
                            case "!=":
                                expression_return = expression_return.And(Lambda.NotEqual<T>(item.name, item.value));
                                break;
                            default:
                                throw new ArgumentException("无效的操作符，目前只支持=,%,>,<,>=,<=,in");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return expression_return;
        }
    }
}
