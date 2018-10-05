using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsTestApp
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //跳轉API
            string strUri = string.Format("https://www.kuaidi100.com/chaxun?com={0}&nu={1}", comboBox_com.Text, textBox_nu.Text);
            Process.Start(strUri);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //手機查詢API
            //注意!!type參數必須使用英文代號
            string strUri = string.Format("https://m.kuaidi100.com/index_all.html?type={0}&postid={1}", comboBox_type.Text, textBox_postid.Text);
            Process.Start(strUri);
        }
    }
}
