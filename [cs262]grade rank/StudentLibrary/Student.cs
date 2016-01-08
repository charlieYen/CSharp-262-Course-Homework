using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary
{
    public class Student : IComparable<Student>
    {
        public static int Key { get; set; }

        public string Name { get; set; }

        public int ChineseGrade { get; set; }

        public int EnglishGrade { get; set; }

        public int MathGrade { get; set; }

        public int TotalGrade
        {
            get { return this.ChineseGrade + this.EnglishGrade + this.MathGrade; }
        }

        public int CompareTo(Student other)
        {
            if (Key == 1)
                return other.TotalGrade - this.TotalGrade;
            else if (Key == 2)
                return other.ChineseGrade - this.ChineseGrade;
            else if (Key == 3)
                return other.EnglishGrade - this.EnglishGrade;
            else if (Key == 4)
                return other.MathGrade - this.MathGrade;
            else
                return 0;
        }
    }
}