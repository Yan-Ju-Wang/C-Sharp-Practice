using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBreakContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum, upper, n; //sum 為連加的總和, upper為臨界值,n為連加的終值 
            sum = 0; n = 0;
            Console.WriteLine("\n ==  求 1+2+3+...... +N <= Upper(臨界值)");
            Console.Write("\n  1. 請輸入 Upper(臨界值)  : ");
            upper = int.Parse(Console.ReadLine()); //輸入值轉整數再指定給upper
            do
            {
                n += 1;            // 連加增值為1
                if (sum <= upper)  // 判斷 sum總和是否小於等於輸入的上限值upper     
                {
                    sum += n;
                    continue;   // 跳到do…while 處判斷n是否大於0
                }
                else   // sum值大於上限值upper時,執行else敘述區段
                {
                    sum -= n - 1;
                    break;      // 離開迴圈
                }
            } while (n > 0);    // 若n>0則進入迴圈
            Console.WriteLine("\n  2. 電腦自動算出 N (終值)  :  {0} ", n - 2);
            Console.WriteLine("\n  3. 1 + 2 + 3 + ...... + {0} = {1}", n - 2, sum);
            Console.Read();
        }
    }
}
