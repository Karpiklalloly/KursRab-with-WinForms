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

namespace WindowsFormsApp1
{

    
    public partial class Form1 : Form
    {
        private string _cpuName;
        
        //Значения в байтах
        private int _ramVisible;
        private int _ramFree;
        private int _ramAllocated;

        public static Cpu CPU;
        private QueueLimited<double> _cpuTemperature;
        private QueueLimited<double> _cpuPower;
        private QueueLimited<double> _cpuRate;

        public Form1()
        {
            InitializeComponent();
            CPU = Cpu.Discover()[0];
            
            SetLabels();
            SetCharts();
        }

        private void SetLabels()
        {
            _cpuName = Cpu.Discover()[0].Name;//GetHardwareInfo("Win32_Processor", "Name")[0];
            label_CPU_Info.Text = _cpuName;
            _ramVisible = Convert.ToInt32(GetHardwareInfo("Win32_OperatingSystem", "TotalVisibleMemorySize")[0]);
            //UpdateLabels();
        }

        private void SetCharts()
        {
            
            _cpuTemperature = new QueueLimited<double>();
            _cpuPower = new QueueLimited<double>();
            _cpuRate = new QueueLimited<double>();
            for (int i = 0; i < _cpuTemperature.Capacity;i++)
            {
                _cpuTemperature.Add(0);
                _cpuPower.Add(0);
                _cpuRate.Add(0);
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
            chart_CPU_Rate.ChartAreas[0].AxisY.Maximum = WindowsFormsApp1.CPUParams.Rate.MaxRate;
            chart_CPU_Rate.ChartAreas[0].AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chart_CPU_Rate.ChartAreas[0].AxisY.LabelStyle.Enabled = false;
        }



        private void UpdateLabels()
        {
            
            _ramFree = Convert.ToInt32(GetHardwareInfo("Win32_OperatingSystem", "FreePhysicalMemory")[0]);
            _ramAllocated = _ramVisible - _ramFree;
            label_RAM_Info.Text = "Доступно памяти " + ConvertBytesIntoGBytes(_ramFree) + "/" + ConvertBytesIntoGBytes(_ramVisible) + " ГБайт";

        }

        private void UpdateCharts()
        {
            UpdateChartCPUTemperature(true);
            UpdateChartCPUPower(true);
            UpdateChartCPURate(true);
        }

        private void UpdateChartCPUTemperature(bool drawChart = true)
        {
            var temperature = WindowsFormsApp1.CPUParams.Temperature.CurTemperature;
            _cpuTemperature.Add(temperature);
            if (drawChart)
            {
                chart_CPU_Temperature.Series[0].Points.Clear();
                int i = 0;
                foreach (var item in _cpuTemperature)
                {
                    chart_CPU_Temperature.Series[0].Points.AddXY(i, item);
                    i++;
                }
            }

            label_test_info1.Text = temperature.ToString("0.00");
        }

        private void UpdateChartCPURate(bool drawChart = true)
        {
            var rate = CPUParams.Rate.CurRate;
            _cpuRate.Add(rate);
            if (drawChart)
            {
                
                chart_CPU_Rate.Series[0].Points.Clear();
                int i = 0;
                foreach (var item in _cpuRate)
                {
                    chart_CPU_Rate.Series[0].Points.AddXY(i, item);
                    i++;
                }
            }
            
            label_test_info3.Text = rate.ToString("0.00");
        }

        private void UpdateChartCPUPower(bool drawChart = true)
        {
            var power = WindowsFormsApp1.CPUParams.Power.CurPower;
            _cpuPower.Add(power);
            if (drawChart)
            {
                chart_CPU_Power.Series[0].Points.Clear();
                int i = 0;
                foreach (var item in _cpuPower)
                {
                    chart_CPU_Power.Series[0].Points.AddXY(i, item);
                    i++;
                }
            }
            
            label_test_info2.Text = power.ToString("0.00");
        }

        private void UpdateInfo()
        {

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
                var lab = new Label()
                {
                    Text = "Нет такого элемента",
                    Dock = DockStyle.Fill,
                    AutoSize = false,
                    TextAlign = ContentAlignment.MiddleCenter,
                };
                
                //chart_RAM.Controls.Add(lab);
            }

            return result;
        }


        private void chart2_Click(object sender, EventArgs e)
        {

        }


        private void timer_Update_Tick(object sender, EventArgs e)
        {
            CPU.Update();
            UpdateLabels();
            UpdateCharts();
            
        }

        /// <summary>
        /// Преобразует Байты в ГБайты
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        private double ConvertBytesIntoGBytes(string num)
        {
            return ConvertBytesIntoGBytes(Convert.ToDouble(num));
        }

        private double ConvertBytesIntoGBytes(double num)
        {
            return Math.Round(num / (1024 * 1024), 2);
        }
    }


}
