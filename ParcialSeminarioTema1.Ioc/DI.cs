using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using ParcialSeminarioTema1.Datos;
using ParcialSeminarioTema1.Datos.Interfaces;
using ParcialSeminarioTema1.Datos.Repositorios;
using ParcialSeminarioTema1.Servicios.Interfaces;
using ParcialSeminarioTema1.Servicios.Servicios;
using System.Configuration;

namespace ParcialSeminarioTema1.Ioc
{
    public static class DI
    {
        public static IServiceProvider ConfigurarDI()
        {
            var services = new ServiceCollection();

            services.AddDbContext<BibliotecaDbContext>(options =>
            {
                options.UseSqlServer(ConfigurationManager
                    .ConnectionStrings["MiConexion"].ConnectionString);
            });

            services.AddScoped<ILibrosRepositorio, LibrosRepositorio>();
            services.AddScoped<IGenerosRepositorio, GenerosRepositorio>();

                
            services.AddScoped<ILibrosServicio, LibrosServicio>();
            services.AddScoped<IGenerosServicio, GenerosServicio>();

            return services.BuildServiceProvider();
        }
    }
}
