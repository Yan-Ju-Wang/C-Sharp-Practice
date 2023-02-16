using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Linq;  //使用LINQ必須用此命名空間

namespace Linq_Method2
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
            new Book {Id="AEL017400", Name= "Visual C# 2015基礎必修課",Price=530 },
            new Book {Id="AEL014700", Name= "Visual Basic 2013程式設計經典",Price=650},
            new Book {Id="AEL014300", Name = "Visual C# 2013程式設計經典",Price=650}
        };
        //宣告index整數變數，用來表示陣列中的第幾筆書籍記錄
        int index = 0;
        //定義ShowRecord方法，可傳人指定的書籍物件，並將該物件資訊顯示在表單上控制項上
        void ShowRecord(Book t)
        {
            txtId.Text = t.Id;                   //顯示書號
            txtName.Text = t.Name;               //顯示書名
            txtPrice.Text = t.Price.ToString();  //顯示單價
            pictureBox1.Image = new Bitmap(t.Id + ".jpg");//顯示書籍封面圖檔，圖檔和書號同名
            lblShow.Text = (index + 1) + " / " + books.Count(); //顯示產品總數
        }
        //表單載入時執行
        private void Form1_Load(object sender, EventArgs e)
        {
            var result = books.FirstOrDefault();    //取得books書籍陣列的第一筆記錄	
            ShowRecord(result);			//呼叫ShowRecord()方法，顯示第一筆書籍記錄
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }
        //按 [上一筆] 鈕執行
        private void btnPrev_Click(object sender, EventArgs e)
        {
            index--;
            if (index < 0)
            {
                index = books.Count() - 1;
            }
            var result = books.Skip(index).FirstOrDefault();
            ShowRecord(result);

        }
        //按 [下一筆] 鈕執行
        private void btnNext_Click(object sender, EventArgs e)
        {
            index++;
            if (books.Count() <= index)
            {
                index = 0;
            }
            var result = books.Skip(index).FirstOrDefault();
            ShowRecord(result);
        }
    }
}
