using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitaFlow.Core.Entities.Application
{
    public class MedicalRecord
    {
        public int Id { get; set; }
        public int PatientId { get; set; }

        public string BloodType { get; set; }
        public string Allergies { get; set; }
        public string ChronicDiseases { get; set; }

        // Navigation
        public PatientFile Patient { get; set; }
    }
}
