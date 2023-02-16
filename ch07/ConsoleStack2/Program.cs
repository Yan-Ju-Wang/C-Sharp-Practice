using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;  // 匯入System.Collections命名空間

namespace ConsoleStack2
{
    class Program
    {
        class Course
        {
            public string Name { get; set; }     // 姓名屬性          
            public bool Status { get; set; }        // 本系生屬性
            public int Score { get; set; }          // 計概成績屬性

            public override string ToString()    // 覆寫覆類別 ToString()方法
            {
                return string.Format("  姓名 : {0} \t 本系生 : {1} \t 計概成績 : {2} \n ", Name, Status ? "是" : "非", Score.ToString());
            }
        }
        static void Main(string[] args)
        {
            Stack<Course> mstack = new Stack<Course>();   // 泛型           

            mstack.Push(new Course() { Name = "David", Status = true, Score = 85 });
            mstack.Push(new Course() { Name = "Mary", Status = false, Score = 95 });
            mstack.Push(new Course() { Name = "Tom", Status = true, Score = 75 });
            mstack.Push(new Course() { Name = "Jack", Status = true, Score = 80 });

            Console.WriteLine("\n === 泛型 Stack 操作不需強制轉換 .... \n");

            while (mstack.Count > 0)
            {
                Console.WriteLine("{0} ", mstack.Pop());
            }
            Console.Read();
        }
    }
}
