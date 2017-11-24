using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marker
{
    /// <summary>
    /// 站点信息
    /// </summary>
    public class MSite
    {
        /// <summary>
        /// 当前节点的链接地址
        /// </summary>
        public string URL;
        /// <summary>
        /// 浏览标识符，True:该链接已经被浏览   False:该链接还未被浏览
        /// </summary>
        public bool HasVisited;
        /// <summary>
        /// 当前链接的等级，0为根节点
        /// </summary>
        public int Level;
        /// <summary>
        /// 当前节点的父节点
        /// </summary>
        public MSite Parents;
        /// <summary>
        /// 当前节点的孩子节点
        /// </summary>
        public List<MSite> Childen;
        
    }
}
