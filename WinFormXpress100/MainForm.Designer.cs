namespace WinFormsTestApp
{
    partial class formMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_nu = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_postid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox_com = new System.Windows.Forms.ComboBox();
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_com);
            this.groupBox1.Controls.Add(this.textBox_nu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(606, 121);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "跳轉API";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(431, 29);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 65);
            this.button1.TabIndex = 1;
            this.button1.Text = "跳轉API";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "com(快递公司的代码)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "nu(快递单号)";
            // 
            // textBox_nu
            // 
            this.textBox_nu.Location = new System.Drawing.Point(204, 65);
            this.textBox_nu.Name = "textBox_nu";
            this.textBox_nu.Size = new System.Drawing.Size(205, 29);
            this.textBox_nu.TabIndex = 5;
            this.textBox_nu.Text = "640006627095";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox_type);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.textBox_postid);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(14, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(606, 121);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "手機查詢API";
            // 
            // textBox_postid
            // 
            this.textBox_postid.Location = new System.Drawing.Point(204, 65);
            this.textBox_postid.Name = "textBox_postid";
            this.textBox_postid.Size = new System.Drawing.Size(205, 29);
            this.textBox_postid.TabIndex = 9;
            this.textBox_postid.Text = "640006627095";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "postid(快递单号)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "type(快递公司的代码)";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(431, 29);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 65);
            this.button2.TabIndex = 10;
            this.button2.Text = "手機查詢API";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // comboBox_com
            // 
            this.comboBox_com.FormattingEnabled = true;
            this.comboBox_com.Items.AddRange(new object[] {
            "全球专递",
            "安捷快递",
            "安信达快递",
            "彪记快递",
            "bht",
            "百福东方国际物流",
            "中国东方",
            "长宇物流",
            "大田物流",
            "德邦物流",
            "dhl",
            "dpex",
            "速快递",
            "递四方",
            "快递",
            "fedex",
            "飞康达物流",
            "凤凰快递",
            "飞快达",
            "国通快递",
            "港中能达物流",
            "广东邮政物流",
            "共速达",
            "汇通快运",
            "恒路物流",
            "华夏龙物流",
            "海红",
            "海外环球",
            "佳怡物流",
            "京广速递",
            "急先达",
            "佳吉物流",
            "加运美物流",
            "金大物流",
            "嘉里大通",
            "晋越快递",
            "快捷速递",
            "联邦快递",
            "联昊通物流",
            "龙邦物流",
            "立即送",
            "乐捷递",
            "民航快递",
            "美国快递",
            "门对门",
            "OCS",
            "配思货运",
            "全晨快递",
            "全峰快递",
            "全际通物流",
            "全日通快递",
            "全一快递",
            "如风达",
            "三态速递",
            "盛辉物流",
            "申通",
            "顺丰",
            "速尔物流",
            "盛丰物流",
            "赛澳递",
            "天地华宇",
            "天天快递",
            "tnt",
            "ups",
            "万家物流",
            "文捷航空速递",
            "伍圆",
            "万象物流",
            "新邦物流",
            "信丰物流",
            "亚风速递",
            "一邦速递",
            "优速物流",
            "邮政包裹挂号信",
            "邮政国际包裹挂号信",
            "远成物流",
            "圆通速递",
            "源伟丰快递",
            "元智捷诚快递",
            "韵达快运",
            "运通快递",
            "越丰物流",
            "源安达",
            "银捷速递",
            "宅急送",
            "中铁快运",
            "中通速递",
            "中邮物流",
            "忠信达",
            "芝麻开门"});
            this.comboBox_com.Location = new System.Drawing.Point(204, 31);
            this.comboBox_com.Name = "comboBox_com";
            this.comboBox_com.Size = new System.Drawing.Size(205, 28);
            this.comboBox_com.TabIndex = 3;
            this.comboBox_com.Text = "中通速递";
            // 
            // comboBox_type
            // 
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Items.AddRange(new object[] {
            "aae",
            "anjie",
            "anxindakuaixi",
            "biaojikuaidi",
            "bht",
            "baifudongfang",
            "coe",
            "changyuwuliu",
            "datianwuliu",
            "debangwuliu",
            "dhl",
            "dpex",
            "dsukuaidi",
            "disifang",
            "ems",
            "fedex",
            "feikangda",
            "fenghuangkuaidi",
            "feikuaida",
            "guotongkuaidi",
            "ganzhongnengda",
            "guangdongyouzhengwuliu",
            "gongsuda",
            "huitongkuaidi",
            "hengluwuliu",
            "huaxialongwuliu",
            "haihongwangsong",
            "haiwaihuanqiu",
            "jiayiwuliu",
            "jinguangsudikuaijian",
            "jixianda",
            "jjwl",
            "jymwl",
            "jindawuliu",
            "jialidatong",
            "jykd",
            "kuaijiesudi",
            "lianb",
            "lianhaowuliu",
            "longbanwuliu",
            "lijisong",
            "lejiedi",
            "minghangkuaidi",
            "meiguokuaidi",
            "menduimen",
            "ocs",
            "peisihuoyunkuaidi",
            "quanchenkuaidi",
            "quanfengkuaidi",
            "quanjitong",
            "quanritongkuaidi",
            "quanyikuaidi",
            "rufengda",
            "santaisudi",
            "shenghuiwuliu",
            "shentong",
            "shunfeng",
            "sue",
            "shengfeng",
            "saiaodi",
            "tiandihuayu",
            "tiantian",
            "tnt tnt",
            "ups ups",
            "wanjiawuliu",
            "wenjiesudi",
            "wuyuan",
            "wxwl",
            "xinbangwuliu",
            "xinfengwuliu",
            "yafengsudi",
            "yibangwuliu",
            "youshuwuliu",
            "youzhengguonei",
            "youzhengguoji",
            "yuanchengwuliu",
            "yuantong",
            "yuanweifeng",
            "yuanzhijiecheng",
            "yunda",
            "yuntongkuaidi",
            "yuefengwuliu",
            "yad",
            "yinjiesudi",
            "zhaijisong",
            "zhongtiekuaiyun",
            "zhongtong",
            "zhongyouwuliu",
            "zhongxinda",
            "zhimakaimen"});
            this.comboBox_type.Location = new System.Drawing.Point(204, 31);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(205, 28);
            this.comboBox_type.TabIndex = 8;
            this.comboBox_type.Text = "zhongtong";
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 280);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "快遞100 API呼叫範例";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_nu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_postid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox_com;
        private System.Windows.Forms.ComboBox comboBox_type;
    }
}

