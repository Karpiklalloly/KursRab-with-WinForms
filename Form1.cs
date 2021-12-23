using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using HardwareProviders.CPU;
using HardwareProviders.HDD;
using System.IO;
using System.Reflection;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        private string _cpuName;
        
        //Значения в ГБайтах
        private double _ramTotal;
        private double _ramFree;
        private double _ramAllocated;

        private double _cpuCurTemperature;
        private double _cpuCurPower;
        private double _cpuCurRate;

        public static Cpu CPU;
        public static DriveInfo[] HDDS;
        public static System.Windows.Forms.DataVisualization.Charting.Chart[] HDDCharts;
        private System.Windows.Forms.DataVisualization.Charting.Chart _prevChart;
        private Color _prevColor;
        private Panel _prevPanel;
        private QueueLimited<double> _cpuTemperature;
        private QueueLimited<double> _cpuPower;
        private QueueLimited<double> _cpuRate;
        private QueueLimited<double> _bigChart;
        private QueueLimited<double>[] HDDQueues;

        private QueueLimited<double> _RAMAllocated;

        static int indexOfPanel = 0;

        private readonly ToolTip _toolTipFOrCharts = new ToolTip
        {
            IsBalloon = false,
            InitialDelay = 500,
            Active = false,
            ReshowDelay = 100,
        };

        public Form1()
        {
            
            InitializeComponent();
            
            CPU = Cpu.Discover()[0];
            HDDS = DriveInfo.GetDrives();
            SetLabels();
            SetCharts();
            ChangeBigChart(chart_CPU_Power, new EventArgs());
        }

        private void SetLabels()
        {
            _cpuName = Cpu.Discover()[0].Name;
            groupBox_CPU.Text = _cpuName;
            _ramTotal = RAMParams.Total.MemoryGB;
            HDDQueues = new QueueLimited<double>[HDDS.Length];
            HDDCharts = new System.Windows.Forms.DataVisualization.Charting.Chart[HDDS.Length];
            for (int i = 0; i < HDDS.Length; i++)
            {
                HDDQueues[i] = new QueueLimited<double>();
                AddHDDPanelToBox(ref groupBox_HDD, i);
            }
            

        }

        private void SetCharts()
        {
            
            _cpuTemperature = new QueueLimited<double>();
            _cpuPower = new QueueLimited<double>();
            _cpuRate = new QueueLimited<double>();
            _RAMAllocated = new QueueLimited<double>();
            _bigChart = new QueueLimited<double>();
            for (int i = 0; i < _cpuTemperature.Capacity; i++)
            {
                _cpuTemperature.Add(0);
                _cpuPower.Add(0);
                _cpuRate.Add(0);
                _RAMAllocated.Add(0);
                _bigChart.Add(0);
                for (int j = 0; j < HDDS.Length; j++)
                {
                    HDDQueues[j].Add(0);
                }
            }
            chart_CPU_Temperature.ChartAreas[0].AxisX.Minimum = 0;
            chart_CPU_Temperature.ChartAreas[0].AxisX.Maximum = _cpuTemperature.Capacity-1;
            chart_CPU_Temperature.ChartAreas[0].AxisY.Minimum = 0;
            chart_CPU_Temperature.ChartAreas[0].AxisY.Maximum = 120;
            chart_CPU_Temperature.ChartAreas[0].AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chart_CPU_Temperature.ChartAreas[0].AxisY.LabelStyle.Enabled = false;
            chart_CPU_Temperature.Click += ChangeBigChart;
            

            chart_CPU_Power.ChartAreas[0].AxisX.Minimum = 0;
            chart_CPU_Power.ChartAreas[0].AxisX.Maximum = _cpuPower.Capacity-1;
            chart_CPU_Power.ChartAreas[0].AxisY.Minimum = 0;
            chart_CPU_Power.ChartAreas[0].AxisY.Maximum = 100;
            chart_CPU_Power.ChartAreas[0].AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chart_CPU_Power.ChartAreas[0].AxisY.LabelStyle.Enabled = false;
            chart_CPU_Power.Click += ChangeBigChart;

            chart_CPU_Rate.ChartAreas[0].AxisX.Minimum = 0;
            chart_CPU_Rate.ChartAreas[0].AxisX.Maximum = _cpuRate.Capacity-1;
            chart_CPU_Rate.ChartAreas[0].AxisY.Minimum = 0;
            chart_CPU_Rate.ChartAreas[0].AxisY.Maximum = CPUParams.Rate.MaxRate;
            chart_CPU_Rate.ChartAreas[0].AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chart_CPU_Rate.ChartAreas[0].AxisY.LabelStyle.Enabled = false;
            chart_CPU_Rate.Click += ChangeBigChart;

            chart_RAM.ChartAreas[0].AxisX.Minimum = 0;
            chart_RAM.ChartAreas[0].AxisX.Maximum = _RAMAllocated.Capacity - 1;
            chart_RAM.ChartAreas[0].AxisY.Minimum = 0;
            chart_RAM.ChartAreas[0].AxisY.Maximum = _ramTotal;
            chart_RAM.ChartAreas[0].AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chart_RAM.ChartAreas[0].AxisY.LabelStyle.Enabled = false;
            chart_RAM.Click += ChangeBigChart;

            chart_BIG.ChartAreas[0].AxisX.Minimum = 0;
            chart_BIG.ChartAreas[0].AxisX.Maximum = _cpuTemperature.Capacity - 1;
            chart_BIG.ChartAreas[0].AxisY.Minimum = 0;
            chart_BIG.ChartAreas[0].AxisY.Maximum = 120;
            chart_BIG.ChartAreas[0].AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chart_BIG.ChartAreas[0].AxisY.LabelStyle.Enabled = false;
            chart_BIG.Series.Add("Series");
        }

        private void ChangeBigChart(object sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.DataVisualization.Charting.Chart chart)
            {
                if (_prevChart != chart)
                {
                    if (_prevChart != null)
                    {
                        _prevColor = chart.Parent.BackColor;
                        _prevChart.Parent.BackColor = _prevColor;
                    }
                    chart.Parent.BackColor = System.Drawing.Color.Yellow;
                    chart_BIG.ChartAreas[0].AxisX.Maximum = chart.ChartAreas[0].AxisX.Maximum;
                    chart_BIG.ChartAreas[0].AxisY.Maximum = chart.ChartAreas[0].AxisY.Maximum;
                    //chart_BIG = chart;
                    
                    _prevChart = chart;
                }
            }
        }

        private void UpdateLabels()
        {
           
            label_RAM_Info.Text = "Занаято памяти " + _ramAllocated + "/" + _ramTotal + " ГБайт";
            label_CPU_temperature.Text = "Температура, " + _cpuCurTemperature.ToString("0.00") + " °C";
            label_CPU_Power.Text = "Нагрузка, " + _cpuCurPower.ToString("0.00") + " %";
            label_CPU_Rate.Text = "Частота, " + _cpuCurRate.ToString("0.00") + " МГц";
        }

        private void UpdateCharts()
        {
            UpdateChartRAMAllocated();
            UpdateChartCPUTemperature();
            UpdateChartCPUPower();
            UpdateChartCPURate();
            UpdateHDDCharts();
            UpdateBigChart();
        }

        private void UpdateBigChart()
        {
            chart_BIG.Series[0].Points.Clear();
            for (int i = 0; i< _prevChart.Series[0].Points.Count; i++)
            {
                chart_BIG.Series[0].Points.AddXY(_prevChart.Series[0].Points[i].XValue, _prevChart.Series[0].Points[i].YValues[0]);
            }
            
        }

        private void UpdateChartCPUTemperature()
        {
            
            _cpuTemperature.Add(_cpuCurTemperature);
            chart_CPU_Temperature.Series[0].Points.Clear();
            int i = 0;
            foreach (var item in _cpuTemperature)
            {
                chart_CPU_Temperature.Series[0].Points.AddXY(i, item);
                i++;
            }

            //label_test_info1.Text = _cpuCurTemperature.ToString("0.00");
        }

        private void UpdateChartCPURate()
        {
            _cpuRate.Add(_cpuCurRate);
            chart_CPU_Rate.Series[0].Points.Clear();
            int i = 0;
            foreach (var item in _cpuRate)
            {
                chart_CPU_Rate.Series[0].Points.AddXY(i, item);
                i++;
            }

            //label_test_info3.Text = _cpuCurRate.ToString("0.00");
        }

        private void UpdateChartCPUPower()
        {
            _cpuPower.Add(_cpuCurPower);
            chart_CPU_Power.Series[0].Points.Clear();
            int i = 0;
            foreach (var item in _cpuPower)
            {
                chart_CPU_Power.Series[0].Points.AddXY(i, item);
                i++;
            }

            //label_test_info2.Text = _cpuCurPower.ToString("0.00");
        }

        private void UpdateChartRAMAllocated(bool drawChart = true)
        {
            var allocated = RAMParams.Allocated.MemoryGB;
            _RAMAllocated.Add(allocated);
            if (drawChart)
            {
                chart_RAM.Series[0].Points.Clear();
                int i = 0;
                foreach (var item in _RAMAllocated)
                {
                    chart_RAM.Series[0].Points.AddXY(i, item);
                    i++;
                }
            }

            //label_test_info2.Text = allocated.ToString("0.00");
        }

        private void UpdateHDDCharts(bool drawChart = true)
        {
            int t = 0;
            for (int i = 0; i < HDDS.Length; i++)
            {
                HDDQueues[i].Add(ConvertBytesIntoMBytes(HDDS[i].TotalSize) - ConvertBytesIntoMBytes(HDDS[i].TotalFreeSpace));
                if (drawChart)
                {
                    HDDCharts[i].Series[0].Points.Clear();
                    t = 0;
                    foreach (var item in HDDQueues[i])
                    {
                        HDDCharts[i].Series[0].Points.AddXY(t, item);
                        t++;
                    }
                }
            }
        }

        private void UpdateData()
        {
            CPU.Update();
            _ramFree = RAMParams.Free.MemoryGB;
            _ramAllocated = _ramTotal - _ramFree;
            _cpuCurTemperature = CPUParams.Temperature.CurTemperature;
            _cpuCurRate = CPUParams.Rate.CurRate;
            _cpuCurPower = CPUParams.Power.CurPower;
        }


        public static List<string> GetHardwareInfo(string WIN32_Class, string ClassItemField, bool isFromRoot = false)
        {
            List<string> result = new List<string>();
            ManagementObjectSearcher searcher;
            if (isFromRoot)
            {
                searcher = new ManagementObjectSearcher(@"root\WMI", "SELECT * FROM " + WIN32_Class);
            }
            else
            {
                searcher = new ManagementObjectSearcher("SELECT * FROM " + WIN32_Class);
            }

            try
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    result.Add(obj[ClassItemField].ToString().Trim());
                }
            }
            catch (Exception)
            {

            }

            return result;
        }


        private void timer_Update_Tick(object sender, EventArgs e)
        {
            UpdateData();
            UpdateCharts();
            UpdateLabels();
        }

        public static double ConvertBytesIntoGBytes(string num)
        {
            return ConvertBytesIntoGBytes(Convert.ToDouble(num));
        }

        public static double ConvertBytesIntoMBytes(double num)
        {
            return Math.Round(num / (1024), 2);
        }

        public static double ConvertBytesIntoMBytes(string num)
        {
            return ConvertBytesIntoGBytes(Convert.ToDouble(num));
        }

        public static double ConvertBytesIntoGBytes(double num)
        {
            return Math.Round(num / (1024 * 1024), 2);
        }

        private void AddHDDPanelToBox(ref GroupBox groupBox, int hardIndex)
        {
            
            Panel panel = new Panel();
            panel.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            panel.AutoSize = true;
            panel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel.Location = new System.Drawing.Point(5, 22+indexOfPanel*185);
            panel.MouseEnter+=panel10_MouseEnter;
            panel.MouseLeave += panel10_MouseLeave;
            groupBox.Controls.Add(panel);
            
            Label label = new Label();
            label.Location = new System.Drawing.Point(5, 7);
            label.Text = "Диск " + HDDS[hardIndex].Name.Substring(0, HDDS[hardIndex].Name.Length-2);
            label.MouseEnter += panel10_MouseEnter;
            panel.Controls.Add(label);

            HDDCharts[hardIndex] = new System.Windows.Forms.DataVisualization.Charting.Chart();
            HDDCharts[hardIndex].Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            HDDCharts[hardIndex].Size = new System.Drawing.Size(296, 143);
            HDDCharts[hardIndex].Location = new System.Drawing.Point(8, 27);
            HDDCharts[hardIndex].Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            HDDCharts[hardIndex].ChartAreas.Add("Series1");
            HDDCharts[hardIndex].ChartAreas[0] = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            HDDCharts[hardIndex].ChartAreas[0].AxisX.Minimum = 0;
            HDDCharts[hardIndex].ChartAreas[0].AxisX.Maximum = HDDQueues[hardIndex].Capacity-1;
            HDDCharts[hardIndex].ChartAreas[0].AxisY.Minimum = 0;
            HDDCharts[hardIndex].ChartAreas[0].AxisY.Maximum = ConvertBytesIntoMBytes(HDDS[hardIndex].TotalSize);
            HDDCharts[hardIndex].ChartAreas[0].AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            HDDCharts[hardIndex].ChartAreas[0].AxisY.LabelStyle.Enabled = false;
            HDDCharts[hardIndex].Series.Add("Series1");
            HDDCharts[hardIndex].Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            HDDCharts[hardIndex].Series[0].Color = System.Drawing.Color.Green;

            HDDCharts[hardIndex].Click += ChangeBigChart;
            HDDCharts[hardIndex].MouseEnter += panel10_MouseEnter;
            panel.Controls.Add(HDDCharts[hardIndex]);


            /*
             * chart_RAM.ChartAreas[0].AxisX.Minimum = 0;
            chart_RAM.ChartAreas[0].AxisX.Maximum = _RAMAllocated.Capacity - 1;
            chart_RAM.ChartAreas[0].AxisY.Minimum = 0;
            chart_RAM.ChartAreas[0].AxisY.Maximum = _ramTotal;
            chart_RAM.ChartAreas[0].AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chart_RAM.ChartAreas[0].AxisY.LabelStyle.Enabled = false;
             */
            indexOfPanel++;
            var t = panel1.Controls.Count;
        }

        private void vScrollBar1_Scroll_1(object sender, ScrollEventArgs e)
        {
            if (sender is ScrollBar)
            {
                panel1.Location = new System.Drawing.Point(panel1.Location.X, panel1.Location.Y - (panel1.Height / 125) * (e.NewValue - e.OldValue));
            }
            else
            {
                if (e.NewValue >= e.OldValue)
                {
                    if (vScrollBar1.Value < 100)
                    {
                        vScrollBar1.Value++;
                    }
                }
                else
                {
                    if (vScrollBar1.Value > 0)
                    {
                        vScrollBar1.Value--;
                    }
                }
                
            }
            
        }

        private void panel10_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Panel pan)
            {
                if (pan != _prevPanel)
                {
                    if (_prevPanel != null)
                    {
                        _prevPanel.BorderStyle = BorderStyle.None;
                    }
                    pan.BorderStyle = BorderStyle.FixedSingle;
                    _prevPanel = pan;
                }

            }
            else if (sender is System.Windows.Forms.DataVisualization.Charting.Chart chart)
            {
                ((Panel)chart.Parent).BorderStyle = BorderStyle.FixedSingle;
            }
            else if (sender is Label lab)
            {
                ((Panel)lab.Parent).BorderStyle = BorderStyle.FixedSingle;
            }

        }

        private void panel10_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Panel pan)
            {
                if (_prevPanel != null)
                {
                    _prevPanel.BorderStyle = BorderStyle.None;
                }
                _prevPanel = null;
            }
        }
    }


}
