using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using System.Data;    // DataSet與DataTable置於此命名空間下
using System.Data.SqlClient;

namespace DataTableDemo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataTable dt;
        int index = 0, count;
        // ShowData方法在文字方塊上顯示目前成績單第index筆記錄
        void ShowData()
        {
            txtId.Text = dt.Rows[index]["學號"].ToString();
            txtName.Text = dt.Rows[index]["姓名"].ToString();
            txtChi.Text = dt.Rows[index]["國文"].ToString();
            txtEng.Text = dt.Rows[index]["英文"].ToString();
            txtMath.Text = dt.Rows[index]["數學"].ToString();
            lblShow.Text = string.Format("記錄在第{0}筆,共{1}筆", (index+1), count);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 使用using敘述建立SqlConnection物件
            using (SqlConnection cn = new SqlConnection())
            {
                // 連接ch17DB.mdf資料庫
                cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    "AttachDbFilename=|DataDirectory|ch17DB.mdf;" +
                    "Integrated Security=True";
                DataSet ds = new DataSet();  // 建立DataSet物件ds
                // 建立SqlDataAdapter物件daScore並取出成績單資料表
                SqlDataAdapter daScore = new SqlDataAdapter("SELECT * FROM 成績單", cn);
                // 將成績單資料表所有記錄填入ds物件
                daScore.Fill(ds, "成績單");
                // 宣告DataTable物件dt，該dt內存放ds中的成績單DataTable
                dt = ds.Tables["成績單"];
                // 成績單資料表所有筆數
                count = dt.Rows.Count;
                // 呼叫ShowData方法在文字方塊上顯示目前成績單第index筆記錄
                ShowData();
            }
        }
        // 按 [第一筆] 鈕 
        private void btnFirst_Click(object sender, EventArgs e)
        {
            index = 0;
            ShowData();
        }
        // 按 [上一筆] 鈕 
        private void btnPrev_Click(object sender, EventArgs e)
        {
            index--;
            if (index < 0)
            {
                index = count-1;
            }
            ShowData();
        }
        // 按 [下一筆] 鈕 
        private void btnNext_Click(object sender, EventArgs e)
        {
            index++;
            if (index >= count)
            {
                index = 0;
            }
             ShowData();
        }
        // 按 [最末筆] 鈕 
        private void btnLast_Click(object sender, EventArgs e)
        {
            index = count - 1;
            ShowData();
        }
    }
}
