using System.Collections.Generic;
using System.Text;

namespace Open.Utils
{
    public static class TreeSelect
    {
        public static string TreeSelectJson(this List<TreeSelectModel> data, string initialValue)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            sb.Append(TreeSelectJson(data, initialValue, ""));
            sb.Append("]");
            return sb.ToString();
        }


        public static string SubTreeSelectJson(this List<TreeSelectModel> data)
        {
            StringBuilder sb1 = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();
            var tabline = "";
            sb1.Append("[");
            foreach (TreeSelectModel entity in data)
            {
                entity.text = tabline + entity.text;
                string strJson = entity.ToJson();
                sb2.Append(strJson);
                sb2.Append(TreeSelectJson(data, entity.id, tabline));
            }
            sb1.Append(sb2.ToString().Replace("}{", "},{"));
            sb1.Append("]");
            string tree = sb1.ToString();
            return tree;
        }

        private static string TreeSelectJson(List<TreeSelectModel> data, string parentId, string blank)
        {
            StringBuilder sb = new StringBuilder();
            var ChildNodeList = data.FindAll(t => t.parentId == parentId);
            var tabline = "";
            if (parentId != "0" && parentId != "-1")
            {
                tabline = "　　";
            }
            if (ChildNodeList.Count > 0)
            {
                tabline = tabline + blank;
            }
            foreach (TreeSelectModel entity in ChildNodeList)
            {
                entity.text = tabline + entity.text;
                string strJson = entity.ToJson();
                sb.Append(strJson);
                sb.Append(TreeSelectJson(data, entity.id, tabline));
            }
            return sb.ToString().Replace("}{", "},{");
        }
    }
}