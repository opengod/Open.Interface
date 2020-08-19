using System.Collections.Generic;
using System.Text;

namespace Open.Utils
{
    public static class TreeGrid
    {
        public static string TreeGridJson(this List<TreeGridModel> data)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("{ \"rows\": [");
            sb.Append(TreeGridJson(data, -1, "0"));
            sb.Append("]}");
            return sb.ToString();
        }

        /// <summary>
        /// 树形数据转化
        /// </summary>
        /// <param name="list">数据</param>
        /// <returns></returns>
        public static List<TreeGridModel> ToTree(this List<TreeGridModel> list, string parentId = "")
        {
            var childrenMap = new Dictionary<string, List<TreeGridModel>>();
            var parentMap = new Dictionary<string, TreeGridModel>();
            var res = new List<TreeGridModel>();
            //首先按照
            foreach (var node in list)
            {
                node.hasChildren = false;
                node.complete = true;
                // 注册子节点映射表
                if (!childrenMap.ContainsKey(node.parentId))
                {
                    childrenMap.Add(node.parentId, new List<TreeGridModel>());
                }
                else if (parentMap.ContainsKey(node.parentId))
                {
                    parentMap[node.parentId].hasChildren = true;
                }
                childrenMap[node.parentId].Add(node);
                // 注册父节点映射节点表
                parentMap.Add(node.id, node);

                // 查找自己的子节点
                if (!childrenMap.ContainsKey(node.id))
                {
                    childrenMap.Add(node.id, new List<TreeGridModel>());
                }
                else
                {
                    node.hasChildren = true;
                }
                node.ChildNodes = childrenMap[node.id];
            }

            if (string.IsNullOrEmpty(parentId))
            {
                // 获取祖先数据列表
                foreach (var item in childrenMap)
                {
                    if (!parentMap.ContainsKey(item.Key))
                    {
                        res.AddRange(item.Value);
                    }
                }
            }
            else
            {
                if (childrenMap.ContainsKey(parentId))
                {
                    return childrenMap[parentId];
                }
                else
                {
                    return new List<TreeGridModel>();
                }
            }
            return res;
        }

        private static string TreeGridJson(List<TreeGridModel> data, int index, string parentId)
        {
            StringBuilder sb = new StringBuilder();
            var ChildNodeList = data.FindAll(t => t.parentId == parentId);
            if (ChildNodeList.Count > 0)
            {
                index++;
            }
            foreach (TreeGridModel entity in ChildNodeList)
            {
                string strJson = entity.entityJson;
                strJson = strJson.Insert(1, "\"loaded\":" + (entity.loaded == true ? false : true).ToString().ToLower() + ",");
                strJson = strJson.Insert(1, "\"expanded\":" + (entity.expanded).ToString().ToLower() + ",");
                strJson = strJson.Insert(1, "\"isLeaf\":" + (entity.isLeaf == true ? false : true).ToString().ToLower() + ",");
                strJson = strJson.Insert(1, "\"parent\":\"" + parentId + "\",");
                strJson = strJson.Insert(1, "\"level\":" + index + ",");
                sb.Append(strJson);
                sb.Append(TreeGridJson(data, index, entity.id));
            }
            return sb.ToString().Replace("}{", "},{");
        }
    }
}
