using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Marker;

namespace AVMarker
{
    public partial class Form1 : Form
    {
        //IP列表文件地址
        string filepath = Application.StartupPath + @"\ip.txt";
        public Form1()
        {
            InitializeComponent();
            btn_start.Click += btn_start_Click;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {//开始访问

            string url = txt_link.Text.Trim().ToLower();
            if (!url.Contains("http://"))
            {
                url = "http://" + url;
            }
            string ip = Tool.GetIP(filepath);
            MQueue<MSite> mq = new MQueue<MSite>();
            mq.DoMain+=mq_DoMain;
            MSite ms = new MSite()
            {
                HasVisited = false,
                IP = ip,
                Level = 0,
                URL = url
            };

        }

        /// <summary>
        /// 执行事件
        /// </summary>
        /// <param name="obj"></param>
        private void mq_DoMain(MSite obj)
        {
            /*
             * 将该对象放入到线程池中，等待执行完毕，则将该对象删除
             * */
            
        }
    }
}
