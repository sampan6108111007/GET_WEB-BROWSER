using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GET_WEB_BROWSER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.TabStop = false;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

            button2.TabStop = false;
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

            button3.TabStop = false;
            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

            button4.TabStop = false;
            button4.FlatStyle = FlatStyle.Flat;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

  
        }

        private void button1_Click(object sender, EventArgs e)
        {

            webBrowser1.Navigate("http://www.lptcoop.com:82/member/FrmLogin.aspx");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            webBrowser1.Navigate("http://www.lptcoop.com:82/member/main.aspx");
        }

        private void button3_Click(object sender, EventArgs e)
        {

            webBrowser1.Navigate("http://www.lptcoop.com:82/member/main.aspx");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.lptcoop.com/lptcoop/%e0%b8%a3%e0%b8%b0%e0%b9%80%e0%b8%9a%e0%b8%b5%e0%b8%a2%e0%b8%9a-%e0%b8%82%e0%b9%89%e0%b8%ad%e0%b8%9a%e0%b8%b1%e0%b8%87%e0%b8%84%e0%b8%b1%e0%b8%9a/");
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
