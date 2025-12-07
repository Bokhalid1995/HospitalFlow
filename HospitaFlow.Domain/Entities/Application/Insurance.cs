using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitaFlow.Core.Entities.Application
{
    public class Insurance
    {
        public int Id { get; set; }
        public string ProviderName { get; set; } = string.Empty;
        public string PolicyNumber { get; set; } = string.Empty;
        public DateTime ExpiryDate { get; set; } = DateTime.Now;

        public int PatientId { get; set; } 
        public PatientFile Patient { get; set; }
    }
}
