using System;
using System.Diagnostics;

namespace PCHealthDashboard.Services
{
    public class SystemMonitorService
    {
        public float GetCpuUsage()
        {
            var cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            cpuCounter.NextValue(); // First call returns 0
            System.Threading.Thread.Sleep(1000);
            return cpuCounter.NextValue();
        }

        public float GetRamUsage()
        {
            var ramCounter = new PerformanceCounter("Memory", "Available MBytes");
            float availableMb = ramCounter.NextValue();

            var totalMb = GetTotalPhysicalMemoryMb();
            return 100 - ((availableMb / totalMb) * 100);
        }

        private float GetTotalPhysicalMemoryMb()
        {
            var computerInfo = new Microsoft.VisualBasic.Devices.ComputerInfo();
            return computerInfo.TotalPhysicalMemory / (1024 * 1024);
        }

        public TimeSpan GetSystemUptime()
        {
            return TimeSpan.FromMilliseconds(Environment.TickCount64);
        }
    }
}
