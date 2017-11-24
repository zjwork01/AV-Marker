using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Marker;

namespace AVMarker
{
    class Run
    {
        private static string ORG = string.Empty;
        /// <summary>
        /// 从根目录开始执行
        /// </summary>
        /// <param name="startURL"></param>
        public static void Start(string startURL)
        {//开始执行
            /**
             * 1.请求根目录页面，并将页面的站内链接保存起来
             * 2.随机取出3-6个并加入到线程池中执行
             * 3.将新加载的页面中所有的站内链接保存起来，并循环执行第二步
             * 4.确定深度为4-5个页面
             * */
            //截取域名
            ORG = Tool.SubStringURL(startURL);
            MSite root = new MSite(){URL=startURL,Level=0,Parents=null,HasVisited=true};
            List<string> nodeList = Tool.GetContentURLS(Tool.StreamToText(Tool.RequestToURL(startURL),Encoding.GetEncoding("utf-8")));
            foreach(string temp in nodeList)
            {
                MSite ms = new MSite()
                {
                    Level = root.Level + 1,
                    Parents = root,
                    URL = temp,
                    HasVisited = false,
                    Childen = new List<MSite>()
                };
                root.Childen.Add(ms);
            }
            //获取一级链接
            

        }
    }
}
