using System;
using System.Dynamic;
using System.Collections.Generic;
using System.Text;

namespace Open.Utils
{
    public class SysHelper
    {
        /// <summary>
        /// 获取提示信息
        /// </summary>
        /// <param name="resxName"></param>
        /// <returns></returns>
        public static dynamic GetIndexResx(string resxName)
        {
            var expando = (IDictionary<string, object>)new ExpandoObject();
            expando["listTitle"] = resxName + "管理";
            expando["addTitle"] = "新增" + resxName;
            expando["editTitle"] = "修改" + resxName;
            expando["viewTitle"] = "查看" + resxName;
            expando["noneSelect"] = "请先选择" + resxName + "数据！";
            expando["deleteConfirm"] = "确定要删除选中的" + resxName + "吗？";
            expando["deleteSuccess"] = "删除成功！";
            return expando;
        }

        /// <summary>
        /// 获取地址信息
        /// </summary>
        /// <param name="controller"></param>
        /// <param name="NameSpace"></param>
        /// <returns></returns>
        public static dynamic GetIndexUrls(string controller, string NameSpace = null)
        {
            var area = string.IsNullOrEmpty(NameSpace) ? "SysManage" : NameSpace;
            var expando = (IDictionary<string, object>)new ExpandoObject();
            expando["queryUrl"] = string.Format("/{0}/{1}/GetGridJson", area, controller);
            expando["queryTreeUrl"] = string.Format("/{0}/{1}/GetTreeGridJsonAsync", area, controller);
            expando["editUrl"] = string.Format("/{0}/{1}/Form", area, controller);
            expando["deleteUrl"] = string.Format("/{0}/{1}/DeleteForm", area, controller);
            return expando;
        }

        /// <summary>
        /// 显示错层方法
        /// </summary>
        public static string LevelName(string name, bool hasChildren, decimal? level)
        {
            int width = 24;
            if (level == 1)
            {
                if (hasChildren)
                {
                    name = string.Format("<div class='tree-wrap tree-wrap-ltr' style='width:{0}px;'>" +
                                        "<div class='glyphicon treeclick house-minus tree-plus'></div></div><span class='cell-wrapper'>{1}</span>", width, name);
                }
                else
                {
                    name = string.Format("<div class='tree-wrap tree-wrap-ltr' style='width:{0}px;'>" +
                                        "<div class='glyphicon treeclick house-line tree-plus'></div></div><span class='cell-wrapper'>{1}</span>", width, name);
                }
            }
            if (level > 1)
            {
                var leftWidth = (level.ObjToInt() - 1) * width;
                var levelWidth = level.ObjToInt() * width;
                name = string.Format("<div class='tree-wrap tree-wrap-ltr' style='width: {0}px;'>" +
                                        "<div style='left: {1}px;' class='glyphicon house-line tree-leaf treeclick'>" +
                                        "</div></div><span class='cell-wrapperleaf'>{2}</span>", levelWidth, leftWidth, name);
            }
            return name;
        }
    }
}