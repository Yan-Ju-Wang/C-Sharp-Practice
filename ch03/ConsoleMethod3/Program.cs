using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMethod3
{
        class Class1
    {
        public static string GetWelcome(string username, bool ismale)
        {
              string str = "";
              if (ismale)
                      str = username + " 先生，歡迎光臨！";
              else
                      str = username + " 小姐，歡迎光臨！";
              return str;  // 傳回字串
         }
    }

    class Program
    {
        static void Main(string[] args)
        {
               string name = "Jack Wu";
               //使用Class1類別的GetWelcome方法
               string Welcome = Class1.GetWelcome(name, true);
               Console.WriteLine("\n {0}",Welcome);
               Console.WriteLine();
               Console.WriteLine("\n {0}",Class1.GetWelcome("Mary Lin", false));

               Console.Read();
    }
}
}
