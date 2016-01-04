using GameLibrary;
using System;

namespace programe02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int trytime = 0;
            int totalTry = 0;
            Console.Write("1A2B電腦自我挑戰，請輸入測試局數：");
            int runCYC = int.Parse(Console.ReadLine());

            for (int cyc = 0; cyc < runCYC; cyc++)
            {
                GameLibrary.Array2D answerBase = new GameLibrary.Array2D(5050, 4);
                answerBase.GenerateAnswerTable();

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
                Console.Write("題目是：");
                answer.Print();
                Console.WriteLine();

                GameLibrary.Array guess = new GameLibrary.Array(4);

                int a, b, c, d;
                int remain = 5040;
                trytime = 0;
                do
                {
                    a = 0;
                    b = 0;

                    for (int i = 0; i < 4; i++)
                    {
                        guess.element[i] = answerBase.element2D[0, i];
                    }
                    trytime++;

                    for (int i = 0; i < 4; i++)
                    {
                        if (guess.element[i] == answer.element[i]) a++;
                        for (int j = 0; j < 4; j++)
                        {
                            if (guess.element[i] == answer.element[j] && i != j) b++;
                        }
                    }

                    Console.WriteLine("第{0}次猜：[{1},{2},{3},{4}]，結果：{5}A{6}B",
                        trytime,
                        guess.element[0], guess.element[1], guess.element[2], guess.element[3],
                        a, b);

                    for (int tmp = 0; tmp < remain; tmp++)
                    {
                        c = 0;
                        d = 0;
                        for (int i = 0; i < 4; i++)
                        {
                            if (guess.element[i] == answerBase.element2D[tmp, i]) c++;
                            for (int j = 0; j < 4; j++)
                            {
                                if (guess.element[i] == answerBase.element2D[tmp, j] && i != j) d++;
                            }
                        }
                        if (a != c || b != d)
                        {
                            for (int i = tmp; i < remain; i++)
                            {
                                for (int j = 0; j < 4; j++)
                                {
                                    answerBase.element2D[i, j] = answerBase.element2D[i + 1, j];
                                }
                            }
                            remain--;
                            tmp--;
                        }
                    }
                } while (a != 4);
                totalTry += trytime;
            }

            double avgTry = (double)totalTry / runCYC;
            Console.WriteLine("*************************");
            Console.WriteLine("***總共測試了{0}場猜數字*", runCYC);
            Console.WriteLine("***平均 {0}次猜中答案***", avgTry.ToString("0.00"));
            Console.WriteLine("*************************");
        }
    }
}