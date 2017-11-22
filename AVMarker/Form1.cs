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
            MQueue<MSite> mq = MQueue<MSite>.GetInstance();
        }
    }
}
