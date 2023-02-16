using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDictionary1
{
    class Program
    {
        class Course
        {
            public string Name { get; set; }     // 姓名屬性          
            public bool Status { get; set; }       // 本系生屬性
            public int Score { get; set; }          // 計概成績屬性           
        }

        static void Main(string[] args)
        {
            Dictionary<string, Course> bcc = new Dictionary<string, Course>();

            bcc.Add("David", new Course() { Name = "David", Status = true, Score = 85 });
            bcc.Add("Mary", new Course() { Name = "Mary", Status = false, Score = 95 });
            bcc.Add("Tom", new Course() { Name = "Tom", Status = true, Score = 75 });
            bcc.Add("Jack", new Course() { Name = "Jack", Status = true, Score = 80 });

            //泛型陣列操作
            Console.WriteLine("\n === 泛型 Dictionary 操作不需強制轉換 .... \n");
            foreach (KeyValuePair<string, Course> item in bcc)
            {
                Console.WriteLine("  姓名 : {0} \t 本系生 : {1}  \t  計概成績 : {2}  \n", item.Key, item.Value.Status ? "是" : "非", item.Value.Score);
            }
            Console.Read();
        }
    }
}
