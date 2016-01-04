using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class Array
    {
        public int[] element;
        

        public Array(int length)
        {
            element = new int[length];
            for(int i=0; i < length; i++)
            {
                element[i] = 0;
            }
        }

       

        public Array GenerateSequence()
        {
            for(int i =0; i<this.element.Length; i++)
            {
                element[i] = i;
            }
            return this;
        }

        public Array Remove(int eraseIndex)
        {
            int[] newArray = new int[this.element.Length - 1];
            int j = 0;
            for(int i = 0; i < this.element.Length; i++)
            {
                if (i == eraseIndex) continue;
                newArray[j] = element[i];
                j++;
            }
            this.element = newArray;
            return this;
         }

        public void Print()
        {
            for(int i = 0; i < this.element.Length; i++)
            {
                Console.Write("[{0}]", element[i]);
            }
        }
    }
}
