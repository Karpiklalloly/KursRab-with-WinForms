// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenHardwareMonitor.Hardware;

namespace WindowsFormsApp1.PCParams
{
    internal class PC
    {
        public static PC Instatnce
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PC();
                    _instance.Init();
                }
                    
                return _instance;
            }
        }
        private static PC _instance = null;

        private Computer _computer;
        public Computer Computer
        {
            get
            {
                if (_computer == null)
                    Init();
                return _computer;
            }
            private set
            {
                _computer = value;
            }
        }

        private void Init(bool cpu = true, bool hdd = true, bool ram = true, bool gpu = false, bool fanControl = false, bool mainBoard = false)
        {
            Computer = new Computer();
            Computer.Open();
            Computer.CPUEnabled = cpu;
            Computer.HDDEnabled = hdd;
            Computer.RAMEnabled = ram;

            Computer.GPUEnabled = gpu;
            Computer.FanControllerEnabled = fanControl;
            Computer.MainboardEnabled = mainBoard;
            Computer.Accept(new UpdateVisitor());
        }

        public void Update()
        {
            foreach (var t in Computer.Hardware)
            {
                t.Update();
            }
        }
    }

    public class CPU
    {
        public static CPU Instatnce
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CPU();
                    _instance.Init();
                }
                    
                return _instance;
            }
        }
        private static CPU _instance = null;

        private IHardware _hardware;
        private ISensor _temperature;
        private ISensor _rate = null;
        private ISensor _load;

        public string Name;


        private void Init()
        {
            foreach (var t in PC.Instatnce.Computer.Hardware)
            {
                if (t.HardwareType == HardwareType.CPU)
                {
                    _hardware = t;
                    break;
                }
            }

            foreach (var t in _hardware.Sensors)
            {
                if (t.SensorType == SensorType.Temperature)
                {
                    _temperature = t;
                }
                else if (t.SensorType == SensorType.Clock)
                {
                    _rate = t;
                }
                else if (t.SensorType == SensorType.Load)
                {
                    _load = t;
                }
            }
            Name = _hardware.Name;
        }

        public double MaxTemperature
        {
            get
            {
                return (double)_temperature.Max;
            }
        }
        public double CurTemperature
        {
            get
            {
                return (double)_temperature.Value;
            }
        }

        public double MaxRate
        {
            get
            {
                return (double)_rate.Max;
            }
        }
        public double CurRate
        {
            get
            {
                return (double)_rate.Value;
            }
        }

        public double CurLoad
        {
            get
            {
                return (double)_load.Value;
            }
        }
    }

    public class HDD
    {
        public static HDD Instatnce
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new HDD();
                    _instance.Init();
                }
                return _instance;
            }
        }
        private static HDD _instance = null;

        private List<IHardware> _hardwares;

        public int Count;

        private char _char = 'B';

        public List<string> Names
        {
            get;
            private set;
        }

        public List<double> Usages
        {
            get;
            private set;
        }

        private void Init()
        {
            _hardwares = new List<IHardware>();
            Names = new List<string>();
            Usages = new List<double>();
            foreach (var t in PC.Instatnce.Computer.Hardware)
            {
                if (t.HardwareType == HardwareType.HDD)
                {
                    _hardwares.Add(t);
                }
            }
            Count = _hardwares.Count;
            for (int i = 0; i< Count; i++)
            {
                _char++;
                Names.Add(_char + @"");
                foreach (var t in _hardwares[i].Sensors)
                {
                    Usages.Add((double)t.Value);
                }
            }
            

        }
    }

    public class RAM
    {
        public static RAM Instatnce
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RAM();
                    _instance.Init();
                }
                return _instance;
            }
        }
        private static RAM _instance = null;

        private IHardware _hardware;
        private ISensor _usage;
        private ISensor _allocated;
        private ISensor _free;

        public double Total
        {
            get;
            private set;
        }
        public double Usage
        {
            get
            {
                return (double)_usage.Value;
            }
        }
        public double Allocated
        {
            get
            {
                return (double)_allocated.Value;
            }
        }
        public double Free
        {
            get
            {
                return (double)_free.Value;
            }
        }

        private void Init()
        {
            foreach (var t in PC.Instatnce.Computer.Hardware)
            {
                if (t.HardwareType == HardwareType.RAM)
                {
                    _hardware = t;
                    break;
                }
            }

            foreach (var t in _hardware.Sensors)
            {
                if (t.SensorType == SensorType.Load)
                {
                    _usage = t;
                }
                if (t.Name == "Used Memory")
                {
                    _allocated = t;
                }
                if (t.Name == "Available Memory")
                {
                    _free = t;
                }
            }
            Total = Free + Allocated;
        }
    }

    public class UpdateVisitor : IVisitor
    {
        public void VisitComputer(IComputer computer)
        {
            computer.Traverse(this);
        }
        public void VisitHardware(IHardware hardware)
        {
            hardware.Update();
            foreach (IHardware subHardware in hardware.SubHardware) subHardware.Accept(this);
        }
        public void VisitSensor(ISensor sensor) { }
        public void VisitParameter(IParameter parameter) { }
    }
}
