using OrbEditor.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace OrbEditor.WPF
{
    public partial class App : Application
    {
        private readonly ServiceProvider serviceProvider;

        public App()
        {
            ServiceCollection services = new();

            services.AddSingleton<MainWindow>();
            services.AddTransient<MainWindowViewModel>();

            serviceProvider = services.BuildServiceProvider();
        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            MainWindow mainWindow = serviceProvider.GetRequiredService<MainWindow>();
            mainWindow.DataContext = serviceProvider.GetRequiredService<MainWindowViewModel>();

            mainWindow.Show();
        }
    }
}
