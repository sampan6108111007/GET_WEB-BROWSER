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
    public partial class Form2 : Form
    {
        public Form2()
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

            button5.TabStop = false;
            button5.FlatStyle = FlatStyle.Flat;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

            webBrowser1.Navigating += webBrowser1_Navigating;
  
        }

        private void button1_Click(object sender, EventArgs e)
        {

            webBrowser1.Navigate("http://www.lptcoop.com/lptcoop/%e0%b8%84%e0%b8%b3%e0%b8%aa%e0%b8%b1%e0%b9%88%e0%b8%87-3/");
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
            string pdfLink = "http://www.lptcoop.com/lptcoop/%e0%b8%a3%e0%b8%b0%e0%b9%80%e0%b8%9a%e0%b8%b5%e0%b8%a2%e0%b8%9a-%e0%b8%82%e0%b9%89%e0%b8%ad%e0%b8%9a%e0%b8%b1%e0%b8%87%e0%b8%84%e0%b8%b1%e0%b8%9a/";

        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            // Check if the URL points to a PDF file
            if (e.Url.AbsolutePath.EndsWith(".pdf", StringComparison.OrdinalIgnoreCase))
            {
                // Cancel the navigation within the WebBrowser control
                e.Cancel = true;

                // Open the PDF link externally using the default PDF viewer
                System.Diagnostics.Process.Start(e.Url.ToString());
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            string message = "คุณต้องการปิดโปรแกรม?";
            string title = "ปิดโปรแกรม";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                // Do something  
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
