using CleanArchitecture.Sample.Application.Contracts.Logics;
using CleanArchitecture.Sample.Application.Logics;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Sample.Application
{
    public static class Injectcion
    {
        public static IServiceCollection RegisterApplicationServices(
            this IServiceCollection service,
            IConfiguration configuration)
        {
            service.AddScoped<IGadgetLogic, GadgetLogic>();
            return service;
        }
    }
}