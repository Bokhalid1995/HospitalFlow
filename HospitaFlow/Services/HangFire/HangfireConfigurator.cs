using Hangfire;
using HospitaFlow.Infrastructure.Jobs;

namespace HospitaFlow.Api.Services.HangFire
{
    public static class HangfireConfigurator
    {
        public static void AddHangfireServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddHangfire(options =>
            {
                options.UseSqlServerStorage(config.GetConnectionString("HospitalFlowDb"));
            });

            services.AddHangfireServer();
        }

        public static void UseHangfireJobs(this IApplicationBuilder app)
        {
            app.UseHangfireDashboard();

            using var scope = app.ApplicationServices.CreateScope();
            var jobs = scope.ServiceProvider.GetServices<IHangfireJobConfigurator>();

            foreach (var job in jobs)
                job.ConfigureRecurringJobs();
        }
    }

}
