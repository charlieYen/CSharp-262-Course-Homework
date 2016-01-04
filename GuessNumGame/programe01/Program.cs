using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLibrary;

namespace programe01
{
    class Program
    {
        static void Main(string[] args)
        {
            GameLibrary.Array sequent = new GameLibrary.Array(10);
            sequent.GenerateSequence();
            GameLibrary.Array answer = new GameLibrary.Array(4);
            Random random = new Random();
            for (int i = 0; i < 4; i++)
            {
                int pickedIndex = random.Next(0, sequent.element.Length);
                answer.element[i] = sequent.element[pickedIndex];
                sequent.Remove(pickedIndex);
            }
            answer.Print();

            GameLibrary.Array guess = new GameLibrary.Array(4);
            
            int a , b ;
            do{
                a = 0;
                b = 0;
                Console.WriteLine("請輸入4個不同的數字，以Enter做區隔：");
            for (int i = 0; i < 4; i++)
            {
                guess.element[i] = int.Parse(Console.ReadLine());
            }

                for (int i = 0; i < 4; i++)
                {
                    if (guess.element[i] == answer.element[i]) a++;
                    for (int j = 0; j < 4; j++)
                    {
                      if (guess.element[i] == answer.element[j] && i != j) b++;
                    }   
                }
                Console.WriteLine("{0}A{1}B", a, b);
            } while (a != 4);
        }
    }
}
