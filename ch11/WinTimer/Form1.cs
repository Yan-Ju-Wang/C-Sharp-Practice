using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 設定共用成員變數 left為true表示跑馬燈往左，left為false表示跑碼燈往右
        bool left = true;

        // === 表單載入時執行
        private void Form1_Load(object sender, EventArgs e)
        {
            // 設定跑馬燈圖片方塊為gotop.jpg
            pictureBox1.Image = new Bitmap("gotop.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            timer1.Interval = 10;      // 設定計時器每0.01秒執行Tick事件一次
            timer1.Enabled = true;   // 啟動計時器
            label1.Text = "跑馬燈方向往左移動";
        }
        // 每當 0.01秒一到便觸動此事件
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (left)       // 跑馬燈往表單左邊界移動 (表示 left=true)
            {
                 // 圖片方塊X座標減 1，表示往表單左邊界移動
                 pictureBox1.Left -= 1;
                 label1.Text = "跑馬燈方向往左移動　X座標：" + pictureBox1.Left;
                 // 若跑馬燈的X座標小於等於0則設 left = false
                 if (pictureBox1.Left <= 0)
                 {
                      left = false;   // 設定跑馬燈往表單左邊界移動
                 }
            }
            else         // 跑馬燈往表單右邊界移動
            {
                // 圖片方塊X座標加 1，表示往表單右邊界移動
                pictureBox1.Left += 1;
                label1.Text = "跑馬燈方向往右移動　X座標：" + pictureBox1.Left;
                // 若跑馬燈X座標加上跑馬燈寬度大於等於表單的寬度則設 left = true
                if (pictureBox1.Left + pictureBox1.Width >= (this.Width-15)) // 扣除表單右邊界厚度
                {
                    left = true;    // 設定跑馬燈往右移動
                }
            }
        }

        // === 按 <播放> 鈕執行
        private void btnPlay_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;  // 啟動計時器
        }
        // === 按 <停止> 鈕執行
        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;  // 啟動計時器
        }
        // === 按 <結束> 鈕執行
        private void btnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
    }
}
