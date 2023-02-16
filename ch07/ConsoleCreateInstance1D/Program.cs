using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;  // 若此行有寫入，第16行System.Collections.可省略

namespace ConsoleCreateInstance1D
{
    class Program
    {
        static void Main(string[] args)
        {
               // 產生一個含有五個陣列元素的整數陣列
               Array ary1D = Array.CreateInstance(typeof(Int32), 5);
            // 設定陣列初值依序為:10,20,30,40,50           
               for (int i = ary1D.GetLowerBound(0); i <= ary1D.GetUpperBound(0);  i ++)
                      ary1D.SetValue(10+i*10, i);
            
               // 顯示陣列初值            
               // System.Collections.IEnumerator myEnumerator = ary1D.GetEnumerator();
              IEnumerator myEnumerator = ary1D.GetEnumerator();
              int k = 0;
              int cols = ary1D.GetLength(ary1D.Rank - 1);
            Console.WriteLine();
            while (myEnumerator.MoveNext())
                {
                       if (k < cols)
                       {
                               k++;
                        }
                        else
                        {
                               Console.WriteLine();
                                k = 1;
                         }
                        Console.Write(" {0}. ary1D[{1}] = {2} \n", k, k, myEnumerator.Current);
                }
                Console.Read();
        }
    }
}
