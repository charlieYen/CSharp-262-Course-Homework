using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class Array2D
    {
        public int[,] element2D;
        public int maxnumber = 9999;

        public Array2D(int x, int y)
        {
            element2D = new int[x, y];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    element2D[i, j] = 0;
                }
            }
        }

        public Array2D GenerateAnswerTable()
        {
            int count = 0;
            for (int i = 123; i < this.maxnumber; i++)
            {

                int unit1 = (i / 1) % 10;
                int unit10 = (i / 10) % 10;
                int unit100 = (i / 100) % 10;
                int unit1000 = (i / 1000) % 10;

                if (unit1 != unit10 && unit1 != unit100 && unit1 != unit1000 && unit10 != unit100 && unit10 != unit1000 && unit100 != unit1000)
                {
                    this.element2D[count, 3] = unit1000;
                    this.element2D[count, 2] = unit100;
                    this.element2D[count, 1] = unit10;
                    this.element2D[count, 0] = unit1;
                    count++;
                }
            }
            return this;
        }

        public void Print()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("[{0},{1},{2},{3}]", this.element2D[i, 3], this.element2D[i, 2], this.element2D[i, 1], this.element2D[i, 0]);
            }
        }

        public Array2D removeArray2D(int count)
        {
            for (int i = count - 1; i < 5045; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    this.element2D[i, j] = this.element2D[i + 1, j];
                }
            }
            return this;
        }
    }
}
