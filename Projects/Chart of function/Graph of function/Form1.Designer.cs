namespace Graph_of_function
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.inputMin = new System.Windows.Forms.TextBox();
            this.inputMax = new System.Windows.Forms.TextBox();
            this.inputStep = new System.Windows.Forms.TextBox();
            this.goButton = new System.Windows.Forms.Button();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelStep = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.MyChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.MyChart)).BeginInit();
            this.SuspendLayout();
            // 
            // inputMin
            // 
            this.inputMin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.inputMin.Location = new System.Drawing.Point(260, 507);
            this.inputMin.Name = "inputMin";
            this.inputMin.Size = new System.Drawing.Size(100, 20);
            this.inputMin.TabIndex = 1;
            // 
            // inputMax
            // 
            this.inputMax.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.inputMax.Location = new System.Drawing.Point(366, 507);
            this.inputMax.Name = "inputMax";
            this.inputMax.Size = new System.Drawing.Size(100, 20);
            this.inputMax.TabIndex = 2;
            // 
            // inputStep
            // 
            this.inputStep.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.inputStep.Location = new System.Drawing.Point(472, 507);
            this.inputStep.Name = "inputStep";
            this.inputStep.Size = new System.Drawing.Size(100, 20);
            this.inputStep.TabIndex = 3;
            // 
            // goButton
            // 
            this.goButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.goButton.Location = new System.Drawing.Point(582, 505);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(75, 23);
            this.goButton.TabIndex = 4;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // labelMin
            // 
            this.labelMin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelMin.AutoSize = true;
            this.labelMin.Location = new System.Drawing.Point(257, 488);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(24, 13);
            this.labelMin.TabIndex = 5;
            this.labelMin.Text = "Min";
            // 
            // labelStep
            // 
            this.labelStep.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelStep.AutoSize = true;
            this.labelStep.Location = new System.Drawing.Point(469, 488);
            this.labelStep.Name = "labelStep";
            this.labelStep.Size = new System.Drawing.Size(29, 13);
            this.labelStep.TabIndex = 6;
            this.labelStep.Text = "Step";
            // 
            // labelMax
            // 
            this.labelMax.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelMax.AutoSize = true;
            this.labelMax.Location = new System.Drawing.Point(363, 488);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(27, 13);
            this.labelMax.TabIndex = 7;
            this.labelMax.Text = "Max";
            // 
            // MyChart
            // 
            this.MyChart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.MyChart.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.MyChart.Legends.Add(legend1);
            this.MyChart.Location = new System.Drawing.Point(41, 105);
            this.MyChart.Name = "MyChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.MyChart.Series.Add(series1);
            this.MyChart.Size = new System.Drawing.Size(821, 300);
            this.MyChart.TabIndex = 8;
            this.MyChart.Text = "chart1";
            // 
            // MainWindow
            // 
            this.AcceptButton = this.goButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 600);
            this.Controls.Add(this.MyChart);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.labelStep);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.inputStep);
            this.Controls.Add(this.inputMax);
            this.Controls.Add(this.inputMin);
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chart of function";
            ((System.ComponentModel.ISupportInitialize)(this.MyChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox inputMin;
        private System.Windows.Forms.TextBox inputMax;
        private System.Windows.Forms.TextBox inputStep;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelStep;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.DataVisualization.Charting.Chart MyChart;
    }
}

