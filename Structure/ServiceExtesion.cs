using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Scrutor;
using Structure.Context;
using Microsoft.Extensions.Configuration;
using Application.Interfaces.Repositories.Generic;
using Structure.Repositories;

namespace Structure
{
    public static class ServiceExtesion
    {
        public static void AddDataLayer(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<CiteruContext>(
                opt => opt.UseSqlServer(config.GetConnectionString("DbConnection"),
                m => m.MigrationsAssembly(typeof(CiteruContext).Assembly.FullName))
            );

            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            services.Scan(scan => scan
                .FromAssemblies(typeof(GenericRepository<>).Assembly)
                .AddClasses(classes => classes.InNamespaces("Structure.Repositories"))
                .AsImplementedInterfaces()
                .WithTransientLifetime()
            );
        }
    }
}