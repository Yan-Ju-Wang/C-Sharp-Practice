using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTryCatch3
{
    class Program
    {
        static void Main(string[] args)
        {
               int i;
               int[] score = new int[] { 1, 2, 3 };
               for (i = 0; i <= 3; i++)
               {
                     Console.Write("  score[{0}]=", i.ToString());
                     try
                      {
                           Console.WriteLine(score[i]);
                      }
                     catch (IndexOutOfRangeException ex)
                      {
                             Console.WriteLine();
                             Console.WriteLine("\n 1. 例外處理類型   :{0}", ex.GetType().ToString());
                             Console.WriteLine("\n 2. 錯誤訊息       :{0}", ex.Message);
                             Console.WriteLine("\n 3. 程式或物件名稱 :{0}",  ex.Source);
                             Console.WriteLine("\n 4. 產生錯誤程序   :{0}", ex.TargetSite.Name);
                             Console.WriteLine("\n 5. 錯誤之處       :{0}\n", ex.StackTrace);
                       }
                     finally
                       {
                              Console.WriteLine(" --> index = {0}\n ", i.ToString());
                       }
               }
               Console.Read();
         }
     }
}
