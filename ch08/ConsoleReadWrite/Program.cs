using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;  // 引用System.IO命名空間

namespace ConsoleReadWrite
{
    class Program
    {
        static void Main(string[] args)
        {
              string input, sel, fname;
              // 宣告StreamReader的sr物件, 用來讀出資料
             StreamReader sr;
             // 宣告StreamWriter的sw物件, 用來寫入資料
            StreamWriter sw;
             FileInfo f;
             while (true)
              {
                  Console.Write("\n 請輸入要讀寫的檔案路徑 : ");
                  fname = Console.ReadLine();
                try
                {
                    f = new FileInfo(fname);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\n 檔案路徑有錯! .... ");
                    Console.WriteLine();
                    continue;
                }
                Console.Write("\n 請選擇功能 ->1.寫入   2.附加   其他離開：");
                sel = Console.ReadLine();
                if (sel == "1")
                 {
                        sw = f.CreateText();  // 開啟新檔
                        Console.Write("\n [寫入]：");
                         input = Console.ReadLine();
                          // 將輸入的資料覆蓋原檔並重新寫入
                         sw.WriteLine(input);
                 }
                 else if (sel == "2")
                  {
                       sw = f.AppendText();   // 開啟舊檔
                       Console.Write("\n [附加]：");
                       input = Console.ReadLine();
                        // 將輸入的資料附加到資料檔的最後
                        sw.WriteLine(input);
                  }
                 else
                  {
                       Console.WriteLine("\n [離開]系統 .....");
                       break;
                  }
                  sw.Flush();
                  sw.Close();
                  sr = f.OpenText();  // 以唯讀模式開檔
                  Console.WriteLine("\n===資料檔內容 ===\n");
                  Console.WriteLine(sr.ReadToEnd());      // 讀出資料
                  sr.Close();
                  Console.WriteLine("-------------------------------------------------");
              }
              Console.Read();
         }
    }
}
