namespace demo
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_num = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_exist = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.list_resultShow = new System.Windows.Forms.ListBox();
            this.list_IP = new System.Windows.Forms.ListBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_stateShow = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.number_time = new System.Windows.Forms.NumericUpDown();
            this.number_Count = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_urlconst = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_agencyIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.list_result = new System.Windows.Forms.ListBox();
            this.web_show = new System.Windows.Forms.WebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.btn_sure = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.number_time)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_Count)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1038, 589);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1030, 563);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "自动代理";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbl_num);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.btn_exist);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.list_resultShow);
            this.panel3.Controls.Add(this.list_IP);
            this.panel3.Controls.Add(this.btn_start);
            this.panel3.Location = new System.Drawing.Point(169, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(858, 508);
            this.panel3.TabIndex = 8;
            // 
            // lbl_num
            // 
            this.lbl_num.AutoSize = true;
            this.lbl_num.BackColor = System.Drawing.Color.Transparent;
            this.lbl_num.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_num.ForeColor = System.Drawing.Color.Red;
            this.lbl_num.Location = new System.Drawing.Point(251, 232);
            this.lbl_num.Name = "lbl_num";
            this.lbl_num.Size = new System.Drawing.Size(0, 16);
            this.lbl_num.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(228, 203);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 12;
            this.label11.Text = "访问页数：";
            // 
            // btn_exist
            // 
            this.btn_exist.Location = new System.Drawing.Point(224, 342);
            this.btn_exist.Name = "btn_exist";
            this.btn_exist.Size = new System.Drawing.Size(75, 23);
            this.btn_exist.TabIndex = 11;
            this.btn_exist.Text = "取消代理";
            this.btn_exist.UseVisualStyleBackColor = true;
            this.btn_exist.Click += new System.EventHandler(this.btn_exist_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(348, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "结果：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "代理IP列表：";
            // 
            // list_resultShow
            // 
            this.list_resultShow.FormattingEnabled = true;
            this.list_resultShow.ItemHeight = 12;
            this.list_resultShow.Location = new System.Drawing.Point(350, 30);
            this.list_resultShow.Name = "list_resultShow";
            this.list_resultShow.Size = new System.Drawing.Size(495, 472);
            this.list_resultShow.TabIndex = 8;
            // 
            // list_IP
            // 
            this.list_IP.FormattingEnabled = true;
            this.list_IP.ItemHeight = 12;
            this.list_IP.Location = new System.Drawing.Point(3, 30);
            this.list_IP.Name = "list_IP";
            this.list_IP.Size = new System.Drawing.Size(182, 472);
            this.list_IP.TabIndex = 7;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(224, 119);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 6;
            this.btn_start.Text = "开始代理";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_stateShow);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.number_time);
            this.groupBox3.Controls.Add(this.number_Count);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(3, 47);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(160, 508);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "设置";
            // 
            // lbl_stateShow
            // 
            this.lbl_stateShow.AutoSize = true;
            this.lbl_stateShow.Location = new System.Drawing.Point(12, 186);
            this.lbl_stateShow.Name = "lbl_stateShow";
            this.lbl_stateShow.Size = new System.Drawing.Size(0, 12);
            this.lbl_stateShow.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(92, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 12);
            this.label10.TabIndex = 4;
            this.label10.Text = "次";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(92, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 12);
            this.label9.TabIndex = 3;
            this.label9.Text = "秒";
            // 
            // number_time
            // 
            this.number_time.Location = new System.Drawing.Point(8, 113);
            this.number_time.Name = "number_time";
            this.number_time.Size = new System.Drawing.Size(76, 21);
            this.number_time.TabIndex = 1;
            // 
            // number_Count
            // 
            this.number_Count.Location = new System.Drawing.Point(8, 52);
            this.number_Count.Name = "number_Count";
            this.number_Count.Size = new System.Drawing.Size(76, 21);
            this.number_Count.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "最长时间";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "访问次数";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_urlconst);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1024, 38);
            this.panel2.TabIndex = 6;
            // 
            // txt_urlconst
            // 
            this.txt_urlconst.Location = new System.Drawing.Point(62, 8);
            this.txt_urlconst.Name = "txt_urlconst";
            this.txt_urlconst.ReadOnly = true;
            this.txt_urlconst.Size = new System.Drawing.Size(957, 21);
            this.txt_urlconst.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "URL：";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1030, 563);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "手动代理";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(1, 41);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.web_show);
            this.splitContainer1.Size = new System.Drawing.Size(1029, 532);
            this.splitContainer1.SplitterDistance = 385;
            this.splitContainer1.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_status);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_agencyIP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 110);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "代理服务器设置";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_status.ForeColor = System.Drawing.Color.Red;
            this.lbl_status.Location = new System.Drawing.Point(68, 66);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(0, 16);
            this.lbl_status.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "Status：";
            // 
            // txt_agencyIP
            // 
            this.txt_agencyIP.Location = new System.Drawing.Point(67, 23);
            this.txt_agencyIP.Name = "txt_agencyIP";
            this.txt_agencyIP.Size = new System.Drawing.Size(237, 21);
            this.txt_agencyIP.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "IP：";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.list_result);
            this.groupBox2.Location = new System.Drawing.Point(2, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 406);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "访问信息";
            // 
            // list_result
            // 
            this.list_result.BackColor = System.Drawing.SystemColors.Control;
            this.list_result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_result.FormattingEnabled = true;
            this.list_result.ItemHeight = 12;
            this.list_result.Location = new System.Drawing.Point(3, 17);
            this.list_result.Name = "list_result";
            this.list_result.Size = new System.Drawing.Size(369, 386);
            this.list_result.TabIndex = 0;
            // 
            // web_show
            // 
            this.web_show.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.web_show.Location = new System.Drawing.Point(2, 3);
            this.web_show.MinimumSize = new System.Drawing.Size(20, 20);
            this.web_show.Name = "web_show";
            this.web_show.ScriptErrorsSuppressed = true;
            this.web_show.Size = new System.Drawing.Size(637, 519);
            this.web_show.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_url);
            this.panel1.Controls.Add(this.btn_sure);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 35);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "网址";
            // 
            // txt_url
            // 
            this.txt_url.Location = new System.Drawing.Point(60, 10);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(813, 21);
            this.txt_url.TabIndex = 0;
            this.txt_url.Text = "http://2017.ip138.com/ic.asp";
            // 
            // btn_sure
            // 
            this.btn_sure.Location = new System.Drawing.Point(895, 10);
            this.btn_sure.Name = "btn_sure";
            this.btn_sure.Size = new System.Drawing.Size(75, 23);
            this.btn_sure.TabIndex = 3;
            this.btn_sure.Text = "search";
            this.btn_sure.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 589);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "代理IP访问网站";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.number_time)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_Count)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_agencyIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox list_result;
        private System.Windows.Forms.WebBrowser web_show;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.Button btn_sure;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_urlconst;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_exist;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox list_resultShow;
        private System.Windows.Forms.ListBox list_IP;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown number_Count;
        private System.Windows.Forms.NumericUpDown number_time;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_num;
        private System.Windows.Forms.Label lbl_stateShow;


    }
}