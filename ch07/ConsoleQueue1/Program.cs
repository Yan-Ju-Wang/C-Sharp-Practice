using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;  // 匯入System.Collections命名空間

namespace ConsoleQueue1
{
    class Program
    {
        class Course
        {
            public string Name { get; set; }    // 姓名屬性          
            public bool Status { get; set; }       // 本系生屬性
            public int Score { get; set; }         // 計概成績屬性

            public override string ToString()    // 覆寫覆類別 ToString()方法
            {
                return string.Format("  姓名 : {0} \t 本系生  : {1} \t 計概成績 : {2} \n ", Name, Status ? "是" : "非", Score.ToString());
            }
        }
        static void Main(string[] args)
        {
            Queue mQueue = new Queue();   // 非泛型           

            mQueue.Enqueue(new Course() { Name = "David", Status = true, Score = 85 });   // 泛型
            mQueue.Enqueue(new Course() { Name = "Mary", Status = false, Score = 95 });
            mQueue.Enqueue(new Course() { Name = "Tom", Status = true, Score = 75 });
            mQueue.Enqueue(new Course() { Name = "Jack", Status = true, Score = 80 });

            Console.WriteLine("\n === 非泛型 Queue 操作 需強制轉換 .... \n");
            while (mQueue.Count > 0)
            {
                Console.WriteLine("{0} ", ((Course)mQueue.Dequeue()).ToString());
            }
            Console.Read();
        }
    }
}
