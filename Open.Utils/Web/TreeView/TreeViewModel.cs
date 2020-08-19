using System.Collections.Generic;

namespace Open.Utils
{
    public class TreeViewModel
    {
        /// <summary>
        /// 父级节点ID
        /// </summary>
        public string parentId { get; set; }
        /// <summary>
        /// 节点id
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 节点显示数据
        /// </summary>
        public string text { get; set; }
        /// <summary>
        /// 节点提示
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 节点数值
        /// </summary>
        public string value { get; set; }
        /// <summary>
        /// 显示图标
        /// </summary>
        public string img { get; set; }
        /// <summary>
        /// 是否显示勾选框
        /// </summary>
        public bool showcheck { get; set; }
        /// <summary>
        /// 是否被勾选0 for unchecked, 1 for checked, 2 for partial checked 
        /// </summary>
        public int? checkstate { get; set; }
        /// <summary>
        /// 是否展开
        /// </summary>
        public bool isexpand { get; set; }
        /// <summary>
        /// 子节点是否已经加载完成了
        /// </summary>
        public bool complete { get; set; }
        /// <summary>
        /// 是否有子节点
        /// </summary>
        public bool hasChildren { get; set; }
        /// <summary>
        /// 文字图标
        /// </summary>
        public string iconState { get; set; }
        /// <summary>
        /// 节点路径
        /// </summary>
        public string path { get; set; }
        /// <summary>
        /// 扩展数据1
        /// </summary>
        public string extend { get; set; }
        /// <summary>
        /// 扩展数据2
        /// </summary>
        public string extend2 { get; set; }
        /// <summary>
        /// 排序码
        /// </summary>
        public int sortCode { get; set; }
        /// <summary>
        /// 子节点列表数据
        /// </summary>
        public List<TreeViewModel> ChildNodes { get; set; }
    }
}
