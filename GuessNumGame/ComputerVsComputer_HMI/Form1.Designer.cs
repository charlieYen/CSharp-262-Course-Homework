namespace ComputerVsComputer_Form
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.CYCtextBox1 = new System.Windows.Forms.TextBox();
            this.ResultTextBox1 = new System.Windows.Forms.TextBox();
            this.ReviewTextBox1 = new System.Windows.Forms.TextBox();
            this.ReviewTextBox2 = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.StartButton1 = new System.Windows.Forms.Button();
            this.runLabel1 = new System.Windows.Forms.Label();
            this.resultLabel1 = new System.Windows.Forms.Label();
            this.reviewLabel1 = new System.Windows.Forms.Label();
            this.reviewLabel2 = new System.Windows.Forms.Label();
            this.restButton1 = new System.Windows.Forms.Button();
            this.resultLabel2 = new System.Windows.Forms.Label();
            this.reviewButton1 = new System.Windows.Forms.Button();
            this.checkChartButton1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // CYCtextBox1
            // 
            this.CYCtextBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CYCtextBox1.Location = new System.Drawing.Point(81, 48);
            this.CYCtextBox1.Name = "CYCtextBox1";
            this.CYCtextBox1.Size = new System.Drawing.Size(112, 29);
            this.CYCtextBox1.TabIndex = 0;
            this.CYCtextBox1.TextChanged += new System.EventHandler(this.CYCtextBox1_TextChanged);
            // 
            // ResultTextBox1
            // 
            this.ResultTextBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ResultTextBox1.Location = new System.Drawing.Point(97, 88);
            this.ResultTextBox1.Name = "ResultTextBox1";
            this.ResultTextBox1.Size = new System.Drawing.Size(51, 29);
            this.ResultTextBox1.TabIndex = 1;
            // 
            // ReviewTextBox1
            // 
            this.ReviewTextBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ReviewTextBox1.Location = new System.Drawing.Point(81, 133);
            this.ReviewTextBox1.Name = "ReviewTextBox1";
            this.ReviewTextBox1.Size = new System.Drawing.Size(111, 29);
            this.ReviewTextBox1.TabIndex = 2;
            this.ReviewTextBox1.TextChanged += new System.EventHandler(this.ReviewTextBox1_TextChanged);
            // 
            // ReviewTextBox2
            // 
            this.ReviewTextBox2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ReviewTextBox2.Location = new System.Drawing.Point(80, 175);
            this.ReviewTextBox2.Multiline = true;
            this.ReviewTextBox2.Name = "ReviewTextBox2";
            this.ReviewTextBox2.Size = new System.Drawing.Size(111, 209);
            this.ReviewTextBox2.TabIndex = 3;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(294, 133);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "場數";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(383, 156);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // StartButton1
            // 
            this.StartButton1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.StartButton1.Location = new System.Drawing.Point(199, 48);
            this.StartButton1.Name = "StartButton1";
            this.StartButton1.Size = new System.Drawing.Size(85, 29);
            this.StartButton1.TabIndex = 5;
            this.StartButton1.Text = "執行";
            this.StartButton1.UseVisualStyleBackColor = true;
            this.StartButton1.Click += new System.EventHandler(this.StartButton1_Click);
            // 
            // runLabel1
            // 
            this.runLabel1.AutoSize = true;
            this.runLabel1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.runLabel1.Location = new System.Drawing.Point(1, 47);
            this.runLabel1.Name = "runLabel1";
            this.runLabel1.Size = new System.Drawing.Size(74, 21);
            this.runLabel1.TabIndex = 6;
            this.runLabel1.Text = "測試場數";
            // 
            // resultLabel1
            // 
            this.resultLabel1.AutoSize = true;
            this.resultLabel1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.resultLabel1.Location = new System.Drawing.Point(49, 91);
            this.resultLabel1.Name = "resultLabel1";
            this.resultLabel1.Size = new System.Drawing.Size(42, 21);
            this.resultLabel1.TabIndex = 6;
            this.resultLabel1.Text = "平均";
            // 
            // reviewLabel1
            // 
            this.reviewLabel1.AutoSize = true;
            this.reviewLabel1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.reviewLabel1.Location = new System.Drawing.Point(17, 136);
            this.reviewLabel1.Name = "reviewLabel1";
            this.reviewLabel1.Size = new System.Drawing.Size(58, 21);
            this.reviewLabel1.TabIndex = 6;
            this.reviewLabel1.Text = "查看第";
            // 
            // reviewLabel2
            // 
            this.reviewLabel2.AutoSize = true;
            this.reviewLabel2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.reviewLabel2.Location = new System.Drawing.Point(193, 136);
            this.reviewLabel2.Name = "reviewLabel2";
            this.reviewLabel2.Size = new System.Drawing.Size(74, 21);
            this.reviewLabel2.TabIndex = 6;
            this.reviewLabel2.Text = "局的結果";
            // 
            // restButton1
            // 
            this.restButton1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.restButton1.Location = new System.Drawing.Point(602, 338);
            this.restButton1.Name = "restButton1";
            this.restButton1.Size = new System.Drawing.Size(75, 39);
            this.restButton1.TabIndex = 7;
            this.restButton1.Text = "Reset";
            this.restButton1.UseVisualStyleBackColor = true;
            this.restButton1.Click += new System.EventHandler(this.restButton1_Click);
            // 
            // resultLabel2
            // 
            this.resultLabel2.AutoSize = true;
            this.resultLabel2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.resultLabel2.Location = new System.Drawing.Point(154, 91);
            this.resultLabel2.Name = "resultLabel2";
            this.resultLabel2.Size = new System.Drawing.Size(58, 21);
            this.resultLabel2.TabIndex = 6;
            this.resultLabel2.Text = "可猜中";
            // 
            // reviewButton1
            // 
            this.reviewButton1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.reviewButton1.Location = new System.Drawing.Point(199, 175);
            this.reviewButton1.Name = "reviewButton1";
            this.reviewButton1.Size = new System.Drawing.Size(85, 29);
            this.reviewButton1.TabIndex = 8;
            this.reviewButton1.Text = "查看";
            this.reviewButton1.UseVisualStyleBackColor = true;
            this.reviewButton1.Click += new System.EventHandler(this.reviewButton1_Click);
            // 
            // checkChartButton1
            // 
            this.checkChartButton1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkChartButton1.Location = new System.Drawing.Point(592, 79);
            this.checkChartButton1.Name = "checkChartButton1";
            this.checkChartButton1.Size = new System.Drawing.Size(85, 29);
            this.checkChartButton1.TabIndex = 9;
            this.checkChartButton1.Text = "看分佈";
            this.checkChartButton1.UseVisualStyleBackColor = true;
            this.checkChartButton1.Click += new System.EventHandler(this.checkChartButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 389);
            this.Controls.Add(this.checkChartButton1);
            this.Controls.Add(this.reviewButton1);
            this.Controls.Add(this.restButton1);
            this.Controls.Add(this.reviewLabel2);
            this.Controls.Add(this.reviewLabel1);
            this.Controls.Add(this.resultLabel2);
            this.Controls.Add(this.resultLabel1);
            this.Controls.Add(this.runLabel1);
            this.Controls.Add(this.StartButton1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.ReviewTextBox2);
            this.Controls.Add(this.ReviewTextBox1);
            this.Controls.Add(this.ResultTextBox1);
            this.Controls.Add(this.CYCtextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CYCtextBox1;
        private System.Windows.Forms.TextBox ResultTextBox1;
        private System.Windows.Forms.TextBox ReviewTextBox1;
        private System.Windows.Forms.TextBox ReviewTextBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button StartButton1;
        private System.Windows.Forms.Label runLabel1;
        private System.Windows.Forms.Label resultLabel1;
        private System.Windows.Forms.Label reviewLabel1;
        private System.Windows.Forms.Label reviewLabel2;
        private System.Windows.Forms.Button restButton1;
        private System.Windows.Forms.Label resultLabel2;
        private System.Windows.Forms.Button reviewButton1;
        private System.Windows.Forms.Button checkChartButton1;
    }
}

