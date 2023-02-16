using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;  // 匯入System.Collections;命名空間

namespace ConsoleSortedList1
{
    class Program
    {
        class Course
        {
            public string Name { get; set; }     // 姓名屬性          
            public bool Status { get; set; }       // 本系生屬性
            public int Score { get; set; }          // 計概成績屬性  

            public override string ToString()    // 覆寫覆類別 ToString()方法
            {
                return string.Format("  姓名 : {0} \t 本系生 :{1} \t 計概成績: {2} \n ", Name, Status ? "是" : "非", Score.ToString());
            }
        }

        static void Main(string[] args)
        {
            SortedList bcc = new SortedList();  // 非泛型

            bcc.Add("David", new Course() { Name = "David", Status = true, Score = 85 });
            bcc.Add("Mary", new Course() { Name = "Mary", Status = false, Score = 95 });
            bcc.Add("Tom", new Course() { Name = "Tom", Status = true, Score = 75 });
            bcc.Add("Jack", new Course() { Name = "Jack", Status = true, Score = 80 });

            //非泛型操作
            Console.WriteLine("\n === 非泛型 SortedList 操作需強制轉換 .... \n");
            foreach (DictionaryEntry item in bcc)
            {
                Console.WriteLine(((Course)item.Value).ToString());
            }
            Console.Read();
        }
    }
}
