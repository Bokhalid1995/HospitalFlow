


using Microsoft.Extensions.DependencyInjection;

namespace HospitaFlow.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationDI(this IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddMediatR(cfg =>
             cfg.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly));

          
            return services;
        }
    }
}
