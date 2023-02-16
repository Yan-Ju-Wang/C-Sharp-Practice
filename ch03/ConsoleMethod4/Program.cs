using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMethod4
{
        class Class1
        {
              public string GetWelcome(string username, bool ismale)
              {
                   string str = "";
                   if (ismale)
                           str = username + " 先生，歡迎光臨！";
                   else
                            str = username + " 小姐，歡迎光臨！";
                    return str;
               }
         }

    class Program
    {
        static void Main(string[] args)
        {
                string name = "Jack Wu";
                // 建立myClass物件為Class1類別
                Class1 myClass = new Class1();
                // 呼叫Class1類別的GetWelcome方法
                string Welcome = myClass.GetWelcome(name, true);
                Console.WriteLine("\n {0}", Welcome);
                Console.WriteLine();
                Console.WriteLine("\n {0}",  myClass.GetWelcome("Mary Lin", false));
               
            Console.Read();
         }
     }
}
