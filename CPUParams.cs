﻿using System;

/// <summary>
/// Параметры процессора
/// </summary>
namespace WindowsFormsApp1.CPUParams
{
    /// <summary>
    /// Температура
    /// </summary>
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

    /// <summary>
    /// Частота
    /// </summary>
    public class Rate
    {
        private static readonly double _maxRate = (double)Form1.CPU.CoreClocks[0].Max;
        private static double _sum;

        public static double MaxRate { get { return _maxRate; } }
        public static double CurRate
        {
            get
            {
                _sum = 0;
                for (int i = 0; i < Form1.CPU.CoreClocks.Length; i++)
                {
                    _sum += (double)Form1.CPU.CoreClocks[i].Value;
                }
                return _sum / Form1.CPU.CoreCount;
            }
        }
    }

    /// <summary>
    /// Нагрузка
    /// </summary>
    public class Power
    {
        private static double _sum;
        public static double CurPower
        {
            get
            {
                _sum = 0;
                for (int i = 0; i < Form1.CPU.CoreCount; i++)
                {
                    _sum += (double)Form1.CPU.CoreLoads[i].Value;
                }
                return _sum / Form1.CPU.CoreCount;
                
            }
        }
    }
}
