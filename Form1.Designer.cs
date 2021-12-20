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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_CPU_Temperature = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_CPU_Power = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_CPU_Rate = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_RAM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_CPU_Info = new System.Windows.Forms.Label();
            this.label_RAM_Info = new System.Windows.Forms.Label();
            this.timer_Update = new System.Windows.Forms.Timer(this.components);
            this.label_test_info1 = new System.Windows.Forms.Label();
            this.label_test_info2 = new System.Windows.Forms.Label();
            this.label_test_info3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart_CPU_Temperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_CPU_Power)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_CPU_Rate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_RAM)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart_CPU_Temperature
            // 
            chartArea5.Name = "ChartArea1";
            this.chart_CPU_Temperature.ChartAreas.Add(chartArea5);
            this.chart_CPU_Temperature.Location = new System.Drawing.Point(1, 0);
            this.chart_CPU_Temperature.Margin = new System.Windows.Forms.Padding(4);
            this.chart_CPU_Temperature.Name = "chart_CPU_Temperature";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series5.Name = "Series1";
            this.chart_CPU_Temperature.Series.Add(series5);
            this.chart_CPU_Temperature.Size = new System.Drawing.Size(296, 143);
            this.chart_CPU_Temperature.TabIndex = 0;
            this.chart_CPU_Temperature.Text = "chart1";
            // 
            // chart_CPU_Power
            // 
            chartArea6.Name = "ChartArea1";
            this.chart_CPU_Power.ChartAreas.Add(chartArea6);
            this.chart_CPU_Power.Location = new System.Drawing.Point(1, 148);
            this.chart_CPU_Power.Margin = new System.Windows.Forms.Padding(4);
            this.chart_CPU_Power.Name = "chart_CPU_Power";
            series6.BackSecondaryColor = System.Drawing.Color.Cyan;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series6.LabelForeColor = System.Drawing.Color.IndianRed;
            series6.Name = "Series1";
            this.chart_CPU_Power.Series.Add(series6);
            this.chart_CPU_Power.Size = new System.Drawing.Size(296, 143);
            this.chart_CPU_Power.TabIndex = 1;
            this.chart_CPU_Power.Text = "chart2";
            this.chart_CPU_Power.Click += new System.EventHandler(this.chart2_Click);
            // 
            // chart_CPU_Rate
            // 
            chartArea7.Name = "ChartArea1";
            this.chart_CPU_Rate.ChartAreas.Add(chartArea7);
            this.chart_CPU_Rate.Location = new System.Drawing.Point(1, 298);
            this.chart_CPU_Rate.Margin = new System.Windows.Forms.Padding(4);
            this.chart_CPU_Rate.Name = "chart_CPU_Rate";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series7.Name = "Series1";
            this.chart_CPU_Rate.Series.Add(series7);
            this.chart_CPU_Rate.Size = new System.Drawing.Size(296, 143);
            this.chart_CPU_Rate.TabIndex = 2;
            this.chart_CPU_Rate.Text = "chart3";
            // 
            // chart_RAM
            // 
            chartArea8.Name = "ChartArea1";
            this.chart_RAM.ChartAreas.Add(chartArea8);
            legend2.Name = "Legend1";
            this.chart_RAM.Legends.Add(legend2);
            this.chart_RAM.Location = new System.Drawing.Point(353, 58);
            this.chart_RAM.Margin = new System.Windows.Forms.Padding(4);
            this.chart_RAM.Name = "chart_RAM";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.chart_RAM.Series.Add(series8);
            this.chart_RAM.Size = new System.Drawing.Size(316, 143);
            this.chart_RAM.TabIndex = 3;
            this.chart_RAM.Text = "chart1";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label_test_info3);
            this.Controls.Add(this.label_test_info2);
            this.Controls.Add(this.label_test_info1);
            this.Controls.Add(this.label_RAM_Info);
            this.Controls.Add(this.label_CPU_Info);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chart_RAM);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart_CPU_Temperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_CPU_Power)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_CPU_Rate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_RAM)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_CPU_Temperature;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_CPU_Power;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_CPU_Rate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_RAM;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_CPU_Info;
        private System.Windows.Forms.Label label_RAM_Info;
        private System.Windows.Forms.Timer timer_Update;
        private System.Windows.Forms.Label label_test_info1;
        private System.Windows.Forms.Label label_test_info2;
        private System.Windows.Forms.Label label_test_info3;
    }
}

