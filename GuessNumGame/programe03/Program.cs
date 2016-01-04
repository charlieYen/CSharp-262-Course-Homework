using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLibrary;

namespace programe03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] answerBase = new int[5040][];
            int count = 0;

            for (int i = 100; i < 9999; i++)
            {
                int unit1 = (i / 1) % 10;
                int unit10 = (i / 10) % 10;
                int unit100 = (i / 100) % 10;
                int unit1000 = (i / 1000) % 10;
                if (unit1 != unit10 && unit1 != unit100 && unit1 != unit1000 && unit10 != unit100 && unit10 != unit1000 && unit100 != unit1000)
                {
                    answerBase[count] = new int[] { unit1000, unit100, unit10, unit1 };
                    count++;    
                }
                
                }
            for (int j = 0; j < 50; j++)
            {
                    Console.WriteLine("[{0},{1},{2},{3}]", answerBase[j][0], answerBase[j][1], answerBase[j][2], answerBase[j][3]);
            }
        }
    }
}
