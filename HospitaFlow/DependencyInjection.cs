
using FluentValidation;

using HospitaFlow.Application;
using HospitaFlow.Application.Common.Behaviors;

using HospitaFlow.Application.Features.Application.PatientFileFeature.Commands.Validations;
using HospitaFlow.Core;
using HospitaFlow.Infrastructure.Jobs;
using MediatR;


namespace HospitaFlow.Api
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAppDI(this IServiceCollection services )
        {
            services.AddValidatorsFromAssemblyContaining<AddPatientFileValidator>();
            services.AddValidatorsFromAssemblyContaining<UpdatePatientFileValidator>();
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
            services.AddApplicationDI().AddInfrastructureDI();
        
            return services;
        }
    }
}
