using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinKeyDownGoToClick
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // 在此文字方塊按鍵會觸發此事件
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)   // 另種寫法 if (e.KeyCode.ToString() == "Return")
            {
                button1.Focus();                 // 將插入點游標(駐點)移到 button1按鈕控制項上                        
                button1_Click(sender, e);    // 執行 button1按鈕的Click事件
            }
        }
        // 按 <確定>鈕執行此事件
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Hi, Hello!");
        }
    }
}
