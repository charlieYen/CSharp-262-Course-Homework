using GameLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerVsComputer_Form
{
    public partial class Form1 : Form
    {
        private int trytime;
        private int runCYC = 0;
        private double avgTry = 0;
        private int resultCYC;

        private GameLibrary.Array3D reviewTable = new GameLibrary.Array3D(100, 10);
        public GameLibrary.Array statist = new GameLibrary.Array(10);

        public Form1()
        {
            InitializeComponent();
        }

        private void CYCtextBox1_TextChanged(object sender, EventArgs e)
        {
            bool isCYCtextBox1 = int.TryParse(CYCtextBox1.Text, out runCYC);
            if (isCYCtextBox1)
            { CYCtextBox1.Text = runCYC.ToString(); }
            else { MessageBox.Show("你有事嗎"); }
        }

        private void StartButton1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                statist.element[i] = 0;
            }

            int totalTry = 0;

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
                        reviewTable.element3D[cyc, trytime, i] = answerBase.element2D[0, i];
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
                statist.element[trytime]++;
                totalTry += trytime;
            }
            avgTry = (double)totalTry / runCYC;
            ResultTextBox1.Text = avgTry.ToString();
            MessageBox.Show("跑完了");
        }

        private void restButton1_Click(object sender, EventArgs e)
        {
            runCYC = 1;
            CYCtextBox1.Text = runCYC.ToString();
            avgTry = 0;
            ResultTextBox1.Text = avgTry.ToString();
            resultCYC = 1;
            ReviewTextBox1.Text = resultCYC.ToString();
            ReviewTextBox2.Text = "[0][0][0][0]";

            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    for (int k = 0; k < 4; k++)
                    { reviewTable.element3D[i, j, k] = 0; }
                }
            }
            foreach (var series in chart1.Series) { series.Points.Clear(); }
        }

        private void ReviewTextBox1_TextChanged(object sender, EventArgs e)
        {
            bool isReviewTextBox1 = int.TryParse(ReviewTextBox1.Text, out resultCYC);
            if (isReviewTextBox1) ReviewTextBox1.Text = resultCYC.ToString();
            else MessageBox.Show("請輸入整數");
        }

        private void reviewButton1_Click(object sender, EventArgs e)
        {
            string result = string.Empty;
            int count = 0;
            for (int i = 0; i < 10; i++)
            {
                string tmpResult = string.Empty;
                for (int j = 3; j >= 0; j--)
                {
                    tmpResult += "[" + reviewTable.element3D[resultCYC - 1, i, j] + "]";
                }
                tmpResult += Environment.NewLine;
                if (reviewTable.element3D[resultCYC - 1, i, 0] == 0 && reviewTable.element3D[resultCYC - 1, i, 1] == 0 && reviewTable.element3D[resultCYC - 1, i, 2] == 0 && reviewTable.element3D[resultCYC - 1, i, 3] == 0) { break; }
                else
                {
                    result += tmpResult;
                    count++;
                }
            }

            ReviewTextBox2.Text = result + "猜了" + count.ToString() + "次";
        }

        private void checkChartButton1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                this.chart1.Series["場數"].Points.AddXY(i, statist.element[i]);
            }
        }
    }
}