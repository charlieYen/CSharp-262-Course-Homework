using StudentLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programe01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Student[] students = new Student[]
            {
                new Student() { Name = "John", ChineseGrade = 80, EnglishGrade = 77, MathGrade = 30 },
                new Student() { Name = "Bob", ChineseGrade = 30, EnglishGrade = 37, MathGrade = 99 },
                new Student() { Name = "Marry", ChineseGrade = 99, EnglishGrade = 69, MathGrade = 80 }
            };

            do
            {
                Console.WriteLine("你想以哪個分數做排序：1.總分 2.國文 3.英文 4.數學 5.結束");
                Student.Key = Convert.ToInt32(Console.ReadLine());

                if (Student.Key == 5) { Console.WriteLine("結束查詢"); }
                else
                {
                    Console.WriteLine("姓名\t總分\t國文\t英文\t數學");
                    Array.Sort(students);
                    foreach (Student student in students)
                    {
                        Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", student.Name, student.TotalGrade, student.ChineseGrade, student.EnglishGrade, student.MathGrade);
                    }
                }
            } while (Student.Key != 5);
        }
    }
}