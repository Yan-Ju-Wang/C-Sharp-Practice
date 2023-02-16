using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Linq; //使用LINQ必須引用System.Linq命名空間

namespace Linq_Method1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //建立Book書籍陣列物件
        Book[] books = new Book[] {
            new Book {Id="AEL015400", Name= "Java 8 基礎必修課",Price=530  },
            new Book {Id="AEL017400", Name= "Visual C# 2017基礎必修課",Price=530 },
            new Book {Id="AEL014700", Name= "Visual Basic 2017程式設計經典",Price=650},
            new Book {Id="AEL014300", Name= "Visual C# 2017程式設計經典",Price=650  }
        };
        //表單載入時執行
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = books.ToList();
        }
        //按下 [查詢] 鈕執行 
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtKeyword.Text;
            var result = books
                .Where(m => m.Name.Contains(keyword))
                .ToList();
            dataGridView1.DataSource = result;
        }
        //按下 [書籍列表] 鈕執行
        private void btnBookList_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }
        //按下 [單價遞增排序] 鈕執行
        private void btnPriceAsc_Click(object sender, EventArgs e)
        {
            string keyword = txtKeyword.Text;
            var result = books
                .OrderBy(m => m.Price)
                .ToList();
            dataGridView1.DataSource = result;
        }

        //按下 [單價遞減排序] 鈕執行
        private void btnPriceDesc_Click(object sender, EventArgs e)
        {
            string keyword = txtKeyword.Text;
            var result = books
                .OrderByDescending(m => m.Price)
                .ToList();
            dataGridView1.DataSource = result;
        }
    }
}
