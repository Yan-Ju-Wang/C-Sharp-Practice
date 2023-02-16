using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTryCatchTest2
{
    class Program
    {
        static void Main(string[] args)
        {
            int up, down, result;
            up = 10;
            down = 0;
            try
            {
                result = up / down;
            }
            //catch (System.DivideByZeroException ex)
            //{
            //    Console.WriteLine(" 除數不可為零...");
            //}
            catch (System.DivideByZeroException ex)
            {
                Console.WriteLine("\n1. {0} ", ex.ToString());
            }
            finally
            {
                Console.WriteLine("\n2  已執行 finally區塊...");
            }
            Console.Read();

        }
    }
}
