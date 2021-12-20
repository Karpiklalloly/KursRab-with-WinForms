namespace WindowsFormsApp1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_CPU_Temperature = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_CPU_Power = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_CPU_Rate = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_CPU_Info = new System.Windows.Forms.Label();
            this.label_RAM_Info = new System.Windows.Forms.Label();
            this.timer_Update = new System.Windows.Forms.Timer(this.components);
            this.label_test_info1 = new System.Windows.Forms.Label();
            this.label_test_info2 = new System.Windows.Forms.Label();
            this.label_test_info3 = new System.Windows.Forms.Label();
            this.chart_RAM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart_CPU_Temperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_CPU_Power)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_CPU_Rate)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_RAM)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_CPU_Temperature
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_CPU_Temperature.ChartAreas.Add(chartArea1);
            this.chart_CPU_Temperature.Location = new System.Drawing.Point(1, 0);
            this.chart_CPU_Temperature.Margin = new System.Windows.Forms.Padding(4);
            this.chart_CPU_Temperature.Name = "chart_CPU_Temperature";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series1.Name = "Series1";
            this.chart_CPU_Temperature.Series.Add(series1);
            this.chart_CPU_Temperature.Size = new System.Drawing.Size(296, 143);
            this.chart_CPU_Temperature.TabIndex = 0;
            this.chart_CPU_Temperature.Text = "chart1";
            // 
            // chart_CPU_Power
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_CPU_Power.ChartAreas.Add(chartArea2);
            this.chart_CPU_Power.Location = new System.Drawing.Point(1, 148);
            this.chart_CPU_Power.Margin = new System.Windows.Forms.Padding(4);
            this.chart_CPU_Power.Name = "chart_CPU_Power";
            series2.BackSecondaryColor = System.Drawing.Color.Cyan;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series2.LabelForeColor = System.Drawing.Color.IndianRed;
            series2.Name = "Series1";
            this.chart_CPU_Power.Series.Add(series2);
            this.chart_CPU_Power.Size = new System.Drawing.Size(296, 143);
            this.chart_CPU_Power.TabIndex = 1;
            this.chart_CPU_Power.Text = "chart2";
            this.chart_CPU_Power.Click += new System.EventHandler(this.chart2_Click);
            // 
            // chart_CPU_Rate
            // 
            chartArea3.Name = "ChartArea1";
            this.chart_CPU_Rate.ChartAreas.Add(chartArea3);
            this.chart_CPU_Rate.Location = new System.Drawing.Point(1, 298);
            this.chart_CPU_Rate.Margin = new System.Windows.Forms.Padding(4);
            this.chart_CPU_Rate.Name = "chart_CPU_Rate";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series3.Name = "Series1";
            this.chart_CPU_Rate.Series.Add(series3);
            this.chart_CPU_Rate.Size = new System.Drawing.Size(296, 143);
            this.chart_CPU_Rate.TabIndex = 2;
            this.chart_CPU_Rate.Text = "chart3";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chart_CPU_Power);
            this.groupBox1.Controls.Add(this.chart_CPU_Temperature);
            this.groupBox1.Controls.Add(this.chart_CPU_Rate);
            this.groupBox1.Location = new System.Drawing.Point(20, 58);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(305, 439);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label_CPU_Info
            // 
            this.label_CPU_Info.AutoSize = true;
            this.label_CPU_Info.Location = new System.Drawing.Point(21, 34);
            this.label_CPU_Info.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_CPU_Info.Name = "label_CPU_Info";
            this.label_CPU_Info.Size = new System.Drawing.Size(44, 16);
            this.label_CPU_Info.TabIndex = 5;
            this.label_CPU_Info.Text = "label1";
            // 
            // label_RAM_Info
            // 
            this.label_RAM_Info.AutoSize = true;
            this.label_RAM_Info.Location = new System.Drawing.Point(353, 34);
            this.label_RAM_Info.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_RAM_Info.Name = "label_RAM_Info";
            this.label_RAM_Info.Size = new System.Drawing.Size(44, 16);
            this.label_RAM_Info.TabIndex = 6;
            this.label_RAM_Info.Text = "label1";
            // 
            // timer_Update
            // 
            this.timer_Update.Enabled = true;
            this.timer_Update.Interval = 1000;
            this.timer_Update.Tick += new System.EventHandler(this.timer_Update_Tick);
            // 
            // label_test_info1
            // 
            this.label_test_info1.AutoSize = true;
            this.label_test_info1.Location = new System.Drawing.Point(793, 74);
            this.label_test_info1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_test_info1.Name = "label_test_info1";
            this.label_test_info1.Size = new System.Drawing.Size(44, 16);
            this.label_test_info1.TabIndex = 7;
            this.label_test_info1.Text = "label1";
            // 
            // label_test_info2
            // 
            this.label_test_info2.AutoSize = true;
            this.label_test_info2.Location = new System.Drawing.Point(793, 117);
            this.label_test_info2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_test_info2.Name = "label_test_info2";
            this.label_test_info2.Size = new System.Drawing.Size(44, 16);
            this.label_test_info2.TabIndex = 8;
            this.label_test_info2.Text = "label1";
            // 
            // label_test_info3
            // 
            this.label_test_info3.AutoSize = true;
            this.label_test_info3.Location = new System.Drawing.Point(793, 161);
            this.label_test_info3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_test_info3.Name = "label_test_info3";
            this.label_test_info3.Size = new System.Drawing.Size(44, 16);
            this.label_test_info3.TabIndex = 9;
            this.label_test_info3.Text = "label1";
            // 
            // chart_RAM
            // 
            chartArea4.Name = "ChartArea1";
            this.chart_RAM.ChartAreas.Add(chartArea4);
            this.chart_RAM.Location = new System.Drawing.Point(356, 58);
            this.chart_RAM.Margin = new System.Windows.Forms.Padding(4);
            this.chart_RAM.Name = "chart_RAM";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series4.Name = "Series1";
            this.chart_RAM.Series.Add(series4);
            this.chart_RAM.Size = new System.Drawing.Size(296, 143);
            this.chart_RAM.TabIndex = 10;
            this.chart_RAM.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.chart_RAM);
            this.Controls.Add(this.label_test_info3);
            this.Controls.Add(this.label_test_info2);
            this.Controls.Add(this.label_test_info1);
            this.Controls.Add(this.label_RAM_Info);
            this.Controls.Add(this.label_CPU_Info);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart_CPU_Temperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_CPU_Power)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_CPU_Rate)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_RAM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_CPU_Temperature;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_CPU_Power;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_CPU_Rate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_CPU_Info;
        private System.Windows.Forms.Label label_RAM_Info;
        private System.Windows.Forms.Timer timer_Update;
        private System.Windows.Forms.Label label_test_info1;
        private System.Windows.Forms.Label label_test_info2;
        private System.Windows.Forms.Label label_test_info3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_RAM;
    }
}

