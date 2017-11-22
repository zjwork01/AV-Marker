using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace demo
{
    public partial class MainForm : Form
    {
        private Tool t = null;
        private readonly DateTime date = DateTime.Now;//运行程序的时间，即起始时间
        private System.Windows.Forms.Timer timer = null;
        private int currentIndex = 0;
        private int[] dateList = null;
        private int randomNumer = 0;
        private int randomMin = 0;
        private int randomMax = 0;
        private CountdownEvent countdoen = new CountdownEvent(1);

        public MainForm()
        {
            InitializeComponent();
        }



        private void MainForm_Load(object sender, EventArgs e)
        {
            if (t == null)
            {
                t = Tool.NewInstance();
            }

            btn_sure.Click += btn_sure_Click;
            web_show.ScriptErrorsSuppressed = true;
            web_show.DocumentCompleted += web_show_DocumentCompleted;
            number_Count.ValueChanged += number_Count_ValueChanged;
            number_time.ValueChanged += number_Count_ValueChanged;
            list_resultShow.MouseDoubleClick += list_resultShow_MouseDoubleClick;
            list_IP.MouseDoubleClick += list_resultShow_MouseDoubleClick;
            //设置最大次数和最长时间
            number_Count.Maximum = 1000;
            number_time.Maximum = 23 * 60 * 60;
            //设置初始值
            randomNumer = decimal.ToInt32(number_Count.Value);
            randomMax = decimal.ToInt32(number_time.Value);
            randomMin = 10;
            lbl_num.Text = "0";
            txt_url.Text = "http://2017.ip138.com/ic.asp";
            txt_urlconst.Text = "http://2017.ip138.com/ic.asp";
        }

        void list_resultShow_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListBox item = sender as ListBox;
            if (item.SelectedItem != null && item.SelectedItem.ToString() != "")
            {
                string msg = item.SelectedItem.ToString();
                string url = msg.Split(' ')[0];
                txt_agencyIP.Text = url;
                tabControl1.SelectedTab = tabPage2;
                btn_sure_Click(null, null);
            }
        }

        #region 自动代理

        /// <summary>
        /// 开始代理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_start_Click(object sender, EventArgs e)
        {
            //获取刷新网页的时间
            dateList = t.GetRandomArray(randomNumer, randomMin, randomMax);
            //获取代理IP列表
            list_IP.Items.AddRange(t.GetIPS());
            //设置状态
            lbl_stateShow.Text = "正在访问... ...";
            //开始获取网页数据
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            timer.Start();
        }

        /// <summary>
        /// 取消代理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_exist_Click(object sender, EventArgs e)
        {
            if (timer != null)
            {
                timer.Stop();
                timer.Dispose();
            }
        }

        /// <summary>
        /// 设置修改的时候刷新次数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void number_Count_ValueChanged(object sender, EventArgs e)
        {
            randomNumer = decimal.ToInt32(number_Count.Value);
            randomMax = decimal.ToInt32(number_time.Value);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (dateList.Contains(GetSeconds(DateTime.Now - date)))
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback((object obj) =>
                {
                    currentIndex++;
                    countdoen.AddCount();
                    string ip = t.GetIP();
                    string url = t.GetURL();
                    string path = Application.StartupPath + @"\html\" + currentIndex.ToString() + @".html";
                    try
                    {
                        Stream stream = null;
                        /**
                         * 共链接5次，连接成功返回，连接不成功失败
                         * */
                        int m = 0;
                        do
                        {
                            try
                            {
                                stream = t.RequestToURL(ip, url);
                                break;
                            }
                            catch
                            {
                                m++;
                            }
                        } while (m < 5);

                        if (stream != null)
                        {
                            this.BeginInvoke(new Action(() =>
                            {
                                list_resultShow.Items.Add(ip + " 链接成功 " + DateTime.Now.ToString("hh:mm:ss"));
                                lbl_num.Text = (Int32.Parse(lbl_num.Text.Trim()) + 1).ToString();
                            }));
                            //将流保存到文件中
                            if (!File.Exists(path))
                            {
                                File.Create(path).Close();
                            }
                            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                            byte[] data = new byte[1024];
                            int size = stream.Read(data, 0, data.Length);
                            while (size > 0)
                            {
                                fs.Write(data, 0, size);
                                size = stream.Read(data, 0, data.Length);
                            }
                            fs.Close();
                            stream.Close();
                            fs.Dispose();
                            stream.Dispose();
                            path = null;
                            data = null;
                        }
                    }
                    catch
                    {
                        this.BeginInvoke(new Action(() =>
                        {
                            list_resultShow.Items.Add(ip + " 链接失败 " + DateTime.Now.ToString("hh:mm:ss"));
                        }));
                    }
                    countdoen.Signal();
                    GC.Collect();
                }));
            }
            else if (GetSeconds(DateTime.Now - date) > dateList.Max())
            {
                //等待线程池中所有线程执行完毕方可结束
                timer.Stop();
                countdoen.Signal();
                countdoen.Wait();
                timer.Dispose();
                lbl_stateShow.Text = "访问结束";
            }
        }

        /// <summary>
        /// 获取一段时间的总秒数
        /// </summary>
        /// <param name="span"></param>
        /// <returns></returns>
        private int GetSeconds(TimeSpan span)
        {
            double seconds = span.TotalSeconds;
            return Convert.ToInt32(Math.Floor(seconds));
        }

        #endregion

        #region 手动代理

        void web_show_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {
                lbl_status.Text = "加载完成";
                web_show.DocumentStream.Close();
            }));
        }

        /// <summary>
        /// 搜索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_sure_Click(object sender, EventArgs e)
        {
            GC.Collect();
            Task task = new Task(new Action(() =>
            {
                this.BeginInvoke(new Action(() =>
                {
                    lbl_status.Text = "正在连接";
                }));
                string ip = txt_agencyIP.Text.Trim();
                string url = txt_url.Text.Trim();
                try
                {
                    Stream stream = t.RequestToURL(ip, url);
                    this.BeginInvoke(new Action(() =>
                    {
                        if (web_show.DocumentStream != null)
                        {
                            web_show.DocumentStream.Dispose();
                        } if (web_show.Document != null)
                        {
                            web_show.DocumentText = string.Empty;
                        }
                    }));
                    if (stream != null)
                    {
                        this.BeginInvoke(new Action(() =>
                        {
                            web_show.DocumentStream = stream;
                            string msg = ip + " 链接成功 " + DateTime.Now.ToString("hh:mm:ss");
                            list_result.Items.Add(msg);
                            lbl_status.Text = "连接成功";
                        }));
                    }
                    else
                    {
                        this.BeginInvoke(new Action(() =>
                        {
                            string msg = ip + " 链接失败 " + DateTime.Now.ToString("hh:mm:ss");
                            list_result.Items.Add(msg);
                            lbl_status.Text = "链接失败";
                        }));
                    }
                }
                catch
                {
                    this.BeginInvoke(new Action(() =>
                    {
                        string msg = ip + " 链接失败 " + DateTime.Now.ToString("hh:mm:ss");
                        list_result.Items.Add(msg);
                        lbl_status.Text = "链接失败";
                    }));
                }
            }));
            task.Start();
        }

        #endregion



    }

}
