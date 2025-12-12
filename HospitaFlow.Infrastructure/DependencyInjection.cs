using Hangfire;
using Hangfire.SqlServer;
using HospitaFlow.Application.Interfaces.Application;
using HospitaFlow.Application.Interfaces.Common;
using HospitaFlow.Infrastructure.Data;
using HospitaFlow.Infrastructure.Jobs;
using HospitaFlow.Infrastructure.Repositories;
using HospitaFlow.Infrastructure.UnitOfWork;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HospitaFlow.Core
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureDI(this IServiceCollection services )
        {
            services.AddScoped<IHangfireJobConfigurator, HangfireJobs>();
            services.AddScoped<IEmailService, EmailService>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IPatientFileRepository, PatientFileRepository>();
            services.AddHangfireServer();
 
            return services; 
        }
    }
}
