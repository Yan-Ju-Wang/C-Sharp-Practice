using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace IBM	   // 定義 IBM 命名空間
 {
       class Notebook
       {

       }
 }
 namespace Apple	// 定義 Apple命名空間
 {
       class Notebook
       {

       }
 }

namespace ConsoleNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
               // 使用IBM命名空間下的Notebook類別建立A物件
               IBM.Notebook A = new IBM.Notebook();
               // 使用Apple命名空間下的Notebook類別建立B物件
               Apple.Notebook B = new Apple.Notebook();

        }
    }
}
