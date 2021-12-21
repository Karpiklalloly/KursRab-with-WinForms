﻿using System;
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
        private QueueLimited<double> _cpuTemperature;
        private QueueLimited<double> _cpuPower;
        private QueueLimited<double> _cpuRate;

        private QueueLimited<double> _RAMAllocated;

        private readonly ToolTip _toolTipFOrCharts = new ToolTip
        {
            IsBalloon = false,
            InitialDelay = 500,
            Active = false,
            ReshowDelay = 500
        };

        public Form1()
        {
            InitializeComponent();
            CPU = Cpu.Discover()[0];
            
            SetLabels();
            SetCharts();
        }

        private void SetLabels()
        {
            _cpuName = Cpu.Discover()[0].Name;
            label_CPU_Info.Text = _cpuName;
            _ramTotal = RAMParams.Total.MemoryGB;

            
        }

        private void SetCharts()
        {
            
            _cpuTemperature = new QueueLimited<double>();
            _cpuPower = new QueueLimited<double>();
            _cpuRate = new QueueLimited<double>();
            _RAMAllocated = new QueueLimited<double>();
            for (int i = 0; i < _cpuTemperature.Capacity; i++)
            {
                _cpuTemperature.Add(0);
                _cpuPower.Add(0);
                _cpuRate.Add(0);
                _RAMAllocated.Add(0);
            }
            chart_CPU_Temperature.ChartAreas[0].AxisX.Minimum = 0;
            chart_CPU_Temperature.ChartAreas[0].AxisX.Maximum = _cpuTemperature.Capacity-1;
            chart_CPU_Temperature.ChartAreas[0].AxisY.Minimum = 0;
            chart_CPU_Temperature.ChartAreas[0].AxisY.Maximum = 120;
            chart_CPU_Temperature.ChartAreas[0].AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chart_CPU_Temperature.ChartAreas[0].AxisY.LabelStyle.Enabled = false;

            chart_CPU_Power.ChartAreas[0].AxisX.Minimum = 0;
            chart_CPU_Power.ChartAreas[0].AxisX.Maximum = _cpuPower.Capacity-1;
            chart_CPU_Power.ChartAreas[0].AxisY.Minimum = 0;
            chart_CPU_Power.ChartAreas[0].AxisY.Maximum = 100;
            chart_CPU_Power.ChartAreas[0].AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chart_CPU_Power.ChartAreas[0].AxisY.LabelStyle.Enabled = false;

            chart_CPU_Rate.ChartAreas[0].AxisX.Minimum = 0;
            chart_CPU_Rate.ChartAreas[0].AxisX.Maximum = _cpuRate.Capacity-1;
            chart_CPU_Rate.ChartAreas[0].AxisY.Minimum = 0;
            chart_CPU_Rate.ChartAreas[0].AxisY.Maximum = CPUParams.Rate.MaxRate;
            chart_CPU_Rate.ChartAreas[0].AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chart_CPU_Rate.ChartAreas[0].AxisY.LabelStyle.Enabled = false;

            chart_RAM.ChartAreas[0].AxisX.Minimum = 0;
            chart_RAM.ChartAreas[0].AxisX.Maximum = _RAMAllocated.Capacity - 1;
            chart_RAM.ChartAreas[0].AxisY.Minimum = 0;
            chart_RAM.ChartAreas[0].AxisY.Maximum = _ramTotal;
            chart_RAM.ChartAreas[0].AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chart_RAM.ChartAreas[0].AxisY.LabelStyle.Enabled = false;
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


        private void chart2_Click(object sender, EventArgs e)
        {

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

        public static double ConvertBytesIntoGBytes(double num)
        {
            return Math.Round(num / (1024 * 1024), 2);
        }

        private void chart_CPU_Rate_Click(object sender, EventArgs e)
        {

        }

        private void chart_CPU_Temperature_MouseMove(object sender, MouseEventArgs e)
        {
            int x = (int)Math.Round(chart_CPU_Temperature.ChartAreas[0].AxisX.PixelPositionToValue(e.X));
            if (x < chart_CPU_Temperature.ChartAreas[0].AxisX.Minimum || x > chart_CPU_Temperature.ChartAreas[0].AxisX.Maximum)
            {
                return;
            }

            if (!_toolTipFOrCharts.Active)
            {
                _toolTipFOrCharts.Active = true;
                _toolTipFOrCharts.SetToolTip(this.chart_CPU_Temperature, chart_CPU_Temperature.Series[0].Points[x].YValues[0].ToString("0.00"));
            }
        }

        private void chart_CPU_Temperature_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void chart_CPU_Temperature_MouseLeave(object sender, EventArgs e)
        {
            _toolTipFOrCharts.Active = false;
        }

        private void chart_CPU_Power_MouseLeave(object sender, EventArgs e)
        {
            _toolTipFOrCharts.Active = false;
        }

        private void chart_CPU_Power_MouseMove(object sender, MouseEventArgs e)
        {
            int x = (int)Math.Round(chart_CPU_Power.ChartAreas[0].AxisX.PixelPositionToValue(e.X));
            if (x < chart_CPU_Power.ChartAreas[0].AxisX.Minimum || x > chart_CPU_Power.ChartAreas[0].AxisX.Maximum)
            {
                return;
            }

            if (!_toolTipFOrCharts.Active)
            {
                _toolTipFOrCharts.Active = true;
                _toolTipFOrCharts.SetToolTip(this.chart_CPU_Power, chart_CPU_Power.Series[0].Points[x].YValues[0].ToString("0.00"));
            }
        }

        private void chart_CPU_Rate_MouseLeave(object sender, EventArgs e)
        {
            _toolTipFOrCharts.Active = false;
        }

        private void chart_CPU_Rate_MouseMove(object sender, MouseEventArgs e)
        {
            int x = (int)Math.Round(chart_CPU_Rate.ChartAreas[0].AxisX.PixelPositionToValue(e.X));
            if (x < chart_CPU_Rate.ChartAreas[0].AxisX.Minimum || x > chart_CPU_Rate.ChartAreas[0].AxisX.Maximum)
            {
                return;
            }

            if (!_toolTipFOrCharts.Active)
            {
                _toolTipFOrCharts.Active = true;
                _toolTipFOrCharts.SetToolTip(this.chart_CPU_Rate, chart_CPU_Rate.Series[0].Points[x].YValues[0].ToString("0.00"));
            }
        }

        private void chart_RAM_MouseLeave(object sender, EventArgs e)
        {
            _toolTipFOrCharts.Active = false;
        }

        private void chart_RAM_MouseMove(object sender, MouseEventArgs e)
        {
            int x = (int)Math.Round(chart_RAM.ChartAreas[0].AxisX.PixelPositionToValue(e.X));
            if (x < chart_RAM.ChartAreas[0].AxisX.Minimum || x > chart_RAM.ChartAreas[0].AxisX.Maximum)
            {
                return;
            }

            if (!_toolTipFOrCharts.Active)
            {
                _toolTipFOrCharts.Active = true;
                _toolTipFOrCharts.SetToolTip(this.chart_RAM, chart_RAM.Series[0].Points[x].YValues[0].ToString("0.00"));
            }
        }
    }


}
