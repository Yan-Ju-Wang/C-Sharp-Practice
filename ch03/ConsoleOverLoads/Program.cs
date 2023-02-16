using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOverLoads
{
    class Program
    {
          static int sum(int x, int y)		// 傳回兩數相加
          {
               return (x + y);
           }
          static int sum(int x, int y, int z) 	// 傳回三數相加
           {
                  return (x + y + z);
           }
          static string sum(string x, string y)  // 傳回兩個字串合併結果
            {
                  return (x + y);
             }
          // 傳回三個字串合併結果
          static string sum(string x, string y, string z)
          {
                 return (x + y + z);
           }

         static void Main(string[] args)
          {
                Console.WriteLine("\n sum(10,20)={0}", sum(10, 20));
                Console.WriteLine("\n sum(10,20,30)={0}", sum(10, 20, 30));
                Console.WriteLine ("\n sum(\"Good \", \"Day.\") = {0}", sum("Good ", "Day."));
                string str1, str2, str3;
                str1 = "Good "; str2 = "Luck "; str3 = "To You!";
                Console.WriteLine("\n sum(\"{0}\",\"{1}\",\"{2}\") = {3}",  str1, str2, str3, sum(str1, str2, str3));

                Console.Read();
          }
    }
}
