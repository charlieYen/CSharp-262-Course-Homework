namespace NumGuess
{
    partial class 猜數字遊戲
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.excutrTimeLabel1 = new System.Windows.Forms.Label();
            this.resultLabel1 = new System.Windows.Forms.Label();
            this.excuteTimeTextBox1 = new System.Windows.Forms.TextBox();
            this.resultTextBox1 = new System.Windows.Forms.TextBox();
            this.reviewTextBox1 = new System.Windows.Forms.TextBox();
            this.resultLabel2 = new System.Windows.Forms.Label();
            this.reviewLabel1 = new System.Windows.Forms.Label();
            this.reviwLabel2 = new System.Windows.Forms.Label();
            this.reviewTextBox2 = new System.Windows.Forms.TextBox();
            this.excuteButton1 = new System.Windows.Forms.Button();
            this.reviewButton1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // excutrTimeLabel1
            // 
            this.excutrTimeLabel1.AutoSize = true;
            this.excutrTimeLabel1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.excutrTimeLabel1.Location = new System.Drawing.Point(3, 46);
            this.excutrTimeLabel1.Name = "excutrTimeLabel1";
            this.excutrTimeLabel1.Size = new System.Drawing.Size(86, 24);
            this.excutrTimeLabel1.TabIndex = 0;
            this.excutrTimeLabel1.Text = "挑戰場數";
            // 
            // resultLabel1
            // 
            this.resultLabel1.AutoSize = true;
            this.resultLabel1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.resultLabel1.Location = new System.Drawing.Point(30, 96);
            this.resultLabel1.Name = "resultLabel1";
            this.resultLabel1.Size = new System.Drawing.Size(48, 24);
            this.resultLabel1.TabIndex = 0;
            this.resultLabel1.Text = "平均";
            // 
            // excuteTimeTextBox1
            // 
            this.excuteTimeTextBox1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.excuteTimeTextBox1.Location = new System.Drawing.Point(84, 43);
            this.excuteTimeTextBox1.Name = "excuteTimeTextBox1";
            this.excuteTimeTextBox1.Size = new System.Drawing.Size(128, 33);
            this.excuteTimeTextBox1.TabIndex = 1;
            // 
            // resultTextBox1
            // 
            this.resultTextBox1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.resultTextBox1.Location = new System.Drawing.Point(84, 93);
            this.resultTextBox1.Name = "resultTextBox1";
            this.resultTextBox1.Size = new System.Drawing.Size(59, 33);
            this.resultTextBox1.TabIndex = 1;
            this.resultTextBox1.TextChanged += new System.EventHandler(this.resultTextBox1_TextChanged);
            // 
            // reviewTextBox1
            // 
            this.reviewTextBox1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.reviewTextBox1.Location = new System.Drawing.Point(84, 146);
            this.reviewTextBox1.Name = "reviewTextBox1";
            this.reviewTextBox1.Size = new System.Drawing.Size(128, 33);
            this.reviewTextBox1.TabIndex = 1;
            // 
            // resultLabel2
            // 
            this.resultLabel2.AutoSize = true;
            this.resultLabel2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.resultLabel2.Location = new System.Drawing.Point(149, 96);
            this.resultLabel2.Name = "resultLabel2";
            this.resultLabel2.Size = new System.Drawing.Size(67, 24);
            this.resultLabel2.TabIndex = 0;
            this.resultLabel2.Text = "可猜中";
            // 
            // reviewLabel1
            // 
            this.reviewLabel1.AutoSize = true;
            this.reviewLabel1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.reviewLabel1.Location = new System.Drawing.Point(30, 149);
            this.reviewLabel1.Name = "reviewLabel1";
            this.reviewLabel1.Size = new System.Drawing.Size(48, 24);
            this.reviewLabel1.TabIndex = 0;
            this.reviewLabel1.Text = "查第";
            // 
            // reviwLabel2
            // 
            this.reviwLabel2.AutoSize = true;
            this.reviwLabel2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.reviwLabel2.Location = new System.Drawing.Point(218, 149);
            this.reviwLabel2.Name = "reviwLabel2";
            this.reviwLabel2.Size = new System.Drawing.Size(67, 24);
            this.reviwLabel2.TabIndex = 0;
            this.reviwLabel2.Text = "的結果";
            // 
            // reviewTextBox2
            // 
            this.reviewTextBox2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.reviewTextBox2.Location = new System.Drawing.Point(84, 225);
            this.reviewTextBox2.Multiline = true;
            this.reviewTextBox2.Name = "reviewTextBox2";
            this.reviewTextBox2.Size = new System.Drawing.Size(201, 210);
            this.reviewTextBox2.TabIndex = 1;
            // 
            // excuteButton1
            // 
            this.excuteButton1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.excuteButton1.Location = new System.Drawing.Point(218, 43);
            this.excuteButton1.Name = "excuteButton1";
            this.excuteButton1.Size = new System.Drawing.Size(76, 30);
            this.excuteButton1.TabIndex = 2;
            this.excuteButton1.Text = "開始玩";
            this.excuteButton1.UseVisualStyleBackColor = true;
            this.excuteButton1.Click += new System.EventHandler(this.excuteButton1_Click);
            // 
            // reviewButton1
            // 
            this.reviewButton1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.reviewButton1.Location = new System.Drawing.Point(84, 185);
            this.reviewButton1.Name = "reviewButton1";
            this.reviewButton1.Size = new System.Drawing.Size(128, 33);
            this.reviewButton1.TabIndex = 2;
            this.reviewButton1.Text = "查看";
            this.reviewButton1.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(321, 43);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(568, 392);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // 猜數字遊戲
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 460);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.reviewButton1);
            this.Controls.Add(this.excuteButton1);
            this.Controls.Add(this.reviewTextBox2);
            this.Controls.Add(this.reviewTextBox1);
            this.Controls.Add(this.resultTextBox1);
            this.Controls.Add(this.excuteTimeTextBox1);
            this.Controls.Add(this.resultLabel2);
            this.Controls.Add(this.reviwLabel2);
            this.Controls.Add(this.reviewLabel1);
            this.Controls.Add(this.resultLabel1);
            this.Controls.Add(this.excutrTimeLabel1);
            this.Name = "猜數字遊戲";
            this.Text = "猜數字遊戲";
            this.Load += new System.EventHandler(this.猜數字遊戲_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label excutrTimeLabel1;
        private System.Windows.Forms.Label resultLabel1;
        private System.Windows.Forms.TextBox excuteTimeTextBox1;
        private System.Windows.Forms.TextBox resultTextBox1;
        private System.Windows.Forms.TextBox reviewTextBox1;
        private System.Windows.Forms.Label resultLabel2;
        private System.Windows.Forms.Label reviewLabel1;
        private System.Windows.Forms.Label reviwLabel2;
        private System.Windows.Forms.TextBox reviewTextBox2;
        private System.Windows.Forms.Button excuteButton1;
        private System.Windows.Forms.Button reviewButton1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}