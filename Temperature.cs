using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Diagnostics;

namespace WindowsFormsApp1.CPU
{
    public class Temperature
    {
        public static double CurTemperature
        {
            get
            {
                double result = Convert.ToDouble(Form1.GetHardwareInfo("MSAcpi_ThermalZoneTemperature", "CurrentTemperature", true)[0]);
                return (result - 2732) / 10.0;
            }
        }
    }

    public class Rate
    {
        private static double _maxRate = Convert.ToDouble(Form1.GetHardwareInfo("Win32_Processor", "MaxClockSpeed")[0]);

        public static double MaxRate { get { return _maxRate; } }
        public static double CurRate
        {
            get
            {
                return Convert.ToDouble(Form1.GetHardwareInfo("Win32_Processor", "CurrentClockSpeed")[0]);
            }
        }
    }

    public class Power
    {
        private static PerformanceCounter _counter = null;
        public static double CurPower
        {
            get
            {
                if (_counter == null)
                {
                    _counter = new PerformanceCounter();
                    _counter.CategoryName = "Processor";
                    _counter.CounterName = "% Processor Time";
                    _counter.InstanceName = "_Total";
                }
                return _counter.NextValue();
            }
        }
    }
}
