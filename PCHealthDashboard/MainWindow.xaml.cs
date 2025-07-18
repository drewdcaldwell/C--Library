using PCHealthDashboard.Services;
using System;
using System.Timers;
using System.Windows;

namespace PCHealthDashboard
{
    public partial class MainWindow : Window
    {
        private readonly SystemMonitorService _monitorService;
        private readonly Timer _updateTimer;

        public MainWindow()
        {
            InitializeComponent();

            _monitorService = new SystemMonitorService();

            _updateTimer = new Timer(3000); // 3 seconds
            _updateTimer.Elapsed += UpdateDashboard;
            _updateTimer.Start();

            UpdateDashboard(null, null);
        }

        private void UpdateDashboard(object sender, ElapsedEventArgs e)
        {
            Dispatcher.Invoke(() =>
            {
                var cpu = _monitorService.GetCpuUsage();
                var ram = _monitorService.GetRamUsage();
                var uptime = _monitorService.GetSystemUptime();

                CpuText.Text = $"CPU Usage: {cpu:F1}%";
                RamText.Text = $"RAM Usage: {ram:F1}%";
                UptimeText.Text = $"System Uptime: {uptime:hh\\:mm\\:ss}";
            });
        }
    }
}