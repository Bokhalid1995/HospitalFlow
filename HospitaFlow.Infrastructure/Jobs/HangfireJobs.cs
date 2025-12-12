

using System.Linq;
using Hangfire;
using HospitaFlow.Application.Interfaces.Common;
using Microsoft.Extensions.DependencyInjection; // Add this at the top

namespace HospitaFlow.Infrastructure.Jobs
{


    public class HangfireJobs : IHangfireJobConfigurator
    {
        private readonly IRecurringJobManager _recurringJobManager;
        private readonly IEmailService _emailService;

        public HangfireJobs(IRecurringJobManager recurringJobManager, IEmailService emailService)
        {
            _recurringJobManager = recurringJobManager;
            _emailService = emailService;
        }

        public void ConfigureRecurringJobs()
        {
            _recurringJobManager.AddOrUpdate(
                "send-test-email",
                () => SendTestEmail(),
                Cron.MinuteInterval(5) // Every 5 minutes
            );
        }

        public async Task SendTestEmail()
        {
            await _emailService.SendEmailAsync(
                "eo000662@gmail.com",
                "موعد الزيارة",
                "نود اعلامك انه قد حان موعد زيارتك الشهرية"
            );
        }
    }


}
