using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marker
{
    public class MSite
    {
        private string ip;
        public string IP
        {
            get
            {
                return ip;
            }
            set
            {
                this.ip = value;
            }
        }

        private int level;
        /// <summary>
        /// 链接等级 根目录等级为0，依次延伸
        /// </summary>
        public int Level
        {
            get { return level; }
            set { level = value; }
        }

        private string domain;
        /// <summary>
        /// 域名
        /// </summary>
        public string DoMain
        {
            get
            {
                return domain;
            }
        }

        private string url;
        /// <summary>
        /// 链接地址
        /// </summary>
        public string URL
        {
            get { return url; }
            set
            {
                this.url = value.ToLower();
                if (url != "" && level == 0)
                {
                    this.domain = Tool.SubStringURL(url);
                }
                if (!Tool.IsContainsORG(url))
                {
                    if (Tool.IsContainsORG(domain))
                    {
                        url = domain + url;
                    }
                }
            }
        }
        /// <summary>
        /// 表示是否已访问 True：已访问 False：未访问 默认为False
        /// </summary>
        public bool HasVisited { get; set; }
    }
}
