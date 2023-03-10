using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleConsoleWhile1
{
    class Program
    {
        static void Main(string[] args)
        {
            int factor, testNo = 0, count = 0;
            Console.Write(" 請輸入欲求因數的數值(1-50)：");
            factor = int.Parse(Console.ReadLine());

            if (factor >= 1 && factor <= 50)
            {
                Console.WriteLine
                 ("\n == 求 1 到 100 能被 {0} 整除的因數 ==\n", factor);
                testNo = 0;
                while (true)
                {
                    testNo += factor;
                    if (testNo <= 100)
                    {
                        count += 1;
                        Console.Write("\t{0},", testNo.ToString());
                        if ((count % 5) == 0)
                            Console.WriteLine(); // 跳下一行
                    }
                    else
                        break;
                }
                Console.WriteLine
                 ("\n\n === 由 1 到 100 共有 {0} 個整數可被 {1} 整除 !",
                 count, factor.ToString());
            }
            else  // 若 輸入的facter因數未介於1~50之間, 則顯示錯誤訊息
                Console.WriteLine("\n === 輸入的資料超出範圍 (1~50) !   @_@ .....");
            Console.ReadLine();

        }
    }
}
