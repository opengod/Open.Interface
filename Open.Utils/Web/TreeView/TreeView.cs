using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Open.Utils
{
    public static class TreeView
    {
        /// <summary>
        /// 树形数据转化
        /// </summary>
        /// <param name="list">数据</param>
        /// <returns></returns>
        public static List<TreeViewModel> ToTree(this List<TreeViewModel> list, string parentId = "")
        {
            Dictionary<string, List<TreeViewModel>> childrenMap = new Dictionary<string, List<TreeViewModel>>();
            Dictionary<string, TreeViewModel> parentMap = new Dictionary<string, TreeViewModel>();
            var res = new List<TreeViewModel>();

            //首先按照
            foreach (var node in list)
            {
                node.hasChildren = false;
                node.complete = true;
                // 注册子节点映射表
                if (!childrenMap.ContainsKey(node.parentId))
                {
                    childrenMap.Add(node.parentId, new List<TreeViewModel>());
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
                    childrenMap.Add(node.id, new List<TreeViewModel>());
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
                    return new List<TreeViewModel>();
                }
            }
            return res;
        }

        public static string TreeViewJson(this List<TreeViewModel> data, string parentId = "0")
        {
            //SetNodeParentCheckState(data);//设置已选中节点的上级的选中状态

            StringBuilder strJson = new StringBuilder();
            List<TreeViewModel> item = data.FindAll(t => t.parentId == parentId);
            strJson.Append("[");
            if (item.Count > 0)
            {
                foreach (TreeViewModel entity in item)
                {
                    strJson.Append("{");
                    strJson.Append("\"id\":\"" + entity.id + "\",");
                    strJson.Append("\"text\":\"" + entity.text.Replace("\n", "") + "\",");
                    if (entity.iconState != null)
                    {
                        strJson.Append("\"iconState\":\"" + entity.iconState.Replace("&nbsp;", "") + "\",");
                    }
                    strJson.Append("\"extend\":\"" + entity.extend + "\",");
                    strJson.Append("\"extend2\":\"" + entity.extend2 + "\",");
                    strJson.Append("\"value\":\"" + entity.value + "\",");
                    if (entity.title != null && !string.IsNullOrEmpty(entity.title.Replace("&nbsp;", "")))
                    {
                        strJson.Append("\"title\":\"" + entity.title.Replace("&nbsp;", "") + "\",");
                    }
                    if (entity.img != null && !string.IsNullOrEmpty(entity.img.Replace("&nbsp;", "")))
                    {
                        strJson.Append("\"img\":\"" + entity.img.Replace("&nbsp;", "") + "\",");
                    }
                    if (entity.checkstate != null)
                    {
                        strJson.Append("\"checkstate\":" + entity.checkstate + ",");
                    }
                    if (entity.parentId != null)
                    {
                        strJson.Append("\"parentnodes\":\"" + entity.parentId + "\",");
                    }
                    strJson.Append("\"showcheck\":" + entity.showcheck.ToString().ToLower() + ",");
                    strJson.Append("\"isexpand\":" + entity.isexpand.ToString().ToLower() + ",");
                    if (entity.complete == true)
                    {
                        strJson.Append("\"complete\":" + entity.complete.ToString().ToLower() + ",");
                    }
                    strJson.Append("\"hasChildren\":" + entity.hasChildren.ToString().ToLower() + ",");
                    strJson.Append("\"ChildNodes\":" + TreeViewJson(data, entity.id) + "");
                    strJson.Append("},");
                }
                strJson = strJson.Remove(strJson.Length - 1, 1);
            }
            strJson.Append("]");
            return strJson.ToString();
        }

        /// <summary>
        /// 设置已选中节点的上级的选中状态
        /// </summary>
        private static void SetNodeParentCheckState(List<TreeViewModel> data)
        {
            var checkNodes = data.FindAll(n => n.checkstate == 1);

            //设置部分选中
            foreach (var checkNode in checkNodes)
            {
                var parentNode = data.Find(n => n.id == checkNode.parentId);
                if (parentNode != null)
                {
                    parentNode.checkstate = 2;
                    SetParentNodeCheckState(parentNode, data);
                }
            }

            //设置全部选中
            checkNodes = data.FindAll(n => n.checkstate == 2);
            foreach (var checkNode in checkNodes)
            {
                var childNodes = data.FindAll(n => n.parentId == checkNode.id);
                if (childNodes.All(n => n.checkstate != 0))
                {
                    checkNode.checkstate = 1;
                }
            }
        }

        private static void SetParentNodeCheckState(TreeViewModel node, List<TreeViewModel> data)
        {
            var parentNode = data.Find(n => n.id == node.parentId);
            if (parentNode != null)
            {
                parentNode.checkstate = 2;
                SetParentNodeCheckState(parentNode, data);
            }
        }

        public static string TopTreeViewJson(this List<TreeViewModel> data, string topId)
        {
            StringBuilder strJson = new StringBuilder();
            List<TreeViewModel> item = data.FindAll(t => t.id == topId);
            strJson.Append("[");
            if (item.Count > 0)
            {
                foreach (TreeViewModel entity in item)
                {
                    strJson.Append("{");
                    strJson.Append("\"id\":\"" + entity.id + "\",");
                    strJson.Append("\"text\":\"" + entity.text.Replace("&nbsp;", "") + "\",");
                    strJson.Append("\"value\":\"" + entity.value + "\",");
                    if (entity.title != null && !string.IsNullOrEmpty(entity.title.Replace("&nbsp;", "")))
                    {
                        strJson.Append("\"title\":\"" + entity.title.Replace("&nbsp;", "") + "\",");
                    }
                    if (entity.img != null && !string.IsNullOrEmpty(entity.img.Replace("&nbsp;", "")))
                    {
                        strJson.Append("\"img\":\"" + entity.img.Replace("&nbsp;", "") + "\",");
                    }
                    if (entity.checkstate != null)
                    {
                        strJson.Append("\"checkstate\":" + entity.checkstate + ",");
                    }
                    if (entity.parentId != null)
                    {
                        strJson.Append("\"parentnodes\":\"" + entity.parentId + "\",");
                    }
                    strJson.Append("\"showcheck\":" + entity.showcheck.ToString().ToLower() + ",");
                    strJson.Append("\"isexpand\":" + entity.isexpand.ToString().ToLower() + ",");
                    if (entity.complete == true)
                    {
                        strJson.Append("\"complete\":" + entity.complete.ToString().ToLower() + ",");
                    }
                    strJson.Append("\"hasChildren\":" + entity.hasChildren.ToString().ToLower() + ",");
                    strJson.Append("\"ChildNodes\":" + TreeViewJson(data, entity.id) + "");
                    strJson.Append("},");
                }
                strJson = strJson.Remove(strJson.Length - 1, 1);
            }
            strJson.Append("]");
            return strJson.ToString();
        }
    }
}
