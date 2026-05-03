using ARM.Client.Windows;
using ARM.Core.ViewModels;
using ARM.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Windows;

namespace ARM.Client
{
    public partial class App : Application
    {
        private readonly IHost _host;
        public App()
        {
            _host = Host.CreateDefaultBuilder().ConfigureServices((context, services) =>
            {
                services.AddDbContext<AppDbContext>(options =>
                options.UseNpgsql("Host=localhost;Port=5432;Database=ArmDb;Username=postgres;Password=12345;"));
                services.AddSingleton<MainWindow>();
                services.AddSingleton<LoginWindow>();
                services.AddSingleton<MessageBoxWindow>();
                services.AddTransient<MainViewModel>();
            }).Build();
        }
        protected override async void OnStartup(StartupEventArgs e)
        {
            await _host.StartAsync();
            var loginWindow = _host.Services.GetRequiredService<LoginWindow>();
            loginWindow.Show();
            base.OnStartup(e);
        }
        protected override async void OnExit(ExitEventArgs e)
        {
            await _host.StopAsync();
            _host.Dispose();
            base.OnExit(e);
        }
    }
}