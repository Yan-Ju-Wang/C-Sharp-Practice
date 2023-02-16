using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTenary
{
    class Program
    {
        static void Main(string[] args)
        {
            double netIncome = 0;  // 淨所得
            double taxRate = 0;    // 所得稅率
            double tax = 0;        // 宣告income淨所得變數為浮點數型別    
            int discount = 0;     // 累進差額
            int stage = 0;        //  級距

            Console.Write("\n >>>>  請輸入全年綜合所得淨額(元)  : ");
            netIncome = double.Parse(Console.ReadLine());
            Console.WriteLine();

            if (netIncome > 0)       // 檢查 淨所得是否大於零
                stage = (netIncome <= 520000 ? 1 : (netIncome <= 1370000 ? 2 :
                         (netIncome <= 2350000 ? 3 : (netIncome <= 4400000 ? 4 :
                         (netIncome <= 10000000 ? 5 : 6)))));
            else
                Console.WriteLine("\n === 全年所得淨額為負 ! 不用繳稅 ... ");

            switch (stage)
            {
                case 1:
                    taxRate = 0.05;
                    discount = 0;
                    tax = netIncome * 0.05;
                    break;
                case 2:
                    taxRate = 0.12;
                    discount = 36400;
                    tax = netIncome * 0.12 - 36400;
                    break;
                case 3:
                    taxRate = 0.2;
                    discount = 130000;
                    tax = netIncome * 0.20 - 130000;
                    break;
                case 4:
                    taxRate = 0.3;
                    discount = 365000;
                    tax = netIncome * 0.30 - 365000;
                    break;
                case 5:
                    taxRate = 0.4;
                    discount = 805000;
                    tax = netIncome * 0.40 - 805000;
                    break;
                case 6:
                    taxRate = 0.45;
                    discount = 1305000;
                    tax = netIncome * 0.45 - 1305000;
                    break;
                default:
                    Console.WriteLine("\n  ****  無此級距  **** ");
                    break;
            }
            Console.WriteLine("\n ==  1. 綜合淨所得  : {0:C} 元", netIncome);
            Console.WriteLine("\n ==  2. 所得稅級距  : 第 {0} 級 ", stage);
            Console.WriteLine("\n ==  3. 累 進 稅 率 : {0}% ", taxRate * 100);
            Console.WriteLine("\n ==  4. 累 進 差 額 : {0:C} 元", discount);
            Console.WriteLine("\n ==  5. 應 繳 稅 額 : {0:C} 元", tax);
            Console.Read();
        }
    }
}
