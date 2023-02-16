﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // 表單載入時執行
        private void Form1_Load(object sender, EventArgs e)
        {
            lblShow.Text = "";
        }
         // 按 <確定>鈕執行此事件
        private void btnOK_Click(object sender, EventArgs e)
        {
            lblShow.Text = "Hello, " + txtName.Text;
            lblShow.BackColor = Color.Yellow;
        }
        // 按 <結束>鈕執行此事件
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
