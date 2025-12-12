


using HospitaFlow.Application.Common.Behaviors;
using HospitaFlow.Application.Common.Exceptions;
using HospitaFlow.Application.DTOs.Application.PatientFile;
using HospitaFlow.Application.Features.Application.PatientFileFeature.Commands.Validations;
using HospitaFlow.Core;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace HospitaFlow.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationDI(this IServiceCollection services)
        {
            services.AddCoreDI();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddTransient<ExceptionMiddleware>();
            services.AddMediatR(cfg =>
             cfg.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly));

           


            return services;
        }
    }
}
