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
        private static Computer _computer;
        public static Computer Computer
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

        public static bool Inited = false;

        public static void Init(bool cpu = true, bool hdd = true, bool ram = true, bool gpu = false, bool fanControl = false, bool mainBoard = false)
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
            Inited = true;
        }

        public static void Update()
        {
            foreach (var t in Computer.Hardware)
            {
                t.Update();
            }
        }
    }

    public class CPU
    {
        public static bool Inited = false;

        private static IHardware _hardware;
        private static ISensor _temperature;
        private static ISensor _rate = null;
        private static ISensor _load;

        public static string Name;


        public static void Init()
        {
            foreach (var t in PC.Computer.Hardware)
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

        public static double MaxTemperature
        {
            get
            {
                if (!Inited)
                {
                    Init();
                }
                return (double)_temperature.Max;
            }
        }
        public static double CurTemperature
        {
            get
            {
                if (!Inited)
                {
                    Init();
                }
                return (double)_temperature.Value;
            }
        }

        public static double MaxRate
        {
            get
            {
                if (!Inited)
                {
                    Init();
                }
                return (double)_rate.Max;
            }
        }
        public static double CurRate
        {
            get
            {
                if (!Inited)
                {
                    Init();
                }
                return (double)_rate.Value;
            }
        }

        public static double CurLoad
        {
            get
            {
                if (!Inited)
                {
                    Init();
                }
                return (double)_load.Value;
            }
        }
    }

    public class HDD
    {
        public static bool Inited = false;

        private static List<IHardware> _hardwares;

        public static int Count;

        private static char _char = 'B';

        public static List<string> Names
        {
            get;
            private set;
        }

        public static List<double> Usages
        {
            get;
            private set;
        }

        public static void Init()
        {
            _hardwares = new List<IHardware>();
            Names = new List<string>();
            Usages = new List<double>();
            foreach (var t in PC.Computer.Hardware)
            {
                if (t.HardwareType == HardwareType.HDD)
                {
                    _hardwares.Add(t);
                }
            }
            Count = _hardwares.Count-1;
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
        public static bool Inited = false;
        private static IHardware _hardware;
        private static ISensor _usage;
        private static ISensor _allocated;
        private static ISensor _free;

        public static double Total
        {
            get;
            private set;
        }
        public static double Usage
        {
            get
            {
                return (double)_usage.Value;
            }
        }
        public static double Allocated
        {
            get
            {
                return (double)_allocated.Value;
            }
        }
        public static double Free
        {
            get
            {
                return (double)_free.Value;
            }
        }

        public static void Init()
        {
            foreach (var t in PC.Computer.Hardware)
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
