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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_CPU_Temperature = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_CPU_Power = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_CPU_Rate = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox_CPU = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label_CPU_temperature = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label_CPU_Power = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label_CPU_Rate = new System.Windows.Forms.Label();
            this.timer_Update = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox_HDD = new System.Windows.Forms.GroupBox();
            this.groupBox_RAM = new System.Windows.Forms.GroupBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.chart_RAM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label_RAM_Info = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.chart_BIG = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart_CPU_Temperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_CPU_Power)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_CPU_Rate)).BeginInit();
            this.groupBox_CPU.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox_RAM.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_RAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_BIG)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_CPU_Temperature
            // 
            this.chart_CPU_Temperature.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart_CPU_Temperature.ChartAreas.Add(chartArea1);
            this.chart_CPU_Temperature.Location = new System.Drawing.Point(8, 27);
            this.chart_CPU_Temperature.Margin = new System.Windows.Forms.Padding(4);
            this.chart_CPU_Temperature.Name = "chart_CPU_Temperature";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series1.Name = "Series1";
            series1.ToolTip = "#VALY";
            this.chart_CPU_Temperature.Series.Add(series1);
            this.chart_CPU_Temperature.Size = new System.Drawing.Size(296, 143);
            this.chart_CPU_Temperature.TabIndex = 0;
            this.chart_CPU_Temperature.Text = "chart1";
            this.chart_CPU_Temperature.MouseEnter += new System.EventHandler(this.panel10_MouseEnter);
            this.chart_CPU_Temperature.MouseLeave += new System.EventHandler(this.chart_CPU_Temperature_MouseLeave);
            this.chart_CPU_Temperature.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart_CPU_Temperature_MouseMove);
            // 
            // chart_CPU_Power
            // 
            this.chart_CPU_Power.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chart_CPU_Power.ChartAreas.Add(chartArea2);
            this.chart_CPU_Power.Location = new System.Drawing.Point(8, 27);
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
            this.chart_CPU_Power.Click += new System.EventHandler(this.chart_CPU_Power_Click);
            this.chart_CPU_Power.MouseEnter += new System.EventHandler(this.panel10_MouseEnter);
            this.chart_CPU_Power.MouseLeave += new System.EventHandler(this.chart_CPU_Power_MouseLeave);
            this.chart_CPU_Power.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart_CPU_Power_MouseMove);
            // 
            // chart_CPU_Rate
            // 
            this.chart_CPU_Rate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Name = "ChartArea1";
            this.chart_CPU_Rate.ChartAreas.Add(chartArea3);
            this.chart_CPU_Rate.Location = new System.Drawing.Point(8, 27);
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
            this.chart_CPU_Rate.Click += new System.EventHandler(this.chart_CPU_Rate_Click_1);
            this.chart_CPU_Rate.MouseEnter += new System.EventHandler(this.panel10_MouseEnter);
            this.chart_CPU_Rate.MouseLeave += new System.EventHandler(this.chart_CPU_Rate_MouseLeave);
            this.chart_CPU_Rate.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart_CPU_Rate_MouseMove);
            // 
            // groupBox_CPU
            // 
            this.groupBox_CPU.AutoSize = true;
            this.groupBox_CPU.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox_CPU.Controls.Add(this.panel4);
            this.groupBox_CPU.Controls.Add(this.panel5);
            this.groupBox_CPU.Controls.Add(this.panel6);
            this.groupBox_CPU.Location = new System.Drawing.Point(4, 13);
            this.groupBox_CPU.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_CPU.Name = "groupBox_CPU";
            this.groupBox_CPU.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_CPU.Size = new System.Drawing.Size(322, 593);
            this.groupBox_CPU.TabIndex = 4;
            this.groupBox_CPU.TabStop = false;
            this.groupBox_CPU.Text = "Процессор";
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.Controls.Add(this.label_CPU_temperature);
            this.panel4.Controls.Add(this.chart_CPU_Temperature);
            this.panel4.Location = new System.Drawing.Point(5, 392);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(310, 179);
            this.panel4.TabIndex = 14;
            this.panel4.MouseEnter += new System.EventHandler(this.panel10_MouseEnter);
            this.panel4.MouseLeave += new System.EventHandler(this.panel10_MouseLeave);
            this.panel4.MouseHover += new System.EventHandler(this.panel5_MouseHover);
            // 
            // label_CPU_temperature
            // 
            this.label_CPU_temperature.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_CPU_temperature.AutoSize = true;
            this.label_CPU_temperature.Location = new System.Drawing.Point(5, 7);
            this.label_CPU_temperature.Name = "label_CPU_temperature";
            this.label_CPU_temperature.Size = new System.Drawing.Size(115, 16);
            this.label_CPU_temperature.TabIndex = 11;
            this.label_CPU_temperature.Text = "Температура, °C";
            this.label_CPU_temperature.MouseEnter += new System.EventHandler(this.panel10_MouseEnter);
            // 
            // panel5
            // 
            this.panel5.AutoSize = true;
            this.panel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel5.Controls.Add(this.label_CPU_Power);
            this.panel5.Controls.Add(this.chart_CPU_Power);
            this.panel5.Location = new System.Drawing.Point(5, 22);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(308, 177);
            this.panel5.TabIndex = 15;
            this.panel5.MouseEnter += new System.EventHandler(this.panel10_MouseEnter);
            this.panel5.MouseLeave += new System.EventHandler(this.panel10_MouseLeave);
            this.panel5.MouseHover += new System.EventHandler(this.panel5_MouseHover);
            // 
            // label_CPU_Power
            // 
            this.label_CPU_Power.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_CPU_Power.AutoSize = true;
            this.label_CPU_Power.Location = new System.Drawing.Point(5, 7);
            this.label_CPU_Power.Name = "label_CPU_Power";
            this.label_CPU_Power.Size = new System.Drawing.Size(88, 16);
            this.label_CPU_Power.TabIndex = 4;
            this.label_CPU_Power.Text = "Нагрузка, %";
            this.label_CPU_Power.MouseEnter += new System.EventHandler(this.panel10_MouseEnter);
            // 
            // panel6
            // 
            this.panel6.AutoSize = true;
            this.panel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel6.Controls.Add(this.chart_CPU_Rate);
            this.panel6.Controls.Add(this.label_CPU_Rate);
            this.panel6.Location = new System.Drawing.Point(5, 207);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(310, 179);
            this.panel6.TabIndex = 16;
            this.panel6.MouseEnter += new System.EventHandler(this.panel10_MouseEnter);
            this.panel6.MouseLeave += new System.EventHandler(this.panel10_MouseLeave);
            this.panel6.MouseHover += new System.EventHandler(this.panel5_MouseHover);
            // 
            // label_CPU_Rate
            // 
            this.label_CPU_Rate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_CPU_Rate.AutoSize = true;
            this.label_CPU_Rate.Location = new System.Drawing.Point(5, 7);
            this.label_CPU_Rate.Name = "label_CPU_Rate";
            this.label_CPU_Rate.Size = new System.Drawing.Size(93, 16);
            this.label_CPU_Rate.TabIndex = 3;
            this.label_CPU_Rate.Text = "Частота, МГц";
            this.label_CPU_Rate.MouseEnter += new System.EventHandler(this.panel10_MouseEnter);
            // 
            // timer_Update
            // 
            this.timer_Update.Enabled = true;
            this.timer_Update.Interval = 1000;
            this.timer_Update.Tick += new System.EventHandler(this.timer_Update_Tick);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.groupBox_HDD);
            this.panel1.Controls.Add(this.groupBox_CPU);
            this.panel1.Controls.Add(this.groupBox_RAM);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 861);
            this.panel1.TabIndex = 11;
            this.panel1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll_1);
            // 
            // groupBox_HDD
            // 
            this.groupBox_HDD.AutoSize = true;
            this.groupBox_HDD.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox_HDD.Location = new System.Drawing.Point(4, 850);
            this.groupBox_HDD.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_HDD.Name = "groupBox_HDD";
            this.groupBox_HDD.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_HDD.Size = new System.Drawing.Size(8, 7);
            this.groupBox_HDD.TabIndex = 4;
            this.groupBox_HDD.TabStop = false;
            this.groupBox_HDD.Text = "Жесткие диски";
            // 
            // groupBox_RAM
            // 
            this.groupBox_RAM.AutoSize = true;
            this.groupBox_RAM.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox_RAM.Controls.Add(this.panel10);
            this.groupBox_RAM.Location = new System.Drawing.Point(4, 619);
            this.groupBox_RAM.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_RAM.Name = "groupBox_RAM";
            this.groupBox_RAM.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_RAM.Size = new System.Drawing.Size(324, 223);
            this.groupBox_RAM.TabIndex = 4;
            this.groupBox_RAM.TabStop = false;
            this.groupBox_RAM.Text = "ОЗУ";
            // 
            // panel10
            // 
            this.panel10.AutoSize = true;
            this.panel10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel10.Controls.Add(this.chart_RAM);
            this.panel10.Controls.Add(this.label_RAM_Info);
            this.panel10.Location = new System.Drawing.Point(5, 22);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(312, 179);
            this.panel10.TabIndex = 17;
            this.panel10.Paint += new System.Windows.Forms.PaintEventHandler(this.panel10_Paint);
            this.panel10.MouseEnter += new System.EventHandler(this.panel10_MouseEnter);
            this.panel10.MouseLeave += new System.EventHandler(this.panel10_MouseLeave);
            this.panel10.MouseHover += new System.EventHandler(this.panel5_MouseHover);
            // 
            // chart_RAM
            // 
            this.chart_RAM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea4.Name = "ChartArea1";
            this.chart_RAM.ChartAreas.Add(chartArea4);
            this.chart_RAM.Location = new System.Drawing.Point(8, 27);
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
            this.chart_RAM.MouseEnter += new System.EventHandler(this.panel10_MouseEnter);
            // 
            // label_RAM_Info
            // 
            this.label_RAM_Info.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_RAM_Info.AutoSize = true;
            this.label_RAM_Info.Location = new System.Drawing.Point(5, 7);
            this.label_RAM_Info.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_RAM_Info.Name = "label_RAM_Info";
            this.label_RAM_Info.Size = new System.Drawing.Size(92, 16);
            this.label_RAM_Info.TabIndex = 6;
            this.label_RAM_Info.Text = "Занято x из y";
            this.label_RAM_Info.MouseEnter += new System.EventHandler(this.panel10_MouseEnter);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Location = new System.Drawing.Point(-89, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 0);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoScroll = true;
            this.panel3.AutoSize = true;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.Location = new System.Drawing.Point(645, 298);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 0);
            this.panel3.TabIndex = 13;
            // 
            // panel8
            // 
            this.panel8.AutoScroll = true;
            this.panel8.AutoSize = true;
            this.panel8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(862, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(0, 858);
            this.panel8.TabIndex = 15;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.vScrollBar1.Location = new System.Drawing.Point(334, 4);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(21, 854);
            this.vScrollBar1.TabIndex = 16;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll_1);
            // 
            // chart_BIG
            // 
            this.chart_BIG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea5.Name = "ChartArea1";
            this.chart_BIG.ChartAreas.Add(chartArea5);
            this.chart_BIG.Location = new System.Drawing.Point(380, 13);
            this.chart_BIG.Margin = new System.Windows.Forms.Padding(4);
            this.chart_BIG.Name = "chart_BIG";
            series5.BackSecondaryColor = System.Drawing.Color.Cyan;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series5.LabelForeColor = System.Drawing.Color.IndianRed;
            series5.Name = "Series1";
            this.chart_BIG.Series.Add(series5);
            this.chart_BIG.Size = new System.Drawing.Size(469, 832);
            this.chart_BIG.TabIndex = 17;
            this.chart_BIG.Text = "chart_BIG";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 858);
            this.Controls.Add(this.chart_BIG);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_CPU_Temperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_CPU_Power)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_CPU_Rate)).EndInit();
            this.groupBox_CPU.ResumeLayout(false);
            this.groupBox_CPU.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox_RAM.ResumeLayout(false);
            this.groupBox_RAM.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_RAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_BIG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_CPU_Temperature;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_CPU_Power;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_CPU_Rate;
        private System.Windows.Forms.GroupBox groupBox_CPU;
        private System.Windows.Forms.Timer timer_Update;
        private System.Windows.Forms.Label label_CPU_temperature;
        private System.Windows.Forms.Label label_CPU_Power;
        private System.Windows.Forms.Label label_CPU_Rate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.GroupBox groupBox_RAM;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_RAM;
        private System.Windows.Forms.Label label_RAM_Info;
        private System.Windows.Forms.GroupBox groupBox_HDD;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_BIG;
    }
}

