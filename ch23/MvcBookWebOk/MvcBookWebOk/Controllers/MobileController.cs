
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MvcBookWeb.Models;

namespace MvcBookWeb.Controllers
{
    public class MobileController : Controller
    {
        // 建立ch22DBEntities物件db
        ch22DBEntities db = new ch22DBEntities();
        // 連結網站/Mobile/Index，會執行Index()方法
        public ActionResult Index()
        {
            //依單價遞減排序
            var bookList = db.書籍.OrderBy(m => m.單價).ToList();
            return View(bookList);
        }

        public ActionResult Details(string bookId)
        {
            var book = db.書籍.Where(m => m.書號 == bookId).FirstOrDefault();
            return View(book);
        }
    }
}