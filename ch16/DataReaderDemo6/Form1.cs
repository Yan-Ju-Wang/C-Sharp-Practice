using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace DataReaderDemo6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    "AttachDbFilename=|DataDirectory|Northwind.mdf;" +
                    "Integrated Security=True";
                cn.Open();
                SqlCommand cmd = new SqlCommand
                    ("SELECT 產品編號,類別名稱,產品,單價,庫存量 FROM 產品類別 " + 
                     "LEFT JOIN 產品資料 " + 
                     "ON 產品類別.類別編號 = 產品資料.類別編號", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    textBox1.Text += dr.GetName(i) + "\t";
                }
                textBox1.Text += Environment.NewLine + Environment.NewLine;
                while (dr.Read())
                {
                    //讀取產品資料的產品編號
                    textBox1.Text += dr["產品編號"].ToString() + "\t";
                    //讀取產品類別的類別名稱
                    textBox1.Text += dr["類別名稱"].ToString() + "\t";
                    //讀取產品資料的產品
                    textBox1.Text += dr["產品"].ToString() + "\t";
                    //讀取產品資料的單價
                    textBox1.Text += dr["單價"].ToString() + "\t";
                    //讀取產品資料的庫存量
                    textBox1.Text += dr["庫存量"].ToString() + "\t";
                    textBox1.Text += Environment.NewLine;
                }
            }
        }
    }
}

