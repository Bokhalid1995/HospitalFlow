using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitaFlow.Application.Interfaces.Common
{
    public interface IEmailService
    {
        Task SendEmailAsync(string to, string subject, string body);
    }
}
