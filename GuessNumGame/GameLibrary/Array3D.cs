using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class Array3D
    {
        public int[,,] element3D;

        public Array3D(int x, int y)
        {
            element3D = new int[x,y,4];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    for (int k = 0; k < 4;k++ ){
                        element3D[i, j, k] = 0;
                    }
                }
            }
        }





    }
}
