using System;
using System.Diagnostics;

namespace WindowsFormsApp1.CPUParams
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
        private static readonly double _maxRate = Convert.ToDouble(Form1.GetHardwareInfo("Win32_Processor", "MaxClockSpeed")[0]);

        public static double MaxRate { get { return _maxRate; } }
        public static double CurRate
        {
            get
            {
                return (double)Form1.CPU.CoreClocks[0].Value;
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
                    _counter = new PerformanceCounter
                    {
                        CategoryName = "Processor",
                        CounterName = "% Processor Time",
                        InstanceName = "_Total"
                    };
                }
                return _counter.NextValue();
            }
        }
    }
}
