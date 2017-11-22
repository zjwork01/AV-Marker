using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class Tool
    {
        private Tool() { }

        private static Tool t = null;
        private const int INTERNET_OPTION_REFRESH = 0x000025;
        private const int INTERNET_OPTION_SETTINGS_CHANGED = 0x000027;

        public static Tool NewInstance()
        {
            if (t == null)
            {
                t = new Tool();
            }
            return t;
        }

        /// <summary>
        /// 链接到指定的URL
        /// </summary>
        /// <param name="url">指定的URL</param>
        /// <returns>请求响应流</returns>
        public Stream RequestToURL(string url)
        {
            try
            {
                HttpWebRequest request = WebRequest.CreateHttp(url);
                request.Method = "GET";
                request.UserAgent = @"Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; Trident/5.0; BOIE9;Z";
                System.Net.Cache.RequestCachePolicy cache = new System.Net.Cache.RequestCachePolicy(System.Net.Cache.RequestCacheLevel.NoCacheNoStore);
                request.CachePolicy = cache;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                return response.GetResponseStream();
            }
            catch { throw new Exception("连接不到指定的URL"); }
        }

        /// <summary>
        /// 用指定的代理IP连接到指定的网站
        /// </summary>
        /// <param name="IP">代理IP</param>
        /// <param name="url">网站URL</param>
        /// <returns>请求响应流</returns>
        public Stream RequestToURL(string IP, string url)
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

        #region 设置代理IP=======private bool SetIP(string ip)==========

        /// <summary>
        /// 设置代理IP
        /// </summary>
        /// <param name="ip"></param>
        private bool SetIP(string ip)
        {
            GC.Collect();
            try
            {
                //设置相关注册表项
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Internet Settings", true);
                if (key.GetValue("ProxyServer") != null)
                {
                    key.DeleteValue("ProxyServer");
                }
                key.SetValue("ProxyOverride", "<local>");//设置不适用代理服务器的时候的IP
                key.SetValue("ProxyServer", ip);//代理服务器的IP和端口
                key.SetValue("ProxyEnable", "dword:00000001");
                key.Close();
                //刷新
                InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
                InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
                //InternetSetOption(IntPtr.Zero, 39, IntPtr.Zero, 0);
                //InternetSetOption(IntPtr.Zero, 37, IntPtr.Zero, 0);

                RefreshIESettings(ip);
                IEProxy ie = new IEProxy(ip);
                bool result = ie.RefreshIESettings();
                return result;
            }
            catch { return false; }

        }

        /// <summary>
        /// 取消设置代理IP
        /// </summary>
        /// <returns></returns>
        private bool ExistIP()
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Internet Settings", true);
                if (key.GetValue("ProxyServer") != null || key.GetValue("ProxyServer").ToString() != "")
                {
                    key.DeleteValue("ProxyServer");
                }
                key.SetValue("ProxyEnable", "dword:00000000");
                key.Close();
                //刷新
                InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
                InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
                //InternetSetOption(IntPtr.Zero, 39, IntPtr.Zero, 0);
                //InternetSetOption(IntPtr.Zero, 37, IntPtr.Zero, 0);

                RefreshIESettings(string.Empty);
                IEProxy ie = new IEProxy(string.Empty);
                return ie.RefreshIESettings();
            }
            catch { return false; }
        }

        private void RefreshIESettings(string strProxy)
        {
            const int INTERNET_OPTION_PROXY = 38;
            const int INTERNET_OPEN_TYPE_PROXY = 3;
            const int INTERNET_OPEN_TYPE_DIRECT = 1;

            Struct_INTERNET_PROXY_INFO struct_IPI;
            // Filling in structure  
            struct_IPI.dwAccessType = INTERNET_OPEN_TYPE_PROXY;
            struct_IPI.proxy = Marshal.StringToHGlobalAnsi(strProxy);
            struct_IPI.proxyBypass = Marshal.StringToHGlobalAnsi("local");

            // Allocating memory  
            IntPtr intptrStruct = Marshal.AllocCoTaskMem(Marshal.SizeOf(struct_IPI));
            if (string.IsNullOrEmpty(strProxy) || strProxy.Trim().Length == 0)
            {
                strProxy = string.Empty;
                struct_IPI.dwAccessType = INTERNET_OPEN_TYPE_DIRECT;

            }
            // Converting structure to IntPtr  
            Marshal.StructureToPtr(struct_IPI, intptrStruct, true);

            InternetSetOption(IntPtr.Zero, INTERNET_OPTION_PROXY, intptrStruct, Marshal.SizeOf(struct_IPI));
        }
        [DllImport("wininet.dll", SetLastError = true)]
        private static extern bool InternetSetOption(IntPtr hInternet, int dwOption, IntPtr lpBuffer, int lpdwBufferLength);


        #endregion

        /// <summary>
        /// 在固定范围内随机生成指定个数的不同的随机数
        /// </summary>
        /// <param name="num">随机数的个数</param>
        /// <param name="min">范围下限（>0）</param>
        /// <param name="max">范围上限</param>
        /// <returns>随机数组</returns>
        public int[] GetRandomArray(int num, int min, int max)
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
        /// 获取代理IP
        /// </summary>
        /// <returns></returns>
        public string GetIP()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"\IP\IPList.txt";
            string content = Read(path);
            string[] list = content.Split('\n');
            int m = GetRandomArray(1, 0, list.Length - 1)[0];
            return list[m].Trim();
        }

        /// <summary>
        /// 获取所有的代理IP
        /// </summary>
        /// <returns></returns>
        public string[] GetIPS()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"\IP\IPList.txt";
            string content = Read(path);
            string[] list = content.Split('\n');
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = list[i].Trim();
            }
            return list;
        }

        private string Read(string path)
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

        public string GetURL()
        {
            return "http://2017.ip138.com/ic.asp";
        }
    }
}
