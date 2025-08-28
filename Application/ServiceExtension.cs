using Application.Interfaces.Services.Generic;
using Scrutor;
using Application.Services.Generic;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Application
{
    public static class ServiceExtension
    {
        public static void AddAplicationLayer(this IServiceCollection services)
        {
            //AgregateGenericServices(services);
            services.AddTransient(typeof(IGenericService<,,>), typeof(GenericService<,,>));
            services.AddAutoMapper(cfg => { cfg.AddMaps(Assembly.GetExecutingAssembly()); });
            //services.AddTransient<IEventoService, EventoService>();

            services.Scan(scan => scan
                .FromAssemblies(typeof(GenericService<,,>).Assembly)
                .AddClasses(classes => classes.InNamespaces("Application.Services"))
                .AsImplementedInterfaces()
                .WithTransientLifetime()
            );
        }
    }
}
