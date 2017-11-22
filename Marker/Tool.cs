using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Marker
{
    class Tool
    {

        private static string filepath = string.Empty;
        /// <summary>
        /// 截取域名
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static string SubStringURL(string url)
        {
            try
            {
                string link = url.ToLower();
                string result = string.Empty;
                if (link.Contains(".com"))
                {
                    result = link.Substring(0, link.IndexOf(".com") + 4);
                }
                else if (link.Contains(".cn"))
                {
                    result = link.Substring(0, link.IndexOf(".cn") + 3);
                }
                else if (link.Contains(".net"))
                {
                    result = link.Substring(0, link.IndexOf(".net") + 4);
                }
                else if (link.Contains(".org"))
                {
                    result = link.Substring(0, link.IndexOf(".org") + 4);
                }
                return result;
            }
            catch { return ""; }
        }
        /// <summary>
        /// 判断字符串中是否包含域名
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static bool IsContainsORG(string url)
        {
            try
            {
                string link = url.ToLower();
                bool result = false;
                if (link.Contains(".com"))
                {
                    result = true;
                }
                else if (link.Contains(".cn"))
                {
                    result = true;
                }
                else if (link.Contains(".net"))
                {
                    result = true;
                }
                else if (link.Contains(".org"))
                {
                    result = true;
                }
                return result;
            }
            catch { return false; }
        }

        /// <summary>
        /// 链接到指定的网页
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static Stream RequestToURL(string url)
        {
            //随机获取一个IP，然后用该IP访问链接
            return RequestToURL(filepath, url);
        }

        /// <summary>
        /// 用指定的代理IP连接到指定的网页
        /// </summary>
        /// <param name="IP">代理IP</param>
        /// <param name="url">网站URL</param>
        /// <returns>请求响应流</returns>
        public static Stream RequestToURL(string IP, string url)
        {
            HttpWebResponse response = null;
            try
            {
                HttpWebRequest request = WebRequest.CreateHttp(url);
                WebProxy proxy = new WebProxy(IP, false);
                request.Proxy = proxy;
                request.Method = "GET";
                request.UserAgent = @"Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; Trident/5.0; BOIE9;Z";
                System.Net.Cache.RequestCachePolicy cache = new System.Net.Cache.RequestCachePolicy(System.Net.Cache.RequestCacheLevel.NoCacheNoStore);
                request.CachePolicy = cache;
                response = (HttpWebResponse)request.GetResponse();
                return response.GetResponseStream();
            }
            catch
            {
                throw new Exception("连接不到指定的URL");
            }
        }
        /// <summary>
        /// 在固定范围内随机生成指定个数的不同的随机数
        /// </summary>
        /// <param name="num">随机数的个数</param>
        /// <param name="min">范围下限（>0）</param>
        /// <param name="max">范围上限</param>
        /// <returns>随机数组</returns>
        public static int[] GetRandomArray(int num, int min, int max)
        {
            int[] array = new int[num];
            HashSet<int> hs = new HashSet<int>();
            Random rm = new Random();
            for (int i = 0; hs.Count < num; i++)
            {
                int temp = rm.Next(min, max + 1);
                if (!hs.Contains(temp))
                {
                    hs.Add(temp);
                }
            }
            array = hs.ToArray<int>();
            Array.Sort(array);
            return array;
        }

        /// <summary>
        /// 设置IP列表文件地址
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string SetFilepath(string path)
        {
            return path;
        }

        /// <summary>
        /// 获取代理IP
        /// </summary>
        /// <returns></returns>
        public static string GetIP(string filepath)
        {
            string path = filepath;
            string content = ReadFile(path);
            string[] list = content.Split('\n');
            int m = GetRandomArray(1, 0, list.Length - 1)[0];
            return list[m].Trim();
        }

        /// <summary>
        /// 读取文件
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string ReadFile(string path)
        {
            FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
            byte[] data = new byte[stream.Length];
            int length = data.Length;
            int offset = 0;
            while (length > 0)
            {
                int read = stream.Read(data, offset, length);
                if (read <= 0)
                {
                    throw new Exception("文件读取到" + read.ToString() + "失败");
                }
                length -= read;
                offset += read;
            }
            string result = Encoding.UTF8.GetString(data);
            return result;
        }

        /// <summary>
        /// 根据指定编码方式解析文件流
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="encode"></param>
        public static string StreamToText(Stream stream,Encoding encode)
        {
            try
            {
                StreamReader reader = new StreamReader(stream, encode);
                string result = reader.ReadToEnd();
                return result;
            }
            catch{ return ""; }
        }
        /// <summary>
        /// 解析文件流
        /// </summary>
        /// <param name="stream"></param>
        public static string StreamToText(Stream stream)
        {
            return StreamToText(stream, Encoding.UTF8);
        }

        /// <summary>
        /// 从文本中获取所有链接，并返回
        /// </summary>
        /// <param name="content"></param>
        public static List<string> GetContentURLS(string content)
        {
            List<string> result = new List<string>();
            string pattern = "<a[^>]*href=\"(?<link>[^>]*?)\"[^>]*>";
            Regex reg = new Regex(pattern);
            MatchCollection smc = reg.Matches(content);
            foreach (Match sm in smc)
            {
                string link = sm.Groups["link"].Value;
                if (link != "")
                {
                    result.Add(link);
                }
            }
            return result;
        }


    }
}
