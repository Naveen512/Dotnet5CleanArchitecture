using CleanArchitecture.Sample.Application.Contracts.Data;
using CleanArchitecture.Sample.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Sample.Infrastructure
{
    public static class Injectcion
    {
        public static IServiceCollection RegisterInfrastructerServices(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<MyWorldDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("MyWorldDbConnection"));
            });

            services.AddScoped<IMyWorldDbContext>(optiont => optiont.GetService<MyWorldDbContext>());
            return services;
        }
    }
}