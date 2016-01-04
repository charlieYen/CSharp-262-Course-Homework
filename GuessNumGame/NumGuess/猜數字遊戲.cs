using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumGuess
{
    public partial class 猜數字遊戲 : Form
    {
        public 猜數字遊戲()
        {
            InitializeComponent();
        }

        public void 猜數字遊戲_Load(object sender, EventArgs e)
        {
            
        }

        private void excuteButton1_Click(object sender, EventArgs e)
        {
            int runCYC ;
            int trytime = 0;
            int totalTry = 0;
            runCYC = int.Parse(excuteTimeTextBox1.Text);

            for (int cyc = 0; cyc < runCYC; cyc++)
            {
                int[][] answerBase = new int[5041][];
                int count = 0;

                for (int i = 100; i <= 9999; i++)
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
                    answerBase[5040] = new int[] { 9, 8, 7, 6 };
                }

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
                        guess.element[i] = answerBase[0][i];
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
                            if (guess.element[i] == answerBase[tmp][i]) c++;
                            for (int j = 0; j < 4; j++)
                            {
                                if (guess.element[i] == answerBase[tmp][j] && i != j) d++;
                            }
                        }
                        if (a != c || b != d)
                        {
                            for (int i = tmp; i < remain; i++)
                            {
                                for (int j = 0; j < 4; j++)
                                {
                                    answerBase[i][j] = answerBase[i + 1][j];
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
        }

        private void resultTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
