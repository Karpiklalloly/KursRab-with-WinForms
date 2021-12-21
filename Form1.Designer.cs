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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea17 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea18 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea19 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea20 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_CPU_Temperature = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_CPU_Power = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_CPU_Rate = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_CPU_temperature = new System.Windows.Forms.Label();
            this.label_CPU_Power = new System.Windows.Forms.Label();
            this.label_CPU_Rate = new System.Windows.Forms.Label();
            this.label_CPU_Info = new System.Windows.Forms.Label();
            this.label_RAM_Info = new System.Windows.Forms.Label();
            this.timer_Update = new System.Windows.Forms.Timer(this.components);
            this.chart_RAM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart_CPU_Temperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_CPU_Power)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_CPU_Rate)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_RAM)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_CPU_Temperature
            // 
            chartArea17.Name = "ChartArea1";
            this.chart_CPU_Temperature.ChartAreas.Add(chartArea17);
            this.chart_CPU_Temperature.Location = new System.Drawing.Point(8, 35);
            this.chart_CPU_Temperature.Margin = new System.Windows.Forms.Padding(4);
            this.chart_CPU_Temperature.Name = "chart_CPU_Temperature";
            series17.ChartArea = "ChartArea1";
            series17.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series17.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series17.Name = "Series1";
            series17.ToolTip = "#VALY";
            this.chart_CPU_Temperature.Series.Add(series17);
            this.chart_CPU_Temperature.Size = new System.Drawing.Size(296, 143);
            this.chart_CPU_Temperature.TabIndex = 0;
            this.chart_CPU_Temperature.Text = "chart1";
            this.chart_CPU_Temperature.MouseLeave += new System.EventHandler(this.chart_CPU_Temperature_MouseLeave);
            this.chart_CPU_Temperature.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart_CPU_Temperature_MouseMove);
            // 
            // chart_CPU_Power
            // 
            chartArea18.Name = "ChartArea1";
            this.chart_CPU_Power.ChartAreas.Add(chartArea18);
            this.chart_CPU_Power.Location = new System.Drawing.Point(8, 202);
            this.chart_CPU_Power.Margin = new System.Windows.Forms.Padding(4);
            this.chart_CPU_Power.Name = "chart_CPU_Power";
            series18.BackSecondaryColor = System.Drawing.Color.Cyan;
            series18.ChartArea = "ChartArea1";
            series18.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series18.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series18.LabelForeColor = System.Drawing.Color.IndianRed;
            series18.Name = "Series1";
            this.chart_CPU_Power.Series.Add(series18);
            this.chart_CPU_Power.Size = new System.Drawing.Size(296, 143);
            this.chart_CPU_Power.TabIndex = 1;
            this.chart_CPU_Power.Text = "chart2";
            this.chart_CPU_Power.MouseLeave += new System.EventHandler(this.chart_CPU_Power_MouseLeave);
            this.chart_CPU_Power.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart_CPU_Power_MouseMove);
            // 
            // chart_CPU_Rate
            // 
            chartArea19.Name = "ChartArea1";
            this.chart_CPU_Rate.ChartAreas.Add(chartArea19);
            this.chart_CPU_Rate.Location = new System.Drawing.Point(8, 369);
            this.chart_CPU_Rate.Margin = new System.Windows.Forms.Padding(4);
            this.chart_CPU_Rate.Name = "chart_CPU_Rate";
            series19.ChartArea = "ChartArea1";
            series19.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series19.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series19.Name = "Series1";
            this.chart_CPU_Rate.Series.Add(series19);
            this.chart_CPU_Rate.Size = new System.Drawing.Size(296, 143);
            this.chart_CPU_Rate.TabIndex = 2;
            this.chart_CPU_Rate.Text = "chart3";
            this.chart_CPU_Rate.MouseLeave += new System.EventHandler(this.chart_CPU_Rate_MouseLeave);
            this.chart_CPU_Rate.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart_CPU_Rate_MouseMove);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_CPU_temperature);
            this.groupBox1.Controls.Add(this.label_CPU_Power);
            this.groupBox1.Controls.Add(this.label_CPU_Rate);
            this.groupBox1.Controls.Add(this.chart_CPU_Power);
            this.groupBox1.Controls.Add(this.chart_CPU_Temperature);
            this.groupBox1.Controls.Add(this.chart_CPU_Rate);
            this.groupBox1.Location = new System.Drawing.Point(13, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(346, 517);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Процессор";
            // 
            // label_CPU_temperature
            // 
            this.label_CPU_temperature.AutoSize = true;
            this.label_CPU_temperature.Location = new System.Drawing.Point(8, 15);
            this.label_CPU_temperature.Name = "label_CPU_temperature";
            this.label_CPU_temperature.Size = new System.Drawing.Size(115, 16);
            this.label_CPU_temperature.TabIndex = 11;
            this.label_CPU_temperature.Text = "Температура, °C";
            // 
            // label_CPU_Power
            // 
            this.label_CPU_Power.AutoSize = true;
            this.label_CPU_Power.Location = new System.Drawing.Point(7, 182);
            this.label_CPU_Power.Name = "label_CPU_Power";
            this.label_CPU_Power.Size = new System.Drawing.Size(88, 16);
            this.label_CPU_Power.TabIndex = 4;
            this.label_CPU_Power.Text = "Нагрузка, %";
            // 
            // label_CPU_Rate
            // 
            this.label_CPU_Rate.AutoSize = true;
            this.label_CPU_Rate.Location = new System.Drawing.Point(8, 349);
            this.label_CPU_Rate.Name = "label_CPU_Rate";
            this.label_CPU_Rate.Size = new System.Drawing.Size(93, 16);
            this.label_CPU_Rate.TabIndex = 3;
            this.label_CPU_Rate.Text = "Частота, МГц";
            // 
            // label_CPU_Info
            // 
            this.label_CPU_Info.AutoSize = true;
            this.label_CPU_Info.Location = new System.Drawing.Point(18, 9);
            this.label_CPU_Info.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_CPU_Info.Name = "label_CPU_Info";
            this.label_CPU_Info.Size = new System.Drawing.Size(44, 16);
            this.label_CPU_Info.TabIndex = 5;
            this.label_CPU_Info.Text = "label1";
            // 
            // label_RAM_Info
            // 
            this.label_RAM_Info.AutoSize = true;
            this.label_RAM_Info.Location = new System.Drawing.Point(382, 40);
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
            // chart_RAM
            // 
            chartArea20.Name = "ChartArea1";
            this.chart_RAM.ChartAreas.Add(chartArea20);
            this.chart_RAM.Location = new System.Drawing.Point(385, 64);
            this.chart_RAM.Margin = new System.Windows.Forms.Padding(4);
            this.chart_RAM.Name = "chart_RAM";
            series20.ChartArea = "ChartArea1";
            series20.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series20.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series20.Name = "Series1";
            this.chart_RAM.Series.Add(series20);
            this.chart_RAM.Size = new System.Drawing.Size(296, 143);
            this.chart_RAM.TabIndex = 10;
            this.chart_RAM.Text = "chart1";
            this.chart_RAM.MouseLeave += new System.EventHandler(this.chart_RAM_MouseLeave);
            this.chart_RAM.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart_RAM_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.chart_RAM);
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
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_RAM;
        private System.Windows.Forms.Label label_CPU_temperature;
        private System.Windows.Forms.Label label_CPU_Power;
        private System.Windows.Forms.Label label_CPU_Rate;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

