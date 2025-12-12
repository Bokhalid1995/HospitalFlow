using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitaFlow.Infrastructure.Jobs
{
    public interface IHangfireJobConfigurator
    {
        Task SendTestEmail();
        void ConfigureRecurringJobs();
    }
}
