using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTryCatch2
{
    class Program
    {
        static void Main(string[] args)
        {
              int a, b, c = 0;
              Console.Write("a = ");
              a = int.Parse(Console.ReadLine());
              Console.Write("b = ");
              b = int.Parse(Console.ReadLine());
              try
               {
                      c = a / b;
               }
               catch (Exception ex)
               {
                       Console.WriteLine("\n 1. {0}", ex.ToString());
               }
               Console.WriteLine("\n 2. {0} / {1} = {2}", a, b, c);
               Console.Read();
            }
        }
}
