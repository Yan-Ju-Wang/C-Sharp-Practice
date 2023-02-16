using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinEventHandler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblShow.Text = "";
            lblShow.BackColor = Color.Aqua;
            lblShow.Font = new Font("標楷體",14,FontStyle.Underline);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
              Button btnHit; // 宣告btnHit為Button類別物件
              // 將sender轉型成Button類別物件，接著再指定給btnHit
              // 此時btnHit即代表是使用者按下的按鈕
              btnHit = (Button)sender;
              lblShow.Text = " 目前按下 <" + btnHit.Text +  ">";
        }
    }
}
