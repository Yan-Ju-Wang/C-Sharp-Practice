using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMyFirstClass
{
    class MyFirstClass     //定義類別，名稱為MyFirstClass
    {

    }

     class Program
    {
        static void Main(string[] args)
        {
              Console.WriteLine("\n  建立一個屬於 MyFirstClass類別的物件A ...");
              MyFirstClass A = new MyFirstClass();

              /* 
              上述一行敘述也可以改成如下兩行
               MyFirstClass A ;                // 宣告 物件A 屬於 MyFirstClass類別
               A = new MyFirstClass();   //使用new敘述建立物件A為MyFirstClass類別
            */

            Console.WriteLine("\n  物件A 已建立完成 !! ");
            Console.WriteLine("\n  請按 <Enter>鍵 結束 ... ");

                        Console.Read();

        }
    }
}
