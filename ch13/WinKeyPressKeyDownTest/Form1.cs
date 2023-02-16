using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinKeyPress_KeyDown_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }        
        // 檢查可觸發 KeyPress事件的按鍵名稱和鍵值
        private void txtKeyPress_KeyPress(object sender, KeyPressEventArgs e)
        {
            //  寫法一 :
            label2.Text = "現在按 <" + e.KeyChar + "> 鍵,  KeyASCII值 :  " + ((byte)e.KeyChar).ToString();   
            
            // 寫法二 :
            //MessageBox.Show("現在按 <" + e.KeyChar + "> 鍵,  KeyASCII值 :  " + ((byte)e.KeyChar).ToString());
        }

        // 檢查可觸發 KeyDown & KeyUp 事件的按鍵名稱和鍵值
        private void txtKeyDown_KeyDown(object sender, KeyEventArgs e)
        {
            label4.Text = "現在按 <" + e.KeyCode.ToString ()+ "> 鍵,   KeyCode : " + e.KeyValue.ToString();
        }
    }
}
