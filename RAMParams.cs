using System;

/// <summary>
/// Параметры ОЗУ
/// </summary>
namespace WindowsFormsApp1.RAMParams
{
    /// <summary>
    /// Занятая память
    /// </summary>
    public class Allocated
    {
        public static double MemoryGB
        {
            get
            {
                return Total.MemoryGB - Free.MemoryGB;
            }
        }

        public static double MemoryB
        {
            get
            {
                return Total.MemoryB - Free.MemoryB;
            }
        }
    }

    /// <summary>
    /// Свободная память
    /// </summary>
    public class Free
    {
        public static double MemoryGB
        {
            get
            {
                return Form1.ConvertBytesIntoGBytes(Convert.ToDouble(Form1.GetHardwareInfo("Win32_OperatingSystem", "FreePhysicalMemory")[0]));
            }
        }

        public static double MemoryB
        {
            get
            {
                return Convert.ToDouble(Form1.GetHardwareInfo("Win32_OperatingSystem", "FreePhysicalMemory")[0]);
            }
        }
    }

    /// <summary>
    /// Общая видимая память
    /// </summary>
    public class Total
    {
        private static double _memoryGB = -1;
        private static double _memoryB = -1;

        public static double MemoryGB
        {
            get
            {
                if (_memoryGB < 0)
                {
                    _memoryGB = Form1.ConvertBytesIntoGBytes(MemoryB);
                }
                return _memoryGB;
            }
        }

        public static double MemoryB
        {
            get
            {
                if (_memoryB < 0)
                {
                    _memoryB = Convert.ToDouble(Form1.GetHardwareInfo("Win32_OperatingSystem", "TotalVisibleMemorySize")[0]);
                }
                return _memoryB;
            }
        }
    }
}
