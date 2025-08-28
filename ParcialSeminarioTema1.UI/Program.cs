using Microsoft.Extensions.DependencyInjection;
using ParcialSeminarioTema1.Ioc;
using ParcialSeminarioTema1.Servicios.Interfaces;

namespace ParcialSeminarioTema1.UI
{
    internal static class Program
    {
        public static IServiceProvider _serviceProvider = null!;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            _serviceProvider = DI.ConfigurarDI();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmBiblioteca(_serviceProvider
                .GetRequiredService<ILibrosServicio>(),
                _serviceProvider.GetRequiredService<IGenerosServicio>()));
        }
    }
}