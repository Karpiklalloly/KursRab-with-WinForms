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

namespace WindowsFormsApp1
{

    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetLabels();
            
            
        }

        private void SetLabels()
        {
            var cpuName = GetHardwareInfo("Win32_Processor", "Name");
            label_CPU_Info.Text = cpuName[0];
            var ramFree = GetHardwareInfo("Win32_OperatingSystem", "FreePhysicalMemory");
            var ramVisible = GetHardwareInfo("Win32_OperatingSystem", "TotalVisibleMemorySize");
            label_RAM_Info.Text = "Доступно памяти " + Math.Round(Convert.ToDouble(ramFree[0]) / (1024 * 1024), 2) + "/" + Math.Round(Convert.ToDouble(ramVisible[0])/(1024*1024), 2) + " ГБайт";
        }


        private List<string> GetHardwareInfo(string WIN32_Class, string ClassItemField)
        {
            List<string> result = new List<string>();

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM " + WIN32_Class);
            new ManagementObjectSearcher();
            try
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    result.Add(obj[ClassItemField].ToString().Trim());
                }
            }
            catch (Exception ex)
            {
                var lab = new Label()
                {
                    Text = "Нет такого элемента",
                    Dock = DockStyle.Fill,
                    AutoSize = false,
                    TextAlign = ContentAlignment.MiddleCenter,
                };
                
                chart_RAM.Controls.Add(lab);
                Console.WriteLine(ex.Message);
            }

            return result;
        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }
    }


}
