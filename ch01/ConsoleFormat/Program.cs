using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.以貨幣方式 C |c顯示資料，以NT$開頭 ==== ");
            Console.WriteLine("12345678901234567890");
            Console.WriteLine("{0}/{1}/{2} ", 1234, -1234, 123.4); //未設輸出格式
            Console.WriteLine("{0, 0 :C}  {1, 0 :c3}\n{2, 15 :C3}\n{3, -15 :C3} ", 5, -5, -5, -5);
            Console.WriteLine();

            Console.WriteLine("2.以十進位方式 D|d 顯示資料，空白處補零 ==== ");
            Console.WriteLine("12345678901234567890");
            Console.WriteLine("{0,0:d5}", 25);  //寬度依資料大小 精確度5位 不足位補0
            Console.WriteLine("{0,10:D5}", 25);  //寬度10 精確度5不足位補0靠右
            Console.WriteLine("{0,-10:D5}", -25); //寬度10 精確度5不足位補0靠左
            Console.WriteLine();

            Console.WriteLine("3.以指數方式 E 顯示資料 ==== ");
            Console.WriteLine("12345678901234567890");
            Console.WriteLine("{0:E}", 250000);     //預設取小數六位  
            Console.WriteLine("{0:E3}", 25000);     //取小數3位 預設靠左對齊
            Console.WriteLine("{0:E3}", 0.0012345); //取小數3位 預設靠左對齊
            Console.WriteLine("{0,20:E3}", 25000);  //取小數3位 總長度20位 靠右對齊
            Console.WriteLine("{0,-20:E3}", -25000);  //取小數3位 總長度20位靠左
            Console.WriteLine("------------------------------------");

            Console.WriteLine("3.以浮點數方式 F|f 顯示資料 ===== ");
            Console.WriteLine("12345678901234567890");
            Console.WriteLine("{0:F}", 123.4567);   //預設取小數兩位 第3位四捨五入
                                                    //總長度不夠 預設靠左對齊
            Console.WriteLine("{0:F0}", 123.4567); //預設取小數兩位 總長度不夠 
                                                   //預設靠左對齊
            Console.WriteLine("{0:F3}", 123.4555);  //取小數3位 四捨五入 總長度不夠 
                                                    //預設靠左對齊
            Console.WriteLine("{0,20:F3}", 123.4567);  //取小數3位 總長度 20位 
                                                       //靠右對齊
            Console.WriteLine("{0,-20:F3}", -123.45);   //取小數3位 -123.450,
                                                        //總長度 20位 靠左對齊
            Console.WriteLine("------------------------------------");

            Console.WriteLine("4.以一般方式 G|g顯示資料  ==== ");
            Console.WriteLine("12345678901234567890");
            Console.WriteLine("{0:G}", 123.4567);      //預設取小數兩位  123.4567   
                                                       //總長度不夠 預設靠左對齊
            Console.WriteLine("{0:g0}", 123.4567);   //預設取小數兩位  123.4567  
                                                     //總長度不夠 預設靠左對齊
            Console.WriteLine("{0:g3}", 123.4555);   //取前3位  123  四捨五入 
                                                     //總長度不夠 預設靠左對齊
            Console.WriteLine("{0,20:G5}", 123.4567);   //不包括小數點 取前5位  123.46
                                                        // 第6位四捨五入 , 總長度 20位 靠右對齊
            Console.WriteLine("{0,-20:G3}", -123.45);   // 取小數3位  -123,  
                                                        //總長度 20位 靠左對齊
            Console.WriteLine("------------------------------------");

            Console.WriteLine("5.以千位符號, N|n顯示資料 , 不加 $ ===== ");
            Console.WriteLine("12345678901234567890");
            Console.WriteLine("{0:N}", 2500000);      //2,500,000.00 寬度未設 
                                                      //預設小數2位預設靠左對齊 
            Console.WriteLine("{0:N0}", 2500000);     //2,500,000 寬度未設
                                                      // 小數0位預設靠左對齊
            Console.WriteLine("{0:N1}", 2500000);     //2,500,000.0寬度未設
                                                      //小數一位預設靠左對齊
            Console.WriteLine("{0,20:N2}", -2500000);  //-2,500,000.00寬度20位  
                                                       //小數兩位 靠右對齊
            Console.WriteLine("{0,-20:N2}", 2500000);  //2,500,000.00，寬度20位  
                                                       //小數兩位 靠左對齊
            Console.WriteLine("------------------------------------");

            Console.WriteLine("6.以16進制, X|x 顯示資料 ==== ");
            Console.WriteLine("12345678901234567890");
            Console.WriteLine("{0:X}", 255);
            Console.WriteLine("{0,10:X}", 255);
            Console.WriteLine("{0,-10:X}", 255);
            Console.WriteLine("{0,0 :x4}", 12);    // 000c
            Console.WriteLine("{0, 2 :x}", 12);    //  c            
            Console.Read();
        }
    }
}
