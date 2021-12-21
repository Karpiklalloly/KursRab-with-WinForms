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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea15 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel7 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.chart_RAM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label_RAM_Info = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart_CPU_Temperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_CPU_Power)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_CPU_Rate)).BeginInit();
            this.groupBox_CPU.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel7.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_RAM)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_CPU_Temperature
            // 
            this.chart_CPU_Temperature.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea11.Name = "ChartArea1";
            this.chart_CPU_Temperature.ChartAreas.Add(chartArea11);
            this.chart_CPU_Temperature.Location = new System.Drawing.Point(8, 27);
            this.chart_CPU_Temperature.Margin = new System.Windows.Forms.Padding(4);
            this.chart_CPU_Temperature.Name = "chart_CPU_Temperature";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series11.Name = "Series1";
            series11.ToolTip = "#VALY";
            this.chart_CPU_Temperature.Series.Add(series11);
            this.chart_CPU_Temperature.Size = new System.Drawing.Size(296, 143);
            this.chart_CPU_Temperature.TabIndex = 0;
            this.chart_CPU_Temperature.Text = "chart1";
            this.chart_CPU_Temperature.MouseLeave += new System.EventHandler(this.chart_CPU_Temperature_MouseLeave);
            this.chart_CPU_Temperature.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart_CPU_Temperature_MouseMove);
            // 
            // chart_CPU_Power
            // 
            this.chart_CPU_Power.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea12.Name = "ChartArea1";
            this.chart_CPU_Power.ChartAreas.Add(chartArea12);
            this.chart_CPU_Power.Location = new System.Drawing.Point(8, 27);
            this.chart_CPU_Power.Margin = new System.Windows.Forms.Padding(4);
            this.chart_CPU_Power.Name = "chart_CPU_Power";
            series12.BackSecondaryColor = System.Drawing.Color.Cyan;
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series12.LabelForeColor = System.Drawing.Color.IndianRed;
            series12.Name = "Series1";
            this.chart_CPU_Power.Series.Add(series12);
            this.chart_CPU_Power.Size = new System.Drawing.Size(296, 143);
            this.chart_CPU_Power.TabIndex = 1;
            this.chart_CPU_Power.Text = "chart2";
            this.chart_CPU_Power.Click += new System.EventHandler(this.chart_CPU_Power_Click);
            this.chart_CPU_Power.MouseLeave += new System.EventHandler(this.chart_CPU_Power_MouseLeave);
            this.chart_CPU_Power.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart_CPU_Power_MouseMove);
            // 
            // chart_CPU_Rate
            // 
            this.chart_CPU_Rate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea13.Name = "ChartArea1";
            this.chart_CPU_Rate.ChartAreas.Add(chartArea13);
            this.chart_CPU_Rate.Location = new System.Drawing.Point(8, 27);
            this.chart_CPU_Rate.Margin = new System.Windows.Forms.Padding(4);
            this.chart_CPU_Rate.Name = "chart_CPU_Rate";
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series13.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series13.Name = "Series1";
            this.chart_CPU_Rate.Series.Add(series13);
            this.chart_CPU_Rate.Size = new System.Drawing.Size(296, 143);
            this.chart_CPU_Rate.TabIndex = 2;
            this.chart_CPU_Rate.Text = "chart3";
            this.chart_CPU_Rate.Click += new System.EventHandler(this.chart_CPU_Rate_Click_1);
            this.chart_CPU_Rate.MouseLeave += new System.EventHandler(this.chart_CPU_Rate_MouseLeave);
            this.chart_CPU_Rate.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart_CPU_Rate_MouseMove);
            // 
            // groupBox_CPU
            // 
            this.groupBox_CPU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox_CPU.Controls.Add(this.panel4);
            this.groupBox_CPU.Controls.Add(this.panel5);
            this.groupBox_CPU.Controls.Add(this.panel6);
            this.groupBox_CPU.Location = new System.Drawing.Point(4, 4);
            this.groupBox_CPU.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_CPU.Name = "groupBox_CPU";
            this.groupBox_CPU.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_CPU.Size = new System.Drawing.Size(322, 549);
            this.groupBox_CPU.TabIndex = 4;
            this.groupBox_CPU.TabStop = false;
            this.groupBox_CPU.Text = "Процессор";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.label_CPU_temperature);
            this.panel4.Controls.Add(this.chart_CPU_Temperature);
            this.panel4.Location = new System.Drawing.Point(5, 370);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(310, 179);
            this.panel4.TabIndex = 14;
            // 
            // label_CPU_temperature
            // 
            this.label_CPU_temperature.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_CPU_temperature.AutoSize = true;
            this.label_CPU_temperature.Location = new System.Drawing.Point(8, 7);
            this.label_CPU_temperature.Name = "label_CPU_temperature";
            this.label_CPU_temperature.Size = new System.Drawing.Size(115, 16);
            this.label_CPU_temperature.TabIndex = 11;
            this.label_CPU_temperature.Text = "Температура, °C";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.label_CPU_Power);
            this.panel5.Controls.Add(this.chart_CPU_Power);
            this.panel5.Location = new System.Drawing.Point(5, 22);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(310, 179);
            this.panel5.TabIndex = 15;
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
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.chart_CPU_Rate);
            this.panel6.Controls.Add(this.label_CPU_Rate);
            this.panel6.Location = new System.Drawing.Point(5, 196);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(310, 179);
            this.panel6.TabIndex = 16;
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
            // 
            // timer_Update
            // 
            this.timer_Update.Enabled = true;
            this.timer_Update.Interval = 1000;
            this.timer_Update.Tick += new System.EventHandler(this.timer_Update_Tick);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.groupBox_CPU);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 553);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Location = new System.Drawing.Point(21, 15);
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
            this.panel3.Location = new System.Drawing.Point(865, 298);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 0);
            this.panel3.TabIndex = 13;
            // 
            // panel8
            // 
            this.panel8.AutoScroll = true;
            this.panel8.AutoSize = true;
            this.panel8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel8.Controls.Add(this.groupBox3);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(742, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(340, 553);
            this.panel8.TabIndex = 15;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.Controls.Add(this.panel9);
            this.groupBox3.Location = new System.Drawing.Point(4, 4);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(332, 221);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Жесткие диски";
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.Controls.Add(this.label1);
            this.panel9.Controls.Add(this.chart1);
            this.panel9.Location = new System.Drawing.Point(7, 22);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(310, 179);
            this.panel9.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Диск 1";
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea14.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea14);
            this.chart1.Location = new System.Drawing.Point(8, 24);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series14.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series14.Name = "Series1";
            this.chart1.Series.Add(series14);
            this.chart1.Size = new System.Drawing.Size(296, 143);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.AutoScroll = true;
            this.panel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel7.Controls.Add(this.groupBox2);
            this.panel7.Location = new System.Drawing.Point(361, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(357, 234);
            this.panel7.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.panel10);
            this.groupBox2.Location = new System.Drawing.Point(4, 4);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(345, 219);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ОЗУ";
            // 
            // panel10
            // 
            this.panel10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel10.Controls.Add(this.chart_RAM);
            this.panel10.Controls.Add(this.label_RAM_Info);
            this.panel10.Location = new System.Drawing.Point(7, 22);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(320, 179);
            this.panel10.TabIndex = 17;
            // 
            // chart_RAM
            // 
            this.chart_RAM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea15.Name = "ChartArea1";
            this.chart_RAM.ChartAreas.Add(chartArea15);
            this.chart_RAM.Location = new System.Drawing.Point(8, 24);
            this.chart_RAM.Margin = new System.Windows.Forms.Padding(4);
            this.chart_RAM.Name = "chart_RAM";
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series15.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series15.Name = "Series1";
            this.chart_RAM.Series.Add(series15);
            this.chart_RAM.Size = new System.Drawing.Size(296, 143);
            this.chart_RAM.TabIndex = 10;
            this.chart_RAM.Text = "chart1";
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 553);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1100, 600);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_CPU_Temperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_CPU_Power)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_CPU_Rate)).EndInit();
            this.groupBox_CPU.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_RAM)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_RAM;
        private System.Windows.Forms.Label label_RAM_Info;
    }
}

