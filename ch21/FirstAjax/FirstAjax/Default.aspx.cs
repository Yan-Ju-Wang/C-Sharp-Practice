using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstAjax
{
    public partial class Default : System.Web.UI.Page
    {
        // 網頁載入時執行
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) // 網頁第一次載入時才會執行
            {
                Label1.Text = Label2.Text =
                "目前時間：" + DateTime.Now.ToString();
            }
        }
        //按下 [顯示時間-1] 鈕執行此事件
        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "同步更新目前時間：" + DateTime.Now.ToString();
        }
        // 按下 [顯示時間-2] 鈕執行此事件 
        protected void Button2_Click(object sender, EventArgs e)
        {
            Label2.Text = "非同步更新目前時間：" + DateTime.Now.ToString();
        }
    }
}