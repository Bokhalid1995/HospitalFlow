using HospitaFlow.Application.Interfaces.Application;
using HospitaFlow.Application.Interfaces.Common;
using HospitaFlow.Infrastructure.Data;
using HospitaFlow.Infrastructure.Repositories;
using HospitaFlow.Infrastructure.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace HospitaFlow.Core
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureDI(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer("Server=DESKTOP-G7OAL88\\SQLEXPRESS;Database=HospitalFlowDb;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True");
            });
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IPatientFileRepository, PatientFileRepository>();
            return services; 
        }
    }
}
