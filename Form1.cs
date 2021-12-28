using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Management;
using HardwareProviders.CPU;
using DirectShowLib;
using System.Net.NetworkInformation;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        private string _cpuName;
        
        private double _ramTotal;
        private double _ramFree;
        private double _ramAllocated;

        private double _cpuCurTemperature;
        private double _cpuCurPower;
        private double _cpuCurRate;

        public static Cpu CPU;
        public static Cpu[] CPUS;
        public static System.Windows.Forms.DataVisualization.Charting.Chart[] HDDCharts;

        /// <summary>
        /// Данные, чтобы вернуть цвета для ранее выделенного графика
        /// </summary>
        private System.Windows.Forms.DataVisualization.Charting.Chart _prevChart;
        private Color _prevColor;
        private Panel _prevPanel;

        /// <summary>
        /// Данные для графиков
        /// </summary>
        private QueueLimited<double> _cpuTemperature;
        private QueueLimited<double> _cpuPower;
        private QueueLimited<double> _cpuRate;
        private QueueLimited<double> _bigChart;
        private QueueLimited<double>[] HDDQueues;
        private QueueLimited<double> _RAMAllocated;

        static int indexOfPanel = 0;

        public Form1()
        {
            
            InitializeComponent();
            
            CPUS = Cpu.Discover();
            CPU = CPUS[0];
            SetLabels();
            SetCharts();
            
            SetDeviceTree();
        }

        /// <summary>
        /// Задает древо устройств во вкладке "Диспетчер устройств"
        /// </summary>
        private void SetDeviceTree()
        {
            treeView1.Nodes[0].Text = Environment.MachineName;
            
            int index = 0;

            AddNodeToTree(ref treeView1, ref index, "Звуковые, игровые и видеоустройства", "Win32_SoundDevice", "Name");

            //Выводит Primary, надо исправить
            AddNodeToTree(ref treeView1, ref index, "Батарея", "Win32_Battery", "Name");

            AddNodeToTree(ref treeView1, ref index, "Видеоадаптеры", "Win32_VideoController", "Description");

            AddNodeToTree(ref treeView1, ref index, "Дисковые устройства", "Win32_DiskDrive", "Model");

            DsDevice[] captureDevices;
            captureDevices = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice);
            List<string> names = new List<string>();
            for (int idx = 0; idx < captureDevices.Length; idx++)
            {
                names.Add(captureDevices[idx].Name);
            }
            AddNodeToTree(ref treeView1, ref index, "Камеры", names);

            captureDevices = DsDevice.GetDevicesOfCat(FilterCategory.AudioInputDevice);
            names = new List<string>();
            for (int idx = 0; idx < captureDevices.Length; idx++)
            {
                names.Add(captureDevices[idx].Name);
            }
            AddNodeToTree(ref treeView1, ref index, "Устройства ввода", names);

            AddNodeToTree(ref treeView1, ref index, "USB" , "Win32_USBHub", "Name");

            AddNodeToTree(ref treeView1, ref index, "Мониторы", "Win32_DesktopMonitor", "Description");

            AddNodeToTree(ref treeView1, ref index, "Мыши и иные указывающие устройства", "Win32_PointingDevice", "Name");

            names = new List<string>();
            for (int i = 0; i < CPUS.Length; i++)
            {
                names.Add(CPUS[i].Name);
            }
            AddNodeToTree(ref treeView1, ref index, "Процессоры", names);

            names = new List<string>();
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                names.Add(nic.Description);
            }
            AddNodeToTree(ref treeView1, ref index, "Сетевые адапторы", names);
            treeView1.Nodes[0].Expand();
        }

        /// <summary>
        /// Добавляет узлы к древу по запросам через WMI
        /// </summary>
        /// <param name="tree">Древо, к которому добавляются узлы</param>
        /// <param name="index">Индекс узла, к которому добавляются узлы</param>
        /// <param name="title">Заголовок этого узла</param>
        /// <param name="WIN32_Class">Класс, в котором ищется информация</param>
        /// <param name="ClassItemField">Параметр класса, который нам нужен</param>
        private void AddNodeToTree(ref TreeView tree, ref int index, string title, string WIN32_Class, string ClassItemField)
        {
            int secondIndex = 0;
            var names = GetHardwareInfo(WIN32_Class, ClassItemField);
            if (names.Count != 0)
            {
                tree.Nodes[0].Nodes.Add(new TreeNode());
                tree.Nodes[0].Nodes[index].Text = title;
                foreach (var item in names)
                {
                    tree.Nodes[0].Nodes[index].Nodes.Add(new TreeNode());
                    tree.Nodes[0].Nodes[index].Nodes[secondIndex++].Text = item;
                }
                index++;
            }
        }

        /// <summary>
        /// Добавляет узлы к древу по с уже заданными назавниями
        /// </summary>
        /// <param name="tree">Древо, к которому добавляются узлы</param>
        /// <param name="index">Индекс узла, к которому добавляются узлы</param>
        /// <param name="title">Заголовок этого узла</param>
        /// <param name="names">Названия для дочерних узлов</param>
        private void AddNodeToTree(ref TreeView tree, ref int index, string title, List<string> names)
        {
            int secondIndex = 0;
            if (names.Count != 0)
            {
                tree.Nodes[0].Nodes.Add(new TreeNode());
                tree.Nodes[0].Nodes[index].Text = title;
                foreach (var item in names)
                {
                    tree.Nodes[0].Nodes[index].Nodes.Add(new TreeNode());
                    tree.Nodes[0].Nodes[index].Nodes[secondIndex++].Text = item;
                }
                index++;
            }
        }

        /// <summary>
        /// Задает названия ярлыков для "коробки" процессора и графиков жестких дисков
        /// </summary>
        private void SetLabels()
        {
            _cpuName = Cpu.Discover()[0].Name;
            groupBox_CPU.Text = _cpuName;
            _ramTotal = RAMParams.Total.MemoryGB;
            HDDQueues = new QueueLimited<double>[HDDParams.Info.Count];
            HDDCharts = new System.Windows.Forms.DataVisualization.Charting.Chart[HDDParams.Info.Count];
            for (int i = 0; i < HDDParams.Info.Count; i++)
            {
                HDDQueues[i] = new QueueLimited<double>();
                AddHDDPanelToBox(ref groupBox_HDD, i);
            }
        }

        /// <summary>
        /// Задает параметры для графиков и заполняет нулями очереди для графиков
        /// </summary>
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
                for (int j = 0; j < HDDParams.Info.Count; j++)
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

            ChangeBigChart(chart_CPU_Power, new EventArgs());
        }

        /// <summary>
        /// Позволяет задать, к какому графику относится большой график
        /// </summary>
        /// <param name="sender">График, с котором надо свзяать</param>
        /// <param name="e"></param>
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
                    
                    _prevChart = chart;
                }
            }
        }

        /// <summary>
        /// Обновляет информацию ярлыков графиков процессора и ОЗУ
        /// </summary>
        private void UpdateLabels()
        {
           
            label_RAM_Info.Text = "Занаято памяти " + _ramAllocated + "/" + _ramTotal + " ГБайт";
            label_CPU_temperature.Text = "Температура, " + _cpuCurTemperature.ToString("0.00") + " °C";
            label_CPU_Power.Text = "Нагрузка, " + _cpuCurPower.ToString("0.00") + " %";
            label_CPU_Rate.Text = "Частота, " + _cpuCurRate.ToString("0.00") + " МГц";
        }

        /// <summary>
        /// Обновляет данные в графиках
        /// </summary>
        private void UpdateCharts()
        {
            UpdateChartRAMAllocated();
            UpdateChartCPUTemperature();
            UpdateChartCPUPower();
            UpdateChartCPURate();
            UpdateHDDCharts();
            UpdateBigChart();
        }

        /// <summary>
        /// Обновляет данные для большого графика
        /// </summary>
        private void UpdateBigChart()
        {
            chart_BIG.Series[0].Points.Clear();
            for (int i = 0; i< _prevChart.Series[0].Points.Count; i++)
            {
                chart_BIG.Series[0].Points.AddXY(_prevChart.Series[0].Points[i].XValue, _prevChart.Series[0].Points[i].YValues[0]);
            }
            
        }

        /// <summary>
        /// Обновляет данные для графика температуры процессора
        /// </summary>
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
        }

        /// <summary>
        /// Обновляет данные для графика частоты процессора
        /// </summary>
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
        }

        /// <summary>
        /// Обновляет данные для графика нагруженности процессора
        /// </summary>
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
        }

        /// <summary>
        /// Обновляет данные для графика занятой ОЗУ
        /// </summary>
        private void UpdateChartRAMAllocated()
        {
            var allocated = RAMParams.Allocated.MemoryGB;
            _RAMAllocated.Add(allocated);
            chart_RAM.Series[0].Points.Clear();
            int i = 0;
            foreach (var item in _RAMAllocated)
            {
                chart_RAM.Series[0].Points.AddXY(i, item);
                i++;
            }
        }

        /// <summary>
        /// Обновляет данные для графиков жестких дисков
        /// </summary>
        private void UpdateHDDCharts()
        {
            int t;
            for (int i = 0; i < HDDParams.Info.Count; i++)
            {
                HDDQueues[i].Add(ConvertBytesIntoMBytes(HDDParams.Info.GetDrive(i).TotalSize) - ConvertBytesIntoMBytes(HDDParams.Info.GetDrive(i).TotalFreeSpace));
                HDDCharts[i].Series[0].Points.Clear();
                t = 0;
                foreach (var item in HDDQueues[i])
                {
                    HDDCharts[i].Series[0].Points.AddXY(t, item);
                    t++;
                }
            }
        }

        /// <summary>
        /// Обновляет данные
        /// </summary>
        private void UpdateData()
        {
            CPU.Update();
            _ramFree = RAMParams.Free.MemoryGB;
            _ramAllocated = _ramTotal - _ramFree;
            _cpuCurTemperature = CPUParams.Temperature.CurTemperature;
            _cpuCurRate = CPUParams.Rate.CurRate;
            _cpuCurPower = CPUParams.Power.CurPower;
        }

        /// <summary>
        /// Получает ифнормацию через WMI
        /// </summary>
        /// <param name="WIN32_Class">Класс для запроса WMI</param>
        /// <param name="ClassItemField">Параметр класса</param>
        /// <param name="isFromRoot"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Обновляет данные, графики и ярлыки
        /// </summary>
        /// <param name="sender">Таймер, который вызывает этот метод раз в секунду</param>
        /// <param name="e"></param>
        private void timer_Update_Tick(object sender, EventArgs e)
        {
            UpdateData();
            UpdateCharts();
            UpdateLabels();
        }

        /// <summary>
        /// Преобразует Байты в ГБайты
        /// </summary>
        /// <param name="num">Число в виде строки</param>
        /// <returns></returns>
        public static double ConvertBytesIntoGBytes(string num)
        {
            return ConvertBytesIntoGBytes(Convert.ToDouble(num));
        }

        /// <summary>
        /// Преобразует Байты в ГБайты
        /// </summary>
        /// <param name="num">Число для преобразования</param>
        /// <returns></returns>
        public static double ConvertBytesIntoGBytes(double num)
        {
            return Math.Round(num / (1024 * 1024), 2);
        }

        /// <summary>
        /// Преобразует Байты в МБайты
        /// </summary>
        /// <param name="num">Число для преобразования</param>
        /// <returns></returns>
        public static double ConvertBytesIntoMBytes(double num)
        {
            return Math.Round(num / (1024), 2);
        }

        /// <summary>
        /// Преобразует Байты в МБайты
        /// </summary>
        /// <param name="num">Число в виде строки</param>
        /// <returns></returns>
        public static double ConvertBytesIntoMBytes(string num)
        {
            return ConvertBytesIntoGBytes(Convert.ToDouble(num));
        }

        /// <summary>
        /// Добавляет панел, график и ярлык Жесткого диска по индексу. Жестко связан с HDDQueues
        /// </summary>
        /// <param name="groupBox">"Коробка, в которую добавляется новый график"</param>
        /// <param name="hardIndex">Индекс жесткого диска в HDDQueues</param>
        private void AddHDDPanelToBox(ref GroupBox groupBox, int hardIndex)
        {

            Panel panel = new Panel
            {
                Anchor = AnchorStyles.Top | AnchorStyles.Left,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                Location = new System.Drawing.Point(5, 22 + indexOfPanel * 185)
            };
            panel.MouseEnter+=panel10_MouseEnter;
            panel.MouseLeave += panel10_MouseLeave;
            groupBox.Controls.Add(panel);

            Label label = new Label
            {
                Location = new System.Drawing.Point(5, 7),
                Text = "Диск " + HDDParams.Info.GetDrive(hardIndex).Name.Substring(0, HDDParams.Info.GetDrive(hardIndex).Name.Length - 2)
            };
            label.MouseEnter += panel10_MouseEnter;
            panel.Controls.Add(label);

            HDDCharts[hardIndex] = new System.Windows.Forms.DataVisualization.Charting.Chart
            {
                Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom,
                Size = new System.Drawing.Size(296, 143),
                Location = new System.Drawing.Point(8, 27),
                Margin = new System.Windows.Forms.Padding(4, 4, 4, 4)
            };
            HDDCharts[hardIndex].ChartAreas.Add("Series1");
            HDDCharts[hardIndex].ChartAreas[0] = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            HDDCharts[hardIndex].ChartAreas[0].AxisX.Minimum = 0;
            HDDCharts[hardIndex].ChartAreas[0].AxisX.Maximum = HDDQueues[hardIndex].Capacity-1;
            HDDCharts[hardIndex].ChartAreas[0].AxisY.Minimum = 0;
            HDDCharts[hardIndex].ChartAreas[0].AxisY.Maximum = ConvertBytesIntoMBytes(HDDParams.Info.GetDrive(hardIndex).TotalSize);
            HDDCharts[hardIndex].ChartAreas[0].AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            HDDCharts[hardIndex].ChartAreas[0].AxisY.LabelStyle.Enabled = false;
            HDDCharts[hardIndex].Series.Add("Series1");
            HDDCharts[hardIndex].Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            HDDCharts[hardIndex].Series[0].Color = System.Drawing.Color.Green;

            for (int i = 0; i < HDDQueues[hardIndex].Capacity; i++)
            {
                HDDQueues[hardIndex].Add(0);
            }

            HDDCharts[hardIndex].Click += ChangeBigChart;
            HDDCharts[hardIndex].MouseEnter += panel10_MouseEnter;
            panel.Controls.Add(HDDCharts[hardIndex]);

            indexOfPanel++;
            var t = panel1.Controls.Count;
        }

        /// <summary>
        /// Прокрчивает панель с графиками; используется, т.к. автоскролл прокручивает не до конца
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Создает обводку вокруг панели с графиком
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Убирает обводку вокург панели с графиком
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
